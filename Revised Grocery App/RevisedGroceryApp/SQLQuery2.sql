use grocerydb;
go

-- Gets the stock of a specific item
CREATE PROCEDURE GetItemStock
    @ItemName NVARCHAR(100)
AS
BEGIN
    SELECT inventorystock
    FROM dbo.inventory
END
go

-- Updates the stock after a sale
create procedure UpdateItemStockAfterSale
    @ItemName nvarchar(50),
    @SoldQuantity int,
    @InventoryDate datetime
as
begin
    set nocount on;

    declare @ItemId int, @CurrentStock int;

    select @ItemId = itemid
    from dbo.items
    where items.itemname = @ItemName;

    if @ItemId is not null
    begin

        select top 1 @CurrentStock = inventorystock
        from inventory
        where inventory.inv_itemid = @ItemId
        order by inventorydate desc;

        if @CurrentStock >= @SoldQuantity
        begin
            insert into inventory (inv_itemid, inventorystock, inventorydate)
            values (@ItemId, @CurrentStock - @SoldQuantity, @InventoryDate);
        end
        else
        begin
            raiserror('Not enough stock available for sale.', 16, 1);
        end
    end
    else
    begin
        raiserror('Item not found.', 16, 1);
    end
end;
go

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

-- Reset Inventory Stock Procedure
create procedure resetInventoryStock
AS
BEGIN
    UPDATE inventory
    SET inventorystock = CASE 
        WHEN items.itemname = 'croissant' THEN 20
        WHEN items.itemname = 'sliced bread' THEN 25
        WHEN items.itemname = 'bagel' THEN 30
        WHEN items.itemname = 'butter' THEN 30
        WHEN items.itemname = 'cheese' THEN 20
        WHEN items.itemname = 'yogurt' THEN 20
        WHEN items.itemname = 'wine' THEN 30
        WHEN items.itemname = 'juice' THEN 50
        WHEN items.itemname = 'soda' THEN 60
        WHEN items.itemname = 'rice' THEN 1000
        WHEN items.itemname = 'wheat' THEN 90
        WHEN items.itemname = 'corn' THEN 70
        WHEN items.itemname = 'tomato' THEN 40
        WHEN items.itemname = 'cabbage' THEN 30
        WHEN items.itemname = 'carrots' THEN 30
        WHEN items.itemname = 'chips' THEN 40
        WHEN items.itemname = 'nachos' THEN 30
        WHEN items.itemname = 'cookies' THEN 30
        ELSE inventorystock
    END
    FROM inventory
    INNER JOIN items ON inventory.inv_itemid = items.itemid;
END;
GO