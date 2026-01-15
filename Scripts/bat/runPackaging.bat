@echo off
cd ../../

dotnet run --project Content.Packaging server --hybrid-acz --platform win-x64

pause
