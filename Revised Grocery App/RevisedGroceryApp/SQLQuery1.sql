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
    inventoryid int primary key identity(1,1),
    inv_itemid int not null,
    inventorydate datetime not null,
    inventorystock int not null,
    foreign key (inv_itemid) references items(itemid) on delete cascade -- if items.itemid is deleted, auto delete also
);

create table sales (
    saleid int primary key identity(1,1),
    saledate datetime not null
);

create table salesdetails (
    salesdetailid int primary key identity(1,1),
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

-- Insert items into table
INSERT INTO items (itemName, itemCategory, itemPrice)
SELECT itemName, itemCategory, itemPrice
FROM (VALUES
    ('croissant', 'bakery', 2.50),
    ('sliced bread', 'bakery', 1.80),
    ('bagel', 'bakery', 2.00),
    ('butter', 'dairy', 1.50),
    ('cheese', 'dairy', 3.00),
    ('yogurt', 'dairy', 1.20),
    ('wine', 'beverage', 12.00),
    ('juice', 'beverage', 3.50),
    ('soda', 'beverage', 1.00),
    ('rice', 'grains', 0.75),
    ('wheat', 'grains', 0.90),
    ('corn', 'grains', 1.20),
    ('tomato', 'vegetable', 0.80),
    ('cabbage', 'vegetable', 1.00),
    ('carrots', 'vegetable', 0.90),
    ('chips', 'snacks', 2.00),
    ('nachos', 'snacks', 2.50),
    ('cookies', 'snacks', 1.50)
) 
AS ItemsData(itemName, itemCategory, itemPrice)
WHERE NOT EXISTS (SELECT 1 FROM items WHERE items.itemName = ItemsData.itemName);

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


-- Testing the Database
select * from items;
select * from inventory;
select * from sales;
select * from salesdetails;
select * from salesreports;

-- Optionally drop the database for testing purposes (use with caution)
-- drop database grocerydb;
-- drop procedure dbo.insertIntoItems
