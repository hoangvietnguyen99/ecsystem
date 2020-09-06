-- CREATE PROCEDURE

USE dbQLBanHangQuaMang
GO

----------------- NHAN VIEN -------------------------
CREATE PROC USP_GetNhanVienByMaNV
@manv nvarchar(5)
AS 
BEGIN
	SELECT * FROM dbo.NHAN_VIEN WHERE MaNV = @manv
END
GO


CREATE PROC USP_Login
@username varchar(5), @password varchar(50)
AS
BEGIN
	SELECT * FROM dbo.NHAN_VIEN WHERE MaNV = @username AND Password = @password
END
GO

-------------- TIN_QUANG_CAO ------------------------
CREATE PROC USP_KiemTraTinQuangCao
@MaTin varchar(5), @NgayLap date, @NoiDung nvarchar(200), @NVDangTin varchar(5)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM [dbo].[TIN_QUANG_CAO] WHERE MaTin = @MaTin)
	BEGIN
	INSERT INTO [dbo].[TIN_QUANG_CAO] VALUES (@MaTin, @NgayLap, @NoiDung, @NVDangTin);
	END
	ELSE
	BEGIN
	UPDATE [dbo].[TIN_QUANG_CAO] SET NoiDung = @NoiDung WHERE MaTin = @MaTin;
	END
END
GO

CREATE PROCEDURE USP_ThemTinQuangCao
@MaTin varchar(5), @NgayLap date, @NoiDung nvarchar(200), @NVDangTin varchar(5)
AS
BEGIN
	INSERT INTO [dbo].[TIN_QUANG_CAO] VALUES (@MaTin, @NgayLap, @NoiDung, @NVDangTin);
END
GO

CREATE PROCEDURE USP_CapNhatTinQuangCao
@MaTin varchar(5), @NoiDung nvarchar(200)
AS
BEGIN
	UPDATE [dbo].[TIN_QUANG_CAO] SET [NoiDung] = @NoiDung WHERE MaTin = @MaTin;
END
GO

CREATE PROCEDURE USP_XoaTinQuangCao
@MaTin varchar(5)
AS
BEGIN
	DELETE FROM [dbo].[LICH_SU_TIN_QC_DOI_TAC] WHERE MaTin = @MaTin;
	DELETE FROM [dbo].[LICH_SU_TIN_QC_KH] WHERE MaTin = @MaTin;
	DELETE FROM [dbo].[TIN_QUANG_CAO] WHERE MaTin = @MaTin;
END
GO

CREATE PROCEDURE USP_XemDSTinQuangCao
AS
BEGIN
	SELECT * FROM [dbo].[TIN_QUANG_CAO];
END
GO

CREATE PROCEDURE USP_XemTinQuangCao
@MaTin varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[TIN_QUANG_CAO] WHERE MaTin = @MaTin;
END
GO

CREATE PROCEDURE USP_XemKhachHang
@MaKH varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[KHACH_HANG] WHERE MaKH = @MaKH;
END
GO

CREATE PROCEDURE USP_LayDSKhachHangChuaThemVaoTin
@MaTin varchar(5)
AS
BEGIN
	SELECT MaKH FROM [dbo].[KHACH_HANG] WHERE MaKH NOT IN (SELECT MaKH FROM [dbo].[LICH_SU_TIN_QC_KH] WHERE MaTin = @MaTin)
END
GO

CREATE PROCEDURE USP_LayDSLICH_SU_TIN_QC_KHTHEOTIN
@MaTin varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[LICH_SU_TIN_QC_KH] WHERE MaTin = @MaTin;
END
GO

CREATE PROCEDURE USP_ThemKhachHangVaoTin
@MaTin varchar(5), @MaKH varchar(5)
AS
BEGIN
	INSERT INTO [dbo].[LICH_SU_TIN_QC_KH]
           ([MaTin]
           ,[MaKH]
           ,[NgayGui])
     VALUES
           (@MaTin, @MaKH, GETDATE())
END
GO
--- DOI TAC
CREATE PROCEDURE USP_XemDoiTac
@MaKH varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[DOI_TAC_QUANG_CAO] WHERE MaDoiTac = @MaKH;
END
GO

CREATE PROCEDURE USP_LayDSDoiTacChuaThemVaoTin
@MaTin varchar(5)
AS
BEGIN
	SELECT MaDoiTac FROM [dbo].[DOI_TAC_QUANG_CAO] WHERE MaDoiTac NOT IN (SELECT MaDoiTac FROM [dbo].[LICH_SU_TIN_QC_DOI_TAC] WHERE MaTin = @MaTin)
END
GO

CREATE PROCEDURE USP_LayDSLICH_SU_TIN_DOITAC_KHTHEOTIN
@MaTin varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[LICH_SU_TIN_QC_DOI_TAC] WHERE MaTin = @MaTin;
END
GO

CREATE PROCEDURE USP_ThemDoiTacVaoTin
@MaTin varchar(5), @MaDoiTac varchar(5), @ThoiGianQC int, @TTVTD nvarchar(100)
AS
BEGIN
INSERT INTO [dbo].[LICH_SU_TIN_QC_DOI_TAC]
           ([MaTin]
           ,[MaDoiTac]
           ,[NgayKyHD]
           ,[ThoiGianQC]
           ,[ThongTinViTriDang])
     VALUES
           (@MaTin, @MaDoiTac, GETDATE(), @ThoiGianQC, @TTVTD);
END
GO

--LOAI_HANG
CREATE PROCEDURE USP_LayDSLoaiHang
AS
	SELECT * FROM [dbo].[LOAI_HANG];
GO

CREATE PROCEDURE USP_LayDSTenLoaiHang
AS
BEGIN
	SELECT DISTINCT TenLH FROM [dbo].[LOAI_HANG];
END
GO

CREATE PROCEDURE USP_LayLoaiHangTheoTen
@TenLH nvarchar(50)
AS
BEGIN
	SELECT * FROM [dbo].[LOAI_HANG] WHERE TenLH = @TenLH;
END
GO

CREATE PROCEDURE USP_ThemLoaiHang
@MaLH varchar(5), @TenLH nvarchar(50), @NVQuanLy varchar(5)
AS
BEGIN
INSERT INTO [dbo].[LOAI_HANG]
           ([MaLH]
           ,[TenLH]
           ,[NVQuanLy])
     VALUES
           (@MaLH, @TenLH, @NVQuanLy);
END
GO

CREATE PROCEDURE USP_XoaLoaiHang
@MaLH varchar(5)
AS
BEGIN
	DELETE FROM [dbo].[LOAI_HANG] WHERE MaLH = @MaLH AND MaLH NOT IN (SELECT DISTINCT LoaiHang FROM [dbo].[MAT_HANG]);
END
GO

--DON NHAP HANG
CREATE PROCEDURE USP_LayDSDonNhapHangChuaDuyet
AS
BEGIN
	SELECT * FROM [dbo].[DON_NHAP_HANG] WHERE QuanLyXacNhan = null;
END
GO

--MAT HANG

CREATE PROCEDURE USP_LayDSMatHang
AS
BEGIN
	SELECT * FROM [dbo].[MAT_HANG];
END
GO


CREATE PROCEDURE USP_LayDSMatHangTheoTenLoaiHang
@TenLH varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[MAT_HANG] WHERE LoaiHang = @TenLH;
END
GO


CREATE PROCEDURE USP_ThemMatHang
@MaMH varchar(5), @TenMH nvarchar(50), @GiaTien float, @SLTon int, @LoaiHang varchar(5)
AS
BEGIN
INSERT INTO [dbo].[MAT_HANG]
           ([MaMH]
           ,[TenMH]
           ,[GiaTien]
           ,[SLTon]
           ,[LoaiHang])
     VALUES
           (@MaMH, @TenMH, @GiaTien, @SLTon, @LoaiHang);
END
GO

----- mua ban hang
CREATE PROCEDURE USP_LayDSMatHangTheoMa
@MaMH varchar(5)
AS
BEGIN
	SELECT * FROM [dbo].[MAT_HANG] WHERE MaMH = @MaMH;
END
GO


CREATE PROCEDURE USP_LayDSMatHangTheoGia @minPrice FLOAT, @maxPrice FLOAT
AS	
	SELECT * FROM dbo.MAT_HANG WHERE GiaTien BETWEEN  @minPrice AND @maxPrice
GO

CREATE PROCEDURE USP_TimMatHang @tenMH NVARCHAR(50)
AS	
	Select * From MAT_HANG WHERE TenMH LIKE '%'+ @tenMH +'%'
GO

CREATE PROCEDURE USP_LayDSMatHangTheoLoaiHang @maLoaiHang VARCHAR(5)
AS	
	Select * From MAT_HANG WHERE LoaiHang = @maLoaiHang
GO

CREATE PROCEDURE USP_LayDSMatHangGiaGiamDan
AS	
	Select * From MAT_HANG ORDER BY GiaTien DESC
GO

CREATE PROCEDURE USP_LayDSMatHangTangDan
AS	
	Select * From MAT_HANG ORDER BY GiaTien ASC
GO

CREATE PROCEDURE USP_CapNhatSoLuongTon (@maMH VARCHAR(5), @soluongMua INT)
AS
	UPDATE dbo.MAT_HANG SET SLTon = SLTon - @soluongMua WHERE MaMH = @maMH; 
GO


-- HOA DON
CREATE PROCEDURE USP_LayDSHoaDon
AS
	SELECT * FROM dbo.HOA_DON
GO

CREATE PROCEDURE USP_LayDSHoaDonHienCo
AS
	SELECT TOP 1 MaHD FROM HOA_DON ORDER BY MaHD DESC
GO

CREATE PROCEDURE USP_ThemHoaDon @maHD VARCHAR(5), @tongTien FLOAT, @maKH VARCHAR(5)
AS
	INSERT INTO HOA_DON VALUES (@maHD, GETDATE(), @tongTien, NULL, NULL, NULL, NULL, @maKH)
GO

-- CT_HOA_DON
CREATE PROCEDURE USP_LayDSCTHoaDon
AS
	SELECT * FROM dbo.CT_HOA_DON
GO

CREATE PROCEDURE USP_ThemCTHoaDon @maHD VARCHAR(5), @maMH VARCHAR(5), @donGia FLOAT, @soLuong INT
AS
	INSERT INTO CT_HOA_DON VALUES (@maHD, @maMH, @donGia , @soLuong)
GO

-- KHACH_HANG
CREATE PROCEDURE USP_LayDSKhachHang
AS
	SELECT * FROM dbo.KHACH_HANG
GO

CREATE PROCEDURE USP_KhachHangLogin @userName VARCHAR(30), @passWord VARCHAR(30) 
AS
	SELECT MaKH, TenKH FROM KHACH_HANG WHERE Username = @userName AND Password= @passWord
GO

CREATE PROCEDURE USP_LichSuMuaHangTheoMaKH @maKH VARCHAR(5)
AS
	SELECT MaHD, NgayLap, TongTien FROM HOA_DON WHERE MaKH = @maKH;
GO
-- INSERT SAMPLE DATA

USE [dbQLBanHangQuaMang]
GO

------------------- DOI TAC QUANG CAO -------------------------------
INSERT INTO [dbo].[DOI_TAC_QUANG_CAO]
           ([MaDoiTac]
           ,[TenDoiTac]
           ,[DiaChi]
           ,[SDT]
           ,[DanhGia]
           ,[SoLanGiaHan])
     VALUES
           ('DT001',N'Best AD Corp',N'Califonia','09128390812',N'Ổn',0),
		   ('DT002',N'Tiki Website',N'Việt Nam','0912839812',N'Ổn',0),
		   ('DT003',N'AD Company',N'New York','0928390812',N'Tạm',0),
		   ('DT004',N'Title Value',N'Hà Nội','091283812',N'Ổn',0),
		   ('DT005',N'Best Corp for AD',N'Hồ Chí Minh','0918390812',N'Worst',0)
GO



-------------------- NHAN VIEN --------------------------
INSERT INTO [dbo].[NHAN_VIEN]
           ([MaNV]
           ,[TenNV]
           ,[DiaChi]
           ,[SDT]
           ,[ChucVu]
           ,[Password])
     VALUES
           ('001'
		   ,'NHV'
           ,N'Hồ Chí Minh'
           ,'0966586'
           ,N'Quản lý'
           ,'001')
GO

INSERT INTO dbo.NHAN_VIEN
        ( MaNV ,
          TenNV ,
          DiaChi ,
          SDT ,
          ChucVu ,
          Password
        )
VALUES  ( 'NV004' , -- MaNV - varchar(5)
          N'Nguyen Anh Tu' , -- TenNV - nvarchar(50)
          N'227 Nguyen Van Tuan' , -- DiaChi - nvarchar(50)
          '0909867542' , -- SDT - varchar(12)
          N'Quảng cáo' , -- ChucVu - nvarchar(50)
          '1234'  -- Password - varchar(50)
        )

INSERT INTO dbo.NHAN_VIEN
        ( MaNV ,
          TenNV ,
          DiaChi ,
          SDT ,
          ChucVu ,
          Password
        )
VALUES  ( 'NV002' , -- MaNV - varchar(5)
          N'Nguyen Hoang Viet' , -- TenNV - nvarchar(50)
          N'227 Nguyen Van Tuan' , -- DiaChi - nvarchar(50)
          '0909867542' , -- SDT - varchar(12)
          N'Mặt hàng' , -- ChucVu - nvarchar(50)
          '1234'  -- Password - varchar(50)
        )


------------------ TIN QUANG CAO -----------------------
INSERT INTO dbo.TIN_QUANG_CAO
        ( MaTin, NgayLap, NoiDung, NVDangTin )
VALUES  ( 'Q0001', -- MaTin - varchar(5)
          GETDATE(), -- NgayLap - date
          N'Flash Sale 9.9', -- NoiDung - nvarchar(200)
          'NV004'  -- NVDangTin - varchar(5)
          )

----------- LSU TIN QUANG CAO DOI TAC --------------------------------
INSERT INTO dbo.LICH_SU_TIN_QC_DOI_TAC
        ( MaTin ,
          MaDoiTac ,
          NgayKyHD ,
          ThoiGianQC ,
          ThongTinViTriDang
        )
VALUES  ( 'Q0001' , -- MaTin - varchar(5)
          'DT002' , -- MaDoiTac - varchar(5)
          GETDATE() , -- NgayKyHD - date
          0 , -- ThoiGianQC - int
          N'tiki.vn'  -- ThongTinViTriDang - nvarchar(100)
        )

------------------------
------------------------------ LOAI HANG ---------------------------------------
INSERT INTO [dbo].[LOAI_HANG]
           ([MaLH]
           ,[TenLH]
           ,[NVQuanLy])
     VALUES
           ('DT'
           ,N'Điện Thoại - Máy Tính Bảng'
           ,NULL);
GO

INSERT INTO [dbo].[LOAI_HANG]
           ([MaLH]
           ,[TenLH]
           ,[NVQuanLy])
     VALUES
           ('PK'
           ,N'Phụ Kiện - Thiết Bị Số'
           ,NULL);
GO

INSERT INTO [dbo].[LOAI_HANG]
           ([MaLH]
           ,[TenLH]
           ,[NVQuanLy])
     VALUES
           ('LT'
           ,N'Laptop - Thiết Bị IT'
           ,NULL);
GO

INSERT INTO [dbo].[LOAI_HANG]
           ([MaLH]
           ,[TenLH]
           ,[NVQuanLy])
     VALUES
           ('MA'
           ,N'Máy Ảnh - Quay Phim'
           ,NULL);
GO
--- MAT_HANG
INSERT INTO [dbo].[MAT_HANG]
           ([MaMH]
           ,[TenMH]
           ,[GiaTien]
           ,[SLTon]
           ,[HinhAnh]
           ,[MoTa]
           ,[LoaiHang])
     VALUES
           ('DT001', N'Iphone SE 2020', 11290000, 50, 'https://salt.tikicdn.com/cache/280x280/ts/product/3f/d8/da/de6d50aec5f8828eb1d421cb7cce1e35.PNG',NULL, 'DT')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('DT002', N'Samsung Galaxy S20', 13990000, 31,'https://salt.tikicdn.com/cache/200x200/ts/product/74/31/d4/0cd9e5db628772bf1ebfa8e4a7986949.jpg',NULL, 'DT')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('DT003', N'Vsmart Active 3', 2790000, 26, 'https://salt.tikicdn.com/cache/200x200/ts/product/25/1e/b7/6584848947954fac3ef811154bb850d6.jpg',NULL, 'DT')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('PK001', N'Tai nghe Bluetooth Xiaomi', 629000, 55,'https://salt.tikicdn.com/cache/280x280/ts/product/30/48/e2/82dc493d097cebd883305c50ee0c5a65.jpg',NULL, 'PK')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('PK002', N'Chuột Có Dây Logitech B100', 65000, 34, 'https://salt.tikicdn.com/cache/280x280/ts/product/11/95/4d/a9c21fbe61ce96d66c06582a49791381.jpg',NULL,  'PK')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('PK003', N'Bút Cảm Ứng Điện Dung 2 Trong 1 Baseus', 139000, 34, 'https://salt.tikicdn.com/cache/280x280/ts/product/dd/88/00/046f3c0505ccd6f6d36748f656e9878b.jpg',NULL,'PK')
GO


INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('LT001', N'Macbook Air 2017', 18399000, 20, 'https://salt.tikicdn.com/cache/280x280/ts/product/24/1b/e9/0771b005d8b7d4547b2a5fc0012d4721.jpg',NULL, 'LT')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('LT002', N'Laptop Lenovo IdeaPad Slim 3', 10599000, 12, 'https://salt.tikicdn.com/cache/280x280/ts/product/f0/3e/b1/864927f9b6c5b55147350d2904f63629.jpg',NULL,  'LT')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('MA001', N'Máy Ảnh Canon 800D', 13690000, 32, 'https://salt.tikicdn.com/cache/280x280/ts/product/1f/b2/58/2f469d312bfeaede1f49a04dbac96665.jpg',NULL, 'MA')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('MA002', N'Camera IP Wifi Ezviz', 499000, 59, 'https://salt.tikicdn.com/cache/280x280/ts/product/f8/63/4c/e797d306bb71bcdb127c3c9ca61ac4c1.png',NULL, 'MA')
GO

INSERT INTO [dbo].[MAT_HANG]
     VALUES
           ('MA003', N'Máy Quay Gopro Hero 7 (Black)', 7999000, 22, 'https://salt.tikicdn.com/cache/280x280/ts/product/91/13/40/5fe189c57b72258ce51879a20c03a4f1.jpg',NULL, 'MA')
GO
--- KHACH_HANG
INSERT INTO [dbo].[KHACH_HANG]
           ([MaKH]
           ,[TenKH]
           ,[Email]
           ,[DiaChi]
           ,[SDT]
           ,[Username]
           ,[Password])
     VALUES
           ('KH001', N'Hoàng Việt', 'viethoang@gmail.com','227 Nguyễn Văn Cừ', '0909676535', 'hoangviet123', '123')
GO

INSERT INTO [dbo].[KHACH_HANG]
           ([MaKH]
           ,[TenKH]
           ,[Email]
           ,[DiaChi]
           ,[SDT]
           ,[Username]
           ,[Password])
     VALUES
           ('KH002', N'Tú Pro', 'tutran@gmail.com','123 Nguyễn Văn Cừu', '0908124531', 'tutran123', '123')
GO