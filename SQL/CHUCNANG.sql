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
	select loaitaikhoan, [KHACH HANG].MaKH from [TAI KHOAN] join [KHACH HANG] on [TAI KHOAN].tentaikhoan=@username and matkhau=@password and [KHACH HANG].tentaikhoan=[TAI KHOAN].tentaikhoan
exec sp_login 'abc','123'
---Xem danh sách quán
create 
--alter
proc sp_dsquan
as  select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [DOI TAC].[So luong chi nhanh], [DOI TAC].[So dien thoai] from [DOI TAC]
exec sp_dsquan
--Tìm kiếm quán
create 
--alter
proc sp_timkiemquan @tenquan nvarchar(20) 
as select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [DOI TAC].[So luong chi nhanh], [DOI TAC].[So dien thoai] from [DOI TAC] where [DOI TAC].[Ten quan]=@tenquan
select * from [DOI TAC]
SELECT * FROM [CHI NHANH]
insert [TAI KHOAN NGAN HANG] values ('VCB','135465',N'Quận 10')
insert [TAI KHOAN] values('dt1','123','Doi tac')
insert [CHI NHANH] values ('cn1','1','Quan7','8:00:00','22:00:00',null,N'Quán ăn 1',N'Đang mở cửa',null,'VCB','135465',4.6,'dt1')
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

-----------------------------------------------------------------------------------------------------------------------------------------
---Chức năng đăng nhập


create 
--alter
proc sp_login @username nvarchar(50), @password char(20) 
as
	declare @loaitk nvarchar(50)
	set @loaitk=(select loaitaikhoan from [TAI KHOAN] where [TAI KHOAN].tentaikhoan=@username and [TAI KHOAN].matkhau=@password )
	if @loaitk='Khach hang'
	begin
		select loaitaikhoan, MaKH from [TAI KHOAN] join [KHACH HANG] on [TAI KHOAN].tentaikhoan=[KHACH HANG].tentaikhoan and [TAI KHOAN].tentaikhoan=@username and [TAI KHOAN].matkhau=@password
	end
	else if @loaitk='Tai xe' 
	begin
		select loaitaikhoan, MaTX from [TAI KHOAN] join [TAI XE] on [TAI KHOAN].tentaikhoan=[TAI XE].tentaikhoan and [TAI KHOAN].tentaikhoan=@username and [TAI KHOAN].matkhau=@password
	end
	---Xem danh sách quán
create 
--alter
proc sp_dsquan
as  select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [DOI TAC].[So luong chi nhanh], [DOI TAC].[So dien thoai] from [DOI TAC]

--Tìm kiếm quán
create 
--alter
proc sp_timkiemquan @tenquan nvarchar(20) 
as select [DOI TAC].[Ten quan], [DOI TAC].[Thanh pho/Quan], [DOI TAC].[So luong chi nhanh], [DOI TAC].[So dien thoai] from [DOI TAC] where [DOI TAC].[Ten quan]=@tenquan

--tao id_donhang tu dong 
CREATE 
--alter 
FUNCTION dbo.auto_iddonhang()
RETURNS char(10)
AS
BEGIN
	DECLARE @ID char(10)
	DECLARE @COUNT INT
	--SET @COUNT = (SELECT COUNT(id_donhang) FROM [DON HANG]) 
	SELECT @COUNT = MAX(RIGHT(id_donhang, 7)) FROM [DON HANG]
	SELECT @ID ='DH0' + CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END
select * from [DON HANG]
-- tạo chi tiết đơn hàng tạm thời
print dbo.auto_iddonhang()
create
--alter
proc taoctdonhang @id char(10), @id_chinhanh char(10), @id_doitac char(10), @tenmon nvarchar(80), @soluong int
as
	begin try
		insert into [CT DON HANG] values(@id, @id_chinhanh, @id_doitac, @tenmon, @soluong)
		return 0
	end try
	begin catch
	end catch

--tao don hang tam thoi
create 
--alter
proc taodonhang @id_chinhanh char(10), @id_doitac char(10), @makh char(10)
as
	declare @id char(10)
	set @id=dbo.auto_iddonhang()
	insert [DON HANG] values (@id, null, @id_chinhanh, @id_doitac, @makh, null, null, null, null, null, null,null)
	select id_donhang from [DON HANG] where id_donhang=@id

select * from [DON HANG]
select * from [CT DON HANG]


-- hủy đơn hàng tạm thời( giỏ hàng)
create 
--alter 
proc huydonhang @id_donhang char(10)
as 
	begin try
		if exists( select id_donhang from [DON HANG] where id_donhang=@id_donhang)
		begin
			delete [DON HANG] where id_donhang=@id_donhang
			return 0
		end
	end try
	begin catch
	end catch 
exec huydonhang 'DH04'

create 
--alter
proc tinhtongdonhang @id_donhang char(10)
as
	begin
		select sum(soluong*gia) as 'Tong' from [CT DON HANG] join [THUC DON] on id_chinhanh="Ma chi nhanh" and id_doitac="Ma doi tac" and [CT DON HANG]."Ten mon"=[THUC DON].[Ten mon] and [CT DON HANG].id_donhang=@id_donhang
	end
EXEC tinhtongdonhang 'DH03'


create 
--alter
proc update_donhang @id_donhang char(10)
as
	begin try
		declare @phivanchuyen money
		set @phivanchuyen =15000

		declare @tongdonhang int 
		set @tongdonhang = (select sum(soluong*gia) as 'Tong' from [CT DON HANG] join [THUC DON] on id_chinhanh="Ma chi nhanh" and id_doitac="Ma doi tac" and [CT DON HANG]."Ten mon"=[THUC DON].[Ten mon] )
		set @tongdonhang= @tongdonhang+@phivanchuyen 
		declare @khuvuc char(10)
		set @khuvuc = (select [CHI NHANH].id_khuvuc from [DON HANG] join [CHI NHANH] on id_donhang=@id_donhang and [DON HANG].id_chinhanh=[CHI NHANH].id_chinhanh and [DON HANG].id_doitac=[CHI NHANH].[Ma doi tac])
		if exists( select id_donhang from [DON HANG] where id_donhang=@id_donhang)
		begin
			update [DON HANG] 
			set [Ngay lap]=CURRENT_TIMESTAMP, [Phi van chuyen]=@phivanchuyen , [Tong don hang]=@tongdonhang, id_khuvuc=@khuvuc
			where id_donhang=@id_donhang
			select * from [DON HANG] where id_donhang=@id_donhang
		end
	end try
	begin catch
		return 1
	end catch
select * from [DON HANG]
create 
--alter
proc hoantatdonhang @id_donhang char(10), @httt nvarchar(50), @diachi nvarchar(256)
as
	begin try
		if exists( select id_donhang from [DON HANG] where id_donhang=@id_donhang)
		begin
			update [DON HANG] 
			set [Hinh thuc thanh toan]=@httt, [Ngay lap]=CURRENT_TIMESTAMP, [Tinh trang don hang]=N'Chờ nhận', diachi=@diachi
			where id_donhang=@id_donhang
			return 0

		end
	end try
	begin catch
		return 1
	end catch

--truy vấn những đang hàng đang được thực hiện
create 
--alter 
proc donhang_dangduocthuchien @makh char(10)
as	
	begin try
		select [DON HANG].id_donhang from [DON HANG] where MaKH=@makh and [Tinh trang don hang]!='null'
	end try
	begin catch
	end catch

--truy vấn tình trạng đơn hàng
create
--alter
proc tinhtrangdonhang @iddonhang char(10)
as
	begin try
		select * from [DON HANG] where id_donhang=@iddonhang
	end try
	begin catch
	end catch
create 
--alter
proc donhang_thanhcong @makh char(10)
as
	begin try
		select * from [DON HANG] 
		where MaKH=@makh and [Tinh trang don hang] =N'Giao hàng thành công' and DATEDIFF(day, [Ngay lap], CURRENT_TIMESTAMP) <30 and id_donhang not in (select id_donhang from [BANG DANH GIA])
	end try
	begin catch
	end catch
create 
--alter
proc lichsudonhang @makh char(10)
as
	begin try
		select * from [DON HANG] 
		where MaKH=@makh and ([Tinh trang don hang]=N'Đã hủy' or [Tinh trang don hang]=N'Giao hàng thành công') and DATEDIFF(day, [Ngay lap], CURRENT_TIMESTAMP) <30 
	end try
	begin catch
	end catch

create 
--alter
proc danhgiadonhang @id_donhang char(10), @makh char(10), @comment nvarchar(256), @rate float 
as
	begin try
		if not exists(select * from [BANG DANH GIA] where id_donhang=@id_donhang)
		begin
			declare @id_chinhanh char(10)
			declare @id_doitac char(10)
			set @id_chinhanh= (select id_chinhanh from [DON HANG] where id_donhang=@id_donhang) 
			set @id_doitac= (select id_doitac from [DON HANG] where id_donhang=@id_donhang) 

			insert [BANG DANH GIA] values (@id_doitac, @id_donhang, @makh, @id_chinhanh, @rate, null, @comment)
		end
	end try
	begin catch
	end catch
select * from [BANG DANH GIA]

--chức năng: danh sách đơn hàng của 1 khu vực
create
--alter
proc dsdonhang @id_khuvuc char(10)
as
	begin try
		select id_donhang, [KHACH HANG].MaKH , [Ngay lap], [Hinh thuc thanh toan], [Phi van chuyen], [Tong don hang], 
		[Tinh trang don hang], [CHI NHANH].Ten 'Ten chi nhanh', [CHI NHANH].[Dia chi] 'Dia chi chi nhanh', [CHI NHANH].sdt 'sdt', [KHACH HANG].[Ho ten] 'Ho ten kh', [KHACH HANG].[So dien thoai] 'sdt kh', [KHACH HANG].[Dia chi] 'dckh'  from [DON HANG] join [CHI NHANH] on [DON HANG].id_chinhanh=[CHI NHANH].id_chinhanh and [DON HANG].id_doitac=[CHI NHANH]."Ma doi tac" and [DON HANG].[Tinh trang don hang]=N'Chờ nhận' and [CHI NHANH].id_khuvuc=@id_khuvuc join [KHACH HANG] on [KHACH HANG].MaKH=[DON HANG].MaKH
	end try
	begin catch
	end catch
select * from [DON HANG]
update [DON HANG] set [Tinh trang don hang]=N'Chờ nhận' where id_donhang='DH06'
create 
--alter
proc thongtinkhachhang @makh char(10)
as
	begin try
		select [Ho ten], [So dien thoai], [Dia chi] from [KHACH HANG] where MaKH=@makh
	end try
	begin catch
	end catch
create 
--alter
proc thongtinchinhanh @iddonhang char(10)
as
	begin try
		select [CHI NHANH].[Dia chi], [CHI NHANH].Ten, [CHI NHANH].sdt , [DON HANG].id_chinhanh, [DON HANG].id_doitac from [CHI NHANH] join [DON HANG] 	
		on [DON HANG].id_donhang=@iddonhang and [CHI NHANH].id_chinhanh=[DON HANG].id_chinhanh and [CHI NHANH].[Ma doi tac]=[DON HANG].id_doitac 
	end try
	begin catch
	end catch
select * from [DON HANG]
exec dsdonhang 'kv2'

create 
--alter
proc taixe_nhandon @id_donhang char(10), @matx char(10)
as
	begin try
		update [DON HANG] 
		set MaTX=@matx, [Tinh trang don hang] = N'Tài xế đã nhận đơn hàng'
		where id_donhang=@id_donhang
		return 0
	end try
	begin catch
	end catch 

create
--alter
proc taixe_chuyentrangthai  @id_donhang char(10)
as
	begin try
		declare @tinhtrang nvarchar(256)
		select @tinhtrang=[Tinh trang don hang] from [DON HANG] where id_donhang=@id_donhang 
		if @tinhtrang = N'Tài xế đã nhận đơn hàng'
		begin
			update [DON HANG] 
			set [Tinh trang don hang]=N'Tài xế đã tới quán ăn'
			where id_donhang=@id_donhang
		end
		else if @tinhtrang = N'Tài xế đã tới quán ăn'
		begin
			update [DON HANG] 
			set [Tinh trang don hang]=N'Tài xế đã nhận món ăn'
			where id_donhang=@id_donhang
		end
		else if @tinhtrang = N'Tài xế đã nhận món ăn'
		begin
			update [DON HANG] 
			set [Tinh trang don hang]=N'Tài xế đã tới nơi'
			where id_donhang=@id_donhang
		end
		else if @tinhtrang = N'Tài xế đã tới nơi'
		begin
			update [DON HANG] 
			set [Tinh trang don hang]=N'Giao hàng thành công'
			where id_donhang=@id_donhang
		end
		return 0
	end try
	begin catch
	end catch 



create 
--alter
proc taixe_tuchoi @id_donhang char(10)
as
	begin try
		update [DON HANG] 
		set MaTX=null, [Tinh trang don hang] =N'Chờ nhận'
		where id_donhang=@id_donhang
		return 0
	end try
	begin catch
	end catch 
exec taixe_tuchoi 'DH05'
select * from [DON HANG]
--chức năng tài xế xem lại lịch sử đơn hàng của mình, phí vận chuyển cho đơn hàng đó
create
--alter
proc dsdonhangdanhan @matx char(10)
as
	begin try
		select id_donhang, [Hinh thuc thanh toan], [Phi van chuyen] from [DON HANG] where MaTX=@matx and [Tinh trang don hang]=N'Giao hàng thành công' and DATEDIFF(day, [Ngay lap], CURRENT_TIMESTAMP) <=5
	end try
	begin catch
	end catch 

create proc updateChinhanh
@tencn char(10),
@dc nvarchar(50),
@tgm time,
@tgd time,
@id char(10),
@iddt char(10)
as 
begin
	if (@tencn is null) or (@dc is null) or(@tgm is null) or (@tgd is null) or (@id is null) 
	begin
		rollback
	end
	update [CHI NHANH]
	set Ten=@tencn,[Dia chi]=@dc,[Thoi gian mo cua]=@tgm,[Thoi gian dong cua]=@tgd
	where @id=id_chinhanh and [Ma doi tac]=@iddt
end

create proc themChinhanh
@id char(10),
@madt char(10),
@tennh nvarchar(10),
@stk numeric(20),
@tgm time,
@tgd time
as 
begin
	if (@id is null) or (@madt is null) or(@tgm is null) or (@tgd is null) or (@tennh is null) or (@stk is null)
	begin
		rollback
	end
	insert into [CHI NHANH](id_chinhanh,[Ma doi tac],[Ten Ngan hang],[So tai khoan],[Thoi gian dong cua],[Thoi gian dong cua])
	values(@id,@madt,@tennh,@stk,@tgm,@tgd)
end

create proc updateMonan
@mieuta nvarchar(50),
@gia money,
@tinhtrang nvarchar(50),
@tenmon nvarchar(50)
as
begin
	if (@mieuta is null) or (@gia is null) or(@tinhtrang is null) or (@tenmon is null)
	begin
		rollback
	end
	update [THUC DON] 
	set [Mieu ta]=@mieuta,Gia=@gia,[Tinh trang mon an]=@tinhtrang
	where @tenmon=[Ten mon]
end

create proc themMonan
@tenmon nvarchar(50),
@madt char(10),
@macn char(10),
@gia money,
@mieuta nvarchar(50),
@tinhtrang nvarchar(50)
as
begin
	if exists (select*from [THUC DON] where [Ten mon]=@tenmon)
	rollback
	if not exists(select*from [THUC DON] where @madt=[Ma doi tac] and @macn=[Ma chi nhanh])
	rollback
	if (@mieuta is null) or (@gia is null) or(@tinhtrang is null) or (@tenmon is null) or (@madt is null) or (@macn is null)
	begin
		rollback
	end
	insert into [THUC DON]([Ten mon],[Ma doi tac],[Ma chi nhanh],Gia,[Mieu ta],[Tinh trang mon an])
	values(@tenmon,@madt,@macn,@gia,@mieuta,@tinhtrang)
end


create
--alter
proc xemDoanhthu
@iddt char(10),
@ngaybd date,
@ngaykt date
as 
begin 
	if (@iddt is null) or (@ngaybd is null) or (@ngaykt is null) 
	rollback
	select* from [DOANH THU DOI TAC] dt where dt.id_doitac = @iddt and ngay <= @ngaykt and ngay>= @ngaybd
end 



create
--alter
proc xemThucDon
@iddt char(10),
@idcn char(10)
as 
begin 
	if (@iddt is null)
	rollback
	if not exists (select*from [DOI TAC] where [Ma doi tac]=@iddt)
	rollback
	select* from [THUC DON]  where [Ma doi tac] = @iddt and [Ma chi nhanh] = @idcn
end 