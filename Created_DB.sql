--THE FOLLOWING IS THE P1 STORE DATABASE SEED CODE!
--THIS CODE IS TO BE USED TO CREATE THE DATABASE AND POPULATE IT WITH DATA
GO
CREATE TABLE Customer(
    CustomerId UNIQUEIDENTIFIER PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    LastOrderDate DATETIME NOT NULL,
    Remarks NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
);

GO
CREATE TABLE Stores(
    StoreId UNIQUEIDENTIFIER PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Address NVARCHAR(50) NOT NULL
);

GO
CREATE TABLE Products(
    ProductId UNIQUEIDENTIFIER PRIMARY KEY,
    Name NVARCHAR(50) NULL,
    Description NVARCHAR(50) NULL
);

GO
CREATE TABLE StoreProductJunction(
    ProductId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Products(ProductId) ON DELETE CASCADE,
    StoreId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Stores(StoreId) ON DELETE CASCADE,
    Quantity INT DEFAULT 0,
);

GO
CREATE TABLE [Order](
    ProductId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Products(ProductId) ON DELETE CASCADE,
    StoreId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Stores(StoreId) ON DELETE CASCADE,
    Quantity INT DEFAULT 0,
);

GO
CREATE TABLE Inventory(
    InventoryId UNIQUEIDENTIFIER PRIMARY KEY,
    StoreId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Stores(StoreId) ON DELETE CASCADE,
    Name NVARCHAR(50) NOT NULL,
    ProductId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Products(ProductId) ON DELETE CASCADE,
    Quantity INT DEFAULT 0,
);

INSERT INTO [dbo].[Products] 
VALUES 
(NEWID(),'Apple', 'Red Apple'), 
(NEWID(),'Orange', 'Orange Orange'), 
(NEWID(),'Banana', 'Yellow Banana');

INSERT INTO [dbo].[Customer] 
VALUES 
(NEWID(), N'John', N'Doe', GETDATE(), N'Customer', N'johndoe', N'password'),
(NEWID(), N'Jane', N'Doe', GETDATE(), N'Customer', N'janedoe', N'password');

INSERT INTO [dbo].[Stores]
VALUES 
(NEWID(), N'Walmart', N'123 Main Street'),
(NEWID(), N'Kroger', N'524 Richmond Street'),
(NEWID(), N'HEB', N'Soul Street');

--store 1 = 2e92c0f1-aac2-4be7-b3c5-0d0e1f8c70a8

INSERT INTO [dbo].[StoreProductJunction] VALUES
('37fbb7dd-38e7-4999-8787-6b01533718d9','2e92c0f1-aac2-4be7-b3c5-0d0e1f8c70a8',10),
('0a12b9cc-7aee-432d-ad91-7dd9ae760db4','2e92c0f1-aac2-4be7-b3c5-0d0e1f8c70a8',10),
('464296e0-6b6a-4053-b916-f6c84b4ec394','2e92c0f1-aac2-4be7-b3c5-0d0e1f8c70a8',10),
('37fbb7dd-38e7-4999-8787-6b01533718d9','d735fd24-f912-4242-ba09-2888b86c42d6',20),
('0a12b9cc-7aee-432d-ad91-7dd9ae760db4','d735fd24-f912-4242-ba09-2888b86c42d6',20),
('464296e0-6b6a-4053-b916-f6c84b4ec394','d735fd24-f912-4242-ba09-2888b86c42d6',20),
('37fbb7dd-38e7-4999-8787-6b01533718d9','394bd266-0833-4168-a880-908bdf7e38e1',50),
('0a12b9cc-7aee-432d-ad91-7dd9ae760db4','394bd266-0833-4168-a880-908bdf7e38e1',50),
('464296e0-6b6a-4053-b916-f6c84b4ec394','394bd266-0833-4168-a880-908bdf7e38e1',50);

--this query gets the stores and their inventories
SELECT s.StoreId, s.Name, s.Address, p.ProductId, p.Name,p.Description, spj.Quantity FROM [dbo].[Stores] s
LEFT JOIN [dbo].[StoreProductJunction] spj ON s.StoreId = spj.StoreId
LEFT JOIN [dbo].[Products] p ON spj.ProductId = p.ProductId


/*******************************************************************************
   Populate Tables
********************************************************************************/
INSERT INTO [dbo].[Customer] 
VALUES 
(NEWID(), N'John', N'Doe', GETDATE(), N'Customer', N'johndoe', N'password');
(NEWID(), N'Jane', N'Doe', GETDATE(), N'Customer', N'janedoe', N'password');

INSERT INTO [dbo].[Stores]
VALUES 
(NEWID(), N'Walmart', N'123 Main Street');
(NEWID(), N'Kroger', N'524 Richmond Street');
(NEWID(), N'HEB', N'Soul Street');

INSERT INTO [dbo].[Products] 
VALUES 
(NEWID(),'Apple', 'Red Apple'), 
(NEWID(),'Orange', 'Orange Orange'), 
(NEWID(),'Banana', 'Yellow Banana');

INSERT INTO [dbo].[Order] ([OrderId], [CustomerId], [OrderDate], [StoreId], [ProductId], [OrderDate], [Quantity])
VALUES
(NEWID(), NEWID(), GETDATE(), NEWID(), NEWID(), GETDATE(), 5);

INSERT INTO [dbo].[Inventory] ([InventoryId], [StoreName], [ProductId], [Quantity]) 
VALUES
(NEWID(), N'Walmart', NEWID(), 10);

INSERT INTO [dbo].[StoreProductJunction] ([StoreId], [ProductId])
VALUES
(NEWID(), NEWID());








