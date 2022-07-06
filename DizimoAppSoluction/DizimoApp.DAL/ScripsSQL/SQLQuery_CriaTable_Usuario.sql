-- Criação de tabela usuário

USE [DizimoDB]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 06/07/2022 23:20:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [bigint] NOT NULL,
	[Usuario] [varchar](10) NULL,
	[Senha] [varchar](16) NULL,
	[DataCadastro] [datetime2](7) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO