create database grocerydb;
go
use grocerydb;
go

create table items (
    itemid int primary key identity(1,1),
    itemname nvarchar(50) not null,
    itemcategory nvarchar(20) not null,
    itemprice decimal(10,2) not null
);

create table inventory (
    inventoryid int primary key identity(100,1),
    inv_itemid int not null,
    inventorydate datetime not null,
    inventorystock int not null,
    foreign key (inv_itemid) references items(itemid) on delete cascade -- if items.itemid is deleted, auto delete also
);

create table sales (
    saleid int primary key identity(1000,1),
    saledate datetime not null
);

create table salesdetails (
    salesdetailid int primary key identity(10000,1),
    salesdetails_saleid int not null,
    quantity int not null,
    salesDetails_totalsale DECIMAL(10,2) NOT NULL DEFAULT 0,
    foreign key (salesdetails_saleid) references sales(saleid)
);

create table invdetails (
    invDetailsId int primary key identity(3000, 24),
    invDetails_inventoryid int not null,
    invdetail_qtyout INT NOT NULL DEFAULT 0,
    invDetailsDate DATETIME,
    foreign key (invDetails_inventoryid) references inventory (inventoryid)
);

create table invreports (
    reportid int primary key identity(5000, 1),
    invreport_invDetailsId int not null,
    invreport_invDetailsDate DATETIME,
    foreign key (invreport_invDetailsId) references invdetails (invDetailsId), 
    invDetailsItemIn int not null ,  
    invDetailsItemOut int not null , 
);


create table salesreports (
    reportid int primary key identity(15000, 1), -- Starting from 15000 to ensure uniqueness
    salesrep_salesdetailid int not null,
    salesrep_itemid int not null,
    itemprice decimal(10,2) not null,
    total decimal(10,2) not null,
    foreign key (salesrep_salesdetailid) references salesdetails(salesdetailid) on delete cascade,
    foreign key (salesrep_itemid) references items(itemid) on delete no action
);

create table userAcc(
   
 userId int primary key identity(9010,25),
    userName nvarchar(20) not null,
    userPass nvarchar(20) not null
);

create table adminAcc(
    adminId int primary key identity(900,25),
    adminUserName nvarchar(20) not null,
    adminPass nvarchar(20) not null
);

CREATE TABLE ItemsInventory (
    itemId INT PRIMARY KEY IDENTITY(1,1),
    itemName NVARCHAR(50) NOT NULL,
    itemCategory NVARCHAR(20) NOT NULL,
    itemPrice DECIMAL(10,2) NOT NULL,
    inventoryStock INT NOT NULL,
    inventoryDate DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE ItemImages (
    imageid INT PRIMARY KEY IDENTITY(1,1),
    itemid INT NOT NULL,
    imagename NVARCHAR(100),
    imagedata VARBINARY(MAX), -- To store the image file
    FOREIGN KEY (itemid) REFERENCES items(itemid) ON DELETE CASCADE
);
