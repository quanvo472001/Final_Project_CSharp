create database WinformBanSach
use WinformBanSach
create table Users(
	id_user int  IDENTITY(1,1) not null,
	users varchar(40) primary key not null,
	passwords varchar(40) not null,
	name_user nvarchar(50) not null,
	phone varchar(10) not null,
	age int not null,
	position nvarchar(40) not null,
)
create table KhoSach(
	book_id int primary key IDENTITY(1,1) not null,
	book_name nvarchar(50) not null,
	book_author nvarchar(50) not null,
	book_printer nvarchar(50) not null,
	book_price decimal(13,3) not null,
	book_type nvarchar(50) not null,
	book_quantity int not null,
	book_day date not null, 
	book_status nvarchar(40) not null
)
create table DonHang(
	order_id int primary key IDENTITY(1,1) not null,
	order_name nvarchar(50) not null,
	order_author nvarchar(50) not null,
	order_printer nvarchar(50) not null,
	order_price decimal(13,3) not null,
	order_type nvarchar(50) not null,
	order_quantity int not null,
	order_day date not null,
	order_location nvarchar(40),
	order_status nvarchar(40) not null,
)

create table HangHoa(
	item_id int not null,
	item_name nvarchar(50) not null,
	item_author nvarchar(50) not null,
	item_printer nvarchar(50) not null,
	item_price decimal(13,3) not null,
	item_type nvarchar(50) not null,
	item_quantity int not null,
	item_total decimal(15,3) not null,
	item_day date not null, 
	item_status nvarchar(40) not null
)
/*Thêm data vào bảng KhoSach*/
insert into Users values('QuanVo','quan472001',N'Kim Quân','0772487344',21,N'Quản lý')
insert into Users values('admin','123','Admin','111111',30,'Admin')
/*Thêm data vào bảng KhoSach*/	
select * from Users where users = 'HieuTrung' and (position = N'Chủ' or position='Admin')
select * from Users
/*Thêm data vào bảng KhoSach*/
insert into KhoSach values (N'Lì quá để nói quài',N'Hiếu Trung',N'NXB Biên Hòa',75,N'Hài hước',60,'2020-10-21',N'Trong kho hàng')
insert into KhoSach values (N'Yêu em bằng mắt giữ em bằng tim',N'Dương Thụy',N'NXB Trẻ',55,N'Tình cảm',20,getdate(),N'Trong kho hàng')
insert into KhoSach values(N'Đừng yêu thầm nữa tỏ tình đi',N'Ngô Thế Vinh',N'NXB Đồng Nai',65,N'Tình cảm',40,getdate(),N'Trong kho hàng')
insert into KhoSach values(N'Nguồn gốc dịch bệnh',N'David Aquammen',N'NXB Nước Ngoài',50,N'Khoa học công nghệ',10,getdate(),N'Trong kho hàng')
insert into KhoSach values(N'IELTS từ A đến Z',N'Nguyễn Nhật Ánh',N'NXB Kim Đồng',55,N'Giáo dục',10,getdate(),N'Trong kho hàng')
insert into KhoSach values(N'Thỏ 7 màu',N'Nguyễn Phong Việt',N'NXB Thanh Niên',45,N'Thiếu nhi',10,getdate(),N'Trong kho hàng')
/*Thao tác với bảng KhoSach*/
select * from KhoSach
select * from KhoSach where book_id=
update KhoSach set book_name = N'',book_author = N'',book_printer =N'',book_price= ,book_type = N'' where book_id =  
/*Thêm data vào bảng KhoSach*/
insert into DonHang values (N'Lì quá để nói quài',N'Hiếu Trung',N'NXB Biên Hòa',75,N'Hài hước',10,'2020-10-21',N'Quy Nhơn',N'Đang vận chuyển')

/*Thêm data vào bảng KhoSach*/
select * from DonHang where order_day = '2022-01-05'
/*Thêm data vào bảng KhoSach*/
insert into HangHoa values('001',N'Lì quá để nói quài',N'Hiếu Trung',N'NXB Biên Hòa',75,N'Hài hước',60,60*75,'2020-10-21',N'Trong kho hàng')
/*Thêm data vào bảng KhoSach*/
select * from HangHoa where item_day='2020-10-21'
select SUM(item_quantity)*(HangHoa.item_price) from HangHoa where MONTH(item_day) = '10' and item_id = '2'
select MONTH(item_day) as 'Tháng', SUM(item_quantity) as 'Tổng số hàng đã nhập', SUM(item_total) as 'Số tiền đã trả'  from HangHoa where item_status = N'Nhập hàng' group by MONTH(item_day) 
/*Trigger update mặt hàng trong kho sau khi xuất*/
CREATE TRIGGER trg_DatHang ON DonHang AFTER INSERT AS 
BEGIN
	UPDATE KhoSach
	SET book_quantity = book_quantity - (
		SELECT order_quantity
		FROM inserted
		WHERE order_name = KhoSach.book_name
	)
	FROM KhoSach
	JOIN inserted ON KhoSach.book_name = inserted.order_name
END
Go
/*Trigger thêm hàng vào trong kho hàng*/
create trigger trg_Khohang on KhoSach instead of insert as
begin

	declare @ID int
	declare @price decimal(13,3)
	declare @name nvarchar(50)
	declare @quantity int
	declare @author nvarchar(50)
	declare @printer nvarchar(50)
	declare @type nvarchar(50)
	
	select @author = book_author from inserted
	select @printer = book_printer from inserted
	select @type = book_type from inserted
	select @price = book_price from inserted
	select @name = book_name from inserted
	select @quantity = book_quantity from inserted
	select @ID = book_id from KhoSach where @name = book_name

	if(exists(select KhoSach.book_name from KhoSach where KhoSach.book_name=@name))
	begin
		update KhoSach set book_quantity = book_quantity+(select book_quantity from inserted where book_name=@name) where book_name=@name
		insert into HangHoa values(@ID,@name,@author,@printer,@price,@type,@quantity,(@quantity*@price),GETDATE(),N'Nhập hàng')
	end
	else 
		insert into KhoSach values(@name,@author,@printer,@price,@type,@quantity,GETDATE(),N'Trong kho hàng')
		
end
go
drop trigger trg_Khohang
/*Trigger thêm hàng vào trong kho hàng*/
create trigger trg_HangHoa on KhoSach after insert as 
begin
	declare @ID int
	declare @price decimal(13,3)
	declare @name nvarchar(50)
	declare @quantity int
	declare @author nvarchar(50)
	declare @printer nvarchar(50)
	declare @type nvarchar(50)
	declare @day date
	
	
	select @author = book_author from inserted
	select @printer = book_printer from inserted
	select @type = book_type from inserted
	select @price = book_price from inserted
	select @name = book_name from inserted
	select @quantity = book_quantity from inserted
	select @day = book_day from inserted
	select @ID = book_id from KhoSach where @name = book_name	

	insert into HangHoa values(@ID,@name,@author,@printer,@price,@type,@quantity,(@quantity*@price),@day,N'Nhập hàng')
end
go

drop trigger trg_HangHoa
/*Trigger thêm hàng vào trong kho hàng*/
create trigger trg_Bill on DonHang after insert as 
begin
	declare @ID int
	declare @price decimal(13,3)
	declare @name nvarchar(50)
	declare @quantity int
	declare @author nvarchar(50)
	declare @printer nvarchar(50)
	declare @type nvarchar(50)
	declare @day date
	
	
	select @author = order_author from inserted
	select @printer = order_printer from inserted
	select @type = order_type from inserted
	select @price = order_price from inserted
	select @name = order_name from inserted
	select @quantity = order_quantity from inserted
	select @day = order_day from inserted
	select @ID = book_id from KhoSach,DonHang where @name = book_name
		
	insert into HangHoa values(@ID,@name,@author,@printer,@price,@type,@quantity,(@quantity*@price),@day,N'Xuất hàng')
end
go
drop trigger trg_Bill


