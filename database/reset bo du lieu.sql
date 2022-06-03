USE QLTHUVIEN 

Delete from MuonTra
Delete from sach
Delete from QuanLy
Delete from TheThuVien
Delete from DocGia
Delete from TacGia
Go

DBCC CHECKIDENT('TheThuVien', RESEED, 0)
DBCC CHECKIDENT('MuonTra', RESEED, 0)
go

insert into TacGia Values('NNA', N'Nguyễn Nhật Ánh ', ' ')
insert into TacGia Values('PLT',N'Plato ', ' ')
insert into TacGia Values('NP',  N'Nguyên Phong ', ' ')
insert into TacGia Values('JH',  N'Jaroslav Hašek ', ' ')
insert into TacGia Values('VG', N'Victor Hugo ', ' ')
go

insert into DocGia Values('BNK', N'Bùi Ngọc Khanh', ' 175 Giang Vo, Ha Noi','0937593869')
insert into DocGia Values('TTCL',N'Trịnh THị Cẩm Ly ', '81 Tran Hung Dao, Ha Noi ','0937593886')
insert into DocGia Values('NNH',  N'Nguyễn Ngọc Hoàng ', '35 Tran Quoc Toan, Ha Noi ','0936579107')
insert into DocGia Values('LTD', N'Lê Trí Dũng', ' 175 Hung Dao, Ha Noi','0937593869')
insert into DocGia Values('TTC',N'Trương Thành Công ', '81 Duong Dinh Chieu, Ha Noi ','0937593886')
insert into DocGia Values('NNM',  N'Nguyễn Nhật Minh ', '35 Pham Ngu Lao, Ha Noi ','0936573407')
insert into DocGia Values('TTCT',N'Trịnh THị Cẩm Tú ', '21 Giang Vo, Ha Noi ','0937593324')
insert into DocGia Values('NGB',  N'Nguyễn Gia Bảo ', '35 Tran Quoc Toan, Ha Noi ','0936572307')
insert into DocGia Values('TTK', N'Trần Trọng Kim', ' 243 Mac Dinh Chi, Ha Noi','0937593869')
Go

insert into TheThuVien Values ('BNK','2021-11-15','2025-11-30',' ')
insert into TheThuVien Values ('TTCL','2022-1-5','2026-1-5',' ')
insert into TheThuVien Values ('NNH','2022-1-15','2026-1-15',' ')
insert into TheThuVien Values ('LTD','2021-1-3','2025-11-30',' ')
insert into TheThuVien Values ('TTC','2022-1-6','2026-1-5',' ')
insert into TheThuVien Values ('NNM','2022-1-7','2026-1-15',' ')
insert into TheThuVien Values ('TTK','2021-11-15','2025-11-30',' ')
insert into TheThuVien Values ('NGB','2022-10-5','2025-1-8',' ')
insert into TheThuVien Values ('TTCT','2022-3-20','2026-3-6',' ')

go

insert into  QuanLy Values('HHN', N'Huỳnh Hiếu Nghĩa', '2002-4-29','0937593869','34653')
insert into  QuanLy Values('TTN',N'Trần Thị Nữ ', '2002-2-9','0937593886','24546')
insert into QuanLy Values('NTD',N'Nguyễn Thị Diệu ', '2002-7-10','0937593886','43657')
insert into QuanLy Values('admin',N'ADMIN ', '2000-01-01','0000000000','admin')

go
insert into  Sach Values('MK1', N'Vận Mệnh Người Lính Tốt', 'JH',N'Tiểu Thuyết-Lịch Sử','1921','55 Quang Trung, Ha Noi',4)
insert into  Sach Values('MK2', N'Con Chó Nhỏ Mang Giỏ Hoa Hồng', 'NNA',N'Lãng Mạn','2019','161B Ly Chinh Thang, TPHCM',8)
insert into  Sach Values('MK3', N'Muôn Kiếp Nhân Sinh', 'NP',N'Triết Học','2017','So 24 Quang Trung, Ha Noi',6)
insert into  Sach Values('MK4', N'Cộng Hòa Plato', 'PLT',N'Triết Học- Chính Trị','2018','35 Tran Quoc Toan, Ha Noi',2)
insert into  Sach Values('MK5', N'Cây Chuối Non Đi Giày Xanh', 'NNA',N'Lãng Mạn','1987','175 Giang Vo, Ha Noi',1)
insert into  Sach Values('MK6', N'Mắt Biếc', 'NNA',N'Lãng Mạn','2019','16B CMT8, TPHCM',8)
insert into  Sach Values('MK9', N'Cô Gái Đén Từ Hôm Qua', 'NNA',N'Lãng Mạn','1971','145 Giang Vo, Ha Noi',1)
insert into  Sach Values('MK10', N'Những Người Khốn Khổ', 'VG',N'Triết Học- Chính Trị','2018','35 Tran Quoc Toan, Ha Noi',2)
insert into  Sach Values('MK11', N'Ngày cuối cùng của một tử tù ', 'VG',N'Bi Kịch','1829','175 Giang Vo, Ha Noi',1)
insert into  Sach Values('MK12', N'Nhà thờ Đức Bà Parisc', 'VG',N'Chính Kịch','2019','16B CMT8, TPHCM',3)
insert into  Sach Values('MK13', N'Yến hội và Phaedrus', 'NNA',N'Triết Học','1971','145 Giang Vo, Ha Noi',8)
go

insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK2',3,'NTD','2022-9-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK4',2,'TTN','2022-2-26',' ',1,'2022-11-5')
insert into MuonTra Values ('MK4',2,'TTN','2022-4-15',' ',0,'2022-8-2')
insert into MuonTra Values ('MK3',3,'TTN','2022-9-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK11',1,'TTN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK10',3,'TTN','2022-9-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK12',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK9',2,'HHN','2022-2-26',' ',1,'2022-11-5')
insert into MuonTra Values ('MK6',2,'HHN','2022-4-15',' ',0,'2022-8-2')
insert into MuonTra Values ('MK13',3,'NTD','2022-9-15',' ',1,'2022-10-30')
go

select * from TacGia
select * from DocGia
select * from TheThuVien
select * from QuanLy
select * from Sach
select * from MuonTra
Go
