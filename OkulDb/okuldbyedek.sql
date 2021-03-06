
USE [OkulDb]
GO
/****** Object:  Table [dbo].[tblOgrenciler]    Script Date: 14.01.2018 12:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOgrenciler](
	[OgrenciId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](20) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Numara] [varchar](10) NOT NULL,
	[TelNo] [varchar](50) NOT NULL,
	[SınıfId] [int] NOT NULL,
 CONSTRAINT [PK_tblOgrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrenciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSiniflar]    Script Date: 14.01.2018 12:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSiniflar](
	[SinifId] [int] IDENTITY(1,1) NOT NULL,
	[SinifAd] [varchar](10) NOT NULL,
	[Kontenjan] [int] NOT NULL,
 CONSTRAINT [PK_tblSiniflar] PRIMARY KEY CLUSTERED 
(
	[SinifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblSiniflar] ON 

INSERT [dbo].[tblSiniflar] ([SinifId], [SinifAd], [Kontenjan]) VALUES (1, N'5-A', 20)
INSERT [dbo].[tblSiniflar] ([SinifId], [SinifAd], [Kontenjan]) VALUES (2, N'7-A', 25)
SET IDENTITY_INSERT [dbo].[tblSiniflar] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_tblOgrenciler_Numara]    Script Date: 14.01.2018 12:13:52 ******/
ALTER TABLE [dbo].[tblOgrenciler] ADD  CONSTRAINT [UK_tblOgrenciler_Numara] UNIQUE NONCLUSTERED 
(
	[Numara] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_tblSiniflar_SinifAd]    Script Date: 14.01.2018 12:13:52 ******/
ALTER TABLE [dbo].[tblSiniflar] ADD  CONSTRAINT [UK_tblSiniflar_SinifAd] UNIQUE NONCLUSTERED 
(
	[SinifAd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblOgrenciler]  WITH CHECK ADD  CONSTRAINT [FK_tblOgrenciler_tblSiniflar] FOREIGN KEY([SınıfId])
REFERENCES [dbo].[tblSiniflar] ([SinifId])
GO
ALTER TABLE [dbo].[tblOgrenciler] CHECK CONSTRAINT [FK_tblOgrenciler_tblSiniflar]
GO
USE [master]
GO
ALTER DATABASE [OkulDb] SET  READ_WRITE 
GO
