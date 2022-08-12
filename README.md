# Pierre's Sweet and Savory Treats #

#### By _**Alex McKnight**_

#### _This app uses authentication and authorization to allow a user to sign up for an account in order to add flavors and foods to a bakery marketplace_

## Technologies Used

* C#
* .NET
* Microsoft EntityFrameworkCore
* Microsoft Identity
* Razor
* ASP.NET MVC
* MySQL Workbench

## Description

_This app uses authentication and authorization through MySQL Workbench to allow a user to sign up for an online account in order to add flavors and foods to a bakery marketplace. It also utilizes many-to-many relationships_

## Setup/Installation Requirements

* In order to use this application you must have MySQL Workbench installed. Depending on your machine please follow setup instructions listed [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Clone this repository to your local machine
* In the project's root directory, you will next need to create an appsettings.json file with the following information where YOURPASSWORDHERE is the password used to connect to MySQL:
```
  {
  "ConnectionStrings":{
    "DefaultConnection":"Server=localhost;Port=3306;database=pierre;uid=root; pwd=[YOURPASSWORDHERE];"
    }
  }
```

* Once saved, type ```cd Pierre``` in your command line to navigate to the main project folder.
* To install the project's dependencies, in the command line type ```dotnet restore```
* To ensure the database is properly connected to the project, type ```dotnet ef database update```, this will ideally apply the most recent migration of the database.
* Once in the Project folder, type ```dotnet run``` in the command line to run the program.

## Known Bugs
* None

## License


MIT License

Copyright (c) [2022] [Alex McKnight]