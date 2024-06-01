# Ensure MSBuild is installed
```
Ensure MSBuild is installed.
You can specify path to MsBuild in ‘Settings | Build, Execution,
Deployment | Toolset and Build’
```
Solution: You have not installed .NET SDK, which comes with MSBuild.

# FnApp runs but throws exception when HttpTrigger is
```
Executing 'HttpTrigger' (Reason='This function was 
programmatically called via the host APIs.', 
Id=93e2e49b-f1c9-4842-8d96-3871760c9fa3)

Executed 'HttpTrigger' (Failed, 
Id=93e2e49b-f1c9-4842-8d96-3871760c9fa3, Duration=1ms)
System.Private.CoreLib: Exception while executing function: HttpTrigger. Lance.LanceMacroTrackerFunctionApp: Could not load file or assembly 

'System.Linq.Expressions, Version=8.0.0.0, Culture=neutral,
PublicKeyToken=b03f5f7f11d50a3a'. 
The system cannot find the file specified.
```