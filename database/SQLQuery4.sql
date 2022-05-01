create database QLTHUVIEN
go 
use QLTHUVIEN
go
-- drop table TacGia
create table TacGia(
	MaTacGia char(4) primary key,
	TenTacGia nchar(50) not null,
	GhiChu nchar(100)
)
go
insert into TacGia Values('NNA', N'Nguyễn Nhật Ánh ', ' ')
insert into TacGia Values('PLT',N'Plato ', ' ')
insert into TacGia Values('NP',  N'Nguyên Phong ', ' ')
insert into TacGia Values('JH',  N'Jaroslav Hašek ', ' ')
go

create table DocGia(
	MaDocGia char(4) primary key,
	TenDocGia nchar(50) not null,
	DiaChi nchar(50),
	SDT char(10) not null
)
go
insert into DocGia Values('BNK', N'Bùi Ngọc Khanh', ' 175 Giang Vo, Ha Noi','0937593869')
insert into DocGia Values('TTCL',N'Trịnh THị Cẩm Ly ', '81 Tran Hung Dao, Ha Noi ','0937593886')
insert into DocGia Values('NNH',  N'Nguyễn Ngọc Hoàng ', '35 Tran Quoc Toan, Ha Noi ','0936579107')
go
create table TheThuVien(
	SoThe int identity (1,1) primary key,
	MaDocGia char(4) references DocGia(MaDocGia),
	NgayBatDau date,
	NgayHetHan date,
	GhiChu nchar(100)
)
go
insert into TheThuVien Values ('BNK','2021-11-15','2025-11-30',' ')
insert into TheThuVien Values ('TTCL','2022-1-5','2026-1-5',' ')
insert into TheThuVien Values ('NNH','2022-1-15','2026-1-15',' ')
go
create table QuanLy(
	MaNhanVien char(4) primary key,
	TenNhanVien nchar(50) not null,
	NgaySinh date,
	SDT char(10) not null,
	MatKhau char(10) not null
)
go
insert into  QuanLy Values('HHN', N'Huỳnh Hiếu Nghĩa', '2002-4-29','0937593869','34653')
insert into  QuanLy Values('TTN',N'Trần Thị Nữ ', '2002-2-9','0937593886','24546')
insert into QuanLy Values('NTD',N'Nguyễn Thị Diệu ', '2002-7-10','0937593886','43657')
go
create table Sach(
	MaSach char(4),
	TenSach nchar(100) not null,
	MaTacGia char(4) references TacGia(MaTacGia),
	TenTheLoai nchar(50) not null,
	NamXuatBan char(4),
	ViTri nchar(50),
	SoLuongConLai int not null
	primary key(MaSach)
)
go
insert into  Sach Values('MK1', N'Vận Mệnh Người Lính Tốt', 'JH','Tiểu Thuyết-Lịch Sử','1921','55 Quang Trung, Ha Noi',4)
insert into  Sach Values('MK2', N'Con Chó Nhỏ Mang Giỏ Hoa Hồng', 'NNA','Lãng Mạn','2019','161B Ly Chinh Thang, TPHCM',8)
insert into  Sach Values('MK3', N'Muôn Kiếp Nhân Sinh', 'NP','Triết Học','2017','So 24 Quang Trung, Ha Noi',6)
insert into  Sach Values('MK4', N'Cộng Hòa Plato', 'PLT','Triết Học- Chính Trị','2018','35 Tran Quoc Toan, Ha Noi',2)
insert into  Sach Values('MK5', N'Cây Chuối Non Đi Giày Xanh', 'NNA','Lãng Mạn','1921','175 Giang Vo, Ha Noi',1)
go

create table MuonTra(
	MaMuonTra int identity (1,1) primary key,
	MaSach char(4) references Sach(MaSach),
	SoThe int references TheThuVien(SoThe),
	MaNhanVien char(4) references QuanLy(MaNhanVien),
	NgayMuon date not null,
	GhiChu nchar(100),
	Da_Tra bit default(0),
	NgayTra date
)
go
insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK2',3,'NTD','2022-9-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK4',2,'TTN','2022-2-26',' ',1,'2022-11-5')
insert into MuonTra Values ('MK4',2,'TTN','2022-4-15',' ',0,'2022-8-2')
insert into MuonTra Values ('MK3',3,'NTD','2022-9-15',' ',1,'2022-10-30')
go