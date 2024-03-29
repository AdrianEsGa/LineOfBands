USE [LineOfBands]
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_Stations]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_StationTypeOperations]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_Stations]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_Operations_StationTypeOperations]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Operations]') AND type in (N'U'))
DROP TABLE [dbo].[Operations]
GO
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_Stations] FOREIGN KEY([StationId])
REFERENCES [dbo].[Stations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_Stations]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_StationTypeOperations] FOREIGN KEY([StationTypeOperationId])
REFERENCES [dbo].[StationTypeOperations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Operations_StationTypeOperations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Operations]'))
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_StationTypeOperations]
GO
SET IDENTITY_INSERT [dbo].[Operations] ON
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (1, 401, 1, 0, 0, 2, 2)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (2, 402, 2, 0, 0, 2, 2)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (4, 403, 1, 0, 0, 2, 3)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (6, 404, 2, 0, 0, 2, 3)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (8, 405, 1, 0, 0, 2, 4)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (9, 406, 2, 0, 0, 2, 4)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (10, 407, 1, 0, 0, 2, 5)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (11, 408, 2, 0, 0, 2, 5)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (12, 409, 1, 0, 0, 2, 6)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (13, 410, 2, 0, 0, 2, 6)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (14, 411, 1, 0, 0, 2, 7)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (15, 412, 2, 0, 0, 2, 7)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (16, 413, 1, 0, 0, 2, 8)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (17, 414, 2, 0, 0, 2, 8)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (18, 415, 1, 0, 0, 2, 9)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (19, 416, 2, 0, 0, 2, 9)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (20, 417, 1, 0, 0, 2, 10)
INSERT [dbo].[Operations] ([Id], [Code], [OperationTypeId], [InitPart], [LoadMold], [StationId], [StationTypeOperationId]) VALUES (21, 418, 2, 0, 0, 2, 10)
SET IDENTITY_INSERT [dbo].[Operations] OFF
