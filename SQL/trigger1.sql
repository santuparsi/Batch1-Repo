create trigger delete_employee_tg
on Employee
After Delete
as
rollback tran
print 'access denied'
delete from Employee where Eid=1001
select * from Employee