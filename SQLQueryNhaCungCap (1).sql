CREATE DATABASE NguyenBaTung_98880_3
USE NguyenBaTung_98880_3

CREATE TABLE NhaSanXuat_8(
	MaNhaSanXuat NVARCHAR(3) PRIMARY KEY,
	TenNhaSanXuat NVARCHAR(50) NOT NULL UNIQUE,
	DiaChi NVARCHAR(100) NOT NULL,
	DienThoai CHAR(10) NOT NULL UNIQUE,
	NgayThanhLap DATE NOT NULL
)
CREATE TABLE NhaCungCap_8(
	MaNhaCungCap NVARCHAR(3) PRIMARY KEY,
	TenNhaCungCap NVARCHAR(50) NOT NULL UNIQUE,
	Email NVARCHAR(50) NOT NULL UNIQUE,
	NguoiDaiDien NVARCHAR(50) NOT NULL,
	NgayBatDauHopTac DATE NOT NULL
)


CREATE TABLE SanPham_0(
	MaSanPham NVARCHAR(3) PRIMARY KEY,
	TenSanPham NVARCHAR(50) NOT NULL UNIQUE,
	MaNhaCungCap NVARCHAR(3) NOT NULL,
	MaNhaSanXuat NVARCHAR(3) NOT NULL,
	FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap_8(MaNhaCungCap),
	FOREIGN KEY (MaNhaSanXuat) REFERENCES NhaSanXuat_8(MaNhaSanXuat)
)

CREATE PROCEDURE ThemNCC
    @MaNhaCungCap NVARCHAR(3),
	@TenNhaCungCap NVARCHAR(50),
	@Email NVARCHAR(50), 
	@NguoiDaiDien NVARCHAR(50), 
	@NgayBatDauHopTac DATE 
AS
BEGIN
    DECLARE @Dem INT;
    DECLARE @Loi NVARCHAR(100);
    SET @Loi = '';
    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE MaNhaCungCap=@MaNhaCungCap);
    IF @Dem > 0
        SET @Loi = @Loi + N'Mã nhà cung cấp đã tồn tại. ';

    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE TenNhaCungCap = @TenNhaCungCap);
    IF @Dem > 0
        SET @Loi = @Loi + N'Tên nhà cung cấp đã tồn tại. ';

	SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE Email = @Email);
    IF @Dem > 0
        SET @Loi = @Loi + N'Email đã tồn tại. ';

    IF @Loi <> ''
    BEGIN
        RAISERROR(@Loi, 16, 1);
        RETURN;
    END
    INSERT INTO NhaCungCap_8(MaNhaCungCap, TenNhaCungCap, Email, NguoiDaiDien, NgayBatDauHopTac)
    VALUES (@MaNhaCungCap, @TenNhaCungCap, @Email, @NguoiDaiDien, @NgayBatDauHopTac);
END;
ALTER PROCEDURE SuaNCC
    @MaNhaCungCap NVARCHAR(3),
	@TenNhaCungCap NVARCHAR(50),
	@Email NVARCHAR(50), 
	@NguoiDaiDien NVARCHAR(50), 
	@NgayBatDauHopTac DATE
AS
BEGIN
    DECLARE @Dem INT;
    DECLARE @Loi NVARCHAR(100);
    SET @Loi = '';

    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE MaNhaCungCap = @MaNhaCungCap);
	
    IF @Dem = 0
    BEGIN
        RAISERROR(N'Mã nhà cung cấp không tồn tại.', 16, 1);
        RETURN;
    END
    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE TenNhaCungCap = @TenNhaCungCap AND MaNhaCungCap <> @MaNhaCungCap);
    IF @Dem > 0
        SET @Loi = @Loi + N'Tên nhà cung cấp đã tồn tại. ';

    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE Email = @Email AND MaNhaCungCap <> @MaNhaCungCap);
    IF @Dem > 0
        SET @Loi = @Loi + N'Email nhà cung cấp đã tồn tại. ';

    IF @Loi <> ''
    BEGIN
        RAISERROR(@Loi, 16, 1);
        RETURN;
    END

    UPDATE NhaCungCap_8
    SET	
		
        TenNhaCungCap = @TenNhaCungCap,
        Email = @Email,
        NguoiDaiDien = @NguoiDaiDien,
		NgayBatDauHopTac = @NgayBatDauHopTac
    WHERE MaNhaCungCap = @MaNhaCungCap
END;
EXEC SuaNCC
	@MaNhaCungCap = 'NC4',
	@TenNhaCungCap =N'Nhà cung cấp 2',
	@Email = N'13eee',
	@NguoiDaiDien = N'Hùng',
	@NgayBatDauHopTac = '2024-11-04'
ALTER PROCEDURE XoaNCC
    @MaNhaCungCap NVARCHAR(3)

AS
BEGIN
	DECLARE @Loi NVARCHAR(100);
	SET @Loi = '';
    DECLARE @Dem INT;
	
   SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE MaNhaCungCap = @MaNhaCungCap);
    IF @Dem = 0
    BEGIN
        RAISERROR(N'Mã nhà cung cấp không tồn tại.', 16, 1);
        RETURN;
    END
	SET @Dem = (SELECT COUNT(*) FROM SanPham_0 WHERE MaNhaCungCap = @MaNhaCungCap);
    IF @Dem > 0
    BEGIN
        RAISERROR(N'Không xóa được do còn liên quan đến sản phẩm', 16, 1);
        RETURN;
    END 

    DELETE FROM NhaCungCap_8
    WHERE MaNhaCungCap = @MaNhaCungCap;
END;


CREATE PROCEDURE SuaSP
    @MaSanPham NVARCHAR(3),
    @TenSanPham NVARCHAR(50),
    @MaNhaCungCap NVARCHAR(3),
    @MaNhaSanXuat NVARCHAR(3)
AS
BEGIN
    DECLARE @Dem INT;
    DECLARE @Loi NVARCHAR(100);
    SET @Loi = '';

    SET @Dem = (SELECT COUNT(*) FROM SanPham_0 WHERE MaSanPham = @MaSanPham);
    IF @Dem = 0
    BEGIN
        RAISERROR(N'Mã sản phẩm không tồn tại.', 16, 1);
        RETURN;
    END
    SET @Dem = (SELECT COUNT(*) FROM SanPham_0 WHERE TenSanPham = @TenSanPham AND MaSanPham <> @MaSanPham);
    IF @Dem > 0
        SET @Loi = @Loi + N'Tên sản phẩm đã tồn tại. ';

    SET @Dem = (SELECT COUNT(*) FROM NhaCungCap_8 WHERE MaNhaCungCap = @MaNhaCungCap);
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã nhà cung cấp không tồn tại. ';

    SET @Dem = (SELECT COUNT(*) FROM NhaSanXuat_8 WHERE MaNhaSanXuat = @MaNhaSanXuat);
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã nhà sản xuất không tồn tại. ';

    IF @Loi <> ''
    BEGIN
        RAISERROR(@Loi, 16, 1);
        RETURN;
    END
    UPDATE SanPham_0
    SET 
        TenSanPham = @TenSanPham,
        MaNhaCungCap = @MaNhaCungCap,
        MaNhaSanXuat = @MaNhaSanXuat
    WHERE MaSanPham = @MaSanPham;
END;
EXEC SuaSP
	@MaSanPham = N'SP1',
    @TenSanPham = N'Sữa',
    @MaNhaCungCap = 'NC1',
    @MaNhaSanXuat = 'NS1'

CREATE FUNCTION TimKiemNCC
(
	@MaNhaCungCap NVARCHAR(3),
	@TenNhaCungCap NVARCHAR(50),
	@Email NVARCHAR(50),
	@NguoiDaiDien NVARCHAR(50)
)
RETURNS TABLE
RETURN(
	SELECT ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.Email, ncc.NguoiDaiDien, ncc.NgayBatDauHopTac
	FROM NhaCungCap_8 ncc
	WHERE 
	(ncc.MaNhaCungCap LIKE '%' + @MaNhaCungCap + '%' OR @MaNhaCungCap IS NULL) AND
	(ncc.TenNhaCungCap LIKE + '%' + @TenNhaCungCap + '%' OR @TenNhaCungCap IS NULL) AND
	(ncc.Email LIKE '%' + @Email + '%' OR @Email IS NULL) AND
	(ncc.NguoiDaiDien LIKE '%' + @NguoiDaiDien + '%' OR @NguoiDaiDien IS NULL)
);
ALTER FUNCTION TimKiemNSX
(	
	@string NVARCHAR(50)

)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        nsx.MaNhaSanXuat,
        nsx.TenNhaSanXuat,
        nsx.DiaChi,
        nsx.DienThoai,
        nsx.NgayThanhLap

    FROM 
        NhaSanXuat_8 nsx
    
    WHERE 
        (@string IS NULL OR nsx.MaNhaSanXuat LIKE '%' + @string + '%') OR
        (@string IS NULL OR nsx.TenNhaSanXuat LIKE '%' + @string + '%') OR
        (@string IS NULL OR nsx.DiaChi LIKE '%' + @string + '%') OR
        (@string IS NULL OR nsx.DienThoai LIKE '%' + @string + '%')

);
SELECT * FROM TimKiemNSX(890);


SELECT MaNhaCungCap, TenNhaCungCap, Email, NguoiDaiDien, NgayBatDauHopTac FROM NhaCungCap_8
