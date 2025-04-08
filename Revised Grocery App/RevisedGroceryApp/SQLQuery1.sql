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

drop table Items

-- testing the database
select * from items;
select * from inventory;
select * from sales;
select * from salesdetails;
select * from salesreports;

-- drop database in case it fails
drop database grocerydb;