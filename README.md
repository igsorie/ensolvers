## Ensolvers


## Getting Started

I started the project implementing the code with TDD only in Entities Folder and Item the other class that 
i implement with TDD is the Services ItemService and FolderService

## Build  with 🛠️

#### Front-End

For the frontend i chose Angular since it´s the one with the most knowledge that i have.

### Backend

For backend i chose c# because i use entity framework to do faster the connection with the data base and database tables and relations.
I use EntityFramework code first to create database.

Commands for EntityFramework:
* Enable-Migrations

* Add-Migrations migration-name

* Update-Database

The database context and database context are locate on the project EnsolversDB, its provide code to GET,ADD,UPDATE and DELETE into database. It´s implemented with LINQ code.

[Link to LINQ explanation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)

##### MVC

I am not going to explain what mvc is, but im going to explain that in my solution implement mvc. 
I try to separate businss logic, controllers and views.
I really demostrate this implementation with interaction diagrams but i can´t do that because i don´t have much time.

##### Postman

I export postman template to test API´s, the postman template it´s locate into Postmane folder.

### DataBase

I work with Microsoft SQL Server 2019, in the following image we can see the MER of the database.

![Test Image 1](EnsolversDB.png)

The dump of the database its locate on the folder DataBase
The dump of the database its locate on the folder DataBase

On the folder Migrations locate in Project EnsolversWebApi, we can see DDL to create tables and attr.

## Version 📌

The exercice has version 1.0.0, wich i will continue to finish it since it did not give me the time to finish some frontend funcionalities.

## Things to do best

* Finish front-end.
* Refactor Code and apply clean code
* Create state, acction, UML diagrams
