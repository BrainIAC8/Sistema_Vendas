USE [master]
GO
/****** Object:  Database [Sales_System]    Script Date: 17/03/2019 14:05:40 ******/
CREATE DATABASE [Sales_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sales_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSEVER\MSSQL\DATA\Sales_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sales_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSEVER\MSSQL\DATA\Sales_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Sales_System] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sales_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sales_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sales_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sales_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sales_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sales_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sales_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sales_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sales_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sales_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sales_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sales_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sales_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sales_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sales_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sales_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sales_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sales_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sales_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sales_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sales_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sales_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sales_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sales_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Sales_System] SET  MULTI_USER 
GO
ALTER DATABASE [Sales_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sales_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sales_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sales_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sales_System] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sales_System', N'ON'
GO
ALTER DATABASE [Sales_System] SET QUERY_STORE = OFF
GO
USE [Sales_System]
GO
/****** Object:  Table [dbo].[tb_category]    Script Date: 17/03/2019 14:05:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_category](
	[id_category] [int] IDENTITY(1,1) NOT NULL,
	[description_category] [varchar](100) NOT NULL,
	[sub_category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_category] PRIMARY KEY CLUSTERED 
(
	[id_category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_product]    Script Date: 17/03/2019 14:05:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_product](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[description_product] [varchar](100) NOT NULL,
	[price] [decimal](25, 2) NOT NULL,
	[id_category] [int] NOT NULL,
	[id_provider] [int] NOT NULL,
	[id_sub_category] [int] NULL,
	[REF] [int] NOT NULL,
 CONSTRAINT [PK_tb_product] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_subcategory]    Script Date: 17/03/2019 14:05:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_subcategory](
	[id_subcategory] [int] IDENTITY(1,1) NOT NULL,
	[subcategory_description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_subcategory] PRIMARY KEY CLUSTERED 
(
	[id_subcategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_category] ON 

INSERT [dbo].[tb_category] ([id_category], [description_category], [sub_category]) VALUES (2, N'DVD', N'Eletronicos')
INSERT [dbo].[tb_category] ([id_category], [description_category], [sub_category]) VALUES (3, N'Disco', N'Eletronicos')
INSERT [dbo].[tb_category] ([id_category], [description_category], [sub_category]) VALUES (4, N'Pen-Drive', N'Informática')
SET IDENTITY_INSERT [dbo].[tb_category] OFF
SET IDENTITY_INSERT [dbo].[tb_product] ON 

INSERT [dbo].[tb_product] ([id_product], [description_product], [price], [id_category], [id_provider], [id_sub_category], [REF]) VALUES (7, N'Pack DVD', CAST(29.00 AS Decimal(25, 2)), 3, 4, 3, 555)
INSERT [dbo].[tb_product] ([id_product], [description_product], [price], [id_category], [id_provider], [id_sub_category], [REF]) VALUES (8, N'Disco 1TB', CAST(55.99 AS Decimal(25, 2)), 4, 4, NULL, 344)
INSERT [dbo].[tb_product] ([id_product], [description_product], [price], [id_category], [id_provider], [id_sub_category], [REF]) VALUES (9, N'Disco 2TB', CAST(70.99 AS Decimal(25, 2)), 4, 4, NULL, 343)
SET IDENTITY_INSERT [dbo].[tb_product] OFF
USE [master]
GO
ALTER DATABASE [Sales_System] SET  READ_WRITE 
GO
