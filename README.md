# NutritionChecker

# Prerequisites

1. Install [.net 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-x64-installer)
2. Install ABP Framework with see [here ](https://docs.abp.io/en/abp/latest/Tutorials/Todo/Index)


# Start it

1. Schritt: Installiere eine MYSQL oder Maria DB Datenbank und ändere den Connection String in Remi.NuritionChecker.DbMigration und .HttpApi.Host in der Datei appsettings.json siehe hierzu [Link](https://docs.abp.io/en/abp/latest/Getting-Started-Running-Solution?UI=MVC&DB=EF&Tiered=No)
2. Schritt: Datenbankmigration: Navigiere mit einer Konsole (PowerShell oder CMD) in .DbMigrator Ordner und führe dotnet run aus.
3. Schritt: Starte Backend: Navigiere mit einer Konsole (PowerShell oder CMD) in .HttpApi.Host Ordner und führe dotnet run aus.