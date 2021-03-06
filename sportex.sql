USE [master]
GO
/****** Object:  Database [Projekat]    Script Date: 29.7.2020. 12:20:41 ******/
CREATE DATABASE [Projekat]
GO
ALTER DATABASE [Projekat] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Projekat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Projekat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Projekat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Projekat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Projekat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Projekat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Projekat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Projekat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Projekat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Projekat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Projekat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Projekat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Projekat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Projekat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Projekat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Projekat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Projekat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Projekat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Projekat] SET  MULTI_USER 
GO
ALTER DATABASE [Projekat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Projekat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Projekat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Projekat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Projekat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Projekat] SET QUERY_STORE = OFF
GO
USE [Projekat]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikID] [int] NOT NULL,
	[KorisnickoIme] [nvarchar](50) NULL,
	[Lozinka] [nvarchar](50) NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narucilac]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narucilac](
	[KorisnikID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Adresa] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[PIB] [nchar](50) NULL,
 CONSTRAINT [PK_Narucilac] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narudzbenica]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narudzbenica](
	[BrojNarudzbenice] [int] NOT NULL,
	[DatumIzdavanja] [date] NULL,
	[StatusPlacanja] [nvarchar](50) NULL,
	[VrednostBezPDV] [float] NULL,
	[VrednostSaPDV] [float] NULL,
	[StatusNarudzbine] [nvarchar](50) NULL,
	[DatumIsporuke] [date] NULL,
	[Obradjena] [bit] NULL,
	[IDRadnika] [int] NULL,
	[IDNarucioca] [int] NULL,
 CONSTRAINT [PK_Narudzbenica] PRIMARY KEY CLUSTERED 
(
	[BrojNarudzbenice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoreskaStopa]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoreskaStopa](
	[ID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Stopa] [float] NULL,
 CONSTRAINT [PK_PoreskaStopa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[IDProizvoda] [int] NOT NULL,
	[NazivProizvoda] [nvarchar](50) NULL,
	[CenaBezPDV] [float] NULL,
	[CenaSaPDV] [float] NULL,
	[Valuta] [nvarchar](50) NULL,
	[TipID] [int] NULL,
	[StopaID] [int] NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[IDProizvoda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[KorisnikID] [int] NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaNarudzbenice]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaNarudzbenice](
	[BrojNarudzbenice] [int] NOT NULL,
	[RBr] [int] NOT NULL,
	[Kolicina] [int] NULL,
	[UkupnaCenaBezPDV] [float] NULL,
	[UkupnaCenaSaPDV] [float] NULL,
	[IDProizvoda] [int] NULL,
 CONSTRAINT [PK_StavkaNarudzbenice] PRIMARY KEY CLUSTERED 
(
	[BrojNarudzbenice] ASC,
	[RBr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipProizvoda]    Script Date: 29.7.2020. 12:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipProizvoda](
	[IDTipa] [int] NOT NULL,
	[NazivTipa] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipProizvoda] PRIMARY KEY CLUSTERED 
(
	[IDTipa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (1, N'momo', N'momo')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (2, N'ljilja', N'ljilja')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (5, N'fiki', N'fiki')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (6, N'ecom', N'ecom')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (7, N'slon', N'slon')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (8, N'fatal', N'fatal')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (9, N'lily', N'lily')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (10, N'dm', N'dm')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (11, N'harizma', N'harizma')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (12, N'Narucilac', N'kasa')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (25, N'moya@moya.com', N'@y8^*VzC')
INSERT [dbo].[Korisnik] ([KorisnikID], [KorisnickoIme], [Lozinka]) VALUES (26, N'kasa', N'K-iSq#M1')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (5, N'Fiki', N'fiki@fiki.com', N'A122222', N'159789', N'1112                                              ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (6, N'E commerce', N'ecommerce@ecommerce.com', N'A2', N'3579511', N'222                                               ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (7, N'Slonce', N'slonce@slonce.com', N'A3', N'468219', N'34                                                ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (8, N'Fatal', N'fatal@fatal.com', N'A4', N'642891', N'4                                                 ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (9, N'Lily', N'lyly@gmail.com', N'A5', N'123A8', N'5                                                 ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (10, N'DM', N'dm.drogerie@gmail.com', N'A6', N'1254', N'6                                                 ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (11, N'Harizma d.o.o', N'harizma@gmail.com', N'A7', N'546897', N'7555                                              ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (12, N'Narucilac', N'email', N'A1', N'1234', N'12345                                             ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (25, N'Moya drogerie', N'moya@moya.com', N'Jove Ilica 22', N'358978', N'896452                                            ')
INSERT [dbo].[Narucilac] ([KorisnikID], [Naziv], [Email], [Adresa], [Telefon], [PIB]) VALUES (26, N'kasa', N'kasa', N'kmj', N'765', N'54                                                ')
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (40, CAST(N'2020-07-21' AS Date), N'Placena', 2400, 2772, N'Isporucena', CAST(N'2020-07-21' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (41, CAST(N'2020-06-01' AS Date), N'Placena', 15180, 18087.3, N'Isporucena', CAST(N'2020-06-01' AS Date), 1, 1, 6)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (42, CAST(N'2020-06-01' AS Date), N'Placena', 3600, 4320, N'Isporucena', CAST(N'2020-06-03' AS Date), 1, 1, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (44, CAST(N'2020-06-03' AS Date), N'Placena', 17156.73, 18872.43, N'Isporucena', CAST(N'2020-06-03' AS Date), 1, 2, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (45, CAST(N'2020-07-20' AS Date), N'Placena', 17640, 21060, N'Isporucena', CAST(N'2020-07-20' AS Date), 1, 1, 6)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (46, CAST(N'2020-07-21' AS Date), N'Placena', 4290, 4954.95, N'Isporucena', CAST(N'2020-07-21' AS Date), 1, 1, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (47, CAST(N'2020-06-03' AS Date), N'Placena', 3200, 3696, N'Isporucena', CAST(N'2020-06-03' AS Date), 1, 2, 11)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (48, CAST(N'2020-06-04' AS Date), N'Placena', 3735, 4482, N'Isporucena', CAST(N'2020-06-04' AS Date), 1, 2, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (49, CAST(N'2020-07-21' AS Date), N'Placena', 13800, 16101, N'Isporucena', CAST(N'2020-07-21' AS Date), 1, 1, 10)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (51, CAST(N'2020-07-21' AS Date), N'Placena', 1000, 1155, N'Isporucena', CAST(N'2020-07-21' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (87, CAST(N'2020-07-22' AS Date), N'Placena', 498, 597.6, N'Isporucena', CAST(N'2020-07-22' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (88, CAST(N'2020-07-22' AS Date), N'Placena', 3735, 4482, N'Isporucena', CAST(N'2020-07-22' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (89, CAST(N'2020-07-22' AS Date), N'Placena', 17500, 21000, N'Isporucena', CAST(N'2020-07-22' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (90, CAST(N'2020-07-22' AS Date), N'Placena', 17000, 19635, N'Isporucena', CAST(N'2020-07-22' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (91, CAST(N'2020-07-22' AS Date), N'Placena', 5250, 6300, N'Isporucena', CAST(N'2020-07-22' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (93, CAST(N'2020-07-24' AS Date), N'Placena', 25049.85, 28717.35, N'Isporucena', CAST(N'2020-07-24' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (94, CAST(N'2020-07-24' AS Date), N'Placena', 23790, 28548, N'Isporucena', CAST(N'2020-07-24' AS Date), 1, 1, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (95, CAST(N'2020-07-24' AS Date), N'Placena', 16854.34, 18539.79, N'Isporucena', CAST(N'2020-07-24' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (96, CAST(N'2020-07-26' AS Date), N'Placena', 5472, 6566.4, N'Isporucena', CAST(N'2020-07-26' AS Date), 1, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (97, CAST(N'2020-07-28' AS Date), N'Placena', 34498.5, 40363.35, N'Isporucena', CAST(N'2020-07-28' AS Date), 1, 1, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (98, CAST(N'2020-07-27' AS Date), N'Neplacena', 36528, 42006.6, N'Primljena', CAST(N'0001-01-01' AS Date), 0, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (99, CAST(N'2020-07-27' AS Date), N'Placena', 20923.5, 24208.35, N'Isporucena', CAST(N'2020-07-27' AS Date), 1, 1, 11)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (100, CAST(N'2020-07-27' AS Date), N'Neplacena', 11564.85, 13141.35, N'Primljena', CAST(N'0001-01-01' AS Date), 0, 1, 5)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (101, CAST(N'2020-07-29' AS Date), N'Neplacena', 44830, 51540.75, N'Primljena', CAST(N'0001-01-01' AS Date), 0, 1, 6)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (102, CAST(N'2020-07-28' AS Date), N'Neplacena', 11385, 13468.95, N'Primljena', CAST(N'0001-01-01' AS Date), 0, 1, 7)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (103, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Narudzbenica] ([BrojNarudzbenice], [DatumIzdavanja], [StatusPlacanja], [VrednostBezPDV], [VrednostSaPDV], [StatusNarudzbine], [DatumIsporuke], [Obradjena], [IDRadnika], [IDNarucioca]) VALUES (104, CAST(N'2020-07-29' AS Date), N'Neplacena', 17790, 19969.95, N'Primljena', CAST(N'0001-01-01' AS Date), 0, 1, 6)
INSERT [dbo].[PoreskaStopa] ([ID], [Naziv], [Stopa]) VALUES (1, N'Posebna stopa PDV-a', 10)
INSERT [dbo].[PoreskaStopa] ([ID], [Naziv], [Stopa]) VALUES (2, N'Opšta stopa PDV-a', 20)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (1, N'UltraDoux Honey', 200, 231, N'RSD', 1, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (2, N'Elseve Color Care', 249, 298.8, N'RSD', 1, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (4, N'Subrina7.4', 200, 231, N'RSD', 1, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (5, N'Garnier BB Cream', 350, 420, N'RSD', 3, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (7, N'Loreal True Match foundation', 850, 981.75, N'RSD', 4, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (8, N'Garnier Skin Active ', 750.99, 826.09, N'RSD', 2, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (9, N'Olia6.8', 350, 385, N'RSD', 1, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (10, N'Olia6.2', 286, 330.33, N'RSD', 1, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (11, N'Loreal Revitalift', 456, 547.2, N'RSD', 3, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (12, N'Colosal BigShot', 650, 780, N'RSD', 4, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (18, N'Olia7.5', 240, 288, N'RSD', 2, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (19, N'Mixa Micellar Water', 490.99, 540.09, N'RSD', 3, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (20, N'MicellarWater', 599.9, 659.89, N'RSD', 3, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (23, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (24, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (25, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (26, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (27, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (36, N'Ultra Doux maska', 850, 1020, N'RSD', 1, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (37, N'Garnier NEO', 345, 414, N'RSD', 1, 2)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (38, N'Loreal eyeshadow palete', 1050, 1155, N'RSD', 4, 1)
INSERT [dbo].[Proizvod] ([IDProizvoda], [NazivProizvoda], [CenaBezPDV], [CenaSaPDV], [Valuta], [TipID], [StopaID]) VALUES (39, N'Garnier color revitalift', 450, 540, N'RSD', 1, 2)
INSERT [dbo].[Radnik] ([KorisnikID], [Ime], [Prezime]) VALUES (1, N'Momir', N'Paunovic')
INSERT [dbo].[Radnik] ([KorisnikID], [Ime], [Prezime]) VALUES (2, N'Ljiljana', N'Paunovic')
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (40, 1, 12, 2400, 2772, 4)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (41, 1, 20, 9120, 10944, 11)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (41, 2, 20, 3200, 3840, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (41, 3, 10, 2860, 3303.3, 9)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (42, 1, 15, 3600, 4320, 18)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (42, 2, 20, 3200, 3840, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (44, 1, 12, 5891.88, 6481.08, 19)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (44, 2, 15, 11264.85, 12391.35, 8)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (45, 1, 20, 13000, 15600, 12)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (45, 2, 14, 2240, 2688, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (45, 3, 12, 2400, 2772, 1)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (46, 1, 15, 4290, 4954.95, 10)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (47, 1, 16, 3200, 3696, 4)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (48, 1, 15, 3735, 4482, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (49, 1, 12, 10200, 11781, 7)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (49, 2, 15, 3600, 4320, 18)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (51, 1, 5, 1000, 1155, 4)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (87, 1, 2, 498, 597.6, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (88, 1, 15, 3735, 4482, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (89, 1, 50, 17500, 21000, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (90, 1, 20, 17000, 19635, 7)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (91, 1, 15, 5250, 6300, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (93, 1, 24, 4800, 5544, 1)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (93, 2, 15, 3735, 4482, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (93, 3, 15, 5250, 6300, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (93, 4, 15, 11264.85, 12391.35, 8)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (94, 1, 12, 4200, 5040, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (94, 2, 15, 6840, 8208, 11)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (94, 3, 15, 12750, 15300, 36)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (95, 1, 15, 8998.5, 9898.35, 20)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (95, 2, 16, 7855.84, 8641.44, 19)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (96, 1, 12, 5472, 6566.4, 11)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (97, 1, 15, 8998.5, 9898.35, 20)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (97, 2, 15, 12750, 15300, 36)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (97, 3, 15, 9750, 11700, 12)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (97, 4, 15, 3000, 3465, 1)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 1, 12, 4200, 5040, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 2, 12, 10200, 11781, 7)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 3, 12, 4140, 4968, 37)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 4, 12, 12600, 13860, 38)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 5, 12, 2988, 3585.6, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (98, 6, 12, 2400, 2772, 4)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (99, 1, 15, 5175, 6210, 37)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (99, 2, 15, 8998.5, 9898.35, 20)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (99, 3, 15, 6750, 8100, 39)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (100, 1, 12, 4200, 5040, 5)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (100, 2, 15, 7364.85, 8101.35, 19)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (101, 1, 37, 31450, 36324.75, 7)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (101, 2, 20, 4980, 5976, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (101, 3, 24, 8400, 9240, 9)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (102, 1, 14, 3360, 4032, 18)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (102, 2, 15, 4290, 4954.95, 10)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (102, 3, 15, 3735, 4482, 2)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (104, 1, 15, 3000, 3465, 4)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (104, 2, 15, 4290, 4954.95, 10)
INSERT [dbo].[StavkaNarudzbenice] ([BrojNarudzbenice], [RBr], [Kolicina], [UkupnaCenaBezPDV], [UkupnaCenaSaPDV], [IDProizvoda]) VALUES (104, 3, 30, 10500, 11550, 9)
INSERT [dbo].[TipProizvoda] ([IDTipa], [NazivTipa]) VALUES (1, N'Tretmani i nega kose')
INSERT [dbo].[TipProizvoda] ([IDTipa], [NazivTipa]) VALUES (2, N'Tretmani i nega tela')
INSERT [dbo].[TipProizvoda] ([IDTipa], [NazivTipa]) VALUES (3, N'Nega lica')
INSERT [dbo].[TipProizvoda] ([IDTipa], [NazivTipa]) VALUES (4, N'Sminka')
ALTER TABLE [dbo].[Narucilac]  WITH CHECK ADD  CONSTRAINT [FK_Narucilac_Korisnik] FOREIGN KEY([KorisnikID])
REFERENCES [dbo].[Korisnik] ([KorisnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Narucilac] CHECK CONSTRAINT [FK_Narucilac_Korisnik]
GO
ALTER TABLE [dbo].[Narudzbenica]  WITH CHECK ADD  CONSTRAINT [FK_Narudzbenica_Narucilac] FOREIGN KEY([IDNarucioca])
REFERENCES [dbo].[Narucilac] ([KorisnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Narudzbenica] CHECK CONSTRAINT [FK_Narudzbenica_Narucilac]
GO
ALTER TABLE [dbo].[Narudzbenica]  WITH CHECK ADD  CONSTRAINT [FK_Narudzbenica_Radnik] FOREIGN KEY([IDRadnika])
REFERENCES [dbo].[Radnik] ([KorisnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Narudzbenica] CHECK CONSTRAINT [FK_Narudzbenica_Radnik]
GO
ALTER TABLE [dbo].[Proizvod]  WITH CHECK ADD  CONSTRAINT [FK_Proizvod_PoreskaStopa] FOREIGN KEY([StopaID])
REFERENCES [dbo].[PoreskaStopa] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Proizvod] CHECK CONSTRAINT [FK_Proizvod_PoreskaStopa]
GO
ALTER TABLE [dbo].[Proizvod]  WITH CHECK ADD  CONSTRAINT [FK_Proizvod_TipProizvoda] FOREIGN KEY([TipID])
REFERENCES [dbo].[TipProizvoda] ([IDTipa])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Proizvod] CHECK CONSTRAINT [FK_Proizvod_TipProizvoda]
GO
ALTER TABLE [dbo].[Radnik]  WITH CHECK ADD  CONSTRAINT [FK_Radnik_Korisnik] FOREIGN KEY([KorisnikID])
REFERENCES [dbo].[Korisnik] ([KorisnikID])
GO
ALTER TABLE [dbo].[Radnik] CHECK CONSTRAINT [FK_Radnik_Korisnik]
GO
ALTER TABLE [dbo].[StavkaNarudzbenice]  WITH CHECK ADD  CONSTRAINT [FK_StavkaNarudzbenice_Narudzbenica] FOREIGN KEY([BrojNarudzbenice])
REFERENCES [dbo].[Narudzbenica] ([BrojNarudzbenice])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaNarudzbenice] CHECK CONSTRAINT [FK_StavkaNarudzbenice_Narudzbenica]
GO
ALTER TABLE [dbo].[StavkaNarudzbenice]  WITH CHECK ADD  CONSTRAINT [FK_StavkaNarudzbenice_Proizvod] FOREIGN KEY([IDProizvoda])
REFERENCES [dbo].[Proizvod] ([IDProizvoda])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaNarudzbenice] CHECK CONSTRAINT [FK_StavkaNarudzbenice_Proizvod]
GO
USE [master]
GO
ALTER DATABASE [Projekat] SET  READ_WRITE 
GO
