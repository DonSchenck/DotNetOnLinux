# Notes and Troubleshooting

### Problem: Cannot delete old version of dotnet CLI  in Windows 10
I had this happen today. I used Windows' "Uninstall", and downloaded and installed the newest CLI, but when I ran `dotnet --version` I was still getting the old version.  

The fix was to delete the folder "C:\Program Files\dotnet", then install the newest CLI.
