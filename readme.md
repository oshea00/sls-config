# Notes

Small example of how to setup a serverless-created template project to load configuration and be runnable in debugger.

## Steps
1. `sls create -t aws-csharp -p ConfigStuff`
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
  - Microsoft.Extensions.Configuration.Json
6. Copy appsettings.json to bin. Add to csproj:
```
  <ItemGroup>
    <Content Include="appsettings.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content> 
  </ItemGroup>
```
## Running

### Local Debug
- See Main.cs
- Set breakpoints as-needed
- hit F5

### Invoke Local
- `sls invoke local -f hello -d {}`
This will use the simulated serverless environment

### Deploy and invoke
- `./build.sh`
- `sls deploy -s dev` 
- `sls invoke -f hello -d {} -l true`
