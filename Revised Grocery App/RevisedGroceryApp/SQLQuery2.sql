use grocerydb;
go

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
            SET inventorystock = inventorystock - @SoldQuantity, inventorydate = @InventoryDate
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
