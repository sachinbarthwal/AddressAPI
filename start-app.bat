@echo off
setlocal enabledelayedexpansion

:: Set colors for console output
set "BLUE=[94m"
set "GREEN=[92m"
set "RED=[91m"
set "RESET=[0m"

:: Check if Node.js is installed
where node >nul 2>nul
if %ERRORLEVEL% neq 0 (
    echo %RED%Error: Node.js is not installed or not in the PATH.%RESET%
    echo Please install Node.js and try again.
    pause
    exit /b 1
)

:: Check if .NET Core SDK is installed
where dotnet >nul 2>nul
if %ERRORLEVEL% neq 0 (
    echo %RED%Error: .NET Core SDK is not installed or not in the PATH.%RESET%
    echo Please install .NET Core SDK and try again.
    pause
    exit /b 1
)

:: Start the backend
echo %BLUE%Starting the AddressAPI backend...%RESET%
start cmd /k "cd AddressAPI && dotnet run && echo Backend is running on https://localhost:7262 && pause"

:: Wait for the backend to start
timeout /t 5 /nobreak >nul

:: Start the frontend
echo %BLUE%Starting the AngularFrontend...%RESET%
start cmd /k "cd AngularFrontend && ng serve && echo Frontend is running on http://localhost:4200 && pause"

:: Wait for the frontend to start
timeout /t 5 /nobreak >nul

:: Open the application in the default browser
echo %GREEN%Opening the application in your default browser...%RESET%
start http://localhost:4200

echo %GREEN%Both backend and frontend are now running.%RESET%
echo %GREEN%The application should open in your default browser shortly.%RESET%
echo %BLUE%Press any key to close all servers and exit.%RESET%
pause >nul

:: Kill all node and dotnet processes
taskkill /F /IM node.exe >nul 2>nul
taskkill /F /IM dotnet.exe >nul 2>nul

echo %GREEN%All servers have been stopped.%RESET%
pause

endlocal