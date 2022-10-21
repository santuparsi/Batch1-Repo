create procedure AddProduct(@pid int,@pname varchar(20),@price int,@stock int)
as
begin
insert into product values(@pid,@pname,@price,@stock)
end

exec AddProduct 34,'Book',30,100
exec GetProducts