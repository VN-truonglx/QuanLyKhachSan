Create Database Qly_KhSan
On 
(	Name = QL_KhSan_data,
	Filename = 'D:\Quanlykhachsan\QL_KhSan.mdf',
	size = 5,
	Maxsize = 10,
	filegrowth = 2
)
Log on
(	Name = QL_KhSan_log,
	Filename = 'D:\Quanlykhachsan\QL_KhSan_log.ldf',
	size = 5mb,
	Filegrowth = 2mb
)
--TẠO BẢNG
--tablePhong
Create table tblPhong
(	MaPhong nvarchar(10) primary key not null,
	TenPhong nvarchar(50),
	DonGia float
)
-- Thêm dữ liệu vào tblPhong
Insert into tblPhong(MaPhong, TenPhong, DonGia) Values ('P01', 'Phòng 1', 14000000)
Insert into tblPhong(MaPhong, TenPhong, DonGia) Values ('P02', 'Phòng 2', 18000000)
Insert into tblPhong(MaPhong, TenPhong, DonGia) Values ('P03', 'Phòng 3', 8000000)

SELECT * FROM tblPhong