USE [master]
GO
/****** Object:  Database [veterinaria]    Script Date: 9/11/2023 3:53:10 PM ******/
CREATE DATABASE [veterinaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'veterinaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\veterinaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'veterinaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\veterinaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [veterinaria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [veterinaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [veterinaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [veterinaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [veterinaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [veterinaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [veterinaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [veterinaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [veterinaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [veterinaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [veterinaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [veterinaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [veterinaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [veterinaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [veterinaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [veterinaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [veterinaria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [veterinaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [veterinaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [veterinaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [veterinaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [veterinaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [veterinaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [veterinaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [veterinaria] SET RECOVERY FULL 
GO
ALTER DATABASE [veterinaria] SET  MULTI_USER 
GO
ALTER DATABASE [veterinaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [veterinaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [veterinaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [veterinaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [veterinaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [veterinaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'veterinaria', N'ON'
GO
ALTER DATABASE [veterinaria] SET QUERY_STORE = ON
GO
ALTER DATABASE [veterinaria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [veterinaria]
GO
/****** Object:  Table [dbo].[atenciones]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[atenciones](
	[nroHC] [int] NOT NULL,
	[nroMatricula] [varchar](45) NOT NULL,
	[fechaYHora] [datetime] NOT NULL,
	[resultado] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[nroHC] ASC,
	[nroMatricula] ASC,
	[fechaYHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nroDoc] [varchar](45) NULL,
	[tipoDoc] [varchar](45) NULL,
	[nombre] [varchar](45) NOT NULL,
	[apellido] [varchar](45) NOT NULL,
	[calle] [varchar](45) NOT NULL,
	[altura] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nroDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuotas]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuotas](
	[fechaVencimiento] [date] NOT NULL,
	[valor] [float] NOT NULL,
	[fechaPago] [date] NULL,
	[cantidad] [int] NOT NULL,
	[nroHC] [int] NOT NULL,
	[nroMatricula] [varchar](45) NOT NULL,
	[fechaYHora] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[fechaVencimiento] ASC,
	[nroHC] ASC,
	[nroMatricula] ASC,
	[fechaYHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_practica]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_practica](
	[codPractica] [int] NOT NULL,
	[nroHC] [int] NOT NULL,
	[nroMatricula] [varchar](45) NOT NULL,
	[fechaYHora] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codPractica] ASC,
	[nroHC] ASC,
	[nroMatricula] ASC,
	[fechaYHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[especies]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[especies](
	[codEspecie] [int] IDENTITY(1,1) NOT NULL,
	[nombreEspecie] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codEspecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascotas]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascotas](
	[nroHC] [int] IDENTITY(1,1) NOT NULL,
	[fechaNac] [date] NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[sexo] [char](1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[codRaza] [int] NOT NULL,
	[codEspecie] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nroHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[practicas]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[practicas](
	[codPractica] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[codPractica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preciosPracticas]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preciosPracticas](
	[codPractica] [int] NOT NULL,
	[fechaDesde] [date] NOT NULL,
	[precio] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[codPractica] ASC,
	[fechaDesde] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[razas]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[razas](
	[codRaza] [int] IDENTITY(1,1) NOT NULL,
	[codEspecie] [int] NOT NULL,
	[nombreRaza] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codRaza] ASC,
	[codEspecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[n_usuario] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
	[tipo_usuario] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veterinarios]    Script Date: 9/11/2023 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veterinarios](
	[nroMatricula] [varchar](45) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[apellido] [varchar](45) NOT NULL,
	[calle] [varchar](45) NOT NULL,
	[altura] [varchar](10) NOT NULL,
	[telefono] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[nroMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[atenciones]  WITH CHECK ADD FOREIGN KEY([nroHC])
REFERENCES [dbo].[mascotas] ([nroHC])
GO
ALTER TABLE [dbo].[atenciones]  WITH CHECK ADD FOREIGN KEY([nroMatricula])
REFERENCES [dbo].[veterinarios] ([nroMatricula])
GO
ALTER TABLE [dbo].[cuotas]  WITH CHECK ADD FOREIGN KEY([nroHC], [nroMatricula], [fechaYHora])
REFERENCES [dbo].[atenciones] ([nroHC], [nroMatricula], [fechaYHora])
GO
ALTER TABLE [dbo].[detalle_practica]  WITH CHECK ADD FOREIGN KEY([codPractica])
REFERENCES [dbo].[practicas] ([codPractica])
GO
ALTER TABLE [dbo].[detalle_practica]  WITH CHECK ADD FOREIGN KEY([nroHC], [nroMatricula], [fechaYHora])
REFERENCES [dbo].[atenciones] ([nroHC], [nroMatricula], [fechaYHora])
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD FOREIGN KEY([codRaza], [codEspecie])
REFERENCES [dbo].[razas] ([codRaza], [codEspecie])
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[clientes] ([idCliente])
GO
ALTER TABLE [dbo].[preciosPracticas]  WITH CHECK ADD FOREIGN KEY([codPractica])
REFERENCES [dbo].[practicas] ([codPractica])
GO
ALTER TABLE [dbo].[razas]  WITH CHECK ADD FOREIGN KEY([codEspecie])
REFERENCES [dbo].[especies] ([codEspecie])
GO
USE [master]
GO
ALTER DATABASE [veterinaria] SET  READ_WRITE 
GO
