USE [dbBiblioteca]
GO
/****** Object:  Table [dbo].[generos]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[generos](
	[idGenero] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
 CONSTRAINT [PK_generos] PRIMARY KEY CLUSTERED 
(
	[idGenero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[barrios]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[barrios](
	[idBarrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_barrios] PRIMARY KEY CLUSTERED 
(
	[idBarrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[autores]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[autores](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nacionalidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_autores] PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[cargo] [varchar](20) NOT NULL,
	[login] [varchar](10) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[mail] [varchar](100) NULL,
	[estado] [varchar](1) NULL,
	[telefono] [varchar](10) NULL,
	[documento] [varchar](8) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (1, N'Administrador', N'admin', N'123456', N'Franca', N'Britos', N'britosfranca@hotmail.com', N'1', N'4647880', N'39937679')
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (2, N'Gerente', N'Mauriii', N'123', N'Mauricio', N'Ferreyra', N'mauFerr@gmail.com', N'1', N'3512020604', N'39937677')
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (3, N'Recepcionista', N'Mari', N'1234566', N'Maria', N'Britos', N'mariBri@hotmail.com', N'1', N'', N'39937672')
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (4, N'Administrador', N'Marce', N'1515', N'Marcela', N'Vera', N'marcevera@hotmail.com', N'1', N'4655223', N'39937644')
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (5, N'Gerente', N'FerGerent', N'45589', N'Fernando', N'Valle', N'fervalle@hotmail.com', N'1', N'4647880', N'65599874')
INSERT [dbo].[usuarios] ([idUsuario], [cargo], [login], [password], [nombre], [apellido], [mail], [estado], [telefono], [documento]) VALUES (6, N'Gerente', N'Matii', N'566', N'Matias', N'Britos', N'matiasBritos@gmail.com', N'0', N'4566558', N'36655987')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
/****** Object:  Table [dbo].[socios]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[socios](
	[idSocio] [int] IDENTITY(1,1) NOT NULL,
	[idAsociacion] [int] NULL,
	[idPrestamo] [int] NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[documento] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[mail] [varchar](100) NOT NULL,
	[habilitado] [varchar](1) NULL,
	[idDomicilio] [int] NULL,
	[foto] [image] NULL,
 CONSTRAINT [PK_socios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[socios] ON
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (1, NULL, NULL, N'Franca', N'Britos', N'39937679', N'4647880', N'Tupac Amaru 3116', N'britosfranca@hotmail.com', N'1', NULL, NULL)
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (2, NULL, NULL, N'Imanol', N'Britos', N'25563658', N'3512020604', N'Tupac Amaru 3116', N'nachobri@hotmail.com', N'1', NULL, NULL)
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (3, NULL, NULL, N'Carolina', N'Rinaldi', N'40203365', N'3516566985', N'Melincue 5889', N'caritorinaldi@gmail.com', N'1', NULL, NULL)
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (14, NULL, NULL, N'Carlos', N'Valle', N'39937679', N'4678556', N'Inca Manco 500', N'carlosValle96@gmail.com', N'0', NULL, NULL)
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (27, NULL, NULL, N'Magdalena', N'Barreiro', N'69985414', N'4647880', N'IncaManco 5698', N'maguiBarreiro@gmail.com', N'1', NULL, NULL)
INSERT [dbo].[socios] ([idSocio], [idAsociacion], [idPrestamo], [nombre], [apellido], [documento], [telefono], [direccion], [mail], [habilitado], [idDomicilio], [foto]) VALUES (28, NULL, NULL, N'Franca', N'Britos', N'36698547', N'', N'', N'', N'1', NULL, NULL)
SET IDENTITY_INSERT [dbo].[socios] OFF
/****** Object:  Table [dbo].[prestamos]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[idPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[fechaSolicitud] [date] NOT NULL,
	[fechaEntrega] [date] NOT NULL,
	[fechaCancelacion] [date] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_prestamos] PRIMARY KEY CLUSTERED 
(
	[idPrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[asociaciones]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asociaciones](
	[idAsociacion] [int] IDENTITY(1,1) NOT NULL,
	[fechaAlta] [date] NOT NULL,
	[fechaBaja] [date] NULL,
	[motivoBaja] [varchar](150) NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_asociaciones] PRIMARY KEY CLUSTERED 
(
	[idAsociacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[asociaciones] ON
INSERT [dbo].[asociaciones] ([idAsociacion], [fechaAlta], [fechaBaja], [motivoBaja], [idUsuario]) VALUES (1, CAST(0x363D0B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[asociaciones] ([idAsociacion], [fechaAlta], [fechaBaja], [motivoBaja], [idUsuario]) VALUES (2, CAST(0xB13C0B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[asociaciones] ([idAsociacion], [fechaAlta], [fechaBaja], [motivoBaja], [idUsuario]) VALUES (3, CAST(0x7E3B0B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[asociaciones] ([idAsociacion], [fechaAlta], [fechaBaja], [motivoBaja], [idUsuario]) VALUES (4, CAST(0xA83A0B00 AS Date), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[asociaciones] OFF
/****** Object:  Table [dbo].[domicilios]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[domicilios](
	[idDomicilio] [int] IDENTITY(1,1) NOT NULL,
	[calle] [varchar](20) NOT NULL,
	[numero] [int] NOT NULL,
	[piso] [int] NULL,
	[codPostal] [int] NOT NULL,
	[idBarrio] [int] NOT NULL,
 CONSTRAINT [PK_domicilios] PRIMARY KEY CLUSTERED 
(
	[idDomicilio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[editoriales]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[editoriales](
	[idEditorial] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idDomicilio] [int] NOT NULL,
 CONSTRAINT [PK_editoriales] PRIMARY KEY CLUSTERED 
(
	[idEditorial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[libros]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[libros](
	[idLibro] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[añoEdicion] [varchar](4) NOT NULL,
	[nroEdicion] [int] NOT NULL,
	[paisOrigen] [varchar](50) NOT NULL,
	[cantidadHojas] [int] NOT NULL,
	[isbn] [varchar](13) NOT NULL,
	[idGenero] [int] NULL,
	[idAutor] [int] NULL,
	[idEditorial] [int] NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[idLibro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ejemplares]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ejemplares](
	[idEjemplar] [int] IDENTITY(1,1) NOT NULL,
	[idLibro] [int] NOT NULL,
	[fechaCompra] [date] NOT NULL,
	[fechaBaja] [date] NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ejemplares] PRIMARY KEY CLUSTERED 
(
	[idEjemplar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detallePrestamos]    Script Date: 09/19/2017 19:06:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detallePrestamos](
	[idDetallePrestamo] [int] IDENTITY(1,1) NOT NULL,
	[idEjemplar] [int] NOT NULL,
	[fechaDevolucionReal] [date] NULL,
	[estado] [varchar](50) NOT NULL,
	[fechaCancelacion] [date] NULL,
	[cantidadEjemplares] [int] NOT NULL,
	[idPrestamo] [int] NULL,
 CONSTRAINT [PK_detallePrestamos] PRIMARY KEY CLUSTERED 
(
	[idDetallePrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_prestamos_usuarios]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_usuarios]
GO
/****** Object:  ForeignKey [FK_asociaciones_usuarios]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[asociaciones]  WITH CHECK ADD  CONSTRAINT [FK_asociaciones_usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[asociaciones] CHECK CONSTRAINT [FK_asociaciones_usuarios]
GO
/****** Object:  ForeignKey [FK_domicilios_barrios]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[domicilios]  WITH CHECK ADD  CONSTRAINT [FK_domicilios_barrios] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[barrios] ([idBarrio])
GO
ALTER TABLE [dbo].[domicilios] CHECK CONSTRAINT [FK_domicilios_barrios]
GO
/****** Object:  ForeignKey [FK_editoriales_domicilios]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[editoriales]  WITH CHECK ADD  CONSTRAINT [FK_editoriales_domicilios] FOREIGN KEY([idDomicilio])
REFERENCES [dbo].[domicilios] ([idDomicilio])
GO
ALTER TABLE [dbo].[editoriales] CHECK CONSTRAINT [FK_editoriales_domicilios]
GO
/****** Object:  ForeignKey [FK_libros_autores]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_autores] FOREIGN KEY([idAutor])
REFERENCES [dbo].[autores] ([idAutor])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_autores]
GO
/****** Object:  ForeignKey [FK_libros_editoriales]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_editoriales] FOREIGN KEY([idEditorial])
REFERENCES [dbo].[editoriales] ([idEditorial])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_editoriales]
GO
/****** Object:  ForeignKey [FK_libros_generos]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_generos] FOREIGN KEY([idGenero])
REFERENCES [dbo].[generos] ([idGenero])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_generos]
GO
/****** Object:  ForeignKey [FK_ejemplares_libros]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[ejemplares]  WITH CHECK ADD  CONSTRAINT [FK_ejemplares_libros] FOREIGN KEY([idLibro])
REFERENCES [dbo].[libros] ([idLibro])
GO
ALTER TABLE [dbo].[ejemplares] CHECK CONSTRAINT [FK_ejemplares_libros]
GO
/****** Object:  ForeignKey [FK_detallePrestamos_ejemplares]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[detallePrestamos]  WITH CHECK ADD  CONSTRAINT [FK_detallePrestamos_ejemplares] FOREIGN KEY([idEjemplar])
REFERENCES [dbo].[ejemplares] ([idEjemplar])
GO
ALTER TABLE [dbo].[detallePrestamos] CHECK CONSTRAINT [FK_detallePrestamos_ejemplares]
GO
/****** Object:  ForeignKey [FK_detallePrestamos_prestamos]    Script Date: 09/19/2017 19:06:43 ******/
ALTER TABLE [dbo].[detallePrestamos]  WITH CHECK ADD  CONSTRAINT [FK_detallePrestamos_prestamos] FOREIGN KEY([idPrestamo])
REFERENCES [dbo].[prestamos] ([idPrestamo])
GO
ALTER TABLE [dbo].[detallePrestamos] CHECK CONSTRAINT [FK_detallePrestamos_prestamos]
GO
