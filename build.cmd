dotnet restore
dotnet build
dotnet test --logger:trx;LogFileName=TestResults.xml