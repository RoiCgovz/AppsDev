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

CREATE PROCEDURE insertUserAccount
    @UserName NVARCHAR(20),
    @UserPass NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO userAcc (userName, userPass)
    VALUES (@UserName, @UserPass);
END;
GO

CREATE PROCEDURE insertAdminAccount
    @AdminUserName NVARCHAR(20),
    @AdminPass NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO adminAcc (adminUserName, adminPass)
    VALUES (@AdminUserName, @AdminPass);
END;
GO