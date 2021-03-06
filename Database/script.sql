USE [master]
GO
/****** Object:  Database [NguoiDung]    Script Date: 4/6/2020 2:55:03 PM ******/
CREATE DATABASE [NguoiDung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NguoiDung', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NguoiDung.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NguoiDung_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NguoiDung_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NguoiDung] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NguoiDung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NguoiDung] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NguoiDung] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NguoiDung] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NguoiDung] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NguoiDung] SET ARITHABORT OFF 
GO
ALTER DATABASE [NguoiDung] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NguoiDung] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NguoiDung] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NguoiDung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NguoiDung] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NguoiDung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NguoiDung] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NguoiDung] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NguoiDung] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NguoiDung] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NguoiDung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NguoiDung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NguoiDung] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NguoiDung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NguoiDung] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NguoiDung] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NguoiDung] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NguoiDung] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NguoiDung] SET  MULTI_USER 
GO
ALTER DATABASE [NguoiDung] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NguoiDung] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NguoiDung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NguoiDung] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NguoiDung] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NguoiDung] SET QUERY_STORE = OFF
GO
USE [NguoiDung]
GO
/****** Object:  Table [dbo].[BanChamCong]    Script Date: 4/6/2020 2:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanChamCong](
	[Ma_BCCC] [nchar](10) NOT NULL,
	[Ma_ND] [nchar](10) NULL,
	[ThangCC] [smallint] NULL,
	[SoNgayCong] [smallint] NULL,
 CONSTRAINT [PK_BanChamCong] PRIMARY KEY CLUSTERED 
(
	[Ma_BCCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 4/6/2020 2:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[Ma_CV] [nchar](10) NOT NULL,
	[Ten_CV] [nchar](10) NULL,
	[HeSoLuong] [smallint] NULL,
	[PhuCap] [float] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[Ma_CV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 4/6/2020 2:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Ma_ND] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nchar](10) NULL,
	[TrinhDo] [nvarchar](50) NULL,
	[Ma_CV] [nchar](10) NULL,
	[Ma_PB] [nchar](10) NULL,
	[Luong] [float] NULL,
	[Image] [text] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Ma_ND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 4/6/2020 2:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[Ma_PB] [nchar](10) NOT NULL,
	[Ten_PB] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[Ma_PB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuong]    Script Date: 4/6/2020 2:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuong](
	[Ma_Thuong] [nchar](10) NOT NULL,
	[Ma_ND] [nchar](10) NULL,
	[Thang] [smallint] NULL,
	[NoiDung] [ntext] NULL,
	[SoTien] [float] NULL,
 CONSTRAINT [PK_Thuong] PRIMARY KEY CLUSTERED 
(
	[Ma_Thuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC1     ', N'ND1       ', 1, 15)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC2     ', N'ND1       ', 2, 28)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC3     ', N'ND1       ', 3, 31)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC4     ', N'ND2       ', 1, 18)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC5     ', N'ND2       ', 2, 27)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC6     ', N'ND3       ', 1, 10)
INSERT [dbo].[BanChamCong] ([Ma_BCCC], [Ma_ND], [ThangCC], [SoNgayCong]) VALUES (N'BCCC7     ', N'ND3       ', 2, 28)
INSERT [dbo].[ChucVu] ([Ma_CV], [Ten_CV], [HeSoLuong], [PhuCap]) VALUES (N'ADMIN     ', N'ADMIN     ', NULL, NULL)
INSERT [dbo].[ChucVu] ([Ma_CV], [Ten_CV], [HeSoLuong], [PhuCap]) VALUES (N'CV1       ', N'Lập trình ', 3, 800000)
INSERT [dbo].[ChucVu] ([Ma_CV], [Ten_CV], [HeSoLuong], [PhuCap]) VALUES (N'CV2       ', N'Thiết kế  ', 3, 800000)
INSERT [dbo].[ChucVu] ([Ma_CV], [Ten_CV], [HeSoLuong], [PhuCap]) VALUES (N'CV3       ', N'Kiểm thử  ', 3, 800000)
INSERT [dbo].[ChucVu] ([Ma_CV], [Ten_CV], [HeSoLuong], [PhuCap]) VALUES (N'CV4       ', N'Giu xe    ', 2, 500000)
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ADMIN     ', N'ADMIN', N'1 ', N'Nam       ', CAST(N'1900-01-06T00:00:00.000' AS DateTime), N'', N'          ', N'', N'ADMIN     ', N'ADMIN     ', 50000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND1       ', N'Phan Van Tài', N'1', N'Nam       ', CAST(N'1997-04-14T00:00:00.000' AS DateTime), N'GiaLai', N'0377529144', N'Đại Học', N'CV1       ', N'PB1       ', 200000000, N'C:\Users\ADMIN\Desktop\Anh\covi.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND11      ', N'Hello', N'2', N'Nam       ', CAST(N'1900-01-06T00:00:00.000' AS DateTime), N'', N'          ', N'THPT', N'CV2       ', N'PB3       ', 5000000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND2       ', N'Lê Thị Thúy Vi', N'1', N'Nữ        ', CAST(N'1997-09-05T00:00:00.000' AS DateTime), N'Đông Hòa', N'0351542222', N'Đại Học', N'CV2       ', N'PB2       ', 10000000, N'C:\Users\ADMIN\Desktop\Anh\covi.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND23      ', N'+ÁDASDASD', N'1 ', N'Nam       ', CAST(N'1900-01-06T00:00:00.000' AS DateTime), N'', N'          ', N'Trung Cấp Nghề', N'ADMIN     ', N'ADMIN     ', 5000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'nd26      ', N'+sdlaksdal', N'ádasdas ', N'Nam       ', CAST(N'1900-01-06T00:00:00.000' AS DateTime), N'ư', N'          ', N'', N'ADMIN     ', N'ADMIN     ', 5000, N'C:\Users\ADMIN\Desktop\Anh\Viet.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'nd27      ', N'+ádasdasd', N'1 ', N'Nam       ', CAST(N'1900-01-09T00:00:00.000' AS DateTime), N'', N'          ', N'', N'CV2       ', N'PB2       ', 50000, N'C:\Users\ADMIN\Desktop\Anh\SonDamSau.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND3       ', N'Nguyễn Quốc Việt', N'1', N'Nam       ', CAST(N'1997-04-14T00:00:00.000' AS DateTime), N'Tam Kỳ', N'0351542254', N'Đại Học', N'CV3       ', N'PB3       ', 15000000, N'C:\Users\ADMIN\Desktop\Anh\Viet.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND4       ', N'Võ Văn Sơn', N'1', N'Nam       ', CAST(N'1997-02-14T00:00:00.000' AS DateTime), N'DakLak', N'0351542254', N'Đại Học', N'CV4       ', N'PB4       ', 10000000, N'C:\Users\ADMIN\Desktop\Anh\SonDamSau.jpg')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND5       ', N'Xuân Diệu', N'1', N'Nữ        ', CAST(N'1998-05-14T00:00:00.000' AS DateTime), N'Gialai', N'0351452485', N'Trung Cấp Nghề', N'CV2       ', N'PB1       ', 8000000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'ND6       ', N'Lý hOàn Nam', N'1', N'Nam       ', CAST(N'1998-02-01T00:00:00.000' AS DateTime), N'', N'          ', N'THPT', N'CV2       ', N'PB2       ', 2000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'nd8       ', N'hhhhh', N'ádasdasdas', N'Nam       ', CAST(N'1900-01-16T00:00:00.000' AS DateTime), N'', N'          ', N'', N'CV2       ', N'pb11      ', 50000, N'')
INSERT [dbo].[NguoiDung] ([Ma_ND], [HoTen], [MatKhau], [GioiTinh], [NgaySinh], [DiaChi], [Sdt], [TrinhDo], [Ma_CV], [Ma_PB], [Luong], [Image]) VALUES (N'nd81      ', N'+adasdas', N'1', N'Nam       ', CAST(N'1900-01-06T00:00:00.000' AS DateTime), N'', N'          ', N'', N'CV1       ', N'PB1       ', 1000, N'C:\Users\ADMIN\Desktop\Anh\SonDamSau.jpg')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'ADMIN     ', N'ADMIN')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB1       ', N'Phòng Ban 5')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB10      ', N'Phòng Ban 10')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'pb11      ', N'phongban11')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'pb12      ', N'phongban12')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB2       ', N'Phòng ban 8')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'pb20      ', N'+phongban20')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB3       ', N'Phòng ban 3')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB4       ', N'Phòng ban 4')
INSERT [dbo].[PhongBan] ([Ma_PB], [Ten_PB]) VALUES (N'PB7       ', N'Phòng Ban 7')
INSERT [dbo].[Thuong] ([Ma_Thuong], [Ma_ND], [Thang], [NoiDung], [SoTien]) VALUES (N'Thuong1   ', N'ND1       ', 1, N'Nghĩ tết', 800000)
INSERT [dbo].[Thuong] ([Ma_Thuong], [Ma_ND], [Thang], [NoiDung], [SoTien]) VALUES (N'Thuong2   ', N'ND2       ', 3, N'Nghĩ lễ 10/3', 500000)
INSERT [dbo].[Thuong] ([Ma_Thuong], [Ma_ND], [Thang], [NoiDung], [SoTien]) VALUES (N'Thuong3   ', N'ND3       ', 4, N'Nghĩ 30/4', 500000)
INSERT [dbo].[Thuong] ([Ma_Thuong], [Ma_ND], [Thang], [NoiDung], [SoTien]) VALUES (N'Thuong4   ', N'ND4       ', 5, N'Nghĩ 1/5', 500000)
ALTER TABLE [dbo].[BanChamCong]  WITH CHECK ADD  CONSTRAINT [FK_BanChamCong_NguoiDung] FOREIGN KEY([Ma_ND])
REFERENCES [dbo].[NguoiDung] ([Ma_ND])
GO
ALTER TABLE [dbo].[BanChamCong] CHECK CONSTRAINT [FK_BanChamCong_NguoiDung]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_ChucVu] FOREIGN KEY([Ma_CV])
REFERENCES [dbo].[ChucVu] ([Ma_CV])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_ChucVu]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_PhongBan] FOREIGN KEY([Ma_PB])
REFERENCES [dbo].[PhongBan] ([Ma_PB])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_PhongBan]
GO
ALTER TABLE [dbo].[Thuong]  WITH CHECK ADD  CONSTRAINT [FK_Thuong_NguoiDung] FOREIGN KEY([Ma_ND])
REFERENCES [dbo].[NguoiDung] ([Ma_ND])
GO
ALTER TABLE [dbo].[Thuong] CHECK CONSTRAINT [FK_Thuong_NguoiDung]
GO
USE [master]
GO
ALTER DATABASE [NguoiDung] SET  READ_WRITE 
GO
