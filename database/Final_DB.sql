
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

create table DocGia(
	MaDocGia char(4) primary key,
	TenDocGia nchar(50) not null,
	DiaChi nchar(50),
	SDT char(10) not null
)
go

create table TheThuVien(
	SoThe int identity (1,1) primary key,
	MaDocGia char(4) references DocGia(MaDocGia),
	NgayBatDau date,
	NgayHetHan date,
	GhiChu nchar(100)
)
go


create table QuanLy(
	MaNhanVien char(4) primary key,
	TenNhanVien nchar(50) not null,
	NgaySinh date,
	SDT char(10) not null,
	MatKhau char(10) not null
)
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