CREATE TABLE [dbo].[Colaboradores](
	[ID] [smallint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Predeterminado] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Colaboradores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Colaboradores] ADD  CONSTRAINT [DF_Colaboradores_Nombre]  DEFAULT ('') FOR [Nombre]
GO

ALTER TABLE [dbo].[Colaboradores] ADD  CONSTRAINT [DF_Colaboradores_Predeterminado]  DEFAULT (0) FOR [Predeterminado]
GO

ALTER TABLE [dbo].[Colaboradores] ADD  CONSTRAINT [DF_Colaboradores_Activo]  DEFAULT (0) FOR [Activo]
GO


