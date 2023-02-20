create database QL_MayTinh
use QL_MayTinh
--Tên: Nguyễn Quang Huy
--Lớp: 62TH2
--MSV: 2051063734
create table SanPham
(
	maSP char(7) Not Null,
	tenSP nchar(70),
	giaSP float,
	hangSP char(10),
	soLuongCon int,
	slBan int,
	giamGia int,
	primary key(maSP)
)
create table HoaDon
(
	maHD char(4) Not Null,
	tenKH nchar(50),
	SDTKH char(10),
	tongTien float,
	ngaymua date,
	primary key(maHD),
)
create table ChiTietHD
(
	maHD char(4),
	maSP char(7),
	soLuongMua int,
	primary key(maSP,maHD),
	foreign key(maSP) references SanPham,
	foreign key(maHD) references HoaDon
)
drop table SanPham
drop table HoaDon
drop table ChiTietHD
insert into SanPham values ('1063024',N'Laptop Lenovo V330-14IKBR',13000000,'Lenovo',20,2,10),
						   ('1055768',N'Laptop ASUS Vivobook S433EA-AM439T 90NB0RL4-M06720',17000000,'Asus',17,1,7),
						   ('1027643',N'Laptop ACER Swift 3 SF313-53-503A NX.A4JSV.002',18000000,'Acer',12,1,8),
						   ('3054857',N'Laptop ACER Nitro 5 AN515-57-77KU NH.QDGSV.001',37500000,'Acer',22,1,5),
						   ('4678747',N'Laptop ASUS UX425EA-KI843W',26400000,'Asus',30,2,2),
						   ('4653877',N'Laptop Lenovo Yoga Slim 7 Pro 14IHU5 O 82NH008TVN',31490000,'Lenovo',10,0,4),
						   ('2021234',N'Laptop Apple MacBook Pro 2018 13.3inch MR9R2',47800000,'Apple',11,1,9),
						   ('1035678',N'Laptop LG Gram 2021 14ZD90P G.AX51A5',21500000,'LG',15,1,11),
						   ('1085648',N'Laptop GIGABYTE Aorus 17 XE5 73VN534GH',57000000,'Gigabyte',7,1,3),
						   ('2037854',N'Laptop MSI Gaming Alpha 17 B5EEK-031VN 031VN',28000000,'MSI',13,0,5),
						   ('2057968',N'Laptop MSI Modern 15 A10M 667VN',16200000,'MSI',20,0,2),
						   ('3017845',N'Laptop HP 14s-fq1080AU 4K0Z7PA',10700000,'HP',18,0,2),
						   ('3069754',N'Laptop Dell Vostro 14 3405 V4R53500U003W',17000000,'Dell',10,0,5)
insert into HoaDon values ('0945',N'Nguyễn Quang Huy','0975639572',83550000,'6/9/2022'),
						  ('5738',N'Trần Trung Dũng','0764285597',150002000,'6/10/2022'),
						  ('3328',N'Trần Bảo Lộc','0165245593',27510000,'6/11/2022')
insert into ChiTietHD values ('0945','1027643',1),
							 ('0945','1063024',1),
							 ('0945','1085648',1),
							 ('5738','1035678',1),
							 ('5738','2021234',1),
							 ('5738','3054857',1),
							 ('5738','4678747',2),
							 ('3328','1055768',1),
							 ('3328','1063024',1)