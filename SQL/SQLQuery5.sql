create procedure GetProductNameById(@pid int,@pname varchar(30) output)
as
begin
select @pname=pname from product where pid=@pid
end

declare @pname varchar(30)
exec GetProductNameById 2,@pname output
select @pname