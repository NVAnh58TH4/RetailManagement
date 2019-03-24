Create Database ChuoiCH;

Use ChuoiCH;

-- Tạo bảng
Create Table Cuahang (
	MaCH char(6) primary key,
	TenCH nvarchar(30),
	Diachi nvarchar(100));

Create Table Nhanvien (
	MaNV char(6) primary key,
	TenNV nvarchar(30) not null,
	NgaySinh smalldatetime,
	Gioitinh nvarchar(3),
	MaCH char(6),
	Foreign key (MaCH) references Cuahang(MaCH));

Create Table Mathang (
	MaH char(6) primary key,
	TenH nvarchar(50),
	Dvitinh nvarchar(10),
	Gia int);

Create Table Khachhang (
	MaKH char(6) primary key,
	TenKH nvarchar(30),
	Diachi nvarchar(100));

Create Table Hoadon (
	MaHD char(6) primary key,
	MaKH char(6) not null,
	MaCH char(6) not null,
	Ngaylap smalldatetime,
	Foreign key (MaKH) references Khachhang(MaKH),
	Foreign key (MaCH) references Cuahang(MaCH));

Create Table ChitietHD (
	MaHD char(6),
	MaH char(6),
	Soluong int,
	Primary key (MaHD, MaH),
	Foreign key (MaHD) references Hoadon(MaHD),
	Foreign key (MaH) references Mathang(MaH));

-- Thêm bản ghi
Insert into Cuahang
Values
	('CH0001', N'Chi nhánh Lê Duẩn', N'120 Lê Duẩn'),
	('CH0002', N'Chi nhánh Hàng Chiếu', N'4A Hàng Chiếu'),
	('CH0003', N'Chi nhánh Đường Thành', N'1 Đường Thành'),
	('CH0004', N'Chi nhánh Nguyễn Thái Học', N'28 Nguyễn Thái Học'),
	('CH0005', N'Chi nhánh Lê Duẩn', N'120 Lê Duẩn'),
	('CH0006', N'Chi nhánh TP HCM', 'TP HCM'),
	('CH0007', N'Chi nhánh Cần Thơ', N'Cần Thơ'),
	('CH0008', N'Chi nhánh Đà Nẵng', N'Đà Nẵng'),
	('CH0009', N'Chi nhánh Huế', N'Huế'),
	('CH0010', N'Chi nhánh Đồng Nai', N'Đồng Nai');

Insert into Nhanvien
Values
	('NV0001', N'Duy Hiếu', '07/11/1998', 'Nam', 'CH0001'),
	('NV0002', N'Huy Bình', '06/15/1998', 'Nam', 'CH0001'),
	('NV0003', N'Phú Hiếu', '10/02/1998', 'Nam', 'CH0002'),
	('NV0004', N'Xuân Hiếu', '04/07/1998', 'Nam', 'CH0002'),
	('NV0005', N'Bá Huy', '12/10/1998', 'Nam', 'CH0003'),
	('NV0006', N'Quốc Hưng', '07/06/1998', 'Nam', 'CH0003'),
	('NV0007', N'Văn Trường', '07/07/1998', 'Nam', 'CH0004'),
	('NV0008', N'Thắng Cảnh', '07/11/1998', 'Nam', 'CH0004'),
	('NV0009', N'Anh Minh', '03/21/1998', 'Nam', 'CH0005'),
	('NV0010', N'Việt Anh', '08/12/1998', 'Nam', 'CH0005'),
	('NV0011', N'Minh Trí', '06/19/1998', 'Nam', 'CH0006'),
	('NV0012', N'Sơn Hưng', '09/25/1998', 'Nam', 'CH0006'),
	('NV0013', N'Đức Thịnh', '11/29/1998', 'Nam', 'CH0007'),
	('NV0014', N'Thùy Dung', '07/11/1998', N'Nữ', 'CH0007'),
	('NV0015', N'Hải Ngọc', '07/11/1998', N'Nữ', 'CH0008'),
	('NV0016', N'Trọng Huy','06/27/1998', 'Nam', 'CH0008'),
	('NV0017', N'Quang Hưng','07/27/1998', 'Nam', 'CH0009'),
	('NV0018', N'Thanh Tùng','05/27/1998', 'Nam', 'CH0009'),
	('NV0019', N'Trọng Tấn','04/27/1998', 'Nam', 'CH0010'),
	('NV0020', N'Thanh Thúy','03/27/1998', N'Nữ', 'CH0010');

Insert into Mathang 
Values
	('MH0001', N'Bánh Nabati', N'Hộp', 43400),
	('MH0002', N'Bánh One One phô mai ngô', N'Gói', 23300),
	('MH0003', N'Bánh Chocopie Cacao', N'Hộp', 47200),
	('MH0004', N'Bánh Ichi Kameda', N'Gói', 15500),
	('MH0005', N'Bánh Richy', N'Gói', 41200),
	('MH0006', N'Sữa Ovaltine', N'Vỉ', 23600),
	('MH0007', N'Bánh Marine Boy', N'Hộp', 12800),
	('MH0008', N'Bánh Mongswell ', N'Hộp', 110000),
	('MH0009', N'Nước tăng lực Red Bull', N'Lon', 9200),
	('MH0010', N'Bánh Custard', N'Hộp', 59500),
	('MH0011', N'Bánh AFC tảo biển', N'Hộp', 26000),
	('MH0012', N'Bánh AFC rau cải', N'Hộp', 26000),
	('MH0013', N'Bánh AFC trà xanh', N'Hộp', 26900),
	('MH0014', N'Bánh mè Gouté', N'Hộp', 52200),
	('MH0015', N'Nước táo ép Vfresh', N'Hộp', 32900),
	('MH0016', N'Bánh One One tôm nướng', N'Gói', 20000),
	('MH0017', N'Bánh Oreo', N'Gói', 13500),
	('MH0018', N'Bánh Cream O', N'Gói', 4800),
	('MH0019', N'Bánh Tiramisu Twist', N'Gói', 36000),
	('MH0020', N'Bánh Chocolate Cream', N'Gói', 36000),
	('MH0021', N'Trà Matcha Tea Plus', N'Chai', 7500),
	('MH0022', N'Nước giải khát Pepsi 330ML', N'Lon', 7500),
	('MH0023', N'Trà sữa Tea Break 345ML', N'Chai', 9000),
	('MH0024', N'Trà Lipton English Breakfast 25 gói', N'Hộp', 57800),
	('MH0025', N'Trà Lipton nhãn vàng 25 gói', N'Hộp', 7500);

Insert into Khachhang 
Values
	('KH0001', N'Minh Hiếu', N'Hà Nội'),
	('KH0002', N'Bá Tường', N'Hà Nội'),
	('KH0003', N'Anh Phi', N'Ninh Bình'),
	('KH0004', N'Nam Khánh', N'Thái Nguyên'),
	('KH0005', N'Xuân Đức', N'Hà Nội'),
	('KH0006', N'Đăng Dương', N'Hưng Yên'),
	('KH0007', N'Vũ Minh', N'Hà Nội'),
	('KH0008', N'Quang Nhật', N'Cà Mau'),
	('KH0009', N'Anh Sơn', N'Đồng Tháp Mười'),
	('KH0010', N'Quang Huy', N'TP HCM'),
	('KH0011', N'Thu Thủy', N'Bình Phước'),
	('KH0012', N'Thu Trang', N'Cần Thơ'),
	('KH0013', N'Manh Hùng', N'Bình Dương'),
	('KH0014', N'Phạm Nam', N'Long An'),
	('KH0015', N'Phương Anh', N'Bến Tre');

Insert into Hoadon 
Values
	('HD0001', 'KH0006', 'CH0006', '01/01/2018'),
	('HD0002', 'KH0014', 'CH0007', '01/02/2018'),
	('HD0003', 'KH0007', 'CH0008', '01/03/2018'),
	('HD0004', 'KH0007', 'CH0010', '03/01/2018'),
	('HD0005', 'KH0013', 'CH0009', '01/04/2018'),
	('HD0006', 'KH0010', 'CH0010', '01/05/2018'),
	('HD0007', 'KH0009', 'CH0009', '01/06/2018'),
	('HD0008', 'KH0011', 'CH0007', '01/08/2018'),
	('HD0009', 'KH0012', 'CH0008', '01/07/2018'),
	('HD0010', 'KH0014', 'CH0006', '01/09/2018'),
	('HD0011', 'KH0013', 'CH0006', '01/10/2018'),
	('HD0012', 'KH0015', 'CH0010', '01/11/2018'),
	('HD0013', 'KH0004', 'CH0009', '01/11/2018'),
	('HD0014', 'KH0001', 'CH0004', '01/11/2018'),
	('HD0015', 'KH0008', 'CH0001', '01/11/2018');

Insert into ChitietHD 
Values
	('HD0001', 'MH0021', 4),
	('HD0001', 'MH0022', 2),
	('HD0002', 'MH0025', 5),
	('HD0002', 'MH0024', 5),
	('HD0003', 'MH0003', 3),
	('HD0004', 'MH0006', 1),
	('HD0004', 'MH0007', 1),
	('HD0005', 'MH0008', 4),
	('HD0006', 'MH0010', 2),
	('HD0007', 'MH0015', 2),
	('HD0007', 'MH0009', 5),
	('HD0008', 'MH0016', 1),
	('HD0008', 'MH0017', 2),
	('HD0009', 'MH0018', 3),
	('HD0009', 'MH0019', 3),
	('HD0010', 'MH0014', 3),
	('HD0010', 'MH0013', 1),
	('HD0010', 'MH0012', 1),
	('HD0011', 'MH0011', 4),
	('HD0011', 'MH0014', 2),
	('HD0011', 'MH0015', 2),
	('HD0012', 'MH0016', 5),
	('HD0012', 'MH0019', 3),
	('HD0012', 'MH0018', 3),
	('HD0013', 'MH0007', 1),
	('HD0013', 'MH0020', 4),
	('HD0014', 'MH0019', 3),
	('HD0014', 'MH0018', 3),
	('HD0014', 'MH0007', 1),
	('HD0015', 'MH0020', 4);

-- Tạo các view
GO
Create view vw_Cuahang
As
	Select * from Cuahang;

GO
Create view vw_NhanVien
As
	Select * from Nhanvien;
GO
	
Create view vw_MatHang
As
	Select * from Mathang;

GO	
Create view vw_KhachHang
As 
	Select * from Khachhang;

GO	
Create view vw_HoaDon
As
	Select * from Hoadon;
GO

Create view vw_CTHD
As
	Select * from ChitietHD;
GO
	
Create view vw_TSLB
As
	Select Mathang.*, Sum(ChiTietHD.SoLuong) as TSLB
	From Mathang, ChitietHD, Hoadon
	Where Mathang.MaH = ChitietHD.MaH and Hoadon.MaHD = ChitietHD.MaHD
	Group by Mathang.MaH, Mathang.TenH, Mathang.Dvitinh, Mathang.Gia
GO

-- Tạo trigger	
-- Kiểm tra ngày sinh
Create trigger trg_CheckNS_NV
On Nhanvien
For insert
As
	If (DATEDIFF(year, (select NgaySinh from inserted), GETDATE()) < 16)
	Begin
		Print(N'Nhập sai dữ liệu, chưa đủ tuổi lao động!')
		Rollback tran
	End
GO

-- Kiểm tra giới tính
Create trigger trg_CheckGT_NV
On Nhanvien
For insert
As
	If ((Select Gioitinh from inserted) not in ('Nam', N'Nữ'))
	Begin
		Print(N'Nhập sai giới tính')
		Rollback tran 
	End
GO

-- Kiểm tra ngày lập hóa đơn
Create trigger trg_CheckNgaylap_HD
On Hoadon
For insert
As
	If ((Select Ngaylap from inserted) > GETDATE() )
	Begin
		Print(N'Ngày lập không hợp lệ!')
		Rollback tran
	End
GO

-- Kiểm tra số lượng bán trong CTHD
Create trigger trg_CheckSL_CTHD
On ChitietHD
For insert
As
	If ((Select Soluong from inserted) < 0 )
	Begin
		Print(N'Số lượng hàng không được âm!')
		Rollback tran
	End
GO

-- Xóa dữ liệu ở bảng cửa hàng
Create trigger trg_DelCH
On Cuahang
Instead of Delete
As
	Begin
		Delete from ChitietHD Where ChitietHD.MaHD in (Select MaHD from Hoadon Where MaCH = (Select MaCH from deleted))
		Delete from Hoadon Where MaCH in (Select MaCH from deleted)
		Delete from Nhanvien Where MaCH in (Select MaCH from deleted)
		Delete from Cuahang Where MaCH in (Select MaCH from deleted)
	End
GO

Create trigger trg_DelMH
On Mathang
Instead of Delete
As
	Begin
		Delete from ChitietHD Where MaH = (Select MaH from deleted)
		Delete from Mathang Where MaH = (Select MaH from deleted)
	End
GO

Create trigger trg_DelKH
On Khachhang
Instead of Delete
As
	Begin
		Delete from ChitietHD Where ChitietHD.MaHD in (Select MaHD from Hoadon Where MaKH = (Select MaKH from deleted))
		Delete from Hoadon Where MaKH = (Select MaKH from deleted)
		Delete from Khachhang Where MaKH = (Select MaKH from deleted)
	End
GO

Create trigger trg_DelHD
On Hoadon
Instead of Delete
As
	Begin
		Delete from ChitietHD Where ChitietHD.MaHD in (Select MaHD from deleted)
		Delete from Hoadon Where MaHD = (Select MaHD from deleted)
	End

-- Tạo stored procedure
GO
Create proc sp_SP_chuaban
As
	Begin
		select MaH as [Mã hàng], TenH as [Tên hàng], Dvitinh as [Đơn vị tính], Gia as [Giá] from Mathang
		where Mathang.MaH not in (select MaH from ChitietHD)
	End

GO
Create proc sp_KH_chuamua
As
	Begin
		select MaKH as [Mã khách hàng], TenKH as [Tên khách hàng], Diachi as [Địa chỉ] from Khachhang
		where MaKH not in (select MaKH from Hoadon)
	End
GO

Create proc sp_FindNV (@Temp nvarchar(30))
As
	Begin
		Select * From Nhanvien Where MaCH like @Temp or TenNV like @Temp
	End
GO

Create proc sp_Thongkedaban_SL
As
	Begin
		Select vw_TSLB.MaH as [Mã hàng],vw_TSLB.TenH as [Tên hàng], vw_TSLB.Dvitinh as [Đơn vị tính], vw_TSLB.Gia as [Giá], TSLB as [Tổng lượng bán], TSLB*Gia as [Tổng tiền]
		From vw_TSLB , Hoadon, ChitietHD
		Where vw_TSLB.MaH = ChitietHD.MaH and ChitietHD.MaHD = Hoadon.MaHD
		Group by vw_TSLB.MaH, vw_TSLB.TenH, vw_TSLB.Dvitinh, vw_TSLB.Gia, TSLB
	End
GO

-- Tạo user-defined function
GO
Create function fn_SP (@TenH nvarchar(30))
returns table as return
(	
	Select vw_TSLB.MaH as [Mã hàng],vw_TSLB.TenH as [Tên hàng], vw_TSLB.Dvitinh as [Đơn vị tính], vw_TSLB.Gia as [Giá], TSLB as [Tổng lượng bán], TSLB*Gia as [Tổng tiền]
	From vw_TSLB, Hoadon, ChitietHD
	Where vw_TSLB.MaH = ChitietHD.MaH and ChitietHD.MaHD = Hoadon.MaHD and vw_TSLB.TenH = @TenH
	Group by vw_TSLB.MaH, vw_TSLB.TenH, vw_TSLB.Dvitinh, vw_TSLB.Gia, TSLB
)
GO

Create function fn_TTKH (@TenCH nvarchar(30))
returns table as return
(
	Select Khachhang.MaKH as [Mã khách], Khachhang.TenKH as [Tên khách], Khachhang.Diachi as [Địa chỉ] from Khachhang, Hoadon ,Cuahang
	Where Hoadon.MaKH = Khachhang.MaKH and Hoadon.MaCH = Cuahang.MaCH and Cuahang.TenCH = @TenCH
)
GO

-- Login/Permission 
sp_droplogin 'ADMIN'
go
sp_addlogin'QTV','58TH1'
GO
sp_grantdbaccess 'QTV','Quanly'
GO
sp_addrole'Quan_tri'
-- Cấp quyền thao tác trên các bảng
grant select,insert,update,delete on Cuahang to Quan_tri
grant select,insert,update,delete on Nhanvien to Quan_tri
grant select,insert,update,delete on Khachhang to Quan_tri
grant select,insert,update,delete on Mathang to Quan_tri
grant select,insert,update,delete on Hoadon to Quan_tri
grant select,insert,update,delete on ChiTietHD to Quan_tri
-- Cấp quyền thao tác các function, stored procedure
grant execute on sp_SP_chuaban to Quan_tri
grant execute on sp_KH_chuamua to Quan_tri
grant execute on sp_FindNV to Quan_tri
grant execute on sp_Thongkedaban_SL to Quan_tri
grant select on fn_SP to Quan_tri
grant select on fn_TTKH to Quan_tri
-- Cấp quyền trên view
grant select on vw_Cuahang to Quan_tri
grant select on vw_NhanVien to Quan_tri
grant select on vw_MatHang to Quan_tri
grant select on vw_KhachHang to Quan_tri
grant select on vw_HoaDon to Quan_tri
grant select on vw_CTHD to Quan_tri
grant select on vw_TSLB to Quan_tri
GO
exec sp_addrolemember'Quan_tri','Quanly'
GO


sp_addlogin'Nguoidung',''
GO
sp_grantdbaccess 'Nguoidung','Nhanvien'
GO

sp_addrole'Nhan_vien'
grant select,insert,update,delete on Khachhang to Nhan_vien
grant select,insert,update,delete on Mathang to Nhan_vien
grant select,insert,update,delete on Hoadon to Nhan_vien
grant select,insert,update,delete on ChiTietHD to Nhan_vien
grant select on vw_MatHang to Nhan_vien
grant select on vw_KhachHang to Nhan_vien
grant select on vw_HoaDon to Nhan_vien
grant select on vw_CTHD to Nhan_vien
grant select on vw_TSLB to Nhan_vien
grant execute on sp_SP_chuaban to Nhan_vien
grant execute on sp_KH_chuamua to Nhan_vien
grant execute on sp_FindNV to Nhan_vien
grant execute on sp_Thongkedaban_SL to Nhan_vien
grant select on fn_SP to Nhan_vien
grant select on fn_TTKH to Nhan_vien
GO
sp_addrolemember'Nhan_vien','Nhanvien'

Select * from Cuahang