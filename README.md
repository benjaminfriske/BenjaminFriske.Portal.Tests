# BenjaminFriske.Portal


## Solution Setup

### Project Structure
BenjaminFriske.Portal  
-> BenjaminFriske.Portal.sln  
-> omnisharp.json  
-> Folder - BenjaminFriske.Portal <-- portal repository goes here.  
-> Folder - BenjaminFriske.Portal.Tests <-- **this** repository goes here. 

### omnisharp.json
```
{ "msbuild": { "useBundledOnly": true } }
```

### BenjaminFriske.Portal.sln

```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.30114.105
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "BenjaminFriske.Portal.Tests", "BenjaminFriske.Portal.Tests\BenjaminFriske.Portal.Tests.csproj", "{FA3A123B-CE79-4AFF-82E8-5CDA9094B86F}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "BenjaminFriske.Portal", "BenjaminFriske.Portal\BenjaminFriske.Portal.csproj", "{259CA7FF-67E0-469F-9794-C14679FA2C0E}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{FA3A123B-CE79-4AFF-82E8-5CDA9094B86F}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{FA3A123B-CE79-4AFF-82E8-5CDA9094B86F}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{FA3A123B-CE79-4AFF-82E8-5CDA9094B86F}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{FA3A123B-CE79-4AFF-82E8-5CDA9094B86F}.Release|Any CPU.Build.0 = Release|Any CPU
		{259CA7FF-67E0-469F-9794-C14679FA2C0E}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{259CA7FF-67E0-469F-9794-C14679FA2C0E}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{259CA7FF-67E0-469F-9794-C14679FA2C0E}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{259CA7FF-67E0-469F-9794-C14679FA2C0E}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
EndGlobal
```