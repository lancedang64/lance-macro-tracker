# Ensure MSBuild is installed
```
Ensure MSBuild is installed.
You can specify path to MsBuild in ‘Settings | Build, Execution,
Deployment | Toolset and Build’
```
Solution: You have not installed .NET SDK, which comes with MSBuild.

# FnApp can be built but throws exception when HttpTrigger is called
```
Executing 'HttpTrigger' (Reason='This function was 
programmatically called via the host APIs.', 
Id=93e2e49b-f1c9-4842-8d96-3871760c9fa3)

Executed 'HttpTrigger' (Failed, 
Id=93e2e49b-f1c9-4842-8d96-3871760c9fa3, Duration=1ms)
System.Private.CoreLib: Exception while executing function: HttpTrigger. 
Lance.LanceMacroTrackerFunctionApp: Could not load file or assembly 

'System.Linq.Expressions, Version=8.0.0.0, Culture=neutral,
PublicKeyToken=b03f5f7f11d50a3a'. 
The system cannot find the file specified.
```

This happened because I created the Azure Function project with `Functions runtime: default worker`.
This was resolved when I choose `Functions runtime: isolated worker` instead.

# Cannot resolve symbol 'ConfigureFunctionsWebApplication'
```
0>Program.cs(6,6): Error CS1061 : 'HostBuilder' does not contain a definition 
for 'ConfigureFunctionsWebApplication' and no accessible extension method 
'ConfigureFunctionsWebApplication' accepting a first argument of type 
'HostBuilder' could be found 
(are you missing a using directive or an assembly reference?)
```
Solution: You need to install NuGet package `Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore`