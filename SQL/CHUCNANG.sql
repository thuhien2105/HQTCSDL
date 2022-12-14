﻿use DOAN
----------PHÂN HỆ ĐỐI TÁC: AN
---update thông tin

--0: thành công, 1: thất bại


create 
--alter 
proc proc_updatethongtindoitac 
@madt char(10),
@email char(50),
@tenquan nvarchar(20),
@thanhpho nvarchar(20),
@sdt numeric(10,0),
@tennganhang nvarchar(10),
@stk numeric(20,0)
as
begin
	if not exists (select * from [DOI TAC] where [DOI TAC].[Ma doi tac]=@madt)
		begin
			print N'Không tồn tại mã đối tác.'
			rollback 
			return 1
		end
	update [DOI TAC] 
	set Email=@email, [Ten quan]=@tenquan, [Thanh pho/Quan]=@thanhpho, [So dien thoai]=@sdt, [Ten Ngan hang]=@tennganhang, [So tai khoan]=@stk
	where [DOI TAC].[Ma doi tac]=@madt
	return 0
end

---quản lý thực đơn
----thêm món ăn
create 
--alter 
proc proc_themmonan 
@tenmon nvarchar(50),
@madt char(10),
@machinhanh char(10),
@gia money,
@mieuta nvarchar(256),
@tinhtrang nvarchar(256),
@rate float,
@loaiamthuc char(10)
as
begin
	if not exists (select [Ma doi tac] from [DOI TAC] where [DOI TAC].[Ma doi tac]=@madt)
		begin
			print N'Không tồn tại mã đối tác.'
			return 1
		end
	if exists (select * from [THUC DON] where [THUC DON].[Ma doi tac]=@madt and [THUC DON].[Ma chi nhanh]=@machinhanh and [THUC DON].[Ten mon]=@tenmon )
		begin
			print N'Món ăn đã tồn tại.'
			return 1
		end
	insert [THUC DON] values (@tenmon, @madt, @machinhanh, @gia, @mieuta, @tinhtrang, @rate, @loaiamthuc)
	return 0
end
----xóa món ăn
create 
--alter 
proc proc_xoamonan 
@tenmon nvarchar(50),
@madt char(10),
@machinhanh char(10)
as
begin
	if not exists (select * from [DOI TAC] where [DOI TAC].[Ma doi tac]=@madt)
		begin
			print N'Không tồn tại mã đối tác.'
			return 1
		end
	if not exists (select * from [THUC DON] where [THUC DON].[Ma doi tac]=@madt and [THUC DON].[Ma chi nhanh]=@machinhanh and [THUC DON].[Ten mon]=@tenmon )
		begin
			print N'Món ăn không tồn tại.'
			return 1
		end
	delete [THUC DON] where [THUC DON].[Ma doi tac]=@madt and [THUC DON].[Ten mon]=@tenmon and [THUC DON].[Ma chi nhanh]=@machinhanh
	return 0
end

---quản lý chi nhánh
------thêm chi nhánh
create 
--alter
proc proc_add_chinhanh 
@id_chinhanh char(10),
@madt char(10),
@diachi nvarchar(50),
@thoigianmocua datetime,
@thoigiandongcua datetime,
@ten nvarchar(256),
@tennganhang char(10),
@stk numeric(20,0)
as 
begin
	if not exists (select * from [DOI TAC] where [DOI TAC].[Ma doi tac]=@madt)
		begin
			print N'Không tồn tại mã đối tác.'
			return 1
		end
	if exists (select * from [DOI TAC] join [CHI NHANH] on [DOI TAC].[Ma doi tac]=[CHI NHANH].[Ma doi tac] and [DOI TAC].[Ma doi tac]=@madt and [CHI NHANH].id_chinhanh=@id_chinhanh)
		begin
			print N'Đã tồn tại chi nhánh.'
			return 1
		end
	if @thoigianmocua > @thoigiandongcua 
		begin
			print N'Thời gian đóng/mở cửa không hợp lệ.'
			return 1
		end
	insert [CHI NHANH](id_chinhanh,[Ma doi tac],[Dia chi],[Thoi gian mo cua],[Thoi gian dong cua],Ten, [Ten Ngan hang], tentaikhoan)
	values (@id_chinhanh, @madt, @diachi, @thoigianmocua, @thoigiandongcua, @ten, @tennganhang, @stk)
	return 0
end

------xóa chi nhánh
create 
--alter
proc proc_delete_chinhanh 
@id_chinhanh char(10),
@madt char(10)
as 
begin
	if not exists (select * from [DOI TAC] where [DOI TAC].[Ma doi tac]=@madt)
		begin
			print N'Không tồn tại mã đối tác.'
			return 
		end
	if not exists (select * from [DOI TAC] join [CHI NHANH] on [DOI TAC].[Ma doi tac]=[CHI NHANH].[Ma doi tac] and [DOI TAC].[Ma doi tac]=@madt and [CHI NHANH].id_chinhanh=@id_chinhanh)
		begin
			print N'Không tồn tại chi nhánh.'
			return 
		end
	delete [CHI NHANH] where [CHI NHANH].id_chinhanh=@id_chinhanh and [CHI NHANH].[Ma doi tac]=@madt
	return 0
end
----------------------KHÁCH	HÀNG: HIỀN


---Chức năng đăng nhập
create 
--alter
proc sp_login @username nvarchar(50), @password char(20) 
as 
	select loaitaikhoan from [TAI KHOAN] where tentaikhoan=@username and matkhau=@password
exec sp_login 'abc','123'
---Xem danh sách quán
create 
--alter
proc sp_dsquan
as  select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan] from [DOI TAC]
exec sp_dsquan
--Tìm kiếm quán
create 
--alter
function f_timkiemquan(@tenquan nvarchar(20) )
returns table
as return select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan] from [DOI TAC] where [DOI TAC].[Ten quan] like @tenquan

---TÌM KIẾM SẢN PHẨM
----tìm kiếm món theo loại ẩm thực
create 
--alter
function func_tkmonan_loaiamthuc (@loaiamthuc nvarchar(50))
returns table
as return select distinct [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [THUC DON].[Ten mon] from [LOAI AM THUC] JOIN [MON AN] ON @loaiamthuc like [LOAI AM THUC].[Ten am thuc]  and [LOAI AM THUC].id_amthuc=[MON AN].id_amthuc JOIN [THUC DON] ON [THUC DON].[Ten mon]=[MON AN].[Ten mon] JOIN [DOI TAC] ON [DOI TAC].[Ma doi tac]=[THUC DON].[Ma doi tac]
----tìm kiếm theo tên món ăn
create 
--alter 
function func_tkmonan_ten (@tenmonan nvarchar(50))
returns table
as return select distinct [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [THUC DON].[Ten mon] from [THUC DON] join [DOI TAC] on @tenmonan like [THUC DON].[Ten mon]  and [DOI TAC].[Ma doi tac]=[THUC DON].[Ma doi tac]

---XEM THÔNG TIN MÓN ĂN TRONG THỰC ĐƠN CỦA ĐỐI TÁC
create 
--alter
proc proc_thongtinmonan(@tenmonan nvarchar(50) , @madoitac char(10))
as
	if exists (select * from [THUC DON] where [THUC DON].[Ten mon]=@tenmonan and [THUC DON].[Ma doi tac]=@madoitac )
	begin
		select distinct [DOI TAC].[Ten quan] , [DOI TAC].[Thanh pho/Quan], [MON AN].[Ten mon], [THUC DON].Gia , [THUC DON].[Mieu ta] from [THUC DON] join [DOI TAC] on [THUC DON].[Ten mon]=@tenmonan and [THUC DON].[Ma doi tac]=@madoitac and [THUC DON].[Ma doi tac]=[DOI TAC].[Ma doi tac] join [MON AN] on [THUC DON].[Ten mon]=[MON AN].[Ten mon] 
	end

---ĐẶT HÀNG	

----tạo id_donhang
create 
--alter
proc proc_iddonhang
@iddondang char(10) output
as
	select @iddondang = max(id_donhang) from [DON HANG] 


----thêm món ăn vào chi tiết đặt hàng
create 
--alter
proc proc_ctdondathang
@id_donhang char(10),
@tenmon nvarchar(50),
@soluong int,
@id_chinhanh char(10)
as
	if exists ( select * from [TINH TRANG MON AN] where [TINH TRANG MON AN].[Ten mon]=@tenmon and [TINH TRANG MON AN].id_chinhanh=@id_chinhanh and [TINH TRANG MON AN].[Tinh trang]=N'Còn')
	begin
		insert [CT DON HANG] values (@id_donhang, @tenmon, @soluong)
	end

----đặt hàng
create 
--alter
proc proc_dathang 
@id_donhang char(10),
@makh char(10),
@id_chinhhanh char(10),
@ngaylap datetime,
@hinhthucthanhtoan nvarchar(50),
@phivanchuyen money
as
	if not exists (select * from [KHACH HANG] where [KHACH HANG].MaKH=@makh)
	begin
		print N'Khách hàng không tồn tại!'
		return
	end
	if not exists (select * from [CHI NHANH] where [CHI NHANH].id_chinhanh=@id_chinhhanh)
	begin
		print N'Chi nhánh không tồn tại!'
		return
	end
	if (@ngaylap is not null or @hinhthucthanhtoan is not null or @phivanchuyen is not null)
	begin
		print N'Giá trị nhập vào không được trống!'
		return
	end
	declare @tongdonhang int
	set @tongdonhang = @phivanchuyen + (select SUM([THUC DON].Gia*[CT DON HANG].soluong) from [THUC DON] JOIN [CHI NHANH] ON [THUC DON].[Ma doi tac]=[CHI NHANH].[Ma doi tac] AND [CHI NHANH].id_chinhanh=@id_chinhhanh JOIN [CT DON HANG] ON [CT DON HANG].id_donhang=@id_donhang AND [CT DON HANG].[Ten mon]=[THUC DON].[Ten mon])

	INSERT [DON HANG] VALUES (@id_donhang, null, @id_chinhhanh, @makh, @ngaylap, @hinhthucthanhtoan, @phivanchuyen, @tongdonhang)

---THEO DÕI ĐON HÀNG ĐÃ ĐẶT CỦA KHÁCH HÀNG
CREATE 
--ALTER
PROC proc_thongtindondathang 
@makh char(10), @id_donhang char(10)
as 
	if exists (select * from [DON HANG] where [DON HANG].MaKH=@makh and [DON HANG].id_donhang=@id_donhang)
	begin
		select [DON HANG].id_donhang, [TAI XE].[Ho ten], [TAI XE].[Dien thoai], [DON HANG].[Ngay lap], [DON HANG].[Hinh thuc thanh toan], [DON HANG].[Phi van chuyen], [DON HANG].[Tong don hang], [TINH TRANG DON HANG].[Tinh trang]  from [DON HANG] join [TAI XE] on  [DON HANG].id_donhang=@id_donhang and [DON HANG].MaKH=@makh and [DON HANG].MaTX=[TAI XE].MaTX join [CHI NHANH] on [CHI NHANH].id_chinhanh=[DON HANG].id_chinhanh join [TINH TRANG DON HANG] on [TINH TRANG DON HANG].id_donhang=[DON HANG].id_donhang
	end
---HỦY ĐƠN ( KHI Ở TRẠNG THÁI CHỞ NHẬN)

create
--alter
proc proc_huydon 
@makh char(10), @id_donhang char(10)
as
	if exists (select * from [DON HANG] where [DON HANG].MaKH=@makh and [DON HANG].id_donhang=@id_donhang)
	begin
		if not exists ( select * from [TINH TRANG DON HANG] where [TINH TRANG DON HANG].id_donhang=@id_donhang and [TINH TRANG DON HANG].[Tinh trang]=N'Tiếp nhận/Xử lý')
			begin
				update [TINH TRANG DON HANG] 
				SET [TINH TRANG DON HANG].id_donhang=N'Đã hủy', [Thoi gian don hang]=CURRENT_TIMESTAMP
				WHERE [TINH TRANG DON HANG].id_donhang=@id_donhang
			end
	end 
---ĐÁNH GIÁ ĐƠN HÀNG 
create 
--alter
proc proc_danhgiadonhang 
@id_donhang char(10),
@makh char(10),
@id_chinhanh char(10),
@rate float,
@like bit,
@comment nvarchar(256) 
as
	if not exists (select * from [DON HANG] where [DON HANG].id_donhang=@id_donhang and [DON HANG].MaKH=@makh)
		begin
			RAISERROR (N'Đơn hàng không tồn tại',16,1)
		end
	else 
		begin
			insert [BANG DANH GIA] values(@id_donhang, @makh, @id_chinhanh, @rate, @like, @comment)
		end

----CHỌN ĐỊA CHỈ GIAO HÀNG
create proc diachi_giaohang
@diachi nvarchar(256),
@makh char(10)
as	
	if not exists (select * from [KHACH HANG] where [KHACH HANG].MaKH=@makh)
		begin
			RAISERROR (N'Khách hàng không tồn tại',16,1)
			return
		end
	update [KHACH HANG] 
	set [Dia chi]=@diachi where [KHACH HANG].MaKH=@makh
----Chọn phương thức thanh toán

create 
--alter
proc phuongthucthanhtoan 
@phuongthuc nvarchar(50),
@id_donhang char(10),
@makh char(10) 
as	
	if not exists (select * from [DON HANG] where [DON HANG].id_donhang=@id_donhang and [DON HANG].MaKH=@makh)
		begin
			RAISERROR (N'Đơn hàng không tồn tại',16,1)
		end
	update [DON HANG] 
	set [Hinh thuc thanh toan]=@phuongthuc
	where [DON HANG].id_donhang=@id_donhang and [DON HANG].MaKH=@makh
----------------------TÀI XẾ: GIANG-----------------------------------------------

---xem ds đơn hàng theo khu vực đã đăng ký
create 
--alter 
function f_taixexemdonhang(@khuvuc nvarchar(50))
returns table 
as return select distinct [DON HANG].id_donhang from [DON HANG] join [CHI NHANH] on [DON HANG].id_chinhanh=[CHI NHANH].id_chinhanh and [CHI NHANH].[Dia chi] like @khuvuc join [TINH TRANG DON HANG] on [TINH TRANG DON HANG].[Tinh trang]=N'Chờ nhận' 


---cập nhật tình trạng đon hàng
create 
--alter
proc capnhat_donhanag 
@id_donhang char(10),
@tinhtrang nvarchar(50)
as 
	if not exists (select * from [DON HANG] where [DON HANG].id_chinhanh=@id_donhang) 
	begin
			RAISERROR (N'Đơn hàng không tồn tại',16,1)
			return
	end
	update [TINH TRANG DON HANG] 
	set [Tinh trang]=@tinhtrang where [TINH TRANG DON HANG].id_donhang=@id_donhang
-----hủy đơn 
create 
--alter
proc taixe_huydon
@id_donhang char(10)
as 
	if not exists (select * from [DON HANG] where [DON HANG].id_chinhanh=@id_donhang) 
	begin
			RAISERROR (N'Đơn hàng không tồn tại',16,1)
			return
	end
	update [TINH TRANG DON HANG] 
	set [Tinh trang]=N'Chờ nhận' where [TINH TRANG DON HANG].id_donhang=@id_donhang
----------------------NHÂN VIÊN: THẢO
﻿--Chức năng xem danh sách hợp đồng của đối tác
create 
--alter
function f_dsHopDong()
returns table
as return select [HOP DONG].id_hopdong from [HOP DONG]