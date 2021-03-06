USE [milenioBus]
GO
/****** Object:  Table [dbo].[MB_COMBO_CIDADE]    Script Date: 28/03/2019 03:17:52 ******/
DROP TABLE IF EXISTS [dbo].[MB_COMBO_CIDADE]
GO
/****** Object:  Table [dbo].[MB_CLIENTE]    Script Date: 28/03/2019 03:17:52 ******/
DROP TABLE IF EXISTS [dbo].[MB_CLIENTE]
GO
/****** Object:  Table [dbo].[MB_CLIENTE]    Script Date: 28/03/2019 03:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MB_CLIENTE](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[endereco] [varchar](100) NULL,
	[numero] [int] NULL,
	[complemento] [varchar](50) NULL,
	[bairro] [varchar](50) NULL,
	[id_cidade] [int] NULL,
	[cep] [varchar](20) NULL,
 CONSTRAINT [PK_MB_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MB_COMBO_CIDADE]    Script Date: 28/03/2019 03:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MB_COMBO_CIDADE](
	[id_cidade] [int] IDENTITY(1,1) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MB_COMBO_CIDADE] PRIMARY KEY CLUSTERED 
(
	[id_cidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
