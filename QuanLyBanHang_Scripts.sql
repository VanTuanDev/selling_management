USE QuanLyBanHang
GO

-- AUTHENTICATION --
CREATE PROCEDURE sp_DangNhap
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @hashedPassword NVARCHAR(50);
    SELECT @hashedPassword = MatKhau
    FROM TaiKhoan
    WHERE TenDangNhap = @username;

    IF @hashedPassword IS NOT NULL AND @hashedPassword = HASHBYTES('SHA2_256', @password)
		BEGIN
			SELECT qdn.TenQuyen
			FROM TaiKhoan tk 
			INNER JOIN QuyenDangNhap qdn ON tk.MaQuyen = qdn.MaQuyen
			WHERE tk.TenDangNhap = @username;
		END
    ELSE
		BEGIN
			PRINT N'Tên đăng nhập hoặc mật khẩu không chính xác.';
		END;
END;
GO

-- CHANGE PASSWORD --
CREATE PROCEDURE sp_ThayDoiMatKhau
    @TenDangNhap NVARCHAR(50),
    @MatKhauCu NVARCHAR(50),
    @MatKhauMoi NVARCHAR(50)
AS
BEGIN
    DECLARE @HashedMatKhauCu varbinary(256);
    DECLARE @HashedMatKhauMoi varbinary(256);

    SET @HashedMatKhauCu = HASHBYTES('SHA2_256', @MatKhauCu);
    SET @HashedMatKhauMoi = HASHBYTES('SHA2_256', @MatKhauMoi);

    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @HashedMatKhauCu)
    BEGIN
        UPDATE TaiKhoan SET MatKhau = @HashedMatKhauMoi WHERE TenDangNhap = @TenDangNhap AND MatKhau = @HashedMatKhauCu  
        
        SELECT 1 AS Result
    END
    ELSE
    BEGIN
        SELECT 0 AS Result
    END
END
GO


-- GET LIST ACCOUNT --
CREATE PROCEDURE sp_LayDanhSachTaiKhoan
AS
BEGIN
    SET NOCOUNT ON;

    SELECT tk.TenDayDu, tk.TenDangNhap, qdn.TenQuyen 
    FROM TaiKhoan tk 
    INNER JOIN QuyenDangNhap qdn ON tk.MaQuyen = qdn.MaQuyen;
END;
GO

-- CREATE ACCOUNT --
CREATE PROCEDURE sp_ThemTaiKhoan
    @TenDangNhap nvarchar(50),
    @MatKhau nvarchar(50),
    @TenDayDu nvarchar(100),
    @MaQuyen nchar(1)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap)
    BEGIN
        DECLARE @HashedPassword varbinary(256);
        SET @HashedPassword = HASHBYTES('SHA2_256', @MatKhau); 

        INSERT INTO TaiKhoan (TenDangNhap, MatKhau, TenDayDu, MaQuyen)
        VALUES (@TenDangNhap, @HashedPassword, @TenDayDu, @MaQuyen);

        PRINT N'Tài khoản đã được thêm thành công.';
    END
    ELSE
    BEGIN
        PRINT N'Tên đăng nhập đã tồn tại.';
    END
END
GO

-- UPDATE ACCOUNT --
CREATE PROCEDURE sp_SuaTaiKhoan
    @TenDangNhap nvarchar(50),
    @TenDayDu nvarchar(100),
    @TenQuyen nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaQuyen nchar(1);
    SELECT @MaQuyen = MaQuyen
    FROM QuyenDangNhap
    WHERE TenQuyen = @TenQuyen;

    UPDATE TaiKhoan
    SET TenDayDu = @TenDayDu,
        MaQuyen = @MaQuyen
    WHERE TenDangNhap = @TenDangNhap;
END;
GO

-- DELETE ACCOUNT --
CREATE PROCEDURE sp_XoaTaiKhoan
    @TenDangNhap NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON; 

    DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap;
    DECLARE @RowsAffected INT;
    SET @RowsAffected = @@ROWCOUNT;
    SELECT @RowsAffected AS RowsAffected; 
END
GO

-- GET LIST CUSTOMER --
CREATE PROCEDURE sp_LayDanhSachKhachHang
AS
BEGIN
    SELECT * FROM KhachHang;
END
GO

-- CREATE CUSTOMER --
CREATE PROCEDURE sp_ThemKhachHang
    @MaKhachHang nchar(10),
    @TenKhachHang nvarchar(50)
AS
BEGIN
    INSERT INTO KhachHang (MaKhachHang, TenKhachHang)
    VALUES (@MaKhachHang, @TenKhachHang)
END
GO

-- UPDATE CUSTOMER --
CREATE PROCEDURE sp_SuaKhachHang
    @MaKhachHang nchar(10),
    @TenKhachHang nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON; 

    UPDATE KhachHang 
    SET TenKhachHang = @TenKhachHang 
    WHERE MaKhachHang = @MaKhachHang; 
END
GO

-- DELETE CUSTOMER -- 
CREATE PROCEDURE sp_XoaKhachHang
    @MaKhachHang NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON; 

    DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang
    DECLARE @RowsAffected INT;
    SET @RowsAffected = @@ROWCOUNT;
    SELECT @RowsAffected AS RowsAffected; 
END
GO

-- GET LIST PRODUCT --
CREATE PROCEDURE sp_LayDanhSachSanPham
AS
BEGIN
	SET NOCOUNT ON;

    SELECT sp.MaSanPham, sp.TenSanPham, dvt.TenDVT, dm.TenDanhMuc, sp.DonGia 
	FROM SanPham sp 
	INNER JOIN DonViTinh dvt ON sp.MaDVT = dvt.MaDVT 
	INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc
END
GO

-- CREATE PRODUCT --
CREATE PROCEDURE sp_ThemSanPham
    @MaSanPham nchar(10),
    @TenSanPham nvarchar(50),
    @MaDVT nvarchar(2),
    @MaDanhMuc nchar(10),
    @DonGia decimal(18, 0)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSanPham = @MaSanPham)
    BEGIN
        INSERT INTO SanPham (MaSanPham, TenSanPham, MaDVT, MaDanhMuc, DonGia)
        VALUES (@MaSanPham, @TenSanPham, @MaDVT, @MaDanhMuc, @DonGia);

        PRINT N'Sản phẩm đã được thêm thành công.';
    END
    ELSE
    BEGIN
        PRINT N'Sản phẩm với mã ' + @MaSanPham + N' đã tồn tại.';
    END
END
GO

-- UPDATE PRODUCT --
CREATE PROCEDURE sp_SuaSanPham
    @MaSanPham nchar(10),
    @TenSanPham nvarchar(50),
    @TenDVT nvarchar(50),
    @TenDanhMuc nvarchar(50),
    @DonGia decimal(18, 0)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaDVT nvarchar(2);
    DECLARE @MaDanhMuc nchar(10);

    SELECT @MaDVT = MaDVT FROM DonViTinh WHERE TenDVT = @TenDVT;

    SELECT @MaDanhMuc = MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = @TenDanhMuc;

    IF EXISTS (SELECT 1 FROM SanPham WHERE MaSanPham = @MaSanPham)
    BEGIN
        UPDATE SanPham
        SET TenSanPham = @TenSanPham,
            MaDVT = @MaDVT,
            MaDanhMuc = @MaDanhMuc,
            DonGia = @DonGia
        WHERE MaSanPham = @MaSanPham;

        PRINT N'Thông tin sản phẩm đã được cập nhật thành công.';
    END
    ELSE
    BEGIN
        PRINT N'Không tìm thấy sản phẩm có mã ' + @MaSanPham;
    END
END
GO

-- DELETE PRODUCT --
CREATE PROCEDURE sp_XoaSanPham
    @MaSanPham nchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM SanPham WHERE MaSanPham = @MaSanPham)
    BEGIN
        DELETE FROM SanPham WHERE MaSanPham = @MaSanPham;
        PRINT N'Sản phẩm đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT N'Không tìm thấy sản phẩm có mã ' + @MaSanPham;
    END
END
GO

-- GET LIST CATEGORY --
CREATE PROCEDURE sp_LayDanhSachDanhMuc
AS
BEGIN
    SELECT * FROM DanhMucSanPham;
END
GO

-- CREATE CATEGORY --
CREATE PROCEDURE sp_ThemDanhMuc
    @MaDanhMuc nchar(10),
    @TenDanhMuc nvarchar(50)
AS
BEGIN
    INSERT INTO DanhMucSanPham(MaDanhMuc, TenDanhMuc)
    VALUES (@MaDanhMuc, @TenDanhMuc)
END
GO

-- UPDATE CATEGORY --
CREATE PROCEDURE sp_SuaDanhMuc
    @MaDanhMuc nchar(10),
    @TenDanhMuc nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON; 

    UPDATE DanhMucSanPham 
    SET TenDanhMuc = @TenDanhMuc 
    WHERE @MaDanhMuc = MaDanhMuc; 
END
GO

-- DELETE CATEGORY --
CREATE PROCEDURE sp_XoaDanhMuc
    @MaDanhMuc NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON; 

    DELETE FROM DanhMucSanPham WHERE @MaDanhMuc = MaDanhMuc
    DECLARE @RowsAffected INT;
    SET @RowsAffected = @@ROWCOUNT;
    SELECT @RowsAffected AS RowsAffected; 
END
GO

-- GET LIST PRODUCT --
CREATE PROCEDURE sp_LayDanhSachSanPhamBanHang
AS
BEGIN
	SET NOCOUNT ON;

    SELECT sp.TenSanPham, dm.TenDanhMuc, dvt.TenDVT, sp.DonGia 
	FROM SanPham sp 
	INNER JOIN DonViTinh dvt ON sp.MaDVT = dvt.MaDVT 
	INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc
END
GO

-- GET LIST BILL --
CREATE PROCEDURE sp_LayDanhSachHoaDon
AS
BEGIN
	SET NOCOUNT ON;

    SELECT HD.MaHoaDon, KH.TenKhachHang, HD.TinhTrang
    FROM HoaDon HD
    INNER JOIN KhachHang KH ON HD.MaKhachHang = KH.MaKhachHang;
END
GO

-- CREATE BILL --
CREATE PROCEDURE sp_TaoHoaDon
    @MaKhachHang nchar(10),
    @TinhTrang nchar(1)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO HoaDon (MaKhachHang, TinhTrang)
    VALUES (@MaKhachHang, @TinhTrang);

    SELECT SCOPE_IDENTITY() AS MaHoaDon; 
END
GO

-- CREATE BILL DETAIL --
CREATE PROCEDURE sp_TaoChiTietHoaDon
    @MaHoaDon INT,
    @MaSanPham nchar(10),
    @SoLuongDat int,
    @ThanhTien decimal(18, 0)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHoaDon = @MaHoaDon)
    BEGIN
        PRINT N'MaHoaDon không tồn tại';
        RETURN;
    END;

    INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuongDat, ThanhTien)
    VALUES (@MaHoaDon, @MaSanPham, @SoLuongDat, @ThanhTien);
END
GO

-- UPDATE STATUS BILL --
CREATE PROCEDURE sp_CapNhatTrangThaiHoaDon
    @MaHoaDon INT,
    @TinhTrang nchar(1)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHoaDon = @MaHoaDon)
    BEGIN
        PRINT N'MaHoaDon không tồn tại';
        RETURN;
    END;

    UPDATE HoaDon
    SET TinhTrang = @TinhTrang
    WHERE MaHoaDon = @MaHoaDon;
END
GO

-- GET BILL DETAIL --
CREATE PROCEDURE sp_LayChiTietHoaDon
    @MaHoaDon INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CTHD.MaHoaDon, SP.TenSanPham, CTHD.SoLuongDat, CTHD.ThanhTien
    FROM ChiTietHoaDon CTHD
    INNER JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSanPham
    WHERE CTHD.MaHoaDon = @MaHoaDon;
END
GO

CREATE PROCEDURE sp_LayTenKhachHang
	@MaHoaDon INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT kh.TenKhachHang 
	FROM HoaDon hd 
	INNER JOIN KhachHang kh 
	ON hd.MaKhachHang = kh.MaKhachHang;
END
GO