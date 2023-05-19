# _Eau Claire's Hair Salon_

#### By _**Gareth Grindeland**_

#### _An MVC web application built with C#/.NET, MySQL, and EF Core._

## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL Workbench
* Enity Framework Core version 6.0.0
* HTML & CSS
* Bootstrap version 5.2.3

## Description

_This is an MVC web application that allows the user to input and store information about hair stylists and their clients served. The user can navigate between views to see descriptions of stylists and their current list of clients. Additionally, basic CRUD functionality has been implemented to add, edit, and delete elements on each list. This project was completed as an indpendent code review for week 10 of Epicodus to practice using the MVC model connected to a local database._

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's root directory at ```./HairSalon.Solution/"```._
#### To Import the Database Schema to your local server:
* _Launch MySQL Workbench and open the navigator window._
* _Select the Administration tab and click on Data Import/Restore._
* _In "Import Options" select "Import from Self-Contained File"._
* _Navigate to the file named ```gareth_grindeland.sql``` that is located in this project's root directory._
* _Under "Default Schema to be Imported To" select "New" and enter the name of your database and click "OK"._
* _Select "Start Import" at the bottom right._

#### To connect the App to your Database:
* _Use your shell to navigate to this project's production directory at ```./HairSalon.Solution/HairSalon/```._
* _Within the production directory "HairSalon", create a new file called ```appsettings.json```._
* _Within ```appsettings.json```, put the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
#### To Run the App in the browser:
* _Navigate to this project's production directory at ```./HairSalon.Solution/HairSalon```._
* _Run ```dotnet watch run``` in the command line to start the application in development mode with a watcher. This will open the webpage in your browser._
* _To exit out of the application, you can use the keyboard command "CTRL+C" on Mac and Windows._
* _Optionally, you can run ```dotnet build``` within the production directory to compile this app without running it._

## Known Bugs

* _No known bugs_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_