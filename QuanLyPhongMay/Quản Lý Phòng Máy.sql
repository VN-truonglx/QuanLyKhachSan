Create Database QlyPhongMay
On 
(	Name = QuanLyPhongMay_data,
	Filename = 'D:\QuanLyPhongMay\QuanLyPhongMay_data.mdf',
	size = 5,
	Maxsize = 10,
	filegrowth = 2
)
Log on
(	Name = QuanlyPhongMay_log,
	Filename = 'D:\QuanLyPhongMay\QuanLyPhongMay_log.ldf',
	size = 5mb,
	Filegrowth = 2mb
)

CREATE TABLE tblMayTinh 
(
    MaMay       nvarchar (50) NOT NULL PRIMARY KEY,
    TenMay      nvarchar (50) NULL,
    MaPM        nvarchar (50) NULL,
    MaOCung     nvarchar (50) NULL,
    MaDungLuong nvarchar (50) NULL,
    MaChip      nvarchar (50) NULL,
    MaRAM       nvarchar (50) NULL,
    MaTocDo     nvarchar (50) NULL,
    MaManHinh   nvarchar (50) NULL,
    MaCoMH      nvarchar (50) NULL,
    MaChuot    nvarchar (50) NULL,
    MaBanPhim   nvarchar (50) NULL,
    MaODia     nvarchar (50) NULL,
    GhiChu      nvarchar (50) NULL,
)

CREATE TABLE tblCaHoc
(
	MaCa nvarchar (50) NOT NULL PRIMARY KEY, 
    TenCa nvarchar (50) NULL
)
CREATE TABLE tblMonThucHanh
(
	MaMon nvarchar (50) NOT NULL PRIMARY KEY, 
    TenMon nvarchar (50) NULL
)
CREATE TABLE tblLichThucHanh
(
	MaSTT nvarchar (50) NOT NULL PRIMARY KEY, 
    MaPM nvarchar (50) NULL, 
    MaSV nvarchar (50) NULL, 
    MaGV nvarchar (50) NULL, 
    MaLop nvarchar (50) NULL, 
    MaMon nvarchar (50) NULL, 
    MaCa nvarchar (50) NULL, 
    Thu nvarchar (50) NULL, 
    NgayBD nvarchar (50) NULL, 
    NgayKT nvarchar (50) NULL
)



CREATE TABLE tblLop
(
	MaLop nvarchar (50) NOT NULL PRIMARY KEY, 
    SiSo nvarchar (50) NULL, 
    TenLop nvarchar (50) NULL
)

CREATE TABLE tblSinhVien
(
	MaSV nvarchar (50) NOT NULL PRIMARY KEY, 
    TenSV nvarchar (50) NULL, 
    MaPM nvarchar (50) NULL, 
    NamSinh nvarchar (50) NULL, 
    GioiTinh nvarchar (50) NULL,
	MaTinh nvarchar (50) NULL, 
    DienThoai nvarchar (50) NULL
)


CREATE TABLE tblTinh
(
	MaTinh nvarchar (50) NOT NULL PRIMARY KEY, 
    TenTinh nvarchar (50) NULL
)
CREATE TABLE tblMaODia
(
	MaODia nvarchar (50) NOT NULL PRIMARY KEY, 
    TenODia nvarchar (50) NULL
)
CREATE TABLE tblManHinh
(
	MaManHinh nvarchar (50) NOT NULL PRIMARY KEY, 
    TenManHinh nvarchar (50) NULL
)
CREATE TABLE tblPhongMay
(
    MaPM      nvarchar (50) NOT NULL PRIMARY KEY,
    TenPM     nvarchar (50) NULL,
    SoMay     nvarchar (50) NULL,
    DiaDiem   nvarchar (50) NULL,
    DienThoai nvarchar (50) NULL, 
)


CREATE TABLE tblMaChuot
(
	MaChuot nvarchar (50) NOT NULL PRIMARY KEY, 
    TenChuot nvarchar (50) NULL
)
CREATE TABLE tblMaBanPhim
(
	MaBanPhim nvarchar (50) NOT NULL PRIMARY KEY, 
    TenBanPhim nvarchar (50) NULL
)
CREATE TABLE tblGiaoVien
(
	MaGV nvarchar (50) NOT NULL PRIMARY KEY, 
    TenGV nvarchar (50) NULL,
	DienThoai nvarchar (50) NULL,
)
CREATE TABLE tblOCung
(
	MaOCung nvarchar (50) NOT NULL PRIMARY KEY, 
    TenOCung nvarchar (50) NULL,
)
CREATE TABLE tblDungLuong
(
	MaDungLuong nvarchar (50) NOT NULL PRIMARY KEY, 
    TenDungLuong nvarchar (50) NULL,
)
CREATE TABLE tblChip
(
	MaChip nvarchar (50) NOT NULL PRIMARY KEY, 
    TenChip nvarchar (50) NULL,
)
CREATE TABLE tblRAM
(
	MaRAM nvarchar (50) NOT NULL PRIMARY KEY, 
    TenRAM nvarchar (50) NULL,
)
CREATE TABLE tblTocDo
(
	MaTocDo nvarchar (50) NOT NULL PRIMARY KEY, 
    TenTocDo nvarchar (50) NULL,
)
CREATE TABLE tblCoMH
(
	MaCoMH nvarchar (50) NOT NULL PRIMARY KEY, 
    TenCoMH nvarchar (50) NULL,
)

-- Thêm khóa ngoại trên tblLichThucHanh
Alter table tblLichThucHanh
Add constraint FK_MaPM Foreign key (MaPM) references tblPhongMay
Alter table tblLichThucHanh
Add constraint FK_MaSV Foreign key (MaSV) references tblSinhVien
Alter table tblLichThucHanh
Add constraint FK_MaGV Foreign key (MaGV) references tblGiaoVien
Alter table tblLichThucHanh
Add constraint FK_MaLop Foreign key (MaLop) references tblLop
Alter table tblLichThucHanh
Add constraint FK_MaMon Foreign key (MaMon) references tblMonThucHanh
Alter table tblLichThucHanh
Add constraint FK_MaCa Foreign key (MaCa) references tblCaHoc



-- Thêm khóa ngoại trên tblMayTinh
Alter table tblMayTinh
Add constraint tblMayTinh_FK_MaPM Foreign key (MaPM) references tblPhongMay
Alter table tblMayTinh
Add constraint FK_MaOCung Foreign key (MaOCung) references tblOCung
Alter table tblMayTinh
Add constraint FK_MaDungLuong Foreign key (MaDungLuong) references tblDungLuong
Alter table tblMayTinh
Add constraint FK_MaChip Foreign key (MaChip) references tblChip
Alter table tblMayTinh
Add constraint FK_MaRAM Foreign key (MaRAM) references tblRAM
Alter table tblMayTinh
Add constraint FK_MaTocDo Foreign key (MaTocDo) references tblTocDo
Alter table tblMayTinh
Add constraint FK_MaManHinh Foreign key (MaManHinh) references tblManHinh
Alter table tblMayTinh
Add constraint FK_MaCoMH Foreign key (MaCoMH) references tblCoManHinh
Alter table tblMayTinh
Add constraint FK_MaChuot Foreign key (MaChuot) references tblMaChuot
Alter table tblMayTinh
Add constraint FK_MaBanPhim Foreign key (MaBanPhim) references tblMaBanPhim
Alter table tblMayTinh
Add constraint FK_MaODia Foreign key (MaODia) references tblMaODia
 
-- Thêm khóa ngoại trên tblSinhVien
Alter table tblSinhVien
Add constraint tblSinhVien_FK_MaPM Foreign key (MaPM) references tblPhongMay
Alter table tblSinhVien
Add constraint FK_Tinh Foreign key (MaTinh) references tblTinh

----- Insert 
insert into tblCaHoc values ('CH01', 'Ca 1') 
insert into tblCaHoc values ('CH02', 'Ca 2') 
insert into tblCaHoc values ('CH03', 'Ca 3') 
insert into tblCaHoc values ('CH04', 'Ca 4') 
select * from tblCaHoc

insert into tblMonThucHanh values ('MTH01', 'Mon Tin')
insert into tblMonThucHanh values ('MTH02', 'Mon TD')
insert into tblMonThucHanh values ('MTH03', 'Mon Li')
insert into tblMonThucHanh values ('MTH04', 'Mon Hoa')
select * from tblMonThucHanh

insert into tblLop values ('L01', 10, 'Lop A')
insert into tblLop values ('L02', 20, 'Lop B')
insert into tblLop values ('L03', 30, 'Lop C')
select * from tblLop

insert into tblTinh values ('T01', 'Ha Noi')
insert into tblTinh values ('T02', 'TPHCM')
insert into tblTinh values ('T03', 'Hai Duong')
select * from tblTinh

insert into tblMaODia values ('OD01', 'O CD')
insert into tblMaODia values ('OD02', 'O DVD')
select * from tblMaODia

insert into tblMaChuot values ('C01', 'Logitech')
insert into tblMaChuot values ('C02', 'Corsair')
insert into tblMaChuot values ('C03', 'Razer')
select * from tblMaChuot

insert into tblManHinh values ('MNH01', 'Dell U2419H 24inch FullHD 8ms 60Hz IPS')
insert into tblManHinh values ('MNH02', 'LG 34WK95U-W 34inch')
insert into tblManHinh values ('MNH03', 'BenQ GW2470HL 24 inch Full HD')
select * from tblManHinh

insert into tblCoManHinh values ('CM01', '24inch')
insert into tblCoManHinh  values ('CM02', '34inch')
insert into tblCoManHinh  values ('CM03', '29 inch')
select * from tblCoManHinh

insert into tblMaBanPhim values ('BP01', 'G21 LED giả cơ')
insert into tblMaBanPhim values ('BP02', 'Bàn phím Gaming LED Bosston 808')
select * from tblMaBanPhim

insert into tblGiaoVien values ('GV01', 'Trần Mai', '0971453954')
insert into tblGiaoVien values ('GV02', 'Lê Anh Đức', '0805453954')
insert into tblGiaoVien values ('GV03', 'Dương Hải Anh', '0805453302')
select * from tblGiaoVien

insert into tblOCung values ('OC01', 'WD Elements 1TB 2.5 USB 3.0')
insert into tblOCung values ('OC02', 'Toshiba Canvio Advance 2Tb USB3.0 ')
select * from tblOCung

insert into tblDungLuong values ('DL01', '2 TB')
insert into tblDungLuong values ('DL02', '1 TB')
insert into tblDungLuong values ('DL03', '128 MB')
select * from tblDungLuong

insert into tblChip values ('CPU01', 'Intel Core i3-3220 3.3GHz  - Hàng Nhập Khẩu')
insert into tblChip values ('CPU02', 'AMD Ryzen 5 1400 Processor')
insert into tblChip values ('CPU03', 'Core i3 4160/3.6Ghz/L3 3M')
select * from tblChip

insert into tblRAM values ('R01', 'Corsair Vengeance LPX 8GB Bus 2666 DDR4 C16')
insert into tblRAM values ('R02', 'Kingmax 8GB 2400 DDR4')
select * from tblRAM

insert into tblPhongMay values ('M01', 'Phong 1', '01', 'Tang 1', ' 09873452766')
insert into tblPhongMay values ('M02', 'Phong 2', '02', 'Tang 2', ' 0919748278')
insert into tblPhongMay values ('M03', 'Phong 2', '04', 'Tang 1', ' 03854452588')
select * from tblPhongMay

insert into tblMayTinh values ('M1', 'Gaming 4TechGM04 2019', 'M01', 'OC01', 'DL01','CPU01','R01','TD01', 'MNH01','CM01','C01','BP01','OD01', 'Made in China')
insert into tblMayTinh values ('M2', 'Dell Inspiron 3670 MT MTI31410W-4G-1T ', 'M02', 'OC02', 'DL02','CPU02','R02','TD02', 'MNH02','CM02','C02','BP02','OD02', 'Made in U.S')
insert into tblMayTinh values ('M3', 'PC Haizen8 97XP 6XPro ', 'M03', 'OC02', 'DL02','CPU02','R02','TD02', 'MNH02','CM02','C02','BP02','OD02', 'From Guangzhou')

select * from tblMayTinh 

Alter table tblPhongMay
alter column SoMay int


select MaMay, SoMay, b.MaPM from tblMayTinh a join tblPhongMay b on a.MaPM=b.MaPM 
select count(MaMay) as SOMT, MaPM from tblMayTinh group by MaPM
delete from tblMayTinh where MaMay='M1'
delete from tblMayTinh where MaMay='M2'
delete from tblPhongMay where MaPM='PM01'
delete from tblPhongMay where MaPM='PM02'

update tblMayTinh set TenMay='Gaming 4TechGM04 2019', MaODia='OD01' where MaMay='M1'
update tblMayTinh set TenMay='Gaming 4TechGM04 2019', MaPM='PM01', MaOCung='OC01', MaDungLuong='DL01', MaChip='CPU01', MaRAM='R01', MaTocDo='TD01', MaManHinh='MNH01', MaCoMH='CM01', MaChuot='C01', MaBanPhim='BP02', MaODia='OD01', GhiChu='' where MaMay='M3'
update tblMayTinh set MaPM='PM02' where MaMay='M1'

create proc CapnhatSomay @MPM nvarchar(50)
as
	begin
		declare @SOMT int
		select @SOMT=count(MaMay) from tblMayTinh where MaPM=@MPM
		update tblPhongMay set SoMay=@SOMT where MaPM=@MPM
	end

exec CapnhatSomay 'PM02'

create trigger SomayPhongmay
on tblPhongMay
for insert
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from inserted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma

create trigger SomayPhongmayplus
on tblMaytinh
for insert
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from inserted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma

create trigger SomayPhongmaydelete
on tblPhongMay
for delete
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from deleted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma

create trigger SomayPhongmayplusdelete
on tblMaytinh
for delete
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from deleted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma

create trigger SomayPhongmayupdate
on tblPhongMay
for update
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from inserted
	declare @Am nvarchar(50)
	select @Am=MaPM from deleted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma
	exec CapnhatSomay @Am

create trigger SomayPhongmayplusupdate
on tblMaytinh
for update
as
	declare @Ma nvarchar(50)
	select @Ma=MaPM from inserted
	declare @Am nvarchar(50)
	select @Am=MaPM  from deleted
	print 'So may Phong may tu cap nhat'
	exec CapnhatSomay @Ma
	exec CapnhatSomay @Am

drop trigger SomayPhongmayupdate
drop trigger SomayPhongmayplusupdate

select tblPhongMay.MaPM , MaMay, TenMay from tblPhongMay join tblMayTinh on tblPhongMay.MaPM=tblMayTinh.MaPM group by MaMay, TenMay , tblPhongMay.MaPM

select * from tblPhongMay 
select * from tblMayTinh
delete tblPhongMay where MaPM='01'

