USE [master]
GO
/****** Object:  Database [FStore]    Script Date: 1/9/2024 1:32:45 PM ******/
CREATE DATABASE [FStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [FStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FStore] SET RECOVERY FULL 
GO
ALTER DATABASE [FStore] SET  MULTI_USER 
GO
ALTER DATABASE [FStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FStore', N'ON'
GO
ALTER DATABASE [FStore] SET QUERY_STORE = OFF
GO
USE [FStore]
GO
/****** Object:  User [bankingAdmin]    Script Date: 1/9/2024 1:32:46 PM ******/
CREATE USER [bankingAdmin] FOR LOGIN [bankingAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'member1@email.com', N'EcoVista Innovations', N'Barcelona', N'Spain', N'password1')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'member2@email.com', N'Pinnacle Tech Ventures', N'Sydney', N'Country2', N'password2')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'member3@email.com', N'Global Harmony Industries', N'Sydney', N'Country3', N'password3')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'member4@email.com', N'Infinite Horizon Solutions', N'Vancouver', N'Country4', N'password4')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'member5@email.com', N'Strategic Nexus Enterprises', N'Cape Town', N'Country5', N'password5')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (8, N'demo@email.com', N'FPT', N'Da Nang', N'Viet Name', N'password')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2024-01-05T00:00:00.000' AS DateTime), CAST(N'2024-01-03T00:00:00.000' AS DateTime), 5.9900)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2024-02-01T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), CAST(N'2024-02-03T00:00:00.000' AS DateTime), 7.5000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 3, CAST(N'2024-03-01T00:00:00.000' AS DateTime), CAST(N'2024-03-05T00:00:00.000' AS DateTime), CAST(N'2024-03-03T00:00:00.000' AS DateTime), 8.2500)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4, 4, CAST(N'2024-04-01T00:00:00.000' AS DateTime), CAST(N'2024-04-05T00:00:00.000' AS DateTime), CAST(N'2024-04-03T00:00:00.000' AS DateTime), 6.5000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (5, 5, CAST(N'2024-05-01T00:00:00.000' AS DateTime), CAST(N'2024-05-05T00:00:00.000' AS DateTime), CAST(N'2024-05-03T00:00:00.000' AS DateTime), 10.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 10.9900, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 15.9900, 1, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 8.9900, 3, 0.05)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 4, 20.4900, 2, 0.2)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4, 5, 18.7500, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 101, N'Breadboard', N'1.5 kg', 10.9900, 50)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 102, N'Rice', N'2.0 kg', 15.9900, 30)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 103, N'Smartphone', N'1.2 kg', 8.9900, 20)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 104, N'Air Conditioner', N'3.0 kg', 20.4900, 40)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 105, N'Pork', N'2.5 kg', 18.7500, 25)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (8, 141, N'Rice Pork', N'1.5 Kg', 10.0000, 12)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
/****** Object:  StoredProcedure [dbo].[CheckCredentials]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckCredentials]
    @Email VARCHAR(100),
    @Password VARCHAR(30),
    @IsValid BIT OUTPUT
AS
BEGIN
    SET @IsValid = 0; -- Initialize as invalid

    IF EXISTS (SELECT 1 FROM Member WHERE Email = @Email AND Password = @Password)
    BEGIN
        SET @IsValid = 1; -- Set as valid
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteMember]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteMember]
    @MemberId INT
AS
BEGIN
    DELETE FROM Member WHERE MemberId = @MemberId;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrder]
    @OrderId INT
AS
BEGIN
    DELETE FROM [Order] WHERE OrderId = @OrderId;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrderDetail]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrderDetail]
    @OrderId INT
AS
BEGIN
    DELETE FROM OrderDetail WHERE OrderId = @OrderId;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteProduct]
    @ProductId INT
AS
BEGIN
    DELETE FROM Product WHERE ProductId = @ProductId;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetMembers]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetMembers]
AS
BEGIN
    SELECT * FROM Member;
END;

GO
/****** Object:  StoredProcedure [dbo].[GetOrderDetails]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderDetails]
AS
BEGIN
    SELECT * FROM OrderDetail;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetOrders]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrders]
AS
BEGIN
    SELECT * FROM [Order];
END;
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProducts]
AS
BEGIN
    SELECT * FROM Product;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertMember]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertMember]
    @Email VARCHAR(100),
    @CompanyName VARCHAR(40),
    @City VARCHAR(15),
    @Country VARCHAR(15),
    @Password VARCHAR(30)
AS
BEGIN
    INSERT INTO Member (Email, CompanyName, City, Country, Password)
    VALUES (@Email, @CompanyName, @City, @Country, @Password);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrder]
    @MemberId INT,
    @OrderDate DATETIME,
    @RequiredDate DATETIME,
    @ShippedDate DATETIME,
    @Freight MONEY
AS
BEGIN
    INSERT INTO [Order] (MemberId, OrderDate, RequiredDate, ShippedDate, Freight)
    VALUES (@MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertOrderDetail]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrderDetail]
    @OrderId INT,
    @ProductId INT,
    @UnitPrice MONEY,
    @Quantity INT,
    @Discount FLOAT
AS
BEGIN
    INSERT INTO OrderDetail (OrderId, ProductId, UnitPrice, Quantity, Discount)
    VALUES (@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertProduct]
    @CategoryId INT,
    @ProductName VARCHAR(40),
    @Weight VARCHAR(20),
    @UnitPrice MONEY,
    @UnitsInStock INT
AS
BEGIN
    INSERT INTO Product (CategoryId, ProductName, Weight, UnitPrice, UnitsInStock)
    VALUES (@CategoryId, @ProductName, @Weight, @UnitPrice, @UnitsInStock);
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateMember]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateMember]
    @MemberId INT,
    @Email VARCHAR(100),
    @CompanyName VARCHAR(40),
    @City VARCHAR(15),
    @Country VARCHAR(15),
    @Password VARCHAR(30)
AS
BEGIN
    UPDATE Member
    SET Email = @Email,
        CompanyName = @CompanyName,
        City = @City,
        Country = @Country,
        Password = @Password
    WHERE MemberId = @MemberId;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrder]
    @OrderId INT,
    @MemberId INT,
    @OrderDate DATETIME,
    @RequiredDate DATETIME,
    @ShippedDate DATETIME,
    @Freight MONEY
AS
BEGIN
    UPDATE [Order]
    SET MemberId = @MemberId,
        OrderDate = @OrderDate,
        RequiredDate = @RequiredDate,
        ShippedDate = @ShippedDate,
        Freight = @Freight
    WHERE OrderId = @OrderId;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrderDetail]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrderDetail]
    @OrderId INT,
    @ProductId INT,
    @UnitPrice MONEY,
    @Quantity INT,
    @Discount FLOAT
AS
BEGIN
    UPDATE OrderDetail
    SET UnitPrice = @UnitPrice,
        Quantity = @Quantity,
        Discount = @Discount
    WHERE OrderId = @OrderId AND ProductId = @ProductId;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 1/9/2024 1:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProduct]
    @ProductId INT,
    @CategoryId INT,
    @ProductName VARCHAR(40),
    @Weight VARCHAR(20),
    @UnitPrice MONEY,
    @UnitsInStock INT
AS
BEGIN
    UPDATE Product
    SET CategoryId = @CategoryId,
        ProductName = @ProductName,
        Weight = @Weight,
        UnitPrice = @UnitPrice,
        UnitsInStock = @UnitsInStock
    WHERE ProductId = @ProductId;
END;
GO
USE [master]
GO
ALTER DATABASE [FStore] SET  READ_WRITE 
GO
