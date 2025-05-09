use grocerydb;
go


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
GO

-- Item & Inventory
INSERT INTO ItemsInventory (
    itemName, itemCategory, itemPrice, inventoryStock, inventoryDate
)
SELECT 
    i.itemname,
    i.itemcategory,
    i.itemprice,
    inv.inventorystock,
    inv.inventorydate
FROM items i
JOIN inventory inv ON i.itemid = inv.inv_itemid;
GO
-- Gets the item Stock
CREATE PROCEDURE GetItemStock
    @ItemName NVARCHAR(100)
AS
BEGIN
    SELECT inv.inventoryStock
    FROM inventory inv
    INNER JOIN items i ON inv.inv_itemId = i.itemId
    WHERE i.itemName = @ItemName;
END
GO

-- Updates Stock after Sale
CREATE PROCEDURE UpdateItemStockAfterSale
    @ItemName NVARCHAR(50),
    @SoldQuantity INT,
    @InventoryDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ItemId INT, @CurrentStock INT;

    -- Get the item ID based on item name
    SELECT @ItemId = itemid
    FROM dbo.items
    WHERE itemname = @ItemName;

    IF @ItemId IS NOT NULL
    BEGIN
        -- Get the most recent inventory stock for that item
        SELECT TOP 1 @CurrentStock = inventorystock
        FROM dbo.inventory
        WHERE inv_itemid = @ItemId
        ORDER BY inventorydate DESC;

        -- If enough stock is available, update the stock
        IF @CurrentStock >= @SoldQuantity
        BEGIN
            UPDATE dbo.inventory
            SET inventorystock = inventorystock + @SoldQuantity, inventorydate = @InventoryDate
            WHERE inv_itemid = @ItemId
            AND inventorystock = @CurrentStock;
        END
    END
END;
GO

-- Get Item Price Procedure
create procedure GetItemPriceByName
    @ItemName nvarchar(50)
as
begin
    set nocount on;

    select itemprice
    from items
    where itemname = @ItemName;
end;
go


-- Login Acc 
CREATE PROCEDURE accLogin
    @username NVARCHAR(20),
    @password NVARCHAR(20),
    @userType NVARCHAR(10) OUTPUT,
    @accountId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- First check in userAcc
    SELECT @accountId = userId, @userType = 'User'
    FROM userAcc
    WHERE userName = @username AND userPass = @password;

    IF @accountId IS NULL
    BEGIN
        -- Then check in adminAcc
        SELECT @accountId = adminId, @userType = 'Admin'
        FROM adminAcc
        WHERE adminUserName = @username AND adminPass = @password;
    END

    -- If still NULL, then login failed
    IF @accountId IS NULL
    BEGIN
        SET @userType = 'Invalid';
    END
END;
GO


create procedure InsertIntoItemsInventory
    @itemname nvarchar(50),
    @itemcategory nvarchar(20),
    @itemprice decimal(10, 2),
    @inventorystock int
as
begin
    set nocount on;
    -- Step 1: Insert the new item into the 'items' table and get the generated itemid
    insert into items (itemname, itemcategory, itemprice)
    values (@itemname, @itemcategory, @itemprice);

    -- Get the generated itemid of the newly inserted item
    set @itemid = scope_identity();

    begin
        -- Insert inventory for the new item
        insert into inventory (inventorydate, inventorystock)
        values ( getdate(), @inventorystock);
    end
end
drop procedure InsertIntoItemInventory
go

-- Sales Report
CREATE VIEW SalesReport AS
SELECT 
    s.saleid,
    s.saledate,
    sd.salesdetailid,
    sd.quantity,
    sd.salesDetails_totalsale
FROM 
    sales s
INNER JOIN 
    salesdetails sd ON s.saleid = sd.salesdetails_saleid;
GO

-- Inventory Reports 
CREATE VIEW InvReportsView AS
SELECT
    inv.inventorydate,
    inv.inventorystock,
    inv.inventoryid,
    i.itemid,
    i.itemname,
    i.itemcategory
FROM 
    inventory inv
INNER JOIN
    items i ON i.itemid = inv.inv_itemid;
GO

