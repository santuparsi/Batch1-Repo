--GetEmployees using Dept
create function GetEmployeesByDeptId(@deptid varchar(20))
returns table
as
return select * from Employee where Did=@deptid

select * from GetEmployeesByDeptId('D0001')
select Eid,Ename from GetEmployeesByDeptId('D0002')
delete from Employee where Eid=1000