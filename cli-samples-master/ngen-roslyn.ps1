<#
    Use this script to insall or remove native images for application that uses dynamic roslyn compiler.
    
    NOTE: this script generates ngen images for Microsoft.CodeAnalysis.dll 
          and Microsoft.CodeAnalysis.CSharp.dll for both x64 and x86 image cache.


    Usage:
        .\ngen-roslyn.ps1 [install|remove] <exe path>
        <exe path> - path to entry point executable

    Example:
        .\ngen-roslyn.ps1 install bin\debug\net451\HelloMvc.exe
#>

param($action, $exe)
$appbase =  (Get-Item $exe).Directory

C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe $action /execonfig:$exe $appbase\Microsoft.CodeAnalysis.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe $action /execonfig:$exe $appbase\Microsoft.CodeAnalysis.CSharp.dll

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe $action /execonfig:$exe $appbase\Microsoft.CodeAnalysis.dll
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe $action /execonfig:$exe $appbase\Microsoft.CodeAnalysis.CSharp.dll