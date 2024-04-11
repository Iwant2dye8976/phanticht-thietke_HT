CREATE DATABASE QLSACH
CREATE TABLE SACH
(
	MSACH nchar(10) not null primary key,
	TenSach nvarchar(50),
	TacGia nvarchar(30),
	NXB nvarchar(50),
	Gia float,
	NgayCP date
)

CREATE TABLE KH
(
	HoTen nvarchar(50),
	DiaChi nvarchar(50),
	NgaySinh date,
	SDT char(10)
)

CREATE TABLE NV
(
	MaNV char(10) not null primary key,
	UserName char(30),
	Pass_Word char(30)
)