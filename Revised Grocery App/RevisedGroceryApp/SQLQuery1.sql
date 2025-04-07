create database GroceryDb;
use GroceryDb;
go

create table Items (
    itemId int primary key identity(1,1),
    itemName nvarchar(50) unique not null,
    itemPrice decimal(10,2) not null
);

create table Inventory (
    inventoryId int primary key identity(1,1),
    inv_itemId int not null foreign key references Items(itemId),
    inventoryDate datetime not null,
    inventoryStock int not null,
);

create table Sales (
    saleId int primary key identity(1,1),
    saleDate datetime not null
);

create table SalesDetails (
    salesDetailId int primary key identity(1,1),
    salesDetails_invId int not null foreign key references Inventory(inventoryId),
    salesDetails_saleId int not null foreign key references Sales(saleId),
    quantity int not null
);

create table SalesReports (
    reportId int primary key identity(1,1),
    salesRep_salesDetailId int not null foreign key references SalesDetails(salesDetailId),
    salesRep_itemId int not null foreign key references Items(itemId),
    itemPrice int not null,
    total decimal(10,2) not null
);
