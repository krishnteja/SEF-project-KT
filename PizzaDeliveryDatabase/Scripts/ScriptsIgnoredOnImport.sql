
USE [master]
GO

/****** Object:  Database [DeliveryDatabase]    Script Date: 08/05/2018 23:28:12 ******/
CREATE DATABASE [DeliveryDatabase] ON  PRIMARY 
( NAME = N'DeliveryDatabase', FILENAME = N'C:\Users\krishnak\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDBDeliveryDatabase_Primary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DeliveryDatabase_log', FILENAME = N'C:\Users\krishnak\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDBDeliveryDatabase_Primary.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeliveryDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DeliveryDatabase] SET ANSI_NULL_DEFAULT ON
GO

ALTER DATABASE [DeliveryDatabase] SET ANSI_NULLS ON
GO

ALTER DATABASE [DeliveryDatabase] SET ANSI_PADDING ON
GO

ALTER DATABASE [DeliveryDatabase] SET ANSI_WARNINGS ON
GO

ALTER DATABASE [DeliveryDatabase] SET ARITHABORT ON
GO

ALTER DATABASE [DeliveryDatabase] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [DeliveryDatabase] SET AUTO_CREATE_STATISTICS ON
GO

ALTER DATABASE [DeliveryDatabase] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [DeliveryDatabase] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [DeliveryDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [DeliveryDatabase] SET CURSOR_DEFAULT  LOCAL
GO

ALTER DATABASE [DeliveryDatabase] SET CONCAT_NULL_YIELDS_NULL ON
GO

ALTER DATABASE [DeliveryDatabase] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [DeliveryDatabase] SET QUOTED_IDENTIFIER ON
GO

ALTER DATABASE [DeliveryDatabase] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [DeliveryDatabase] SET  DISABLE_BROKER
GO

ALTER DATABASE [DeliveryDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [DeliveryDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [DeliveryDatabase] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [DeliveryDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [DeliveryDatabase] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [DeliveryDatabase] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [DeliveryDatabase] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [DeliveryDatabase] SET  READ_WRITE
GO

ALTER DATABASE [DeliveryDatabase] SET RECOVERY SIMPLE
GO

ALTER DATABASE [DeliveryDatabase] SET  MULTI_USER
GO

ALTER DATABASE [DeliveryDatabase] SET PAGE_VERIFY NONE
GO

ALTER DATABASE [DeliveryDatabase] SET DB_CHAINING OFF
GO

USE [DeliveryDatabase]
GO

/****** Object:  Table [dbo].[OrderItem]    Script Date: 08/05/2018 23:28:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Item]    Script Date: 08/05/2018 23:28:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING ON
GO

/****** Object:  Table [dbo].[UserOrder]    Script Date: 08/05/2018 23:28:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[User]    Script Date: 08/05/2018 23:28:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING ON
GO

/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserOrders]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserIdByName]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserIdByEmail]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserByName]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetUserByEmail]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetOrderItemsById]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetItemById]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[GetAllItems]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[AddUserOrders]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[AddOrderItems]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[AddItem]    Script Date: 08/05/2018 23:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
