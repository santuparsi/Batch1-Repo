--get salary of Employee using id
create function GetSalary(@eid int)
returns int
as
begin
declare @salary int
select @salary=salary from Employee where Eid=@eid
return @salary
end

print dbo.GetSalary(1000)

select * from Employee