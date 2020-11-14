# Notes

Small example of how to setup a serverless-created template project to load configuration and be runnable in debugger.

## Steps
1. sls create -t aws-csharp -p ConfigStuff
2. Add Main.cs
3. Add launch.json and tasks.json
4. Add this section to csproj (allows for debugging):
```
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>
```
5. dotnet add packages:
  - Microsoft.Extensions.Configuration
  - Microsoft.Extensions.Configuration.EnvironmentVariables
  - Microsoft.Extensions.Configuration.Json
6. Copy appsettings to bin
```
  <ItemGroup>
    <Content Include="appsettings.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content> 
  </ItemGroup>
```
