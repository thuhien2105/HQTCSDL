﻿﻿use master
go
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'DOAN')
BEGIN
	CREATE DATABASE DOAN 
end
go
use 
DOAN

go
create table "THUC DON" (
	"Ten mon" nvarchar(50) not null,
	"Ma doi tac"    char(10)    not null,
	Gia money not null,
	"Mieu ta" NVARCHAR(256)
	constraint "PK_THUC DON" primary key ("Ten mon","Ma doi tac")
)
create table "BANG DANH GIA" (
   id_donhang           char(10)            not null,
   MaKH                 char(10)            not null,
   id_chinhanh          char(10)            not null,
   Rate                 float            ,
   "Like"               bit                  ,
   Comment              nvarchar(256)  
   constraint "PK_BANG DANH GIA" primary key (id_donhang, MAKH, id_chinhanh)
)
go

create table "CHI NHANH" (
   id_chinhanh          char(10)             not null,
   "Ma doi tac"         char(10)            not null,
   "Dia chi"            nvarchar(50)                 ,
   "Thoi gian mo cua"   datetime             ,
   "Thoi gian dong cua" datetime             ,
   "Doanh thu thang"  money               ,
   Ten                  nvarchar(256)      
   ,     
   constraint "PK_CHI NHANH" primary key nonclustered (id_chinhanh)
)
go

create table "CT DON HANG" (
   id_donhang           char(10)            not null,
   "Ten mon"            nvarchar(50)                 not null,
   soluong int ,
   constraint "PK_CT DON HANG" primary key (id_donhang, "Ten mon")
)
GO
create table "DOI TAC" (
   Email                char(50)                 not null,
   "Ten quan"           nvarchar(20)                ,
   "Thanh pho/Quan"     nvarchar(20)                 not null,
   "So luong chi nhanh" int                  ,
   "So luong don hang dk" int                  ,
   "So dien thoai"      numeric(10)          not null,
   "Loai am thuc"      char(10)                 ,
   "Ma doi tac"         char(10)            not null,
   tentaikhoan          nvarchar(50)                not null ,
   "Ten Ngan hang"      nvarchar(10)                 not null,
   "So tai khoan"       numeric(20)         not null,
   constraint "PK_DOI TAC" primary key nonclustered ("Ma doi tac")
)
go
create table "DON HANG" (
   id_donhang           char(10)           not null,
   MaTX                 char(10)            not null,
   id_chinhanh          char(10)            not null,
   MaKH                 char(10)            not null,
   "Ngay lap"           datetime             not null,
   "Hinh thuc thanh toan" nvarchar(50)          not null    ,
   "Phi van chuyen"   money                  ,
   "Tong don hang"    int                  ,
   constraint "PK_DON HANG" primary key nonclustered (id_donhang asc) 
   WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
)  ON [PRIMARY] 
go
create table "HOP DONG" (
   id_hopdong           char(10)            not null,
   id_nhanvien          char(10)            not null,
   id_nđd               char(10)            not null,
   "Ngay lap"           datetime             ,
   "Ma so thue"         char(10)            ,
   "Phan tram hoa hong" int               ,
   "Thoi gian het hieu luc" datetime             ,
   "Phi kich hoat"      int             ,
   constraint "PK_HOP DONG" primary key nonclustered (id_hopdong)
)
go

create table "KHACH HANG" (
   "Ho ten"             nvarchar(50)                 not null ,
   "So dien thoai"      numeric(10)          not null,
   "Dia chi"            nvarchar(50)              not null    ,
   Email                nvarchar(50)                 not null ,
   MaKH                 char(10)            not null,
   tentaikhoan          nvarchar(50)                  ,
   constraint "PK_KHACH HANG" primary key nonclustered (MaKH)
)
go
create table "KHU VUC" (
   id_khuvuc            char(10)            not null,
   "Ten khu vuc"        nvarchar(50)                 ,
   constraint "PK_KHU VUC" primary key nonclustered (id_khuvuc)
)
go
create table "MON AN" (
   "Ten mon"            nvarchar(50)                 not null,
   id_amthuc            char(10)            not null,             
   constraint "PK_MON AN" primary key nonclustered ("Ten mon")
)
create table "TUY CHON MON AN"(
	"Ten mon"            nvarchar(50)                 not null,
	"Tuy chon"         nvarchar(256),
	constraint "PK_TUY CHON MON AN" primary key nonclustered ("Ten mon","Tuy chon")
)
go
create table "LOAI AM THUC" (
   id_amthuc            char(10)            not null,
   "Ten am thuc" nvarchar(50),                 
   constraint "PK_LOAI AM THUC" primary key nonclustered (id_amthuc)
)
go
create table "NGUOI DAI DIEN" (
   id_nđd               char(10)            not null,
   "Ma doi tac"         char(10)            not null,
   "Ten dai dien"       nvarchar(50)                 ,
   constraint "PK_NGUOI DAI DIEN" primary key nonclustered (id_nđd)
)
go
create table "NHAN VIEN" (
   id_nhanvien          char(10)            not null,
   tentaikhoan          nvarchar(50)                  ,
   "Ten nhan vien"      nvarchar(50)                 ,

   constraint "PK_NHAN VIEN" primary key nonclustered (id_nhanvien)
)
go
create table "PHIEU DANG KY" (
   id_pdk               char(10)            not null,
   id_nhanvien          char(10)            not null,
   "Ma doi tac"         char(10)            not null,
   constraint "PK_PHIEU DANG KY" primary key nonclustered (id_pdk)
)
go
create table "TAI KHOAN" (
   tentaikhoan          nvarchar(50)             not null,
   matkhau              char(20)                 not null,        
   constraint "PK_TAI KHOAN" primary key (tentaikhoan)
)
go
create table "TAI KHOAN NGAN HANG" (
   "Ten Ngan hang"      nvarchar(10)                 not null,
   "So tai khoan"       numeric(20)         not null,
   "Chi nhanh NH"       nvarchar(50)                 ,
   constraint "PK_TAI KHOAN NGAN HANG" primary key nonclustered ("Ten Ngan hang", "So tai khoan")
)
go
create table "TAI XE" (
   CMND                 numeric(20)          ,
   "Dien thoai"         numeric(10)          ,
   "Dia chi"            nvarchar(50)                 ,
   "Bien so xe"         char(50)                 ,
   Email                nvarchar(50)                 ,
   "Phi thue chan"      money               ,
   "Ho ten"             nvarchar(50)                 ,
   MaTX                 char(10)            not null,
   id_khuvuc            char(10)            not null,
   tentaikhoan         nvarchar(50)                  ,
   id_nhanvien          char(10)            not null,
   "Ten Ngan hang TX"      nvarchar(10)                 not null,
   "So tai khoan TX"       numeric(20)         not null,
   constraint "PK_TAI XE" primary key nonclustered (MaTX)
)
go
create table "TINH TRANG CHI NHANH" (
   "Thoi gian chi nhanh" datetime             not null,
   id_chinhanh          char(10)            not null,
   "Tinh trang chi nhanh" nvarchar(50)                 ,
   "Ghi chu"            nvarchar(50)                 ,
   constraint "PK_TINH TRANG CHI NHANH" primary key nonclustered ("Thoi gian chi nhanh", id_chinhanh)
)
go
create table "TINH TRANG DON HANG" (
   "Thoi gian don hang" datetime             not null,
   id_donhang           char(10)            not null,
   "Tinh trang"         nvarchar(50)                 ,
   "Ghi chu"            nvarchar(50)                 ,
   constraint "PK_TINH TRANG DON HANG" primary key nonclustered ("Thoi gian don hang", id_donhang)
)
go
create table "TINH TRANG MON AN" (
   "Thoi gian mon an"   datetime             not null,
   "Ten mon"            nvarchar(50)                 not null,
   "Tinh trang"         nvarchar(50)   ,
   id_chinhanh char(10)
   constraint "PK_TINH TRANG MON AN" primary key nonclustered ("Thoi gian mon an", "Ten mon")
)

go

alter table "BANG DANH GIA"
   add constraint "FK_BANG DANH GIA_CHI NHANH" foreign key (id_chinhanh)
      references "CHI NHANH" (id_chinhanh) ON DELETE CASCADE
go

alter table "BANG DANH GIA"
   add constraint "FK_BANG DANH GIA_DON HANG" foreign key (id_donhang)
      references "DON HANG" (id_donhang) ON DELETE CASCADE
go

alter table "BANG DANH GIA"
   add constraint "FK_BANG DANH GIA_KHACH HANG" foreign key (MaKH)
      references "KHACH HANG" (MaKH) ON DELETE CASCADE
go

alter table "CHI NHANH"
   add constraint "FK_CHI NHANH_DOI TAC" foreign key ("Ma doi tac")
      references "DOI TAC" ("Ma doi tac")




go

alter table "CT DON HANG"
   add constraint "FK_CT DON HANG_DON HANG" foreign key (id_donhang)
      references "DON HANG" (id_donhang)
go

alter table "CT DON HANG"
   add constraint "FK_CT DON HANH_MON AN" foreign key ("Ten mon")
      references "MON AN" ("Ten mon")
go


alter table "DON HANG"
   add constraint "FK_DON HANG_TIẾP NHẬN_TAI XE" foreign key (MaTX)
      references "TAI XE" (MaTX)
go

alter table "DON HANG"
   add constraint "FK_DON HANG_XÁC NHẬN_KHACH HANG" foreign key (MaKH)
      references "KHACH HANG" (MaKH)
go

alter table "DON HANG"
   add constraint "FK_DON HANG_ĐẶT TẠI_CHI NHANH" foreign key (id_chinhanh)
      references "CHI NHANH" (id_chinhanh)
go

alter table "HOP DONG"
   add constraint "FK_HOP DONG_KÍ XÁC NH_NGUOI DAI DIEN" foreign key (id_nđd)
      references "NGUOI DAI DIEN" (id_nđd)
go

alter table "HOP DONG"
   add constraint "FK_HOP DONG_XÁC NHẬN _NHAN VIEN" foreign key (id_nhanvien)
      references "NHAN VIEN" (id_nhanvien)
go

alter table "KHACH HANG"
   add constraint "FK_KHACH HANG_BELONG2_TAI KHOA" foreign key (tentaikhoan)
      references "TAI KHOAN" (tentaikhoan)
go

alter table "MON AN"
   add constraint "FK_MON AN_THUỘC_LOAI AM THUC" foreign key (id_amthuc)
      references "LOAI AM THUC" (id_amthuc)
go

alter table "NGUOI DAI DIEN"
   add constraint "FK_NGUOI DAI DIEN_THUỘC V_DOI TAC" foreign key ("Ma doi tac")
      references "DOI TAC" ("Ma doi tac")
go

alter table "NHAN VIEN"
   add constraint "FK_NHAN VIEN_BELONG TO_TAI KHOA" foreign key (tentaikhoan)
      references "TAI KHOAN" (tentaikhoan)
go

alter table "PHIEU DANG KY"
   add constraint "FK_PHIEU DANG KY_GHI NHẬN_DOI TAC" foreign key ("Ma doi tac")
      references "DOI TAC" ("Ma doi tac")
go

alter table "PHIEU DANG KY"
   add constraint "FK_PHIEU DANG KY_ĐƯỢC XỨ L_NHAN VIEN" foreign key (id_nhanvien)
      references "NHAN VIEN" (id_nhanvien)
go


alter table "TAI XE"
   add constraint "FK_TAI XE_CÓ_TAI KHOA" foreign key ("Ten Ngan hang TX", "So tai khoan TX")
      references "TAI KHOAN NGAN HANG" ("Ten Ngan hang", "So tai khoan")
go

alter table "TAI XE"
   add constraint "FK_TAI XE_DANG KI L_TAI KHOA" foreign key (tentaikhoan)
      references "TAI KHOAN" (tentaikhoan)
go

alter table "TAI XE"
   add constraint "FK_TAI XE_HOẠT ĐỘNG_KHU VUC" foreign key (id_khuvuc)
      references "KHU VUC" (id_khuvuc)
go

alter table "TAI XE"
   add constraint "FK_TAI XE_ĐĂNG KÝ_NHAN VIE" foreign key (id_nhanvien)
      references "NHAN VIEN" (id_nhanvien)
go

alter table "TINH TRANG CHI NHANH"
   add constraint "FK_TINH TRA_CUA_CHI NHAN" foreign key (id_chinhanh)
      references "CHI NHANH" (id_chinhanh)
go

alter table "TINH TRANG DON HANG"
   add constraint "FK_TINH TRA_OF_DON HANG" foreign key (id_donhang)
      references "DON HANG" (id_donhang)
go

alter table "TINH TRANG MON AN"
   add constraint "FK_TINH TRANG MON AN_CHO THẤY_MON AN" foreign key ("Ten mon")
      references "MON AN" ("Ten mon")
go 
alter table "DOI TAC"
   add constraint "FK_TAI KHOAN NGAN HANG_DOI TAC" foreign key ("Ten ngan hang", "So tai khoan")
      references "TAI KHOAN NGAN HANG" ("Ten ngan hang", "So tai khoan")
go 

alter table "TUY CHON MON AN"
   add constraint "FK_TUY CHON MON AN_MON AN" foreign key ("Ten mon")
      references "MON AN"("Ten mon")
go 
alter table "THUC DON"
   add constraint "FK_THUC DON_MON AN" foreign key ("Ten mon")
      references "MON AN"("Ten mon")
go 
alter table "THUC DON" 
   add constraint "FK_THUC DON_DOI TAC" foreign key ("Ma doi tac")
      references "DOI TAC"("Ma doi tac")
go 
alter table "TINH TRANG MON AN" 
   add constraint "FK_THUC DON_CHI NHANH" foreign key (id_chinhanh)
      references "CHI NHANH"(id_chinhanh)
go 

alter table "DOI TAC"
   add constraint "FK_DOI TAC_TAI KHOAN" foreign key (tentaikhoan)
      references "TAI KHOAN"(tentaikhoan)
go 