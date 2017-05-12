use QuanLyKhachSan


create table KhachHang
(
MaKH varchar(5) primary key,
TenKH nvarchar(50) not null,
GioiTinh nvarchar(4) not null,
DiaChi nvarchar(100) null,
CMND varchar(20) null,
SoDT varchar(12) null,
QuocTich nvarchar(20) null
)

create table NhanVien
(
MaNV varchar(5) primary key,
TenNV nvarchar(50) not null,
NgaySinh datetime null,
GioiTinh nvarchar(4) null,
DiaChi nvarchar(100) null,
SoDT varchar(12) null,
NgayVaoLam datetime null
)

create table Phong
(
MaPhong varchar(5) primary key,
TenLoaiPhong nvarchar(50) null,
DonGia float null,
TinhTrang nvarchar(20) null
)

create table DichVu
(
MaDV varchar(5) primary key,
TenDV nvarchar(50) null,
DonGia float null
)

create table ThietBi
(
MaTB varchar(5) primary key,
MaPhong varchar(5) foreign key(MaPhong) references Phong(MaPhong),
TenTB nvarchar(50) null,
SoLuong int null
)

create table PhieuNhanPhong
(
MaNhanPhong varchar(5) primary key,
MaPhong varchar(5) foreign key(MaPhong) references Phong(MaPhong),
MaKH varchar(5) foreign key(MaKH) references KhachHang(MaKH),
NgayNhan datetime null,
NgayTra datetime null
)

create table DanhSachSuDungDV
(
Ma varchar(5) primary key,
MaDV varchar(5) foreign key(MaDV) references DichVu(MaDV),
MaNhanPhong varchar(5) foreign key(MaNhanPhong) references PhieuNhanPhong(MaNhanPhong),
SoLuong int null
)

create table HoaDon
(
MaHD varchar(5) primary key,
MaKH varchar(5) foreign key(MaKH) references KhachHang(MaKH),
MaNV varchar(5) foreign key(MaNV) references NhanVien(MaNV),
MaNhanPhong varchar(5) foreign key(MaNhanPhong) references PhieuNhanPhong(MaNhanPhong),
MaSDDV varchar(5) foreign key(MaSDDV) references DanhSachSuDungDV(Ma),
TienDV float null,
HinhThucThanhToan nvarchar(5) null,
PhuThu float null,
TongTien float null
)
