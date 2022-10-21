create function AddNumbers(@a int,@b int)
returns int
as
begin
declare @result int
set @result=@a+@b
return 	@result
end


print dbo.AddNumbers(12,23)



