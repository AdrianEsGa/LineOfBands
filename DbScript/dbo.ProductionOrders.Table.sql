USE [LineOfBands]
GO
/****** Object:  Table [dbo].[ProductionOrders]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductionOrders]') AND type in (N'U'))
DROP TABLE [dbo].[ProductionOrders]
GO
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
