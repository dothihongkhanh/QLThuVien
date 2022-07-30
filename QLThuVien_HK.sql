create database QLTHUVIEN_HongKhanh
use QLTHUVIEN_HongKhanh
create table DanhMuc
(
	maDanhMuc char(7) not null primary key,
	tenDanhMuc nvarchar(50) null
)
create table DocGia
(
	maDocGia char(7) not null primary key,
	tenDocGia nvarchar(50) null,
	ngaySinh date null,
	gioiTinh nvarchar(3) null,
	sdt varchar(11)
)
create table Sach
(
	maSach char(7) not null primary key,
	maDanhMuc char (7) not null,
	tenSach nvarchar(50) null,
	theLoai nvarchar (50) null,
	tacGia nvarchar(50) null,
	nhaXuatBan nvarchar(50) null,
	namXuatBan int null,
	soLuongCon int null,
	foreign key (maDanhMuc) references DanhMuc(maDanhMuc)
	--thiết lập ràng buộc phụ thuộc khi Xóa/Update
		on delete
			cascade
		on update 
			cascade
)
create table PhieuMuon
(
	maPM char(7) not null primary key,
	maDocGia char(7) not null,
	tenNhanVien nvarchar(50) null,
	ngayMuon date null,
	soNgayMuon int null,
	foreign key (maDocGia) references DocGia(maDocGia)
	--thiết lập ràng buộc phụ thuộc khi Xóa/Update
		on delete
			cascade
		on update 
			cascade
)
create table ChiTietPhieuMuon
(
	maPM char(7) not null,
	maSach char(7) not null,
	ngayTra date null
	primary key (maPM, maSach),
	foreign key (maPM) references PhieuMuon(maPM),
	foreign key (maSach) references Sach(maSach)
	--thiết lập ràng buộc phụ thuộc khi Xóa/Update
		on delete
			cascade
		on update 
			cascade
)
insert into DanhMuc
values 
	('DM01',N'Chuyên ngành điện - điện tử'),
	('DM02',N'Chuyên ngành công nghệ thông tin'),
	('DM03',N'Chuyên ngành Xây dựng')
set dateformat dmy
insert into DocGia 
values 
	('DG001',N'Nguyễn Văn An','01/05/2002',N'Nam','01245874596'),
	('DG002',N'Lê Lan Anh','12/03/2002',N'Nữ','0214758437'),
	('DG003',N'Nguyễn Văn Quân','25/01/2002',N'Nam','0128459658')
insert into Sach  
values 
	('S001','DM01',N'Bài giảng cấu kiện điện tử',N'Giáo trình',N'Nguyễn Văn Thịnh', N'Trường DHSPKTDN', 2016, 50),
	('S002','DM02',N'Bài giảng Lập trình trực quan',N'Giáo trình',N'Hoàng Thị Mỹ Lệ', N'Trường DHSPKTDN', 2016, 80),
	('S003','DM02',N'Bài tập lập trình java cơ bản',N'Sách bài tập',N'Huỳnh Công Pháp',N'Thông tin -Truyền thông - Hà Nội', 2014, 100),
	('S004','DM03',N'Cơ khí đại cương',N'Giáo trình',N'Hoàng Tùng', N'Khoa học Kỹ Thuật - Hà Nội', 1998, 10)
insert into PhieuMuon
values
	('PM001','DG001',N'An','01/06/2022',5),
	('PM002','DG002',N'Ngân','12/05/2022',7),
	('PM003','DG003',N'Ngân','05/04/2022',7)
insert into ChiTietPhieuMuon
values
	('PM001','S001','06/06/2022'),
	('PM001','S002','06/06/2022'),
	('PM002','S001','18/05/2022'),
	('PM002','S003','18/05/2022'),
	('PM003','S004','12/04/2022')
