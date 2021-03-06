/****** Object:  Table [dbo].[Familia]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Familia](
	[IdFamilia] [varchar](36) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_Familia]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Familia_Familia](
	[IdFamilia] [varchar](36) NOT NULL,
	[IdFamiliaHijo] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_Patente]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Familia_Patente](
	[IdFamilia] [varchar](36) NOT NULL,
	[IdPatente] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__FamiliaE__166FEEA61367E606] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Patente](
	[IdPatente] [varchar](36) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[Vista] [varchar](1000) NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Patente__9F4EF95C34290DD0] PRIMARY KEY CLUSTERED 
(
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [varchar](36) NOT NULL,
	[Usuario] [varchar](30) NOT NULL,
	[Contrasenia] [varchar](30) NOT NULL,
	[Nombre] [varchar](1000) NULL,
	[Email] [varchar](30) NOT NULL,
	[TipoDocumento] [varchar](10) NOT NULL,
	[NroDocumento] [varchar](30) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
CONSTRAINT UQ_UsuarioApodo UNIQUE(Usuario),
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Usuario_Familia](
	[IdUsuario] [varchar](36) NOT NULL,
	[IdFamilia] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 03/09/2021 19:32:47 ******/
CREATE TABLE [dbo].[Usuario_Patente](
	[IdUsuario] [varchar](36) NOT NULL,
	[IdPatente] [varchar](36) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Usuario_Patente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Familia_A__Famil__37A5467C] FOREIGN KEY([IdFamiliaHijo])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Familia] CHECK CONSTRAINT [FK__Familia_A__Famil__37A5467C]
GO
ALTER TABLE [dbo].[Familia_Familia]  WITH CHECK ADD FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Patente_Familia] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_Familia_Patente_Familia]
GO
ALTER TABLE [dbo].[Familia_Patente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaElement_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Familia_Patente] CHECK CONSTRAINT [FK_FamiliaElement_Patente]
GO
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK__Usuario_P__Famil__35BCFE0A]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Patente]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Usuario]
GO

