USE [DizimoDB]
GO

/****** Object:  Table [dbo].[FluxoCaixa]    Script Date: 09/07/2022 10:33:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FluxoCaixa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NOT NULL,
	[IdFluxoTipo] [int] NOT NULL,
	[Valor] [decimal](18, 0) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_FluxoCaixa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [FluxoCaixa] (IdPessoa,IdFluxoTipo,Valor,DataCadastro) VALUES(1,1,250.45,GETDATE())
