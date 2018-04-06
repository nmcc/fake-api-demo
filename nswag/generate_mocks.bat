@echo off

if not exist .\node_modules\.bin\nswag.cmd (
    npm install nswag --save-dev
)

REM echo *** Publishing Web API server to build the server DLL
REM ..\publish-webapi.bat

echo *** Generating client code from server DLL
.\node_modules\.bin\nswag.cmd run MovieRatingAPI.nswag --core 2.0

:END