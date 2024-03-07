USE [milescarrental]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 7/03/2024 12:28:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Model] [varchar](255) NOT NULL,
	[Make] [varchar](255) NOT NULL,
	[Available] [bit] NOT NULL,
	[Location] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/03/2024 12:28:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 7/03/2024 12:28:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Address] [varchar](max) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[PhoneNumber] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[BusinessHours] [varchar](max) NULL,
	[Capacity] [int] NULL,
	[Restrictions] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([ID], [CategoryID], [Model], [Make], [Available], [Location]) VALUES (1, 1, N'Ford Fiesta', N'Ford', 1, N'Paris')
INSERT [dbo].[Cars] ([ID], [CategoryID], [Model], [Make], [Available], [Location]) VALUES (2, 2, N'Toyota Corolla', N'Toyota', 1, N'Madrid')
INSERT [dbo].[Cars] ([ID], [CategoryID], [Model], [Make], [Available], [Location]) VALUES (3, 3, N'Ford Escape', N'Ford', 1, N'Barcelona')
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Name]) VALUES (1, N'Economy')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (2, N'Intermediate')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (3, N'Standard')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (1, N'Miami Airport', N'777 NW 117th St, Miami, FL 33166, United States', 25.764439, -80.206382, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (2, N'Fort Lauderdale Airport', N'2400 E Commercial Blvd, Fort Lauderdale, FL 33316, United States', 26.071111, -80.149722, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (3, N'Orlando International Airport', N'1 Jeff Fuqua Blvd, Orlando, FL 32827, United States', 28.538333, -81.300833, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (4, N'Tampa International Airport', N'4200 George J. Bean Parkway, Tampa, FL 33607, United States', 27.975278, -82.533333, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (5, N'West Palm Beach International Airport', N'7000 Belvedere Rd, West Palm Beach, FL 33407, United States', 26.704444, -80.095278, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (6, N'Los Angeles International Airport', N'1 World Way, Los Angeles, CA 90045, United States', 33.942501, -118.408056, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (7, N'San Francisco International Airport', N'780 S Airport Blvd, San Francisco, CA 94128, United States', 37.618889, -122.385278, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (8, N'San Diego International Airport', N'3225 N Harbor Dr, San Diego, CA 92101, United States', 32.540556, -117.159444, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (9, N'Sacramento International Airport', N'6151 Freeport Blvd, Sacramento, CA 95822, United States', 38.514167, -121.518333, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (10, N'Anaheim', N'1221 S Anaheim Blvd, Anaheim, CA 92805, United States', 33.805556, -117.913611, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (11, N'Madrid Airport', N'Barajas, Madrid, Spain', 40.463667, -3.560278, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (12, N'Barcelona Airport', N'El Prat de Llobregat, Barcelona, Spain', 41.297222, 2.080278, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (13, N'Heathrow Airport', N'London Heathrow Airport Ltd, Hounslow TW6 1QG, United Kingdom', 51.4775, -0.461389, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (14, N'Charles de Gaulle Airport', N'95700 Roissy-en-France, France', 49.009722, 2.547222, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (15, N'Fiumicino Airport', N'Fiumicino, Rome, Italy', 41.799444, 12.250556, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (16, N'Frankfurt Airport', N'Frankfurt, Germany', 50.048889, 8.542222, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (17, N'Munich Airport', N'Munich, Germany', 48.140833, 11.786111, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (18, N'Amsterdam Airport Schiphol', N'Schiphol, Netherlands', 52.310278, 4.763889, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Locations] ([Id], [Name], [Address], [Latitude], [Longitude], [PhoneNumber], [Email], [BusinessHours], [Capacity], [Restrictions]) VALUES (19, N'Zurich Airport', N'Zurich, Switzerland', 47.447222, 8.546111, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
USE [master]
GO
ALTER DATABASE [milescarrental] SET  READ_WRITE 
GO
