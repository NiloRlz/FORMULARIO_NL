USE [login]
GO
/****** Object:  Table [dbo].[inicio_sesion]    Script Date: 8/09/2023 17:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inicio_sesion](
	[pass_log] [int] NULL,
	[user_log] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
