CREATE TABLE [dbo].[CustomerDetails] (
    [CustomerID]    VARCHAR (50) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [ContactNumber] BIGINT       NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);
CREATE TABLE [dbo].[PurchaseHistory] (
    [PurchaseID] VARCHAR (50) NOT NULL,
    [TotalPrice] VARCHAR (50) NOT NULL,
    [Date]       DATETIME     NOT NULL,
    [SupplierID] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PurchaseID] ASC)
);
CREATE TABLE [dbo].[Sales] (
    [SalesID]       INT          NOT NULL,
    [SalesDate]     DATETIME     NOT NULL,
    [TransactionID] VARCHAR (50) NOT NULL,
    [CustomerID]    VARCHAR (50) NOT NULL,
    [SalesTotal]    FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([SalesID] ASC)
);
CREATE TABLE [dbo].[SalesHistory] (
    [SalesID]    VARCHAR (50) NOT NULL,
    [ProductID]  VARCHAR (50) NOT NULL,
    [UnitPrice]  FLOAT (53)   NOT NULL,
    [Quantity]   FLOAT (53)   NOT NULL,
    [Date]       DATETIME     NOT NULL,
    [TotalPrice] FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([SalesID] ASC)
);
CREATE TABLE [dbo].[StockDetails] (
    [ProductID]   VARCHAR (50) NOT NULL,
    [ProductName] VARCHAR (50) NOT NULL,
    [UnitPrice]   FLOAT (53)   NOT NULL,
    [Quantity]    FLOAT (53)   NOT NULL,
    [SupplierID]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);
CREATE TABLE [dbo].[SupplierDetails] (
    [SupplierID]    VARCHAR (50)  NOT NULL,
    [SupplierName]  VARCHAR (50)  NOT NULL,
    [ContactNumber] BIGINT        NOT NULL,
    [Description]   VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([SupplierID] ASC)
);
 