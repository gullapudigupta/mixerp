@echo off

cmd.exe /c chcp 1252

call rebundle-db.bat


"C:\Progra~1\PostgreSQL\9.3\bin\psql.exe" -U postgres -d mixerp < "%~dp0"\mixerp.en-US.sql

echo Task completed successfully.
pause
exit
