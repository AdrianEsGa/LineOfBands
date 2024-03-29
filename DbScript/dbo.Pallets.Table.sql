USE [LineOfBands]
GO
/****** Object:  Table [dbo].[Pallets]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pallets]') AND type in (N'U'))
DROP TABLE [dbo].[Pallets]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pallets]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pallets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Pallets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Pallets] ON
INSERT [dbo].[Pallets] ([Id], [Code]) VALUES (5, 1)
SET IDENTITY_INSERT [dbo].[Pallets] OFF
