@echo off
cd %~dp0
:start
echo SC-CL test1.c
echo Press ENTER to launch
pause > nul
cls
"./bin/SC-CL.exe" -platform=PS3 -target=GTAV -out-dir="GTAV/PS3/bin/" test1.c ./include/common.c -- -I "./include/"
goto start
