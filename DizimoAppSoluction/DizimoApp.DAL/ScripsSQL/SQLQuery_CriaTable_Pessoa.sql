-- Criação de tabela Pessoa
USE [DizimoDB]
GO

/****** Object:  Table [dbo].[Pessoa]    Script Date: 06/07/2022 19:28:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pessoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[Telefone] [varchar](10) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_dbPessoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


