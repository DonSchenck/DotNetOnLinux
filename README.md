
# Install and test .NET on Red Hat Enterprise Linux (RHEL)  

### Prerequisite: Your system needs to have 'wget' installed  
`yum install -y wget`  

### Get the .NET bits
`wget https://dotnetcli.blob.core.windows.net/dotnet/beta/Binaries/Latest/dotnet-dev-rhel-x64.latest.tar.gz`

### Install some dependencies
`sudo yum install -y libicu libuuid libcurl openssl libunwind`

### Create a home for the dotnet binaries  
`mkdir ~/dotnet`  

### Unpack the dotnet binaries  
`tar xf dotnet-dev-rhel-x64.latest.tar.gz -C ~/dotnet`  

### Add the binaries to our path; now, the dotnet command is ready for use  
`export DOTNET_HOME=$HOME/dotnet`  
`export PATH=$PATH:$DOTNET_HOME`  

### Create and move into a directory for our "Hello world" code  
`mkdir src`  
`mkdir src/helloworld_cli`  
`cd src/helloworld_cli/`  

### Here's the magic; Create a new project, pull down the dependencies, and run it  
`dotnet new`  
`dotnet restore`  
`dotnet run`  

You should see "Hello World!" as console output.


## HelloWeb example  
### Move to the directory  
`cd ~/src/DotNetOnLinux/cli-samples/HelloWeb`

### Restore and run the code    
`dotnet restore`    
`dotnet run`  
