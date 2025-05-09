-- Update items in case of 0 stock
/*
UPDATE inv
SET inv.inventorystock = s.inventoryStock
FROM dbo.inventory inv
JOIN (
    VALUES
        ('croissant', 10),
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
select * from inventory;
-- select * from sales;
-- select * from salesdetails;
-- select * from salesreports;
--select * from userAcc;
--select * from adminAcc;

-- Optionally drop the database for testing purposes (use with caution)

USE master;
GO
ALTER DATABASE grocerydb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE grocerydb;
GO
-- drop procedure dbo.insertIntoItem
-- EXEC GetItemStock @ItemName = 'rice';
-- EXEC UpdateItemStockAfterSale 'rice', 200, '2025-02-20'



select * from userAcc
select * from adminAcc
select * from salesreports
--drop table userAcc