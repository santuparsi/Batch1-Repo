 --fetch detais from product
 create procedure GetProducts
 as
 begin
 select * from Product
 end
 --execute produre
 exec GetProducts