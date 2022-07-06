-- Criação de tabela Endereco
 USE [DizimoDB]
GO

/****** Object:  Table [dbo].[Endereço]    Script Date: 06/07/2022 19:37:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Endereco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NOT NULL,
	[Rua] [varchar](300) NULL,
	[Numero] [varchar](50) NULL,
	[Bairro] [varchar](300) NULL,
	[Cep] [varchar](50) NULL,
	[Cidade] [varchar](300) NULL,
	[DataCadastro] [datetime2](7) NULL,
 CONSTRAINT [PK_Endereço] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [Endereco] (IdPessoa,Rua,Numero,Bairro,Cep,Cidade,DataCadastro)
VALUES(1,'Rua da Vitória','777','Esperança','777-777-77','Sete Lagoas',GETDATE())
