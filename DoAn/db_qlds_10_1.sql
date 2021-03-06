USE [QuanLyTauHoa]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuyen](
	[MaChuyen] [int] IDENTITY(1,1) NOT NULL,
	[MaTuyen] [int] NULL,
	[GioKhoiHanh] [varchar](5) NULL,
 CONSTRAINT [PK_Chuyen] PRIMARY KEY CLUSTERED 
(
	[MaChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenTau]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenTau](
	[MaChuyenTau] [int] IDENTITY(1,1) NOT NULL,
	[MaChuyen] [int] NULL,
	[MaTau] [int] NULL,
	[NgayKhoiHanh] [datetime] NULL,
	[CreatedByUser] [varchar](50) NULL,
	[UpdatedByUser] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ChuyenTau] PRIMARY KEY CLUSTERED 
(
	[MaChuyenTau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ga]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ga](
	[MaGa] [int] IDENTITY(1,1) NOT NULL,
	[TenGa] [nvarchar](50) NULL,
	[MaThanhPhoTinh] [int] NULL,
 CONSTRAINT [PK_Ga] PRIMARY KEY CLUSTERED 
(
	[MaGa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe](
	[MaGhe] [int] IDENTITY(1,1) NOT NULL,
	[TenGhe] [nvarchar](50) NULL,
	[DaXoa] [bit] NULL,
	[MaToa] [int] NULL,
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[MaGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhach] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [varchar](15) NULL,
	[SoDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiVe]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiVe](
	[MaLoaiVe] [int] IDENTITY(1,1) NOT NULL,
	[MaChuyenTau] [int] NULL,
	[GiaVe] [float] NULL,
	[LoaiVe] [int] NULL,
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[MaLoaiVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganHang]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganHang](
	[MaNganHang] [int] IDENTITY(1,1) NOT NULL,
	[SoDu] [float] NOT NULL,
	[CMND] [varchar](15) NULL,
	[MaBaoMat] [nvarchar](50) NULL,
 CONSTRAINT [PK_NganHang] PRIMARY KEY CLUSTERED 
(
	[MaNganHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTri]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTri](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_QuanTri] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tau]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tau](
	[MaTau] [int] IDENTITY(1,1) NOT NULL,
	[TenTau] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Tau] PRIMARY KEY CLUSTERED 
(
	[MaTau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhPho_Tinh]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho_Tinh](
	[MaThanhPhoTinh] [int] IDENTITY(1,1) NOT NULL,
	[TenThanhPhoTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThanhPho_Tinh] PRIMARY KEY CLUSTERED 
(
	[MaThanhPhoTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toa]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toa](
	[MaToa] [int] IDENTITY(1,1) NOT NULL,
	[MaTau] [int] NULL,
	[LoaiCho] [int] NULL,
	[TenToa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Toa] PRIMARY KEY CLUSTERED 
(
	[MaToa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyen](
	[MaTuyen] [int] IDENTITY(1,1) NOT NULL,
	[GaDi] [int] NULL,
	[GaDen] [int] NULL,
	[TuyenCha] [int] NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
	[CreatedByUser] [varchar](50) NULL,
	[UpdatedByUser] [varchar](50) NULL,
 CONSTRAINT [PK_Tuyen] PRIMARY KEY CLUSTERED 
(
	[MaTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 1/10/2022 8:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[SoVe] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiVe] [int] NULL,
	[TrangThaiVe] [int] NULL,
	[NgayBanVe] [datetime] NULL,
	[MaGhe] [int] NULL,
	[MaKhach] [int] NULL,
	[TrangThai] [int] NULL,
	[PhiTraVe] [float] NULL,
 CONSTRAINT [PK_ChiTietDatVe] PRIMARY KEY CLUSTERED 
(
	[SoVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Tuyen] FOREIGN KEY([MaTuyen])
REFERENCES [dbo].[Tuyen] ([MaTuyen])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Tuyen]
GO
ALTER TABLE [dbo].[ChuyenTau]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenTau_Chuyen] FOREIGN KEY([MaChuyen])
REFERENCES [dbo].[Chuyen] ([MaChuyen])
GO
ALTER TABLE [dbo].[ChuyenTau] CHECK CONSTRAINT [FK_ChuyenTau_Chuyen]
GO
ALTER TABLE [dbo].[ChuyenTau]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenTau_QuanTri] FOREIGN KEY([UpdatedByUser])
REFERENCES [dbo].[QuanTri] ([TaiKhoan])
GO
ALTER TABLE [dbo].[ChuyenTau] CHECK CONSTRAINT [FK_ChuyenTau_QuanTri]
GO
ALTER TABLE [dbo].[ChuyenTau]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenTau_QuanTri1] FOREIGN KEY([CreatedByUser])
REFERENCES [dbo].[QuanTri] ([TaiKhoan])
GO
ALTER TABLE [dbo].[ChuyenTau] CHECK CONSTRAINT [FK_ChuyenTau_QuanTri1]
GO
ALTER TABLE [dbo].[ChuyenTau]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenTau_Tau] FOREIGN KEY([MaTau])
REFERENCES [dbo].[Tau] ([MaTau])
GO
ALTER TABLE [dbo].[ChuyenTau] CHECK CONSTRAINT [FK_ChuyenTau_Tau]
GO
ALTER TABLE [dbo].[Ga]  WITH CHECK ADD  CONSTRAINT [FK_Ga_ThanhPho_Tinh] FOREIGN KEY([MaThanhPhoTinh])
REFERENCES [dbo].[ThanhPho_Tinh] ([MaThanhPhoTinh])
GO
ALTER TABLE [dbo].[Ga] CHECK CONSTRAINT [FK_Ga_ThanhPho_Tinh]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [FK_Ghe_Toa] FOREIGN KEY([MaToa])
REFERENCES [dbo].[Toa] ([MaToa])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [FK_Ghe_Toa]
GO
ALTER TABLE [dbo].[LoaiVe]  WITH CHECK ADD  CONSTRAINT [FK_Ve_ChuyenTau] FOREIGN KEY([MaChuyenTau])
REFERENCES [dbo].[ChuyenTau] ([MaChuyenTau])
GO
ALTER TABLE [dbo].[LoaiVe] CHECK CONSTRAINT [FK_Ve_ChuyenTau]
GO
ALTER TABLE [dbo].[Toa]  WITH CHECK ADD  CONSTRAINT [FK_Toa_Tau] FOREIGN KEY([MaTau])
REFERENCES [dbo].[Tau] ([MaTau])
GO
ALTER TABLE [dbo].[Toa] CHECK CONSTRAINT [FK_Toa_Tau]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Ga] FOREIGN KEY([GaDi])
REFERENCES [dbo].[Ga] ([MaGa])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Ga]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Ga1] FOREIGN KEY([GaDen])
REFERENCES [dbo].[Ga] ([MaGa])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Ga1]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_QuanTri] FOREIGN KEY([CreatedByUser])
REFERENCES [dbo].[QuanTri] ([TaiKhoan])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_QuanTri]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_QuanTri1] FOREIGN KEY([UpdatedByUser])
REFERENCES [dbo].[QuanTri] ([TaiKhoan])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_QuanTri1]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [FK_Tuyen_Tuyen] FOREIGN KEY([TuyenCha])
REFERENCES [dbo].[Tuyen] ([MaTuyen])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [FK_Tuyen_Tuyen]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Ghe] FOREIGN KEY([MaGhe])
REFERENCES [dbo].[Ghe] ([MaGhe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Ghe]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhachHang]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_LoaiVe] FOREIGN KEY([MaLoaiVe])
REFERENCES [dbo].[LoaiVe] ([MaLoaiVe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_LoaiVe]
GO
