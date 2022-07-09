USE [DizimoDB]
GO

/****** Object:  Table [dbo].[PessoaCategoria]    Script Date: 09/07/2022 09:28:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PessoaCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](250) NOT NULL,
 CONSTRAINT [PK_PessoaCategoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [PessoaCategoria] (Descricao) VALUES('Pessoa Física')
INSERT INTO [PessoaCategoria] (Descricao) VALUES('Pessoa Jurídica')


