/****** Object:  ForeignKey [FK_Operations_Stations]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_Stations]
GO
/****** Object:  ForeignKey [FK_Operations_StationTypeOperations]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_StationTypeOperations]
GO
/****** Object:  ForeignKey [FK_Stations_StationTypes]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] DROP CONSTRAINT [FK_Stations_StationTypes]
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_Stations]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_StationTypeOperations]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Operations]') AND type in (N'U'))
DROP TABLE [dbo].[Operations]
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] DROP CONSTRAINT [FK_Stations_StationTypes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stations]') AND type in (N'U'))
DROP TABLE [dbo].[Stations]
GO
/****** Object:  Table [dbo].[StationTypeOperations]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StationTypeOperations]') AND type in (N'U'))
DROP TABLE [dbo].[StationTypeOperations]
GO
/****** Object:  Table [dbo].[StationTypes]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StationTypes]') AND type in (N'U'))
DROP TABLE [dbo].[StationTypes]
GO
/****** Object:  Table [dbo].[Pallets]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pallets]') AND type in (N'U'))
DROP TABLE [dbo].[Pallets]
GO
/****** Object:  Table [dbo].[Parts]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Parts]') AND type in (N'U'))
DROP TABLE [dbo].[Parts]
GO
/****** Object:  Table [dbo].[ProductionOrders]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductionOrders]') AND type in (N'U'))
DROP TABLE [dbo].[ProductionOrders]
GO
/****** Object:  Table [dbo].[AppLogger]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppLogger]') AND type in (N'U'))
DROP TABLE [dbo].[AppLogger]
GO
/****** Object:  Table [dbo].[Lines]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lines]') AND type in (N'U'))
DROP TABLE [dbo].[Lines]
GO
/****** Object:  Table [dbo].[Molds]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Molds]') AND type in (N'U'))
DROP TABLE [dbo].[Molds]
GO
/****** Object:  Table [dbo].[OperationRegisters]    Script Date: 08/28/2019 16:32:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationRegisters]') AND type in (N'U'))
DROP TABLE [dbo].[OperationRegisters]
GO
/****** Object:  Table [dbo].[OperationRegisters]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationRegisters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OperationRegisters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OperationInId] [int] NOT NULL,
	[OperationOutId] [int] NULL,
	[PalletId] [int] NOT NULL,
	[MoldId] [int] NOT NULL,
	[PartId] [int] NULL,
	[InitDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NULL,
 CONSTRAINT [PK_OperationRegisters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Molds]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Molds]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Molds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Reference] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Molds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lines]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lines]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Lines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AppLogger]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppLogger]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AppLogger](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [tinyint] NOT NULL,
	[Namespace] [varchar](50) NOT NULL,
	[Method] [varchar](100) NOT NULL,
	[Message] [varchar](300) NOT NULL,
 CONSTRAINT [PK_AppLogger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionOrders]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductionOrders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProductionOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PalletId] [int] NOT NULL,
	[MoldId] [int] NOT NULL,
	[PartId] [int] NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductionOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Parts]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Parts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Parts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Reference] [varchar](50) NOT NULL,
	[ProductionOrderId] [int] NOT NULL,
	[FabricationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Parts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pallets]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pallets]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pallets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[LineId] [int] NOT NULL,
 CONSTRAINT [PK_Pallets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Pallets_Code_LineId] UNIQUE NONCLUSTERED 
(
	[Code] ASC,
	[LineId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StationTypes]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StationTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StationTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StationTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StationTypeOperations]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StationTypeOperations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StationTypeOperations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[StationTypeId] [int] NOT NULL,
 CONSTRAINT [PK_StationTypeOperations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Stations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[LineId] [int] NULL,
	[Name] [varchar](50) NOT NULL,
	[StationTypeId] [int] NOT NULL,
	[StatusDataChangeAddress] [varchar](50) NULL,
	[StatusDataChangeAddressAck] [varchar](50) NULL,
	[DataAddress] [varchar](50) NULL,
 CONSTRAINT [PK_Stations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 08/28/2019 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Operations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Operations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[OperationTypeId] [tinyint] NOT NULL,
	[InitPart] [bit] NOT NULL,
	[LoadMold] [bit] NOT NULL,
	[StationId] [int] NOT NULL,
	[StationTypeOperationId] [int] NOT NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_Operations_Stations]    Script Date: 08/28/2019 16:32:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_Stations] FOREIGN KEY([StationId])
REFERENCES [dbo].[Stations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_Stations]
GO
/****** Object:  ForeignKey [FK_Operations_StationTypeOperations]    Script Date: 08/28/2019 16:32:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_StationTypeOperations] FOREIGN KEY([StationTypeOperationId])
REFERENCES [dbo].[StationTypeOperations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_StationTypeOperations]
GO
/****** Object:  ForeignKey [FK_Stations_StationTypes]    Script Date: 08/28/2019 16:32:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations]  WITH CHECK ADD  CONSTRAINT [FK_Stations_StationTypes] FOREIGN KEY([StationTypeId])
REFERENCES [dbo].[StationTypes] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] CHECK CONSTRAINT [FK_Stations_StationTypes]
GO
