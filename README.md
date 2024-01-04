# Chat
## Description
This is EF Core chat application created in three layers architecture

## Prerequisites
- .NET Core SDK
- Visual studio

- SQL Server or any other database provider supported by EF Core, PosgreSQL recommended

  
## Setup and Installation
1. Clone the Repository
2. Navigate to the project directory
3. Restore dependencies
4. Configuring the Database:
- Connection String: Update the connection string in ChatAppContextFactory file in data layer.
5. Restoring the Database:
- restore the database "Chat backup.sql" provided in the root
6. Set Presentation as a startup project

## Project Structure

Data: Contains DbContext and Entity models.
Domain: Contains repositories.
Presentation: Contains actions.

## Users:
Username | Password
--- | --- 
admin@dump.hr | password
pujic.z@gmail.com | 84368436






