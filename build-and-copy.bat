@echo off

set CONTRACTS_PATH=C:\Users\ASROCK\Documents\GitHub\project-shroomfall.contracts\Contract\Contract
set UNITY_PATH=C:\Users\ASROCK\Documents\GitHub\project-shroomfall.fe-v1.0-unity\Shroomfall\Assets\Plugins\Contracts

echo === Building Contracts ===
dotnet build "%CONTRACTS_PATH%" -c Debug

IF %ERRORLEVEL% NEQ 0 (
    echo Build failed. Aborting copy.
    pause
    exit /b 1
)

echo === Copying DLL to Unity ===

if not exist "%UNITY_PATH%" (
    mkdir "%UNITY_PATH%"
)

copy /Y "%CONTRACTS_PATH%\bin\Debug\netstandard2.1\Contract.dll" "%UNITY_PATH%\Contract.dll"

echo === DONE ===
pause