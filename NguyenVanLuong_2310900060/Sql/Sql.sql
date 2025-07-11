USE [NguyenVanLuong_2310900060]
GO
/****** Object:  Table [dbo].[NvlEmployee]    Script Date: 01/07/2025 11:24:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NvlEmployee](
	[nvlEmpId] [nchar](10) NOT NULL,
	[nvlEmpName] [nchar](30) NULL,
	[nvlEmpLevel] [nchar](20) NULL,
	[nvlEmpStartDate] [char](20) NULL,
	[nvlEmpStatus] [bit] NULL,
 CONSTRAINT [PK_NvlEmployee] PRIMARY KEY CLUSTERED 
(
	[nvlEmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NvlEmployee] ([nvlEmpId], [nvlEmpName], [nvlEmpLevel], [nvlEmpStartDate], [nvlEmpStatus]) VALUES (N'1         ', N'Trần Thị C                    ', N'Cao thủ             ', N'11/06/2015          ', 0)
INSERT [dbo].[NvlEmployee] ([nvlEmpId], [nvlEmpName], [nvlEmpLevel], [nvlEmpStartDate], [nvlEmpStatus]) VALUES (N'2         ', N'Lò Thị L                      ', N'Kim Cương           ', N'06/07/2021          ', 1)
INSERT [dbo].[NvlEmployee] ([nvlEmpId], [nvlEmpName], [nvlEmpLevel], [nvlEmpStartDate], [nvlEmpStatus]) VALUES (N'2310900060', N'Nguyễn Văn Lượng              ', N'Bạch Kim            ', N'20/09/2020          ', 1)
INSERT [dbo].[NvlEmployee] ([nvlEmpId], [nvlEmpName], [nvlEmpLevel], [nvlEmpStartDate], [nvlEmpStatus]) VALUES (N'3         ', N'Trần Thanh T                  ', N'Vàng                ', N'12/09/2023          ', 1)
GO
