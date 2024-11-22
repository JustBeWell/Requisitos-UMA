USE [master]
GO
/****** Object:  Database [MiniPIM]    Script Date: 22/11/2024 11:28:16 ******/
CREATE DATABASE [MiniPIM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniPIM', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MiniPIM.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MiniPIM_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MiniPIM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MiniPIM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniPIM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniPIM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniPIM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniPIM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniPIM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniPIM] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniPIM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniPIM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniPIM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniPIM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniPIM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniPIM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniPIM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniPIM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniPIM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniPIM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiniPIM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniPIM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniPIM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniPIM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniPIM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniPIM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniPIM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniPIM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MiniPIM] SET  MULTI_USER 
GO
ALTER DATABASE [MiniPIM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniPIM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniPIM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniPIM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MiniPIM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MiniPIM]
GO
/****** Object:  Table [dbo].[Atributo]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atributo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
	[tipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[Thumbnail] [nvarchar](255) NULL,
	[SKU] [nvarchar](50) NOT NULL,
	[Label] [nvarchar](250) NOT NULL,
	[GTIN] [char](14) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductoCategoria]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCategoria](
	[producto_SKU] [nvarchar](50) NOT NULL,
	[categoria_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[producto_SKU] ASC,
	[categoria_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAtributo]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAtributo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ValorAtributo]    Script Date: 22/11/2024 11:28:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValorAtributo](
	[valor] [nvarchar](255) NOT NULL,
	[atributo_id] [int] NOT NULL,
	[producto_SKU] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ValorAtributo] PRIMARY KEY CLUSTERED 
(
	[atributo_id] ASC,
	[producto_SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Atributo] ON 

INSERT [dbo].[Atributo] ([id], [nombre], [tipo]) VALUES (7, N'Descripción Larga', 6)
INSERT [dbo].[Atributo] ([id], [nombre], [tipo]) VALUES (8, N'Stock Disponible', 4)
SET IDENTITY_INSERT [dbo].[Atributo] OFF
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'image1_200x200.jpg', N'PROD001', N'Robusto', N'12345678901234')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (NULL, N'PROD002', N'Label for product 2', N'12345678901235')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (NULL, N'PROD003', N'Robusto', N'12345678901236')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'image2_200x200.png', N'PROD004', N'Robusto', N'12345678901237')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'image3_200x200.jpg', N'PROD005', N'Robusto', N'12345678901238')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'image4_200x200.png', N'PROD006', N'Special Label for product 6', N'98765432109876')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'thumbnail1.png', N'SKU001', N'Label 1', N'12345678901234')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'thumbnail2.png', N'SKU002', N'Label 2', N'12345678901235')
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN]) VALUES (N'thumbnail3.png', N'SKU003', N'Label 3', N'12345678901236')
SET IDENTITY_INSERT [dbo].[TipoAtributo] ON 

INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (4, N'Entero')
INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (5, N'Real')
INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (6, N'Cadena')
SET IDENTITY_INSERT [dbo].[TipoAtributo] OFF
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Este es un producto con una descripción extendida.', 7, N'PROD001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 1', 7, N'SKU001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 2', 7, N'SKU002')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 3', 7, N'SKU003')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'150', 8, N'PROD001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'10', 8, N'SKU001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'20', 8, N'SKU002')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'15', 8, N'SKU003')
ALTER TABLE [dbo].[Atributo]  WITH CHECK ADD  CONSTRAINT [FK__Atributo__tipo__300424B4] FOREIGN KEY([tipo])
REFERENCES [dbo].[TipoAtributo] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Atributo] CHECK CONSTRAINT [FK__Atributo__tipo__300424B4]
GO
ALTER TABLE [dbo].[ProductoCategoria]  WITH CHECK ADD FOREIGN KEY([categoria_id])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[ProductoCategoria]  WITH CHECK ADD FOREIGN KEY([producto_SKU])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[ValorAtributo]  WITH CHECK ADD FOREIGN KEY([atributo_id])
REFERENCES [dbo].[Atributo] ([id])
GO
ALTER TABLE [dbo].[ValorAtributo]  WITH CHECK ADD FOREIGN KEY([producto_SKU])
REFERENCES [dbo].[Producto] ([SKU])
GO
USE [master]
GO
ALTER DATABASE [MiniPIM] SET  READ_WRITE 
GO
