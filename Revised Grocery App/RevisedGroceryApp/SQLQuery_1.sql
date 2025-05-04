create database grocerydb;
go
use grocerydb;
go

create table items (
    itemid int primary key identity(1,1),
    itemname nvarchar(50) unique not null,
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
    salesdetails_invid int not null,
    salesdetails_saleid int not null,
    quantity int not null,
    foreign key (salesdetails_invid) references inventory(inventoryid) on delete cascade, -- if inv.invID is deleted, auto delete also
    foreign key (salesdetails_saleid) references sales(saleid)
);

create table salesreports (
    reportid int primary key identity(1,1),
    salesrep_salesdetailid int not null,
    salesrep_itemid int not null,
    itemprice decimal(10,2) not null,
    total decimal(10,2) not null,
    foreign key (salesrep_salesdetailid) references salesdetails(salesdetailid) on delete cascade,
    foreign key (salesrep_itemid) references items(itemid) on delete no action
);

create table userAcc(
    userId int primary key identity(900,25),
    userName nvarchar(20) not null,
    userPass nvarchar(20) not null
);

create table adminAcc(
    adminId int primary key identity(900,25),
    adminUserName nvarchar(20) not null,
    adminPass nvarchar(20) not null
);


-- Initialize Insert items into table
INSERT INTO items (itemName, itemCategory, itemPrice)
SELECT itemName, itemCategory, itemPrice
FROM (VALUES
    ('croissant', 'bakery', 1.20),
    ('sliced bread', 'bakery', 1.40),
    ('bagel', 'bakery', 1.78),
    ('butter', 'dairy', 1.20),
    ('cheese', 'dairy', 2.30),
    ('yogurt', 'dairy', 2.50),
    ('wine', 'beverage', 15.35),
    ('juice', 'beverage', 3.00),
    ('soda', 'beverage', 1.50),
    ('rice', 'grains', 4.00),
    ('wheat', 'grains', 2.40),
    ('corn', 'grains', 1.50),
    ('tomato', 'produce', 1.36),
    ('cabbage', 'produce', 1.12),
    ('carrots', 'produce', 1.53),
    ('chips', 'snacks', 0.56),
    ('nachos', 'snacks', 1.23),
    ('cookies', 'snacks', 0.78)
) 
AS ItemsData(itemName, itemCategory, itemPrice)
WHERE NOT EXISTS (SELECT 1 FROM items WHERE items.itemName = ItemsData.itemName);

-- Initalize Inventory
INSERT INTO inventory (inv_itemId, inventoryDate, inventoryStock)
SELECT i.itemId, GETDATE(), s.inventoryStock
FROM (
    VALUES
        ('croissant', 20),
        ('sliced bread', 25),
        ('bagel', 30),
        ('butter', 30),
        ('cheese', 20),
        ('yogurt', 20),
        ('wine', 30),
        ('juice', 50),
        ('soda', 60),
        ('rice', 1000),
        ('wheat', 90),
        ('corn', 70),
        ('tomato', 40),
        ('cabbage', 30),
        ('carrots', 30),
        ('chips', 40),
        ('nachos', 30),
        ('cookies', 30)
) AS s(itemName, inventoryStock)
JOIN items i ON i.itemName = s.itemName
WHERE NOT EXISTS (
    SELECT 1 FROM inventory WHERE inv_itemId = i.itemId
);


-- Update items in case of 0 stock
/*
UPDATE inv
SET inv.inventorystock = s.inventoryStock
FROM dbo.inventory inv
JOIN (
    VALUES
        ('croissant', 20),
        ('sliced bread', 25),
        ('bagel', 30),
        ('butter', 30),
        ('cheese', 20),
        ('yogurt', 20),
        ('wine', 30),
        ('juice', 50),
        ('soda', 60),
        ('rice', 1000),
        ('wheat', 90),
        ('corn', 70),
        ('tomato', 40),
        ('cabbage', 30),
        ('carrots', 30),
        ('chips', 40),
        ('nachos', 30),
        ('cookies', 30)
) AS s(itemName, inventoryStock)
ON inv.inv_itemid = (
    SELECT itemId
    FROM dbo.items
    WHERE itemName = s.itemName
);
*/
-- Testing the Database
select * from items;
select * from inventory;
-- select * from sales;
-- select * from salesdetails;
-- select * from salesreports;
select * from userAcc;
select * from adminAcc;

-- Optionally drop the database for testing purposes (use with caution)

USE master;
GO
ALTER DATABASE grocerydb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE grocerydb;
--GO
-- drop procedure dbo.insertIntoItem
-- EXEC GetItemStock @ItemName = 'rice';
-- EXEC UpdateItemStockAfterSale 'rice', 200, '2025-02-20'