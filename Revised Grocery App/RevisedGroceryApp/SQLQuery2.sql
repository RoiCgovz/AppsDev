CREATE PROCEDURE insertIntoInv
AS
BEGIN
    INSERT INTO Items (itemName, itemCategory, itemPrice)
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
    ) AS ItemsData(itemName, itemCategory, itemPrice)
    WHERE NOT EXISTS (SELECT 1 FROM Items WHERE itemName = ItemsData.itemName);

    DECLARE @itemId INT;
    DECLARE @itemName NVARCHAR(50);
    DECLARE @inventoryStock INT;

    DECLARE inventory_cursor CURSOR FOR
    SELECT itemName, 
        CASE
            WHEN itemName = 'croissant' THEN 20
            WHEN itemName = 'sliced bread' THEN 25
            WHEN itemName = 'bagel' THEN 30
            WHEN itemName = 'butter' THEN 30
            WHEN itemName = 'cheese' THEN 20
            WHEN itemName = 'yogurt' THEN 20
            WHEN itemName = 'wine' THEN 30
            WHEN itemName = 'juice' THEN 50
            WHEN itemName = 'soda' THEN 60
            WHEN itemName = 'rice' THEN 1000
            WHEN itemName = 'wheat' THEN 90
            WHEN itemName = 'corn' THEN 70
            WHEN itemName = 'tomato' THEN 40
            WHEN itemName = 'cabbage' THEN 30
            WHEN itemName = 'carrots' THEN 30
            WHEN itemName = 'chips' THEN 40
            WHEN itemName = 'nachos' THEN 30
            WHEN itemName = 'cookies' THEN 30
            ELSE 0  
        END AS inventoryStock
    FROM Items;

    OPEN inventory_cursor;

    FETCH NEXT FROM inventory_cursor INTO @itemName, @inventoryStock;

    WHILE @@FETCH_STATUS = 0
    BEGIN
    
        SET @itemId = (SELECT itemId FROM Items WHERE itemName = @itemName);

        INSERT INTO Inventory (inv_itemId, inventoryDate, inventoryStock)
        VALUES (@itemId, GETDATE(), @inventoryStock);

        FETCH NEXT FROM inventory_cursor INTO @itemName, @inventoryStock;
    END

    CLOSE inventory_cursor;
    DEALLOCATE inventory_cursor;
END
