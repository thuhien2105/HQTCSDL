


create 
--alter
proc dschinhanh @id_doitac char(10)
as
	select * from [CHI NHANH] where [Ma doi tac]=@id_doitac

create
--alter
proc xemthongtindoitac @id_doitac char(10)
as
	select * from [DOI TAC]

create 
--alter
proc updateChinhanh
@dc nvarchar(50),
@tgm time,
@tgd time,
@iddt char(10),
@idcn char(10)
as 
begin
	if (@dc is null) or(@tgm is null) or (@tgd is null) 
	begin
		rollback
	end
	update [CHI NHANH]
	set [Dia chi]=@dc,[Thoi gian mo cua]=@tgm,[Thoi gian dong cua]=@tgd
	where @idcn=id_chinhanh and [Ma doi tac]=@iddt
end

CREATE 
--alter 
FUNCTION dbo.auto_id_chinhanh()
RETURNS char(10)
AS
BEGIN
	DECLARE @ID char(10)
	DECLARE @COUNT INT
	SELECT @COUNT = MAX(RIGHT(id_chinhanh, 7)) FROM [CHI NHANH]
	SELECT @ID ='CN0' + CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END

create 
--alter
proc themChinhanh
@madt char(10),
@tenchinhanh nvarchar(256),
@tennh nvarchar(10),
@stk numeric(20),
@tgm time,
@tgd time,
@diachi nvarchar(256),
@sdt numeric(10,0)
as 
begin tran
	begin try
	declare @macn char(10)
	set @macn=dbo.auto_id_chinhanh()
	insert into [CHI NHANH](id_chinhanh,[Ma doi tac],[Dia chi],[Thoi gian mo cua],[Thoi gian dong cua],Ten,[Ten Ngan hang],[So tai khoan],sdt)
	values(@macn,@madt,@diachi,@tgm,@tgm,@tenchinhanh,@tennh,@stk,@sdt)
	end try
	begin catch
		rollback tran
	end catch
commit tran

create 
--alter
proc updateMonan
@mieuta nvarchar(50),
@gia money,
@tinhtrang nvarchar(50),
@tenmon nvarchar(50),
@id_doitac char(10),
@id_chinhanh char(10)
as
begin tran
	begin try
	if (@mieuta is null) or (@gia is null) or(@tinhtrang is null) or (@tenmon is null)
	begin
		rollback
	end
	update [THUC DON] 
	set [Mieu ta]=@mieuta,Gia=@gia,[Tinh trang mon an]=@tinhtrang
	where [Ten mon]=@tenmon and [Ma doi tac]=@id_doitac and [Ma chi nhanh]=@id_chinhanh
	end try
	begin catch
		rollback tran
	end catch
commit tran

create 
--alter
proc themMonan
@tenmon nvarchar(50),
@madt char(10),
@macn char(10),
@gia money,
@mieuta nvarchar(50),
@tinhtrang nvarchar(50)
as
begin tran
	begin try
	insert into [THUC DON]([Ten mon],[Ma doi tac],[Ma chi nhanh],Gia,[Mieu ta],[Tinh trang mon an])
	values(@tenmon,@madt,@macn,@gia,@mieuta,@tinhtrang)
	end try
	begin catch
		rollback tran
	end catch
commit tran



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

create 
--alter
proc updateThongtin 
@id char(10),
@email char(50),
@dc nvarchar(20),
@sdt numeric(10),
@tennh nvarchar(10),
@stk numeric(20)
as 
begin
	if  (@email is null) or(@dc is null) or (@sdt is null) or (@tennh is null) or (@stk is null ) or (@id is null) 
	begin
		rollback
	end
	update "DOI TAC" 
	set Email= @email , [Thanh pho/Quan]= @dc , [So dien thoai]=@sdt , [Ten ngan hang]=@tennh , [So tai khoan]=@stk
	where [Ma doi tac]=@id
end



use DOAN

-----------------------------------------------------------------------------------------------------------------------------------------
CREATE 
--alter 
FUNCTION dbo.auto_idkhachhang()
RETURNS char(10)
AS
BEGIN
	DECLARE @ID char(10)
	DECLARE @COUNT INT
	SELECT @COUNT = MAX(RIGHT(MaKH, 7)) FROM [KHACH HANG]
	SELECT @ID ='KH0' + CONVERT(CHAR, CONVERT(INT, @COUNT) + 1)
	RETURN @ID
END

--đăng ký
create 
--alter
proc sp_signup @tentaikhoan char(50), @matkhau char(20), @hoten nvarchar(50), @sdt numeric(10,0), @diachi nvarchar(50), @email nvarchar(50)
as
	begin transaction
		begin try
			declare @makh char(10)
			set @makh=dbo.auto_idkhachhang()
			insert [TAI KHOAN] values (@tentaikhoan,@matkhau, 'Khach hang')
			insert [KHACH HANG] values (@hoten, @sdt, @diachi, @email, @makh, @tentaikhoan)
		end try
		begin catch
			rollback tran
		end catch
commit tran
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
	else if @loaitk='Nhan vien' 
	begin
		select loaitaikhoan, id_nhanvien from [TAI KHOAN] join [NHAN VIEN] on [TAI KHOAN].tentaikhoan=[NHAN VIEN].tentaikhoan and [TAI KHOAN].tentaikhoan=@username and [TAI KHOAN].matkhau=@password
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
	begin tran
	begin try
		insert into [CT DON HANG] values(@id, @id_chinhanh, @id_doitac, @tenmon, @soluong)
	end try
	begin catch
		rollback tran
	end catch
commit tran

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
		[Tinh trang don hang], [CHI NHANH].Ten 'Ten chi nhanh', [CHI NHANH].[Dia chi] 'Dia chi chi nhanh', [CHI NHANH].sdt 'sdt', [KHACH HANG].[Ho ten] 'Ho ten kh', [KHACH HANG].[So dien thoai] 'sdt kh', [KHACH HANG].[Dia chi] 'dckh'  from [DON HANG] join [CHI NHANH] on [DON HANG].id_chinhanh=[CHI NHANH].id_chinhanh and [DON HANG].id_doitac=[CHI NHANH]."Ma doi tac" and [DON HANG].MaTX is null and [CHI NHANH].id_khuvuc=@id_khuvuc join [KHACH HANG] on [KHACH HANG].MaKH=[DON HANG].MaKH
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
		select [Ho ten], [So dien thoai], [Dia chi], Email from [KHACH HANG] where MaKH=@makh
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




--NHÂN VIÊN XEM DANH SÁCH HỢP ĐỒNG thiếu rate đối tác
create
--alter
proc dshopdong 
as
	select id_hopdong, [DOI TAC].[Ten quan], [DOI TAC].[So dien thoai], [DOI TAC].[Thanh pho/Quan], [DOI TAC].ratetb, [NHAN VIEN].[Ten nhan vien], [HOP DONG].[Ma so thue], [HOP DONG].[Ngay lap], [HOP DONG].[Phan tram hoa hong],[HOP DONG].[Thoi gian het hieu luc] from [HOP DONG] join [NHAN VIEN] on [HOP DONG].id_nhanvien=[NHAN VIEN].id_nhanvien  join [DOI TAC] on [DOI TAC].[Ma doi tac]=[HOP DONG].id_doitac and [HOP DONG].tinhtrang=N'Đã duyệt'
	order by [HOP DONG].[Thoi gian het hieu luc] asc

create 
--alter
proc dshopdong_chuaduyet
as
	select id_hopdong, [DOI TAC].[Ten quan], [DOI TAC].[So dien thoai], [DOI TAC].[Nguoi dai dien], [DOI TAC].[Thanh pho/Quan],  [HOP DONG].[Ma so thue], [HOP DONG].[Ngay lap], [HOP DONG].[Phan tram hoa hong],[HOP DONG].[Thoi gian het hieu luc] from [HOP DONG] join [DOI TAC] on [DOI TAC].[Ma doi tac]=[HOP DONG].id_doitac and [HOP DONG].tinhtrang=N'Chưa duyệt'
	order by [HOP DONG].[Ngay lap] asc 

create 
--alter
proc duyethopdoong @id_nhanvien char(10), @id_hopdong char(10)
as
	update [HOP DONG]
	set tinhtrang=N'Đã duyệt', id_nhanvien=@id_nhanvien 
	where id_hopdong=@id_hopdong

create 
--alter
proc giahanhopdong @id_hophong char(10), @ngayhieuluc datetime 
as
	update [HOP DONG] 
	set [Thoi gian het hieu luc]=@ngayhieuluc
	where id_hopdong=@id_hophong
create 
--alter
proc thongtinhopdong @idhopdong char(10)
as
	select [Ma so thue], Email, [So dien thoai], [Thanh pho/Quan],[Nguoi dai dien], [Ten quan], [HOP DONG].[Thoi gian het hieu luc] from [HOP DONG] join [DOI TAC] on [HOP DONG].id_doitac=[DOI TAC].[Ma doi tac] 
select * from [HOP DONG]

select * from [KHACH HANG]
create 
--alter
proc updatekhachhang @id_khachhang char(10), @hoten nvarchar(50), @sdt numeric(10,0),@diachi nvarchar(50), @email nvarchar(50)
as 
	begin tran
		begin try
			update [KHACH HANG]
			set [Ho ten]=@hoten, [So dien thoai]=@sdt, [Dia chi]=@diachi, Email=@email
			where MaKH=@id_khachhang
		end try
		begin catch
			rollback tran
		end catch
	commit tran