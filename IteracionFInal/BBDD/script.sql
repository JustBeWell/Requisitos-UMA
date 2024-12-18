USE [master]
GO
/****** Object:  Database [MiniPIM]    Script Date: 14/12/2024 12:09:47 ******/
CREATE DATABASE [MiniPIM]

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
/****** Object:  Table [dbo].[Atributo]    Script Date: 14/12/2024 12:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Atributo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
	[tipo] [int] NOT NULL,
	[nombre_cuenta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 14/12/2024 12:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cuenta] [varchar](50) NULL,
	[nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__Categori__3213E83F2D2C9962] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 14/12/2024 12:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuenta](
	[nombre] [varchar](50) NOT NULL,
	[fechaCreacion] [date] NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/12/2024 12:09:48 ******/
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
	[nombre_cuenta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductoCategoria]    Script Date: 14/12/2024 12:09:48 ******/
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
/****** Object:  Table [dbo].[Relacion]    Script Date: 14/12/2024 12:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relacion](
	[nombre] [nchar](10) NULL,
	[producto_SKU1] [nvarchar](50) NOT NULL,
	[producto_SKU2] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Relacion] PRIMARY KEY CLUSTERED 
(
	[producto_SKU1] ASC,
	[producto_SKU2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAtributo]    Script Date: 14/12/2024 12:09:48 ******/
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
/****** Object:  Table [dbo].[ValorAtributo]    Script Date: 14/12/2024 12:09:48 ******/
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

INSERT [dbo].[Atributo] ([id], [nombre], [tipo], [nombre_cuenta]) VALUES (7, N'Descripción Larga', 6, NULL)
INSERT [dbo].[Atributo] ([id], [nombre], [tipo], [nombre_cuenta]) VALUES (8, N'Stock Disponible', 4, NULL)
SET IDENTITY_INSERT [dbo].[Atributo] OFF
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id], [nombre_cuenta], [nombre]) VALUES (1, NULL, N'Mesas')
INSERT [dbo].[Categoria] ([id], [nombre_cuenta], [nombre]) VALUES (2, NULL, N'Barcas')
INSERT [dbo].[Categoria] ([id], [nombre_cuenta], [nombre]) VALUES (3, NULL, N'Categoria Aux')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'image1_200x200.jpg', N'PROD001', N'Robusto', N'12345678901234', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (NULL, N'PROD002', N'Label for product 2', N'12345678901235', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (NULL, N'PROD003', N'Robusto', N'12345678901236', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'image2_200x200.png', N'PROD004', N'Robusto', N'12345678901237', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'image3_200x200.jpg', N'PROD005', N'Robusto', N'12345678901238', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'image4_200x200.png', N'PROD006', N'Special Label for product 6', N'98765432109876', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'', N'PROD007', N'OK', N'139184193     ', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'', N'PROD008', N'SI', N'1938419383    ', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'', N'SKU', N'Label', N'GTIN          ', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'thumbnail1.png', N'SKU001', N'Label 1', N'12345678901234', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'thumbnail2.png', N'SKU002', N'Label 2', N'12345678901235', NULL)
INSERT [dbo].[Producto] ([Thumbnail], [SKU], [Label], [GTIN], [nombre_cuenta]) VALUES (N'thumbnail3.png', N'SKU003', N'Label 3', N'12345678901236', NULL)
INSERT [dbo].[ProductoCategoria] ([producto_SKU], [categoria_id]) VALUES (N'PROD001', 1)
INSERT [dbo].[ProductoCategoria] ([producto_SKU], [categoria_id]) VALUES (N'PROD007', 2)
INSERT [dbo].[ProductoCategoria] ([producto_SKU], [categoria_id]) VALUES (N'PROD008', 2)
INSERT [dbo].[Relacion] ([nombre], [producto_SKU1], [producto_SKU2]) VALUES (N'Es inutil ', N'PROD001', N'PROD004')
INSERT [dbo].[Relacion] ([nombre], [producto_SKU1], [producto_SKU2]) VALUES (N'Increible ', N'SKU', N'PROD001')
SET IDENTITY_INSERT [dbo].[TipoAtributo] ON 

INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (4, N'Entero')
INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (5, N'Real')
INSERT [dbo].[TipoAtributo] ([id], [nombre]) VALUES (6, N'Cadena')
SET IDENTITY_INSERT [dbo].[TipoAtributo] OFF
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Este es un producto con una descripción extendida.', 7, N'PROD001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'ESTO ES UN MOJON', 7, N'PROD007')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'ESTO ESTA TOPRE GUAPO', 7, N'PROD008')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción Larga', 7, N'SKU')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 1', 7, N'SKU001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 2', 7, N'SKU002')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'Descripción detallada del producto 3', 7, N'SKU003')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'150', 8, N'PROD001')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'', 8, N'PROD007')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'', 8, N'PROD008')
INSERT [dbo].[ValorAtributo] ([valor], [atributo_id], [producto_SKU]) VALUES (N'', 8, N'SKU')
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
ALTER TABLE [dbo].[Atributo]  WITH CHECK ADD  CONSTRAINT [FK_Atributo_Cuenta] FOREIGN KEY([nombre_cuenta])
REFERENCES [dbo].[Cuenta] ([nombre])
GO
ALTER TABLE [dbo].[Atributo] CHECK CONSTRAINT [FK_Atributo_Cuenta]
GO
ALTER TABLE [dbo].[Categoria]  WITH CHECK ADD  CONSTRAINT [FK_Categoria_Cuenta] FOREIGN KEY([nombre_cuenta])
REFERENCES [dbo].[Cuenta] ([nombre])
GO
ALTER TABLE [dbo].[Categoria] CHECK CONSTRAINT [FK_Categoria_Cuenta]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Cuenta] FOREIGN KEY([nombre_cuenta])
REFERENCES [dbo].[Cuenta] ([nombre])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Cuenta]
GO
ALTER TABLE [dbo].[ProductoCategoria]  WITH CHECK ADD  CONSTRAINT [FK__ProductoC__categ__1B0907CE] FOREIGN KEY([categoria_id])
REFERENCES [dbo].[Categoria] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductoCategoria] CHECK CONSTRAINT [FK__ProductoC__categ__1B0907CE]
GO
ALTER TABLE [dbo].[ProductoCategoria]  WITH CHECK ADD  CONSTRAINT [FK__ProductoC__produ__1BFD2C07] FOREIGN KEY([producto_SKU])
REFERENCES [dbo].[Producto] ([SKU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductoCategoria] CHECK CONSTRAINT [FK__ProductoC__produ__1BFD2C07]
GO
ALTER TABLE [dbo].[Relacion]  WITH CHECK ADD  CONSTRAINT [FK_Relacion_Producto1] FOREIGN KEY([producto_SKU1])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[Relacion] CHECK CONSTRAINT [FK_Relacion_Producto1]
GO
ALTER TABLE [dbo].[Relacion]  WITH CHECK ADD  CONSTRAINT [FK_Relacion_Producto2] FOREIGN KEY([producto_SKU2])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[Relacion] CHECK CONSTRAINT [FK_Relacion_Producto2]
GO
ALTER TABLE [dbo].[ValorAtributo]  WITH CHECK ADD  CONSTRAINT [FK__ValorAtri__atrib__1CF15040] FOREIGN KEY([atributo_id])
REFERENCES [dbo].[Atributo] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ValorAtributo] CHECK CONSTRAINT [FK__ValorAtri__atrib__1CF15040]
GO
ALTER TABLE [dbo].[ValorAtributo]  WITH CHECK ADD  CONSTRAINT [FK__ValorAtri__produ__1DE57479] FOREIGN KEY([producto_SKU])
REFERENCES [dbo].[Producto] ([SKU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ValorAtributo] CHECK CONSTRAINT [FK__ValorAtri__produ__1DE57479]
GO
USE [master]
GO
ALTER DATABASE [MiniPIM] SET  READ_WRITE 
GO
