@echo off
title MoonNight
start "" https://solariano.github.io/solar-hub/welcome.html
color 2
cd tools
:main_menu
cls
echo ================================================
echo                  MoonNight
echo ================================================
echo 1. JJSploits
echo 2. FPS UNLOCKER
echo 3. Auto Clicker
echo 4. Exit
echo ================================================
set /p choice="Select an option (1-4): "

if "%choice%"=="1" goto jjsploits
if "%choice%"=="2" goto fps_unlocker
if "%choice%"=="3" goto auto_clicker
if "%choice%"=="4" goto exit_tool
echo Invalid option. Please try again.
pause
goto main_menu

:jjsploits
cls
echo Loading:
start JJSploit.exe
pause
goto main_menu

:fps_unlocker
cls
echo loading:
start rbxfpsunlocker.exe
goto main_menu

:auto_clicker
cls
echo loading:
start autoclicker.exe
goto main_menu

:exit_tool
cls
echo Thanks for Using this software!
pause
exit