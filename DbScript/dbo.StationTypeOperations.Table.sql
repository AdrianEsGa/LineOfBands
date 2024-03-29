USE [LineOfBands]
GO
/****** Object:  Table [dbo].[StationTypeOperations]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StationTypeOperations]') AND type in (N'U'))
DROP TABLE [dbo].[StationTypeOperations]
GO
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
SET IDENTITY_INSERT [dbo].[StationTypeOperations] ON
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (2, N'Salida de bandeja de desmoldeo', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (3, N'Entrada de bandeja en desmoldeo', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (4, N'Cargar la bandeja', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (5, N'Descargar la bandeja de la línea', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (6, N'Cargar el molde', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (7, N'Ajustamos el molde', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (8, N'Desmoldeamos la pieza', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (9, N'Aplicamos el desmoldeante', 1)
INSERT [dbo].[StationTypeOperations] ([Id], [Name], [StationTypeId]) VALUES (10, N'Montamos la red', 1)
SET IDENTITY_INSERT [dbo].[StationTypeOperations] OFF
