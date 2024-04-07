# Install dotnet cli via winget
winget install -e --id Microsoft.DotNet.SDK.8

dotnet tool install --global dotnet-ef

# restore
dotnet restore

dotnet ef database update
