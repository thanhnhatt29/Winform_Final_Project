
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
go

insert into DocGia Values('BNK', N'Bùi Ngọc Khanh', ' 175 Giang Vo, Ha Noi','0937593869')
insert into DocGia Values('TTCL',N'Trịnh THị Cẩm Ly ', '81 Tran Hung Dao, Ha Noi ','0937593886')
insert into DocGia Values('NNH',  N'Nguyễn Ngọc Hoàng ', '35 Tran Quoc Toan, Ha Noi ','0936579107')
Go

insert into TheThuVien Values ('BNK','2021-11-15','2025-11-30',' ')
insert into TheThuVien Values ('TTCL','2022-1-5','2026-1-5',' ')
insert into TheThuVien Values ('NNH','2022-1-15','2026-1-15',' ')
go

insert into  QuanLy Values('HHN', N'Huỳnh Hiếu Nghĩa', '2002-4-29','0937593869','thanhnhat1')
insert into  QuanLy Values('TTN',N'Trần Thị Nữ ', '2002-2-9','0937593886','1')
insert into QuanLy Values('NTD',N'Nguyễn Thị Diệu ', '2002-7-10','0937593886','1')
go

insert into  Sach Values('MK1', N'Vận Mệnh Người Lính Tốt', 'JH',N'Tiểu Thuyết-Lịch Sử','1921','55 Quang Trung, Ha Noi',4)
insert into  Sach Values('MK2', N'Con Chó Nhỏ Mang Giỏ Hoa Hồng', 'NNA',N'Lãng Mạn','2019','161B Ly Chinh Thang, TPHCM',8)
insert into  Sach Values('MK3', N'Muôn Kiếp Nhân Sinh', 'NP',N'Triết Học','2017','So 24 Quang Trung, Ha Noi',6)
insert into  Sach Values('MK4', N'Cộng Hòa Plato', 'PLT',N'Triết Học- Chính Trị','2018','35 Tran Quoc Toan, Ha Noi',2)
insert into  Sach Values('MK5', N'Cây Chuối Non Đi Giày Xanh', 'NNA',N'Lãng Mạn','1921','175 Giang Vo, Ha Noi',1)
go

insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK2',3,'NTD','2022-9-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK1',1,'HHN','2022-1-15',' ',1,'2022-10-30')
insert into MuonTra Values ('MK4',2,'TTN','2022-2-26',' ',1,'2022-11-5')
insert into MuonTra Values ('MK4',2,'TTN','2022-4-15',' ',0,'2022-8-2')
insert into MuonTra Values ('MK3',3,'NTD','2022-9-15',' ',1,'2022-10-30')
go

select * from TacGia
select * from DocGia
select * from TheThuVien
select * from QuanLy
select * from Sach
select * from MuonTra
Go
