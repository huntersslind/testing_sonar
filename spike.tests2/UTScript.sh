#!/bin/bash
# cd SonarCloudSpike/spike.tests2
mkdir TestResults
dotnet test  -p:CollectCoverage=true  -p:CoverletOutputFormat=opencover -p:CoverletOutput=TestResults/results.trx