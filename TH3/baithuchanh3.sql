CREATE DATABASE QuanLyThuVien;
GO
USE QuanLyThuVien;
GO

create table khoa (
    makhoa int primary key,
    tenkhoa nvarchar(50),
    diachi nvarchar(50),
    sdt varchar(10)
);
GO

create table docgia (
    madocgia int primary key,
    hoten nvarchar(50),
    ngaysinh date,
    makhoa int foreign key references khoa(makhoa),
    vitri nvarchar(50),
    diachi nvarchar(50),
    ngaylapthe date
);
GO

create table sach (
    masach int primary key,
    nhande nvarchar(50),
    sotrang int,
    soluong int,
    namxb int,
    lanxb int,
    solanmuon int,
    loaisach nvarchar(50),
    nxb nvarchar(50),
    tacgia nvarchar(50),
    ngaynhap date
);
GO

create table nhanvien (
    manhanvien int primary key,
    hoten nvarchar(50),
    diachi nvarchar(50),
    tendangnhap nvarchar(50) unique,
    matkhau nvarchar(50),
    quyenhan nvarchar(50)
);
GO

create table phieumuon (
    maphieumuon int primary key,
    madocgia int foreign key references docgia(madocgia),
    thethucmuon nvarchar(50),
    ngaymuon date,
    masach int foreign key references sach(masach),
    manhanvien int foreign key references nhanvien(manhanvien),
    soluong int
);
GO

