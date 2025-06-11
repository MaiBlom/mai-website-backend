### Ubuntu 24.04 install:
1. ```sudo apt-get update && sudo apt-get install -y dotnet-sdk-8.0```
2. ```sudo apt-get update && sudo apt-get install -y aspnetcore-runtime-8.0```
3. ```sudo apt-get install -y dotnet-runtime-8.0```

### Setup database
1. ```sudo apt-get install mysql-server```
2. ```sudo service mysql start``` 
3. ```dotnet add package Pomelo.EntityFrameworkCore.MySql```
4. ```dotnet tool install --global dotnet-ef```
5. ```dotnet add package Microsoft.EntityFrameworkCore.Design```
6. ```dotnet ef database update```