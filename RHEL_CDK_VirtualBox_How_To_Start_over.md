# How to delete your RHEL Virtual Machine and start over  
## Use the following if you are running RHEL using Virtual Box  

### Make sure your VirtualBox VM is not running  
Open the VirtualBox program and stop the VM.  

### Remove the VM  
Remove the VM; Choose the option to delete all files associated with the VM.  

### Remove the "box" from Vagrant  
From the command line, run `vagrant box remove cdkv2`  

At this point, you have removed all instances and references to your VM. You can now restore a new, fresh VM.  

### Delete the box file on your host machine (Windows or Mac).  
In Windows 10, it's probably at C:\Users\yourusername\Downloads\rhel-cdk-kubernetes-7.2-21.x86_64.vagrant-virtualbox.box  

### Download a "fresh" copy of the box file  
(In the future, you may want to keep a fresh copy available on your local machine)  
Follow the links at redhatloves.net  

### Add the box to vagrant  
Move to your CDK folder and run `vagrant box add --name cdkv2`  

### Start the VM, move into it, and install dotnet  
`vagrant up`  
`vagrant ssh`  

#### DOTNET IS NOT YET INSTALLED ON THE VM!
### Install dotnet  
Follow the instructions in the GettingStarted.md document.  
