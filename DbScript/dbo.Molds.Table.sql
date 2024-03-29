USE [LineOfBands]
GO
/****** Object:  Table [dbo].[Molds]    Script Date: 09/20/2019 00:43:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Molds]') AND type in (N'U'))
DROP TABLE [dbo].[Molds]
GO
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
SET IDENTITY_INSERT [dbo].[Molds] ON
INSERT [dbo].[Molds] ([Id], [Code], [Reference]) VALUES (1, 1, N'1229D-91')
SET IDENTITY_INSERT [dbo].[Molds] OFF
