@echo off
cd %~dp0
:start
echo SC-CL test1
cls
"./bin/SC-CL.exe" -platform=PS3 -target=GTAV -out-dir="GTAV/PS3/bin/" -name="test1" test1.c ./include/common.c -- -I "./include/"
"ScriptInjector.exe" -in="GTAV/PS3/bin/test1.csc" -i-c=192.168.1.75
