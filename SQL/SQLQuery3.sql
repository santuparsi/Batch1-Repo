create procedure GetProductById(@pid int)
as
begin
select * from product where pid=@pid
end

exec GetProductById 2