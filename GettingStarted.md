
# Getting Started
## .NET on Linux

### Prerequisites

1. A system running Red Hat Enterprise Linux
1. Your system needs to have 'wget' installed. You can assure that by running the following command:  
`yum install -y wget`

## Instructions
### Get the .NET bits
`wget https://dotnetcli.blob.core.windows.net/dotnet/beta/Binaries/Latest/dotnet-dev-rhel-x64.latest.tar.gz`

### Install some dependencies
`sudo yum install -y libicu libuuid libcurl openssl libunwind`

### Create a home for the dotnet binaries
`mkdir ~/dotnet`

### Unpack the dotnet binaries
`tar xf dotnet-dev-rhel-x64.latest.tar.gz -C ~/dotnet --verbose`  
(Note: The verbose option is shown in order to give you a sense of the scope of the .NET framework)  

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

You should see a message similar to  
```Compiling helloworld_cli for .NETStandard,Version=v1.5```

After a successful compile, you should see `Hello World!` as console output.


## HelloWeb example
### Move to the directory
`cd ~/src/DotNetOnLinux/cli-samples-master/HelloWeb`

### Restore and run the code
`dotnet restore`  
`dotnet run`  

You should receive the following message:  
`Now listening on: http://*:5000`  
`Application started. Press Ctrl+C to shut down.`  

If you are running RHEL with a graphical shell, you can open your browser and point it to `http://localhost:5000` to see the results.  

If you are running RHEL in a command line environment, or if you are running RHEL inside of the CDK virtual machine (VM), point your browser to the server's IP address. For example, if you are using the CDK, you'll point to `http://10.1.2.2:5000`  

Your browser should show the message "Hello World!".  

Press `Ctrl+C` to terminate the .NET web server.  

## HelloMvc example
### Move to the directory  
`cd ~/src/DotNetOnLinux/cli-samples-master/HelloMvc`  

### Restore and run the code  
`dotnet restore`  
`dotnet run`  

As with the previous example, you'll need to enter the appropriate IP address. You should see a banner representing the successful execution of an ASP.NET MVC web application.  

## HelloWebApi example  
Coming *VERY* soon.  

## Entity Framework & SQList example  
Coming _VERY_ soon. Seriously.  
