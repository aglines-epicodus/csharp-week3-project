CREATE DATABASE [hair_salon_test]
GO
USE [hair_salon]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 6/11/2017 6:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[stylist_id] [int] NULL,
	[contact] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stylists]    Script Date: 6/11/2017 6:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[contact] [varchar](255) NULL,
	[photo_link] [varchar](255) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([id], [name], [stylist_id], [contact]) VALUES (5, N'23', 3, N'23')
INSERT [dbo].[clients] ([id], [name], [stylist_id], [contact]) VALUES (3, N'Neo', 2, N'mrAnderson@neocortex.com')
INSERT [dbo].[clients] ([id], [name], [stylist_id], [contact]) VALUES (6, N'66', 3, N'666')
INSERT [dbo].[clients] ([id], [name], [stylist_id], [contact]) VALUES (9, N'fsdsd', 2, N'fds')
SET IDENTITY_INSERT [dbo].[clients] OFF
SET IDENTITY_INSERT [dbo].[stylists] ON 

INSERT [dbo].[stylists] ([id], [name], [contact], [photo_link]) VALUES (2, N'NotNull', N'ted@tedgibson.com', N'http://tedgibson.com/media/wysiwyg/images/tedgibson-dropdownmenu.png')
INSERT [dbo].[stylists] ([id], [name], [contact], [photo_link]) VALUES (3, N'3', N'i am not null', N'again not null')
INSERT [dbo].[stylists] ([id], [name], [contact], [photo_link]) VALUES (1005, N'111', N'111', N'111')
INSERT [dbo].[stylists] ([id], [name], [contact], [photo_link]) VALUES (1006, N'test', N'3333', N'3333')
SET IDENTITY_INSERT [dbo].[stylists] OFF
