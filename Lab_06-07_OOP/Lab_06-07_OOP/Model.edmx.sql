
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/26/2021 11:48:45
-- Generated from EDMX file: D:\University\Labs\OOP part 2\Lab_06-07_OOP\Lab_06-07_OOP\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Market];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CommentProductPK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[comments] DROP CONSTRAINT [FK_CommentProductPK];
GO
IF OBJECT_ID(N'[dbo].[FK_DetailsOrderFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orderdetails] DROP CONSTRAINT [FK_DetailsOrderFK];
GO
IF OBJECT_ID(N'[dbo].[FK_DetailsProductFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orderdetails] DROP CONSTRAINT [FK_DetailsProductFK];
GO
IF OBJECT_ID(N'[dbo].[FK_OrdersUsersFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orders] DROP CONSTRAINT [FK_OrdersUsersFK];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductCategoriesFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[products] DROP CONSTRAINT [FK_ProductCategoriesFK];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductSubcategoriesFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[products] DROP CONSTRAINT [FK_ProductSubcategoriesFK];
GO
IF OBJECT_ID(N'[dbo].[FK_SubCategoryFK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[productsubcategories] DROP CONSTRAINT [FK_SubCategoryFK];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[comments];
GO
IF OBJECT_ID(N'[dbo].[orderdetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orderdetails];
GO
IF OBJECT_ID(N'[dbo].[orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orders];
GO
IF OBJECT_ID(N'[dbo].[productcategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[productcategories];
GO
IF OBJECT_ID(N'[dbo].[products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[products];
GO
IF OBJECT_ID(N'[dbo].[productsubcategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[productsubcategories];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'comments'
CREATE TABLE [dbo].[comments] (
    [CommentID] int IDENTITY(1,1) NOT NULL,
    [CommentProductID] int  NULL,
    [CommentUserID] int  NULL,
    [Comment1] varchar(1000)  NULL
);
GO

-- Creating table 'orderdetails'
CREATE TABLE [dbo].[orderdetails] (
    [DetailsID] int IDENTITY(1,1) NOT NULL,
    [DetailsOrderID] int  NULL,
    [DetailsProductID] int  NULL
);
GO

-- Creating table 'orders'
CREATE TABLE [dbo].[orders] (
    [OrderID] int IDENTITY(1,1) NOT NULL,
    [OrderUserID] int  NULL,
    [OrderCountry] varchar(20)  NULL,
    [OrderCity] varchar(50)  NULL,
    [OrderAddress] varchar(50)  NULL,
    [OrderStatus] char(6)  NULL,
    [OrderDate] datetime  NULL,
    [OrderTrackingNumber] varchar(30)  NULL,
    [OrderAmount] float  NULL
);
GO

-- Creating table 'productcategories'
CREATE TABLE [dbo].[productcategories] (
    [CategoryID] int IDENTITY(1,1) NOT NULL,
    [CategoryName] varchar(50)  NULL,
    [CategoryImage] varbinary(max)  NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [ProductCategory] int  NULL,
    [ProductSubcategory] int  NULL,
    [ProductName] varchar(50)  NULL,
    [ProductWeight] int  NULL,
    [ProductShortDesc] nvarchar(200)  NULL,
    [ProductThumb] varbinary(max)  NULL,
    [ProductImage] varbinary(max)  NULL,
    [ProductStock] int  NULL,
    [ProductPrice] float  NULL
);
GO

-- Creating table 'productsubcategories'
CREATE TABLE [dbo].[productsubcategories] (
    [SubcategoryID] int IDENTITY(1,1) NOT NULL,
    [SubcategoryCategoryID] int  NULL,
    [SubcategoryName] varchar(50)  NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserEmail] varchar(100)  NULL,
    [UserPassword] varchar(30)  NULL,
    [UserFirstName] varchar(50)  NULL,
    [UserLastName] varchar(50)  NULL,
    [UserMiddleNAme] varchar(50)  NULL,
    [UserRegistrationDate] datetime  NULL,
    [UserCountry] varchar(20)  NULL,
    [UserCity] varchar(50)  NULL,
    [UserAddress] varchar(50)  NULL,
    [UserZip] decimal(6,0)  NULL,
    [UserPhone] decimal(14,0)  NULL,
    [Role] tinyint  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CommentID] in table 'comments'
ALTER TABLE [dbo].[comments]
ADD CONSTRAINT [PK_comments]
    PRIMARY KEY CLUSTERED ([CommentID] ASC);
GO

-- Creating primary key on [DetailsID] in table 'orderdetails'
ALTER TABLE [dbo].[orderdetails]
ADD CONSTRAINT [PK_orderdetails]
    PRIMARY KEY CLUSTERED ([DetailsID] ASC);
GO

-- Creating primary key on [OrderID] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [PK_orders]
    PRIMARY KEY CLUSTERED ([OrderID] ASC);
GO

-- Creating primary key on [CategoryID] in table 'productcategories'
ALTER TABLE [dbo].[productcategories]
ADD CONSTRAINT [PK_productcategories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [ProductID] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [SubcategoryID] in table 'productsubcategories'
ALTER TABLE [dbo].[productsubcategories]
ADD CONSTRAINT [PK_productsubcategories]
    PRIMARY KEY CLUSTERED ([SubcategoryID] ASC);
GO

-- Creating primary key on [UserID] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CommentProductID] in table 'comments'
ALTER TABLE [dbo].[comments]
ADD CONSTRAINT [FK_CommentProductPK]
    FOREIGN KEY ([CommentProductID])
    REFERENCES [dbo].[products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentProductPK'
CREATE INDEX [IX_FK_CommentProductPK]
ON [dbo].[comments]
    ([CommentProductID]);
GO

-- Creating foreign key on [DetailsOrderID] in table 'orderdetails'
ALTER TABLE [dbo].[orderdetails]
ADD CONSTRAINT [FK_DetailsOrderFK]
    FOREIGN KEY ([DetailsOrderID])
    REFERENCES [dbo].[orders]
        ([OrderID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetailsOrderFK'
CREATE INDEX [IX_FK_DetailsOrderFK]
ON [dbo].[orderdetails]
    ([DetailsOrderID]);
GO

-- Creating foreign key on [DetailsProductID] in table 'orderdetails'
ALTER TABLE [dbo].[orderdetails]
ADD CONSTRAINT [FK_DetailsProductFK]
    FOREIGN KEY ([DetailsProductID])
    REFERENCES [dbo].[products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetailsProductFK'
CREATE INDEX [IX_FK_DetailsProductFK]
ON [dbo].[orderdetails]
    ([DetailsProductID]);
GO

-- Creating foreign key on [OrderUserID] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [FK_OrdersUsersFK]
    FOREIGN KEY ([OrderUserID])
    REFERENCES [dbo].[users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrdersUsersFK'
CREATE INDEX [IX_FK_OrdersUsersFK]
ON [dbo].[orders]
    ([OrderUserID]);
GO

-- Creating foreign key on [ProductCategory] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [FK_ProductCategoriesFK]
    FOREIGN KEY ([ProductCategory])
    REFERENCES [dbo].[productcategories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductCategoriesFK'
CREATE INDEX [IX_FK_ProductCategoriesFK]
ON [dbo].[products]
    ([ProductCategory]);
GO

-- Creating foreign key on [SubcategoryCategoryID] in table 'productsubcategories'
ALTER TABLE [dbo].[productsubcategories]
ADD CONSTRAINT [FK_SubCategoryFK]
    FOREIGN KEY ([SubcategoryCategoryID])
    REFERENCES [dbo].[productcategories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubCategoryFK'
CREATE INDEX [IX_FK_SubCategoryFK]
ON [dbo].[productsubcategories]
    ([SubcategoryCategoryID]);
GO

-- Creating foreign key on [ProductSubcategory] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [FK_ProductSubcategoriesFK]
    FOREIGN KEY ([ProductSubcategory])
    REFERENCES [dbo].[productsubcategories]
        ([SubcategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductSubcategoriesFK'
CREATE INDEX [IX_FK_ProductSubcategoriesFK]
ON [dbo].[products]
    ([ProductSubcategory]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------