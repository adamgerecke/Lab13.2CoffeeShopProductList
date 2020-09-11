USE [master]
GO
/****** Object:  Database [Lab13.2CoffeeShopProductList]    Script Date: 9/11/2020 4:02:59 PM ******/
CREATE DATABASE [Lab13.2CoffeeShopProductList]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lab13.2CoffeeShopProductList', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lab13.2CoffeeShopProductList.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lab13.2CoffeeShopProductList_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lab13.2CoffeeShopProductList_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab13.2CoffeeShopProductList].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET  MULTI_USER 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET QUERY_STORE = OFF
GO
USE [Lab13.2CoffeeShopProductList]
GO
/****** Object:  User [da]    Script Date: 9/11/2020 4:02:59 PM ******/
CREATE USER [da] FOR LOGIN [da] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/11/2020 4:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Description] [nchar](50) NULL,
	[Price] [money] NOT NULL,
	[Category] [nchar](15) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (1, N'Black Coffee        ', N'Black as night                                    ', 1.9900, N'Drink          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (2, N'Green Tea           ', N'It''s healthy right?                               ', 3.5500, N'Drink          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (3, N'Water               ', N'Natural                                           ', 6.9900, N'Drink          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (4, N'Bread               ', N'Baked with flour                                  ', 2.4300, N'Food           ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (5, N'Cheese              ', N'Salt, and Fat. What else could you want?          ', 5.6300, N'Food           ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (6, N'Soup                ', N'It''s like hot liquid salad                        ', 3.5700, N'Food           ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (7, N'Chocolate Bar       ', N'Mmmmmm                                            ', 1.6300, N'Candy          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (8, N'Fudge               ', N'Like chocolate... but with more sugar             ', 14.5300, N'Candy          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (9, N'Gummy Bears         ', N'Only the best                                     ', 2.7800, N'Candy          ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (10, N'Travel Mug          ', N'So you can take your drink to go!                 ', 15.9800, N'Gift           ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (11, N'Keychain            ', N'So... you can tell your friends about us          ', 0.9500, N'Gift           ')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [Lab13.2CoffeeShopProductList] SET  READ_WRITE 
GO
