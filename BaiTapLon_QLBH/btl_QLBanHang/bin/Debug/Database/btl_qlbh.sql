USE [btl]
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChatLieu] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDB]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDB](
	[MaHDB] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[SLBan] [int] NULL,
	[MaKM] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDN]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDN](
	[MaHDN] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SLNhap] [int] NOT NULL,
	[MaKM] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietMauSac]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietMauSac](
	[MaSP] [nvarchar](50) NULL,
	[MaMauSac] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietNV]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietNV](
	[MaNV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NULL,
	[LuongCB] [money] NULL,
	[HeSo] [float] NULL,
	[Thuong] [money] NULL,
 CONSTRAINT [PK_tblChiTietNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietSize]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietSize](
	[MaSP] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonBan]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonBan](
	[MaHDB] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[NgayBan] [date] NULL,
	[SoSP] [int] NULL,
 CONSTRAINT [PK_tblHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHDN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Anh] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhuyenMai]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhuyenMai](
	[MaKM] [nvarchar](50) NOT NULL,
	[GiamGia] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMauSac]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMauSac](
	[MaMauSac] [nvarchar](50) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblMauSac] PRIMARY KEY CLUSTERED 
(
	[MaMauSac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNV]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNV](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_tblNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaChatLieu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MaKM] [nvarchar](50) NULL,
	[DonGiaNhap] [money] NULL,
	[DonGiaBan] [money] NULL,
	[Anh] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSize]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSize](
	[MaSize] [nvarchar](50) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSize] PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 10/25/2022 12:08:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[MaNV] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl01', N'vải')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl02', N'bò')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl03', N'cotton')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl04', N'nilon')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl05', N'lụa')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl06', N'bông')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl07', N'nhung')
GO
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM]) VALUES (N'hdb01', N'sp02', 20, N'km01')
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM]) VALUES (N'hdb02', N'sp01', 10, N'km01')
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM]) VALUES (N'hdb02', N'sp03', 5, N'km03')
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM]) VALUES (N'hdb04', N'sp01', 10, NULL)
GO
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [MaKM]) VALUES (N'hdn01', N'sp01', 50, NULL)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [MaKM]) VALUES (N'hdn02', N'sp04', 70, N'km01')
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [MaKM]) VALUES (N'hdn02', N'sp03', 50, NULL)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [MaKM]) VALUES (N'hdn04', N'sp02', 100, N'km05')
GO
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp01', N'ms01')
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp01', N'ms02')
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp01', N'ms03')
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp02', N'ms02')
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp02', N'ms03')
INSERT [dbo].[tblChiTietMauSac] ([MaSP], [MaMauSac]) VALUES (N'sp03', N'ms01')
GO
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv01', N'NV', 14900000.0000, 0.5, 200000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv02', N'QL', 2000000.0000, 1, 150000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv03', N'NV', 14900000.0000, 0.7, NULL)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv04', N'QL', 2000000.0000, 0.2, 600000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv05', N'NV', 14900000.0000, 0.5, NULL)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv06', N'NV', 14900000.0000, 0.9, 150000.0000)
GO
INSERT [dbo].[tblChiTietSize] ([MaSP], [MaSize]) VALUES (N'sp01', N's01')
INSERT [dbo].[tblChiTietSize] ([MaSP], [MaSize]) VALUES (N'sp01', N's02')
INSERT [dbo].[tblChiTietSize] ([MaSP], [MaSize]) VALUES (N'sp02', N's01')
INSERT [dbo].[tblChiTietSize] ([MaSP], [MaSize]) VALUES (N'sp03', N's03')
GO
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan], [SoSP]) VALUES (N'hdb01', N'nv01', N'kh01', CAST(N'2020-12-11' AS Date), 2)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan], [SoSP]) VALUES (N'hdb02', N'nv01', N'kh02', CAST(N'2021-12-16' AS Date), 3)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan], [SoSP]) VALUES (N'hdb03', N'nv03', N'kh04', CAST(N'1999-06-18' AS Date), 5)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan], [SoSP]) VALUES (N'hdb04', N'nv04', N'kh02', CAST(N'2022-01-01' AS Date), 3)
GO
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hdb05', N'nv03', CAST(N'2019-12-31' AS Date), N'ncc05')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hdn01', N'nv01', CAST(N'2021-11-29' AS Date), N'ncc01')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hdn02', N'nv01', CAST(N'2022-01-17' AS Date), N'ncc02')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hdn03', N'nv02', CAST(N'2020-06-06' AS Date), N'ncc04')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hdn04', N'nv05', CAST(N'2022-02-07' AS Date), N'ncc01')
GO
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh01', N'Nguyễn Ngọc Anh', N'Hà Nội', N'0987485729', CAST(N'2002-12-08' AS Date), NULL, N'Nữ        ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh02', N'Trịnh Hải Dương', N'Thanh Hóa', N'0998778964', CAST(N'2000-10-19' AS Date), NULL, N'Nam       ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh03', N'Hoàng Anh Tú', N'Nghệ An', N'0998472634', CAST(N'2001-02-19' AS Date), NULL, N'Nam       ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh04', N'Phạm Linh Anh', N'Hồ Chí Minh', N'0936475892', CAST(N'1999-06-18' AS Date), NULL, N'Nữ        ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh05', N'Lê Linh Chi', N'Hải Phòng', N'0983746528', CAST(N'1999-07-02' AS Date), NULL, N'Nữ        ')
GO
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km01', N'20', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km02', N'15', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km03', N'10', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km04', N'25', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km05', N'17', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km06', N'20', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km07', N'19', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km08', N'30', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km09', N'22', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km10', N'5', NULL)
GO
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms01', N'đỏ')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms02', N'đen')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms03', N'vàng')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms04', N'cam')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms05', N'xanh lá cây')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms06', N'xanh nước biển')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms07', N'tím')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'ms08', N'hồng')
GO
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc01', N'Phương Thảo')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc02', N'Rạng Đông')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc03', N'Bình Minh')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc04', N'Chiến Thắng')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc05', N'Hòa Bình')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc06', N'Ngọc Nhi')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc07', N'Thái Hà')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc08', N'Hòa Phát')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc09', N'Hai Ninh')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc10', N'Ngọc Ngà')
GO
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv01', N'Trần Minh Anh', N'Hà Nội', N'0998984756', NULL, N'Nữ', CAST(N'2002-12-11' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv02', N'Trịnh Huy Hiệp', N'Hải Phòng', N'02238495729', NULL, N'Nam', CAST(N'2000-11-11' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv03', N'Thái Hà Anh', N'Mễ Trì', N'0923475827', NULL, N'Nữ', CAST(N'1999-10-16' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv04', N'Nguyễn Ngọc Ngạn', N'Hải Dương', N'0998374628', NULL, N'Nam', CAST(N'1978-10-26' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv05', N'Đinh Mạnh Hải', N'Hồ Chí Minh', N'0837495821', NULL, N'Nam', CAST(N'1999-12-06' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv06', N'Nguyễn Linh Chi', N'Hà Nội', N'0938746591', NULL, N'Nữ', CAST(N'2000-12-17' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv07', N'Phạm Ngọc Hà', N'Thanh Hóa', N'0893758472', NULL, N'Nữ', CAST(N'1998-01-01' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv08', N'Hoàng Ngọc Hân', N'Nghệ An', N'0987698345', NULL, N'Nữ', CAST(N'2003-06-06' AS Date))
GO
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp01', N'Áo thun', N'cl01', 50, NULL, 50000.0000, 75000.0000, NULL, NULL, N'ncc01')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp02', N'Áo vest', N'cl02', 100, N'km01', 70000.0000, 75000.0000, NULL, NULL, N'ncc01')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp03', N'Quần bò', N'cl04', 70, NULL, 150000.0000, 175000.0000, NULL, NULL, N'ncc02')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp04', N'Quần short', N'cl02', 20, N'km02', 120000.0000, 150000.0000, NULL, NULL, N'ncc03')
GO
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's01', N'S')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's02', N'M')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's03', N'L')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's04', N'XL')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's05', N'XXL')
GO
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password]) VALUES (N'nv01', N'ab', N'123')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password]) VALUES (N'nv02', N'bc', N'234')
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[tblHoaDonBan] ([MaHDB])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblKhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblKhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblKhuyenMai]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblKhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblKhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblKhuyenMai]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietMauSac]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietMauSac_tblMauSac] FOREIGN KEY([MaMauSac])
REFERENCES [dbo].[tblMauSac] ([MaMauSac])
GO
ALTER TABLE [dbo].[tblChiTietMauSac] CHECK CONSTRAINT [FK_tblChiTietMauSac_tblMauSac]
GO
ALTER TABLE [dbo].[tblChiTietMauSac]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietMauSac_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietMauSac] CHECK CONSTRAINT [FK_tblChiTietMauSac_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietNV]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNV_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblChiTietNV] CHECK CONSTRAINT [FK_tblChiTietNV_tblNV]
GO
ALTER TABLE [dbo].[tblChiTietSize]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietSize_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietSize] CHECK CONSTRAINT [FK_tblChiTietSize_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietSize]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietSize_tblSize] FOREIGN KEY([MaSize])
REFERENCES [dbo].[tblSize] ([MaSize])
GO
ALTER TABLE [dbo].[tblChiTietSize] CHECK CONSTRAINT [FK_tblChiTietSize_tblSize]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblNV]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNV]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblChatLieu] FOREIGN KEY([MaChatLieu])
REFERENCES [dbo].[tblChatLieu] ([MaChatLieu])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblChatLieu]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblKhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblKhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblKhuyenMai]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblNV]
GO
