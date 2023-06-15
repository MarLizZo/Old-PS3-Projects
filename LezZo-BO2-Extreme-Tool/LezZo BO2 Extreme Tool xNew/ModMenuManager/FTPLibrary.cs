using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using LezZo_BO2_Extreme_Tool_xNew.ModMenuManager;

namespace LezZo_BO2_Extreme_Tool_xNew.ModMenuManager
{
    #region "FTP client class"
    public class FTPclient
    {
        #region Delegated & Events
        //New Server Message Event
        public delegate void NewMessageHandler(object sender, NewMessageEventArgs e);
        public event NewMessageHandler OnNewMessageReceived;

        //Upload Progress Changed Event
        //Download Progress Changed Event
        public delegate void UploadProgressChangedHandler(object sender, UploadProgressChangedArgs e);
        public event UploadProgressChangedHandler OnUploadProgressChanged;

        //Upload Completed Event
        public delegate void UploadCompletedHandler(object sender, UploadCompletedArgs e);
        public event UploadCompletedHandler OnUploadCompleted;
        #endregion

        #region "CONSTRUCTORS"
        /// <summary>
        /// Blank constructor
        /// </summary>
        /// <remarks>Hostname, username and password must be set manually</remarks>
        public FTPclient()
        {
        }

        public FTPclient(string Hostname)
        {
            _hostname = Hostname;
        }
        #endregion

        #region "Directory functions"

        /// <summary>
        /// Return a detailed directory listing
        /// </summary>
        /// <param name="directory">Directory to list, e.g. /pub/etc</param>
        /// <returns>An FTPDirectory object</returns>
        public FTPdirectory ListDirectoryDetail(string directory)
        {
            System.Net.FtpWebRequest ftp = GetRequest(GetDirectory(directory));
            //Set request to do simple list
            ftp.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails;
            //Give Message of Command

            string str = GetStringResponse(ftp);
            //replace CRLF to CR, remove last instance
            str = str.Replace("\r\n", "\r").TrimEnd('\r');
            NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "List Directory Details", "LIST", directory);
            //split the string into a list
            return new FTPdirectory(str, _lastDirectory);
        }

        #endregion

        #region "Upload: File transfer TO ftp server"
        /// <summary>
        /// Copy a local file to the FTP server
        /// </summary>
        /// <param name="localFilename">Full path of the local file</param>
        /// <param name="targetFilename">Target filename, if required</param>
        /// <returns></returns>
        /// <remarks>If the target filename is blank, the source filename is used
        /// (assumes current directory). Otherwise use a filename to specify a name
        /// or a full path and filename if required.</remarks>
        public bool Upload(string localFilename, string targetFilename)
        {
            if (!File.Exists(localFilename))
                throw (new ApplicationException("File " + localFilename + " not found"));
            FileInfo fi = new FileInfo(localFilename);
            return Upload(fi, targetFilename);
        }

        #region Upload Variables
        System.Net.FtpWebRequest UploadFTPRequest = null;
        FileStream UploadFileStream = null;
        Stream UploadStream = null;
        FileInfo UploadFileInfo = null;
        #endregion

        /// <summary>
        /// Upload a local file to the FTP server
        /// </summary>
        /// <param name="fi">Source file</param>
        /// <param name="targetFilename">Target filename (optional)</param>
        /// <returns></returns>
        public bool Upload(FileInfo fi, string targetFilename)
        {
            //copy the file specified to target file: target file can be full path or just filename (uses current dir)
            string target;
            if (targetFilename.Trim() == "")
                target = this.CurrentDirectory + fi.Name;
            else if (targetFilename.Contains("/"))
                target = AdjustDir(targetFilename);
            else
                target = CurrentDirectory + targetFilename;

            string URI = Hostname + target;
            //perform copy
            UploadFTPRequest = GetRequest(URI);

            //Set request to upload a file in binary
            UploadFTPRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            UploadFTPRequest.UseBinary = true;
            //Notify FTP of the expected size
            UploadFTPRequest.ContentLength = fi.Length;
            UploadFileInfo = fi;

            //create byte array to store: ensure at least 1 byte!
            const int BufferSize = 2048;
            byte[] content = new byte[BufferSize - 1 + 1];
            int dataRead;

            //open file for reading
            using (UploadFileStream = fi.OpenRead())
            {
                try
                {
                    using (UploadStream = UploadFTPRequest.GetRequestStream())
                    {
                        Int64 TotalBytesUploaded = 0;
                        Int64 FileSize = fi.Length;
                        do
                        {
                            dataRead = UploadFileStream.Read(content, 0, BufferSize);
                            UploadStream.Write(content, 0, dataRead);
                            TotalBytesUploaded += dataRead;
                            //Declare Event
                            UploadProgressChangedArgs DownloadProgress = new UploadProgressChangedArgs(TotalBytesUploaded, FileSize);
                            //Progress changed, Raise the event.
                            OnUploadProgressChanged(this, DownloadProgress);
                            System.Windows.Forms.Application.DoEvents();
                        }
                        while (!(dataRead < BufferSize));
                        UploadCompletedArgs Args = new UploadCompletedArgs("Successful", true);
                        //Raise Event
                        OnUploadCompleted(this, Args);
                        UploadStream.Close();
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    UploadFileStream.Close();
                }

            }
            UploadFTPRequest = null;
            return true;
        }

        #endregion


        #region "Other functions: Delete rename etc."
        /// <summary>
        /// Delete remote file
        /// </summary>
        /// <param name="filename">filename or full path</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool FtpDelete(string filename)
        {
            //Determine if file or full path
            string URI = this.Hostname + GetFullPath(filename);

            System.Net.FtpWebRequest ftp = GetRequest(URI);
            //Set request to delete
            ftp.Method = System.Net.WebRequestMethods.Ftp.DeleteFile;
            try
            {
                //get response but ignore it
                string str = GetStringResponse(ftp);
                //Give Message of Command
                NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "Delete File", "DELE", str);
                OnNewMessageReceived(this, e);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Determine size of remote file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <remarks>Throws an exception if file does not exist</remarks>


        public bool FtpCreateDirectory(string dirpath)
        {
            //perform create
            string URI = this.Hostname + AdjustDir(dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            //Set request to MkDir
            ftp.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory;
            try
            {
                string str = GetStringResponse(ftp);
                //Give Message of Command
                NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "Make Directory", "MKD", AdjustDir(dirpath));
                OnNewMessageReceived(this, e);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool FtpDeleteDirectory(string dirpath)
        {
            //perform remove
            string URI = this.Hostname + AdjustDir(dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            //Set request to RmDir
            ftp.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory;
            try
            {
                //get response but ignore it
                string str = GetStringResponse(ftp);
                //Give Message of Command
                NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "Remove Directory", "RMD", dirpath);
                OnNewMessageReceived(this, e);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region "private supporting fns"
        //Get the basic FtpWebRequest object with the
        //common settings and security
        private FtpWebRequest GetRequest(string URI)
        {
            //create request
            FtpWebRequest result = (FtpWebRequest)FtpWebRequest.Create(URI);
            //Set the login details
            // result.Credentials = GetCredentials();
            //Do not keep alive (stateless mode)
            result.KeepAlive = false;
            return result;
        }


        /// <summary>
        /// Get the credentials from username/password
        /// </summary>
        private System.Net.ICredentials GetCredentials()
        {
            return new System.Net.NetworkCredential(Username, Password);
        }

        /// <summary>
        /// returns a full path using CurrentDirectory for a relative file reference
        /// </summary>
        private string GetFullPath(string file)
        {
            if (file.Contains("/"))
            {
                return AdjustDir(file);
            }
            else
            {
                return this.CurrentDirectory + file;
            }
        }

        /// <summary>
        /// Amend an FTP path so that it always starts with /
        /// </summary>
        /// <param name="path">Path to adjust</param>
        /// <returns></returns>
        /// <remarks></remarks>
        private string AdjustDir(string path)
        {
            return ((path.StartsWith("/")) ? "" : "/").ToString() + path;
        }

        private string GetDirectory(string directory)
        {
            string URI;
            if (directory == "")
            {
                //build from current
                URI = Hostname + this.CurrentDirectory;
                _lastDirectory = this.CurrentDirectory;
            }
            else
            {
                if (!directory.StartsWith("/"))
                {
                    throw (new ApplicationException("Directory should start with /"));
                }
                URI = this.Hostname + directory;
                _lastDirectory = directory;
            }
            return URI;
        }

        //stores last retrieved/set directory
        private string _lastDirectory = "";

        /// <summary>
        /// Obtains a response stream as a string
        /// </summary>
        /// <param name="ftp">current FTP request</param>
        /// <returns>String containing response</returns>
        /// <remarks>FTP servers typically return strings with CR and
        /// not CRLF. Use respons.Replace(vbCR, vbCRLF) to convert
        /// to an MSDOS string</remarks>
        private string GetStringResponse(FtpWebRequest ftp)
        {
            //Get the result, streaming to a string
            string result = "";
            using (FtpWebResponse response = (FtpWebResponse)ftp.GetResponse())
            {
                long size = response.ContentLength;
                using (Stream datastream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(datastream))
                    {
                        _WelcomeMessage = response.WelcomeMessage;
                        _ExitMessage = response.ExitMessage;
                        result = sr.ReadToEnd();
                        sr.Close();
                    }
                    try
                    {
                        //Declare Event
                        NewMessageEventArgs e = new NewMessageEventArgs("RESPONSE", response.StatusDescription, response.StatusCode.ToString(), "");
                        //Raise Event
                        OnNewMessageReceived(this, e);
                    }
                    catch
                    {

                    }

                    datastream.Close();
                }
                response.Close();
            }
            return result;
        }

        /// <summary>
        /// Gets the size of an FTP request
        /// </summary>
        /// <param name="ftp"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private long GetSize(FtpWebRequest ftp)
        {
            long size;
            using (FtpWebResponse response = (FtpWebResponse)ftp.GetResponse())
            {
                size = response.ContentLength;
                response.Close();
            }

            return size;
        }
        #endregion

        #region "Properties"
        private string _hostname;
        /// <summary>
        /// Hostname
        /// </summary>
        /// <value></value>
        /// <remarks>Hostname can be in either the full URL format
        /// ftp://ftp.myhost.com or just ftp.myhost.com
        /// </remarks>
        public string Hostname
        {
            get
            {
                if (_hostname.StartsWith("ftp://"))
                    return _hostname;
                else
                    return "ftp://" + _hostname;
            }
            set
            {
                _hostname = value;
            }
        }
        private string _username;
        /// <summary>
        /// Username property
        /// </summary>
        /// <value></value>
        /// <remarks>Can be left blank, in which case 'anonymous' is returned</remarks>
        public string Username
        {
            get
            {
                return (_username == "" ? "anonymous" : _username);
            }
            set
            {
                _username = value;
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        /// <summary>
        /// The CurrentDirectory value
        /// </summary>
        /// <remarks>Defaults to the root '/'</remarks>
        private string _currentDirectory = "/";
        public string CurrentDirectory
        {
            get
            {
                //return directory, ensure it ends with /
                return _currentDirectory + ((_currentDirectory.EndsWith("/")) ? "" : "/").ToString();
            }
            set
            {
                if (!value.StartsWith("/"))
                    throw (new ApplicationException("Directory should start with /"));
                _currentDirectory = value;
            }
        }


        #endregion

        #region Server Messages
        string _WelcomeMessage, _ExitMessage;
        public string WelcomeMessage
        {
            get
            {
                return _WelcomeMessage;
            }
            set
            {
                _WelcomeMessage = value;
            }
        }
        public string ExitMessage
        {
            get
            {
                return _ExitMessage;
            }
            set
            {
                _ExitMessage = value;
            }
        }
        #endregion

    }
    #endregion

    #region "FTP file info class"
    /// <summary>
    /// Represents a file or directory entry from an FTP listing
    /// </summary>
    /// <remarks>
    /// This class is used to parse the results from a detailed
    /// directory list from FTP. It supports most formats of
    /// </remarks>
    public class FTPfileInfo
    {
        #region "Properties"
        public string FullName
        {
            get
            {
                return Path + Filename;
            }
        }
        public string Filename
        {
            get
            {
                return _filename;
            }
        }
        public string Path
        {
            get
            {
                return _path;
            }
        }
        public DirectoryEntryTypes FileType
        {
            get
            {
                return _fileType;
            }
        }
        public long Size
        {
            get
            {
                return _size;
            }
        }
        public DateTime FileDateTime
        {
            get
            {
                return _fileDateTime;
            }
        }
        public string Permission
        {
            get
            {
                return _permission;
            }
        }
        public string Extension
        {
            get
            {
                int i = this.Filename.LastIndexOf(".");
                if (i >= 0 && i < (this.Filename.Length - 1))
                {
                    return this.Filename.Substring(i + 1);
                }
                else
                {
                    return "";
                }
            }
        }
        private string _filename;
        private string _path;
        private DirectoryEntryTypes _fileType;
        private long _size;
        private DateTime _fileDateTime;
        private string _permission;

        #endregion

        /// <summary>
        /// Identifies entry as either File or Directory
        /// </summary>
        public enum DirectoryEntryTypes
        {
            File,
            Directory
        }

        /// <summary>
        /// Constructor taking a directory listing line and path
        /// </summary>
        /// <param name="line">The line returned from the detailed directory list</param>
        /// <param name="path">Path of the directory</param>
        /// <remarks></remarks>
        public FTPfileInfo(string line, string path)
        {
            //parse line
            Match m = GetMatchingRegex(line);
            if (m == null)
                throw (new ApplicationException("Unable to parse line: " + line));
            else
            {
                _filename = m.Groups["name"].Value;
                _path = path;

                Int64.TryParse(m.Groups["size"].Value, out _size);
                _permission = m.Groups["permission"].Value;
                string _dir = m.Groups["dir"].Value;
                if (_dir != "" && _dir != "-")
                    _fileType = DirectoryEntryTypes.Directory;
                else
                    _fileType = DirectoryEntryTypes.File;
                try
                {
                    _fileDateTime = DateTime.Parse(m.Groups["timestamp"].Value);
                }
                catch (Exception)
                {
                    _fileDateTime = Convert.ToDateTime(null);
                }

            }
        }

        private Match GetMatchingRegex(string line)
        {
            Regex rx;
            Match m;
            for (int i = 0; i <= _ParseFormats.Length - 1; i++)
            {
                rx = new Regex(_ParseFormats[i]);
                m = rx.Match(line);
                if (m.Success)
                {
                    return m;
                }
            }
            return null;
        }

        #region "Regular expressions for parsing LIST results"
        /// <summary>
        /// List of REGEX formats for different FTP server listing formats
        /// </summary>
        /// <remarks>
        /// The first three are various UNIX/LINUX formats, fourth is for MS FTP
        /// in detailed mode and the last for MS FTP in 'DOS' mode.
        /// I wish VB.NET had support for Const arrays like C# but there you go
        /// </remarks>
        private static string[] _ParseFormats = new string[] {
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\w+\\s+\\w+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{4})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\d+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{4})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\d+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{1,2}:\\d{2})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\w+\\s+\\w+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{1,2}:\\d{2})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})(\\s+)(?<size>(\\d+))(\\s+)(?<ctbit>(\\w+\\s\\w+))(\\s+)(?<size2>(\\d+))\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{2}:\\d{2})\\s+(?<name>.+)",
            "(?<timestamp>\\d{2}\\-\\d{2}\\-\\d{2}\\s+\\d{2}:\\d{2}[Aa|Pp][mM])\\s+(?<dir>\\<\\w+\\>){0,1}(?<size>\\d+){0,1}\\s+(?<name>.+)" };
        #endregion
    }
    #endregion

    #region "FTP Directory class"
    /// <summary>
    /// Stores a list of files and directories from an FTP result
    /// </summary>
    /// <remarks></remarks>
    public class FTPdirectory : List<FTPfileInfo>
    {


        public FTPdirectory()
        {
            //creates a blank directory listing
        }

        /// <summary>
        /// Constructor: create list from a (detailed) directory string
        /// </summary>
        /// <param name="dir">directory listing string</param>
        /// <param name="path"></param>
        /// <remarks></remarks>
        public FTPdirectory(string dir, string path)
        {
            foreach (string line in dir.Replace("\n", "").Split(System.Convert.ToChar('\r')))
            {
                //parse
                if (line != "")
                {
                    this.Add(new FTPfileInfo(line, path));
                }
            }
        }



        //internal: share use function for GetDirectories/Files
        private FTPdirectory GetFileOrDir(FTPfileInfo.DirectoryEntryTypes type, string ext)
        {
            FTPdirectory result = new FTPdirectory();
            foreach (FTPfileInfo fi in this)
            {
                if (fi.FileType == type)
                {
                    if (ext == "")
                    {
                        result.Add(fi);
                    }
                    else if (ext == fi.Extension)
                    {
                        result.Add(fi);
                    }
                }
            }
            return result;

        }



        private const char slash = '/';


    }
    #endregion

    #region Events
    public class DownloadProgressChangedArgs : EventArgs
    {
        //Private Members
        private Int64 _BytesDownload;
        private Int64 _TotalBytes;

        //Constructor
        public DownloadProgressChangedArgs(Int64 BytesDownload, Int64 TotleBytes)
        {
            this._BytesDownload = BytesDownload;
            this._TotalBytes = TotleBytes;
        }

        //Public Members
        public Int64 BytesDownloaded { get { return _BytesDownload; } }
        public Int64 TotleBytes { get { return _TotalBytes; } }
    }

    public class DownloadCompletedArgs : EventArgs
    {
        //Private Members
        private bool _DownloadedCompleted;
        private string _DownloadStatus;

        //Constructor
        public DownloadCompletedArgs(string Status, bool Completed)
        {
            this._DownloadedCompleted = Completed;
            this._DownloadStatus = Status;
        }

        //Public Members
        public String DownloadStatus { get { return _DownloadStatus; } }
        public bool DownloadCompleted { get { return _DownloadedCompleted; } }
    }

    public class NewMessageEventArgs : EventArgs
    {
        //Private Members
        private string _Message;
        private string _StatusCode;
        private string _Type;
        private string _Path;

        //Constructor
        public NewMessageEventArgs(string Type, string Status, string Code, string Path)
        {
            this._Message = Status;
            this._StatusCode = Code;
            this._Type = Type;
            this._Path = Path;
        }

        //Public Members
        public string StatusMessage { get { return _Message; } }
        public string StatusCode { get { return _StatusCode; } }
        public string StatusType { get { return _Type; } }
        public string StatusPath { get { return _Path; } }
    }

    public class UploadProgressChangedArgs : EventArgs
    {
        //Private Members
        private Int64 _BytesUpload;
        private Int64 _TotalBytes;

        //Constructor
        public UploadProgressChangedArgs(Int64 BytesUpload, Int64 TotleBytes)
        {
            this._BytesUpload = BytesUpload;
            this._TotalBytes = TotleBytes;
        }

        //Public Members
        public Int64 BytesUploaded { get { return _BytesUpload; } }
        public Int64 TotleBytes { get { return _TotalBytes; } }
    }

    public class UploadCompletedArgs : EventArgs
    {
        //Private Members
        private bool _UploadCompleted;
        private string _UploadStatus;

        //Constructor
        public UploadCompletedArgs(string Status, bool Completed)
        {
            this._UploadCompleted = Completed;
            this._UploadStatus = Status;
        }

        //Public Members
        public String UploadStatus { get { return _UploadStatus; } }
        public bool UploadCompleted { get { return _UploadCompleted; } }
    }
    #endregion
}
