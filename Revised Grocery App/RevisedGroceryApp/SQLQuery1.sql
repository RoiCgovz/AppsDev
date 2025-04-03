create database GroceryDb;
use GroceryDb;
go

CREATE TABLE GroceryStock (
    StockID int identity(1,1) primary key,
    ItemName nvarchar(100) unique not null,
    Category nvarchar(50) not null,
    AvailableQty int not null check (AvailableQty >= 0),
    Price decimal(10,2) not null check (Price >= 0)
);

insert into GroceryStock (ItemName, Category, AvailableQty, UnitPrice)
values
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
    ('Chips', 'Snack', 40, 0.56),
    ('Nachos', 'Snack', 30, 1.23),
    ('Cookies', 'Snack', 30, 0.78);

CREATE TABLE Transactions (
    TransactionID INT IDENTITY(5000,1) PRIMARY KEY,
    TotalAmount DECIMAL(10,2) NOT NULL,
    ItemCount INT NOT NULL CHECK (ItemCount > 0),
    TransactionDate DATETIME DEFAULT GETDATE() NOT NULL
);

CREATE TABLE TransactionDetails (
    TransactionID INT,
    AccountID INT,
    PRIMARY KEY (TransactionID, AccountID),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON DELETE CASCADE
);

CREATE TABLE Accounts (
    AccountID INT IDENTITY(6000,1) PRIMARY KEY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    PassHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(255) UNIQUE NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL
);

-- Retrieve Stock Data
SELECT * FROM GroceryStock;

-- Retrieve Transaction History
SELECT * FROM Transactions;
