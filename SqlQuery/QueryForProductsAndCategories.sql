Create Database ProductsDb

use ProductsDb

Create Table Categories(
Id int primary key identity,
Name nvarchar(50) not null
)

Create Table Products(
Id int primary key identity,
Name nvarchar(50) not null,
Price decimal(18, 2) not null,
Description nvarchar(200) not null,
CategoryId int foreign key references Categories(Id)

)


Select * from Categories

Select * from Products

