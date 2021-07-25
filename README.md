# MMT-Test
MMT Server Side .Net Technical Test

Following a Git Flow proccess, the main branch is `dev`. There is a main branch updated with all changes, and feature branches that reflects the progress of the project.

## Database
The database design was created as a Sql Server Database Tool project in Visual Studio 2019. The target database is SQL Server 2017. Tested on SQL Server 2019 Developer Edition.
The generated create script can be found in MMTShop-Database/MMTShop-Database_Create.sql. Alternatively, there is a Dacpac file to create the database.

There are two tables, one for Products and another for Categories.

## Service
The Service is exposed as a REST API. The project was build with .NET Core Web Api 5.0, in Visual Studio and Rider. It connects to the database with Entity Framework Core.

The architecture has three layers: api, core, and data. There are unit tests for the api and core layers. There was not enough time to make unit tests for the
data layer. However, it is possible to make unit tests by mocking the DbContext object, or using an in-memory or SQLite databases.

## Console Client
This is a simple .NET Core console application which makes HTTP calls to the localhost service. All responses are printed in the console as plain strings.

### Note
The test took me longer than expected. I had to move between a Windows virtual machine and a Mac, and I had a few problems with SQL Server. That is the reason to use two different IDEs.
