USE [LineOfBands]
GO
/****** Object:  Table [dbo].[OperationRegisters]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationRegisters]') AND type in (N'U'))
DROP TABLE [dbo].[OperationRegisters]
GO
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
SET IDENTITY_INSERT [dbo].[OperationRegisters] ON
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (1, 20, 21, 5, 1, NULL, CAST(0x0000AACE000869BD AS DateTime), CAST(0x0000AACE0008C500 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (2, 1, 2, 5, 1, NULL, CAST(0x0000AACE00092F6F AS DateTime), CAST(0x0000AACE000935BF AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (3, 4, 6, 5, 1, NULL, CAST(0x0000AACE00093629 AS DateTime), CAST(0x0000AACE00093C85 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (4, 12, 13, 5, 1, NULL, CAST(0x0000AACE00093CF2 AS DateTime), CAST(0x0000AACE000993B4 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (5, 14, 15, 5, 1, NULL, CAST(0x0000AACE0009942B AS DateTime), CAST(0x0000AACE0009ADC1 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (6, 16, 17, 5, 1, NULL, CAST(0x0000AACE0009AE33 AS DateTime), CAST(0x0000AACE0009D7FA AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (7, 18, 19, 5, 1, NULL, CAST(0x0000AACE0009D87E AS DateTime), CAST(0x0000AACE0009EF10 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (8, 20, 21, 5, 1, NULL, CAST(0x0000AACE0009EF93 AS DateTime), CAST(0x0000AACE000A19F2 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (9, 1, 2, 5, 1, NULL, CAST(0x0000AACE000A1A7D AS DateTime), CAST(0x0000AACE000A2105 AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (10, 4, 6, 5, 1, NULL, CAST(0x0000AACE000A2184 AS DateTime), CAST(0x0000AACE000A27FB AS DateTime))
INSERT [dbo].[OperationRegisters] ([Id], [OperationInId], [OperationOutId], [PalletId], [MoldId], [PartId], [InitDateTime], [EndDateTime]) VALUES (11, 12, NULL, 5, 1, NULL, CAST(0x0000AACE000A287F AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[OperationRegisters] OFF
