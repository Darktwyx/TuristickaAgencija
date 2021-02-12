USE [TuristickaAgencija]
GO
/****** Object:  Table [dbo].[Destinacija]    Script Date: 6/12/2020 10:24:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinacija](
	[destinacijaID] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
	[Opis] [varchar](50) NULL,
	[datumPolaska] [date] NULL,
	[datumDolaska] [date] NULL,
	[Prevoz] [varchar](50) NULL,
	[Cena] [float] NULL,
 CONSTRAINT [PK_Destinacija] PRIMARY KEY CLUSTERED 
(
	[destinacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FakultativniIzlet]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FakultativniIzlet](
	[fakultativniIzletID] [int] NOT NULL,
	[Mesto] [varchar](50) NULL,
	[Opis] [varchar](50) NULL,
	[Cena] [float] NULL,
 CONSTRAINT [PK_FakultativniIzlet] PRIMARY KEY CLUSTERED 
(
	[fakultativniIzletID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FotografijeDestinacije]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FotografijeDestinacije](
	[fotografijaID] [int] NOT NULL,
	[destinacijaID] [int] NOT NULL,
	[URLFotografije] [varchar](100) NULL,
 CONSTRAINT [PK_FotografijeDestinacije] PRIMARY KEY CLUSTERED 
(
	[fotografijaID] ASC,
	[destinacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[radnikID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[radnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RealizacijaIzleta]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RealizacijaIzleta](
	[destinacijaID] [int] NOT NULL,
	[fakultativniIzletID] [int] NOT NULL,
	[datumRealizacije] [date] NULL,
 CONSTRAINT [PK_RealizacijaIzleta] PRIMARY KEY CLUSTERED 
(
	[destinacijaID] ASC,
	[fakultativniIzletID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[rezervacijaID] [int] NOT NULL,
	[datumRezervacije] [date] NULL,
	[mestoPolaska] [varchar](50) NULL,
	[brojTurista] [int] NULL,
	[destinacijaID] [int] NULL,
	[turistaID] [int] NULL,
	[radnikID] [int] NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[rezervacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turista]    Script Date: 6/12/2020 10:24:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turista](
	[turistaID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Adresa] [varchar](50) NULL,
	[datumRodjenja] [date] NULL,
	[brojTelefona] [varchar](50) NULL,
 CONSTRAINT [PK_Turista] PRIMARY KEY CLUSTERED 
(
	[turistaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Radnik] ([radnikID], [Ime], [Prezime], [Username], [Password]) VALUES (1, N'FON', N'FON', N'FON', N'fonbg')
ALTER TABLE [dbo].[FotografijeDestinacije]  WITH CHECK ADD  CONSTRAINT [FK_FotografijeDestinacije_Destinacija] FOREIGN KEY([destinacijaID])
REFERENCES [dbo].[Destinacija] ([destinacijaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FotografijeDestinacije] CHECK CONSTRAINT [FK_FotografijeDestinacije_Destinacija]
GO
ALTER TABLE [dbo].[RealizacijaIzleta]  WITH CHECK ADD  CONSTRAINT [FK_RealizacijaIzleta_Destinacija] FOREIGN KEY([destinacijaID])
REFERENCES [dbo].[Destinacija] ([destinacijaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RealizacijaIzleta] CHECK CONSTRAINT [FK_RealizacijaIzleta_Destinacija]
GO
ALTER TABLE [dbo].[RealizacijaIzleta]  WITH CHECK ADD  CONSTRAINT [FK_RealizacijaIzleta_FakultativniIzlet] FOREIGN KEY([fakultativniIzletID])
REFERENCES [dbo].[FakultativniIzlet] ([fakultativniIzletID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RealizacijaIzleta] CHECK CONSTRAINT [FK_RealizacijaIzleta_FakultativniIzlet]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Destinacija] FOREIGN KEY([destinacijaID])
REFERENCES [dbo].[Destinacija] ([destinacijaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Destinacija]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Radnik] FOREIGN KEY([radnikID])
REFERENCES [dbo].[Radnik] ([radnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Radnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Turista] FOREIGN KEY([turistaID])
REFERENCES [dbo].[Turista] ([turistaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Turista]
GO
