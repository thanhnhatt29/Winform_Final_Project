create database MUONSACH
go
use MUONSACH
go

create table QuanLi(
	username char(50) primary key,
	passw char(20)
)

create table Sach(
	IDSach char(10) primary key,
	TenSach char(50),
	TacGia char(50) null,
	Soluong int default 1,
	Theloai char(20)
)

create table DocGia(
	IDDocGia char(10) primary key,
	Ten char(50),
	CMND char(20),
	SoDienThoai char(10)
)

create table MuonTra(
	IDSach char(10) references Sach(IDSach),
	IDDocGia char(10) references DocGia(IDDocGia),
	NgayGiaoDich date,
	HanhDong char(10),--Muon/Tra
	primary key (IDSach,IDDocGia,NgayGiaoDich)
)

create table Muon(
	IDSach char(10) references Sach(IDSach),
	IDDocGia char(10) references DocGia(IDDocGia),
	NgayMuon date,
	primary key (IDSach,IDDocGia,NgayMuon)
)

