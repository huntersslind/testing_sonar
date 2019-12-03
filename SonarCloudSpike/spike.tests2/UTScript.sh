# cd SonarCloudSpike/spike.tests2
mkdir TestResults
dotnet add coverlet
dotnet test SonarCloudSpike //p:CollectCoverage=true  //p:CoverletOutputFormat=opencover //p:CoverletOutput=../TestResults/results.trx