#!/bin/bash
# cd SonarCloudSpike/spike.tests2
mkdir TestResults
dotnet test --logger trx --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:CoverletOutput=coverage/
# dotnet test  -p:CollectCoverage=true  -p:CoverletOutputFormat=opencover -p:CoverletOutput=../TestResults/opencover.xml --logger 'trx;LogFileName=ci_tests.trx' 