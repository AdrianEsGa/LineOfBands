USE [LineOfBands]
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] DROP CONSTRAINT [FK_Stations_StationTypes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] DROP CONSTRAINT [FK_Stations_StationTypes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stations]') AND type in (N'U'))
DROP TABLE [dbo].[Stations]
GO
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations]  WITH CHECK ADD  CONSTRAINT [FK_Stations_StationTypes] FOREIGN KEY([StationTypeId])
REFERENCES [dbo].[StationTypes] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stations_StationTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stations]'))
ALTER TABLE [dbo].[Stations] CHECK CONSTRAINT [FK_Stations_StationTypes]
GO
SET IDENTITY_INSERT [dbo].[Stations] ON
INSERT [dbo].[Stations] ([Id], [Code], [Name], [StationTypeId], [StatusDataChangeAddress], [StatusDataChangeAddressAck], [DataAddress]) VALUES (2, 4, N'Desmoldeo1', 1, N'132|200|672|1|1', N'132|200|5322|256|4', N'132|200|1018|256|4')
SET IDENTITY_INSERT [dbo].[Stations] OFF
