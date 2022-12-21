CREATE TABLE Customer
(
	[CustomerID] INT NOT NULL PRIMARY KEY Identity(1, 1), 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL
)
