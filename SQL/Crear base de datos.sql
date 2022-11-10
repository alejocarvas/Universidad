CREATE DATABASE [Universidad]
GO

USE [Universidad]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 10/11/2022 9:28:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](500) NOT NULL,
	[TipoDocumento] [int] NOT NULL,
	[Documento] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](15) NULL,
	[Correo] [nvarchar](150) NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudianteMateria]    Script Date: 10/11/2022 9:28:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudianteMateria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[MateriaId] [int] NOT NULL,
 CONSTRAINT [PK_EstudianteMateria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 10/11/2022 9:28:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Codigo] [char](5) NOT NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semestre]    Script Date: 10/11/2022 9:28:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semestre](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Semestre] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SemestreMateria]    Script Date: 10/11/2022 9:28:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemestreMateria](
	[Id] [int] NOT NULL,
	[SemestreId] [int] NOT NULL,
	[MateriaId] [int] NOT NULL,
 CONSTRAINT [PK_SemestreMateria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EstudianteMateria]  WITH CHECK ADD  CONSTRAINT [FK_EstudianteMateria_Estudiante] FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiante] ([Id])
GO
ALTER TABLE [dbo].[EstudianteMateria] CHECK CONSTRAINT [FK_EstudianteMateria_Estudiante]
GO
ALTER TABLE [dbo].[EstudianteMateria]  WITH CHECK ADD  CONSTRAINT [FK_EstudianteMateria_Materia] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([Id])
GO
ALTER TABLE [dbo].[EstudianteMateria] CHECK CONSTRAINT [FK_EstudianteMateria_Materia]
GO
ALTER TABLE [dbo].[SemestreMateria]  WITH CHECK ADD  CONSTRAINT [FK_SemestreMateria_Materia] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([Id])
GO
ALTER TABLE [dbo].[SemestreMateria] CHECK CONSTRAINT [FK_SemestreMateria_Materia]
GO
ALTER TABLE [dbo].[SemestreMateria]  WITH CHECK ADD  CONSTRAINT [FK_SemestreMateria_Semestre] FOREIGN KEY([SemestreId])
REFERENCES [dbo].[Semestre] ([Id])
GO
ALTER TABLE [dbo].[SemestreMateria] CHECK CONSTRAINT [FK_SemestreMateria_Semestre]
GO
