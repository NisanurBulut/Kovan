## Give a Star! :star:
If you like or are using this project to learn or start your solution, please give it a star. Thanks!

## Purpose of Application
- Performs stock transfer from one warehouse to another.

* Bootstrap5 was used in frontend design and MSSQL was used as database. Hive is an ASP.Net MVC project.

## Usage of the Application
The user chooses the center and target warehouse points. After this selection process, it determines the material to be shipped. Indicates how much material will be submitted. The user can simultaneously ship more than one material between two warehouses.

User can add, delete, update and list operations on repository information.

The user can add, delete, update and list the material information.

## Constraints of the Application
- The user has to select the source and target warehouse from the defined repositories.
- The user chooses as many materials as he wants.
- Unit field and item definition fields are readonly fields.
- The amount field must be greater than 0.
- When the transaction is completed, it is recorded in the motion chart.

o MaterialId: It is the ID of the item selected for transfer.
o Origin Depot: It is the source storage ID on the screen.
o Target Depot: It is the source storage ID on the screen.
o Amount: It is the Amount field on the screen.
o ShipmentDate: The date the transaction was executed.

- When the process is completed, a message is given to the user as the transaction is successful.

[KOVAN](https://github.com/NisanurBulut/Kovan/blob/master/Trailers/Trailer_Kovan.gif)