@echo off
setlocal enabledelayedexpansion

REM === CONFIG ===
set versionFile=version

REM === Read and parse version ===
set /p currentVersion=<%versionFile%
for /f "tokens=1-4 delims=." %%a in ("%currentVersion%") do (
    set major=%%a
    set minor=%%b
    set patch=%%c
    set build=%%d
)

REM === Increment build number ===
set /a build+=1

REM === Format new version ===
set newVersion=%major%.%minor%.%patch%.%build%

echo New version: %newVersion%

REM === Update version file ===
echo %newVersion% > %versionFile%

REM === Stage version file only ===
git add %versionFile%
git commit -m "Update version to %newVersion%"
git tag %newVersion%
git push origin HEAD
git push origin %newVersion%

REM === Show next steps ===
echo.
echo === TAG COMMITTED ===
echo       %newVersion%
echo =====================
