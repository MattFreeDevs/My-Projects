USE [LookingForServiceDB]
GO
/****** Object:  Table [dbo].[BUSINESS]    Script Date: 03/11/2018 19:01:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BUSINESS](
	[Type] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPANIES]    Script Date: 03/11/2018 19:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPANIES](
	[Name] [varchar](255) NOT NULL,
	[NIF] [varchar](64) NOT NULL,
	[Location] [varchar](255) NOT NULL,
	[Phone] [int] NOT NULL,
	[BusinessType] [varchar](255) NULL,
	[Email] [varchar](255) NOT NULL,
	[Description] [varchar](1024) NULL,
	[Owner_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 03/11/2018 19:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nick] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[SecondName] [varchar](255) NOT NULL,
	[Email] [varchar](255) NULL,
	[Type] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Architect')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Babysitter')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Bookkeeper')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Bricklayer')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Cabinetmaker')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Carpenter')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Computer support')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Domestic service')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Driver')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Electrician')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Gardener')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Language teacher')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Lawyer')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Locksmith')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Painter')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Plumber')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Salesman')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Software developer')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Tax consultant')
INSERT [dbo].[BUSINESS] ([Type]) VALUES (N'Welder')
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([Id], [Nick], [Password], [Name], [SecondName], [Email], [Type]) VALUES (1, N'admin', N'admin', N'John', N'Silver', N'admin@gmail.com', N'company')
SET IDENTITY_INSERT [dbo].[USERS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__USERS__7D3471B6E433F38C]    Script Date: 03/11/2018 19:01:58 ******/
ALTER TABLE [dbo].[USERS] ADD UNIQUE NONCLUSTERED 
(
	[Nick] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[COMPANIES]  WITH CHECK ADD FOREIGN KEY([BusinessType])
REFERENCES [dbo].[BUSINESS] ([Type])
GO
ALTER TABLE [dbo].[COMPANIES]  WITH CHECK ADD FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[USERS] ([Id])
GO
