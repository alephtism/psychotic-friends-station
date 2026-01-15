@echo off
cd ../../

call git submodule update --init --recursive
dotnet build Content.Packaging --configuration Release

pause
