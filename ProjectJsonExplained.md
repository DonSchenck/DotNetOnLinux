# project.json explained
The "project.json" file replaces the ".csproj" file found in previous versions of ASP.NET.  The file can be a great mystery. A few simple bits of knowledge can make life a lot easier.

## The Sections  
### project information  
This defines the project; gives it a name, you can list the author(s), the version, and more.  

One  important entry is the `emitEntryPoint` property. Setting it to `true` means the program has a main function to be called when starting. This function, "Main", is in the class "Startup" in the module "Startup.cs".

### dependencies
This section defines which Nuget packages you'll need for this application. Think of it as the "References" section of your project in Visual Studio.
Here's an example:
<pre>
`  "dependencies": {
    "Microsoft.NETCore.App": {
      "type": "platform",
      "version": "1.0.0-rc2-*"
    },`
</pre>
This example says "I'm need the .NET Core library". The "platform" type tells the compiler "but don't build it into this application, it will already be available on the machine where this will execute".  

That's a lot of information in just one snippet of JSON, no?  

The `version` property tells the compiler which version to use. However, this can be very tricky. For example, if you specify "1.0.0", you are actually specifying ">=1.0.0". If a higher version is available, you will get it.

### frameworks  
#### (Example)  
<pre>
`  "frameworks": {
    "netstandardapp1.5": {
      "imports": [
        "portable-net452+win81",
        "dnxcore50"
      ],
      "dependencies": {
        "Microsoft.NETCore.Platforms": "1.0.1-*"
      }
    }
`
</pre>
This section specifies the framework you are targeting for this application. For example, `netcoreapp1.0` means this is a .NET Core 1.0 application. You can specify multiple targets if you wish.  

The `imports` property for a framework defines a list of frameworks that are used by packages created prior to the current framework, but are completely safe to use. In other words, an entry `win81` here means you have a dependency listed that is a package that is compatible with Windows 8.1, but you want it included because you know it will also work with the framework for this application -- in this particular example, it's compatible with .NET Core 1.0.

### More...  
There is a *lot* more to the project.json. You can use Intellisense to view the other options.
