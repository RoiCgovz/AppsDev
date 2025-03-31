create database GroceryDb;

create table GroceryStock (
    ItemID int identity(1,1) primary key,
    ItemName nvarchar(100) not null,
    Category nvarchar(50) not null, 
    Quantity int not null check (Quantity >= 0),
    Price decimal(10,2) not null check (Price >= 0),
);

INSERT INTO GroceryStock (ItemName, Category, Quantity, Price)
VALUES
    -- Bakery Items
    ('Croissant', 'Bakery', 20, 1.20),
    ('Sliced Bread', 'Bakery', 25, 1.40),
    ('Bagel', 'Bakery', 30, 1.78),

    -- Dairy Items
    ('Butter', 'Dairy', 30, 1.20),
    ('Cheese', 'Dairy', 20, 2.30),
    ('Yogurt', 'Dairy', 20, 2.50),

    -- Beverages Items
    ('Wine', 'Beverages', 30, 15.35),
    ('Juice', 'Beverages', 50, 3.00),
    ('Soda', 'Beverages', 60, 1.50),

    -- Grains Items
    ('Rice', 'Grains', 1000, 4.00),
    ('Wheat', 'Grains', 90, 2.40),
    ('Corn', 'Grains', 70, 1.50),

    -- Produce Items
    ('Tomato', 'Produce', 40, 1.36),
    ('Cabbage', 'Produce', 30, 1.12),
    ('Carrots', 'Produce', 30, 1.53),

    -- Snacks Items
    ('Chips', 'Snacks', 40, 0.56),
    ('Nachos', 'Snack', 30, 1.23),
    ('Cookies', 'Snacks', 30, 0.78);