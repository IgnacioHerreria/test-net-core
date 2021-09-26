GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 24/9/2021 23:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreCiudad] [nvarchar](60) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_dbo.Ciudad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = ON, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurante]    Script Date: 24/9/2021 23:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurante](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreRestaurante] [nvarchar](60) NOT NULL,
	[Telefono] [nvarchar](15) NULL,
	[NumeroAforo] [smallint] NOT NULL,
	[CiudadId] [bigint] NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_dbo.Restaurante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = ON, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ciudad] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Restaurante] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Restaurante]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Restaurante_dbo.Ciudad_CiudadId] FOREIGN KEY([CiudadId])
REFERENCES [dbo].[Ciudad] ([Id])
GO
ALTER TABLE [dbo].[Restaurante] CHECK CONSTRAINT [FK_dbo.Restaurante_dbo.Ciudad_CiudadId]
GO
