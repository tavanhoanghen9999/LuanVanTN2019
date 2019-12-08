USE [mydatabase]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[actid] [int] IDENTITY(1,1) NOT NULL,
	[actiname] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[actid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carts]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carts](
	[cartid] [int] IDENTITY(1,1) NOT NULL,
	[money] [bigint] NULL,
	[prid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cartid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comment]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comment](
	[cmtid] [int] IDENTITY(1,1) NOT NULL,
	[comment] [nvarchar](3000) NULL,
	[prid] [int] NULL,
	[usid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cmtid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[describeproducts]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[describeproducts](
	[desid] [int] IDENTITY(1,1) NOT NULL,
	[describes] [nvarchar](3000) NULL,
	[title] [nvarchar](1000) NULL,
	[prid] [int] NULL,
	[stt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[desid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discount]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discount](
	[discountid] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](10) NULL,
	[percents] [int] NULL,
	[eventname] [nvarchar](500) NULL,
	[money] [bigint] NULL,
	[startday] [datetime] NULL,
	[endday] [datetime] NULL,
	[note] [nvarchar](1000) NULL,
	[stt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[discountid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[evaluates]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[evaluates](
	[evaid] [int] IDENTITY(1,1) NOT NULL,
	[evaluate] [int] NULL,
	[prid] [int] NULL,
	[usid] [int] NULL,
	[note] [nvarchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[evaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imageproducts]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imageproducts](
	[imgid] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](500) NULL,
	[prid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[imgid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imgcomments]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imgcomments](
	[icmtid] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](500) NULL,
	[evaid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[icmtid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ivid] [int] IDENTITY(1,1) NOT NULL,
	[namecustomer] [nvarchar](100) NULL,
	[quantitum] [int] NULL,
	[totalmoney] [bigint] NULL,
	[money] [bigint] NULL,
	[discount] [bigint] NULL,
	[note] [nvarchar](300) NULL,
	[prid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ivid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lineproducts]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lineproducts](
	[lineprid] [int] IDENTITY(1,1) NOT NULL,
	[linename] [nvarchar](500) NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[lineprid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[prid] [int] IDENTITY(1,1) NOT NULL,
	[prname] [nvarchar](200) NULL,
	[total] [int] NULL,
	[importprice] [bigint] NULL,
	[price] [bigint] NULL,
	[oldprice] [bigint] NULL,
	[lineprid] [int] NULL,
	[totalview] [int] NULL,
	[totallike] [int] NULL,
	[image] [nvarchar](200) NULL,
	[mnday] [datetime] NULL,
	[expirydate] [datetime] NULL,
	[createday] [datetime] NULL,
	[highlight] [int] NULL,
	[status] [int] NULL,
	[note] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[prid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[roleid] [int] IDENTITY(1,1) NOT NULL,
	[rolename] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[roleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/24/2019 4:11:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[usid] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
	[roles] [int] NULL,
	[avatar] [nvarchar](200) NULL,
	[wall] [nvarchar](200) NULL,
	[email] [nvarchar](100) NULL,
	[phone] [nvarchar](10) NULL,
	[address] [nvarchar](400) NULL,
	[birthday] [datetime] NULL,
	[createday] [datetime] NULL,
	[active] [int] NULL,
	[gender] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[carts]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[comment]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[comment]  WITH CHECK ADD FOREIGN KEY([usid])
REFERENCES [dbo].[users] ([usid])
GO
ALTER TABLE [dbo].[describeproducts]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[evaluates]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[evaluates]  WITH CHECK ADD FOREIGN KEY([usid])
REFERENCES [dbo].[users] ([usid])
GO
ALTER TABLE [dbo].[imageproducts]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[imgcomments]  WITH CHECK ADD FOREIGN KEY([evaid])
REFERENCES [dbo].[evaluates] ([evaid])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([prid])
REFERENCES [dbo].[products] ([prid])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([lineprid])
REFERENCES [dbo].[lineproducts] ([lineprid])
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([active])
REFERENCES [dbo].[Activity] ([actid])
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([roles])
REFERENCES [dbo].[roles] ([roleid])
GO
