CREATE TABLE [dbo].[ItemList] (
    [ItemID]     int        NOT NULL,
    [Name]       CHAR (25)  NOT NULL,
    [Category]   CHAR (25)  NULL,
    [RentPerDay] int        NOT NULL,
    [ItemImage]  CHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ItemID] ASC)
);

CREATE TABLE [dbo].[studentData] (
    [StudentID] CHAR (10)    NOT NULL,
    [name]      VARCHAR (50) NOT NULL,
    [age]       int          NOT NULL,
    [Program]   VARCHAR (24) NOT NULL,
    CONSTRAint [PK_studentData] PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

CREATE TABLE [dbo].[Cart] (
    [ItemID]     
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    NOT NULL,
    [StudentID]  VARCHAR (10)  NOT NULL,
    [Name]       VARCHAR (25)  NOT NULL,
    [Category]   VARCHAR (25)  NULL,
    [RentPerDay] int           NOT NULL,
    [ItemImage]  VARCHAR (MAX) NULL,
    [TotalPrice] int           NOT NULL,
    CONSTRAint [PK_Cart] PRIMARY KEY CLUSTERED ([ItemID] ASC)
);



INSERT intO [dbo].[studentData] ([StudentID], [name], [age], [Program])
VALUES
('201110166', 'Jonathan Lance Mayo', 20, 'Information Systems');



-- Category: Electronics, Clothing & Accessories, Home & Garden, Tools & Equipment

INSERT intO [dbo].[ItemList] ([ItemID], [Name], [Category], [RentPerDay], [ItemImage])
VALUES
(02, 'Iphone 16 Pro Max', 'Electronics',  249.99, 'C:\Users\Jonathan_Lance\source\repos\Rental_App V1.0\Resource\Items\iphone-16-pro-N1.png');

INSERT intO [dbo].[ItemList] ([ItemID], [Name], [Category], [RentPerDay], [ItemImage])
VALUES
(03, 'Samsung S24 Ultra', 'Electronics', 229.99, 'C:\Users\Jonathan_Lance\source\repos\Rental_App V1.0\Resource\Items\S24U.jpg');

INSERT intO [dbo].[ItemList] ([ItemID], [Name], [Category], [RentPerDay], [ItemImage])
VALUES
(04, 'Google Pixel 9', 'Electronics', 199.99, 'C:\Users\Jonathan_Lance\source\repos\Rental_App V1.0\Resource\Items\Pixel9.jpg');

INSERT intO [dbo].[ItemList] ([ItemID], [Name], [Category], [RentPerDay], [ItemImage])
VALUES
(05, 'Electric Hand Massage', 'Electronics', 200, 'C:\Users\Jonathan_Lance\source\repos\Rental_App V1.0\Resource\Items\Masagger.webp');

INSERT intO [dbo].[ItemList] ([ItemID], [Name], [Category], [RentPerDay], [ItemImage])
VALUES
(06, 'Garden Hoe', 'Home & Garden', 75, NULL);