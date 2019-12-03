cd SonarCloudSpike/spike.tests2
dotnet add package coverlet.msbuild
dotnet test spike.tests2.csproj /p:CollectCoverage=true