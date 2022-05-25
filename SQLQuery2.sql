--Select
Select ContactName,CompanyName,City from Customers

Select * from Customers where City = 'Berlin'
--Case İnsensitive

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID=1 order by UnitPrice desc  --ascending --descending

Select count(*) from Products where CategoryID = 2

select CategoryID from Products group by CategoryID

select CategoryID,COUNT(*) from Products where UnitPrice>20
group by CategoryID having COUNT(*)<10

select * from 