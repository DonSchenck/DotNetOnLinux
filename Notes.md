# Notes and Troubleshooting

### Problem: Cannot delete old version of dotnet CLI  in Windows 10
I had this happen today. I used Windows' "Uninstall", and downloaded and installed the newest CLI, but when I ran `dotnet --version` I was still getting the old version.  

The fix was to delete the folder "C:\Program Files\dotnet", then install the newest CLI.

### Error "targeted framework ["Microsoft.NETCore.App": "1.0.0-blahblah"] was not found"  

## Example  
`Could not load host policy library from [/home/vagrant/dotnet/shared/Microsoft.NETCore.App/1.0.0-rc2-3002426]`  
`This may be because the targeted framework ["Microsoft.NETCore.App": "1.0.0-rc2-3002426"] was not found.`   

This error occurs because the version of the dotnet CLI on your machine is behind the level displayed in the error message.  

You can update to a newer version of the dotnet CLI by downloading the latest bits and installing them:  

#### Delete any older version's tar file  
`rm -rf ~/dotnet-dev-rhel-x64.latest.tar.gz`  

#### Get the .NET bits
`wget https://dotnetcli.blob.core.windows.net/dotnet/beta/Binaries/Latest/dotnet-dev-rhel-x64.latest.tar.gz`

#### Unpack the dotnet binaries
`tar xf dotnet-dev-rhel-x64.latest.tar.gz -C ~/dotnet --verbose`  

#### Prove the install  
Run `dotnet --version` and you should see the latest version installed.  
