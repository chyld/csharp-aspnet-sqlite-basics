# ASP.NET Dog Demo

### Commands

```
dotnet new webapi --no-https -o web
cd web
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet ef migrations add Initial
dotnet ef database update
dotnet watch run
```
