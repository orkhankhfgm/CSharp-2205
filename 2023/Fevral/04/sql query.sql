--[Digital Functions]


--Rəqəmsal funksiyalar

-- Min & Max
select * from Production.Product

select
max(SafetyStockLevel) MaxValue,
min(SafetyStockLevel) MinValue
from Production.Product

select
max(SafetyStockLevel) MaxValue,
min(SafetyStockLevel) MinValue
from Production.Product
group by Color

--Count
select count(*) from Production.Product

select count(*) from Production.Product where SafetyStockLevel = 1000

select
Color,
Count(*) as TotalCount
from Production.Product
where Color is not null
group by Color



--AVG
select count(SafetyStockLevel) CountOfStock from Production.Product
select avg(SafetyStockLevel) AverageOfStock from Production.Product

--Sum
select sum(SafetyStockLevel) SumOfStock from Production.Product






select * from Sales.SalesOrderHeader
select * from Sales.SalesOrderDetail

select * from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID

select SalesPersonID, * from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID

select * from Person.Person where BusinessEntityID=279



select
concat(PP.FirstName, ' ', PP.LastName) as FullName,
sum(SSOD.LineTotal) as Total
from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID
inner join Person.Person PP
on SSOH.SalesPersonID = PP.BusinessEntityID
where
SSOH.OrderDate = '2011-05-31 00:00:00.000'
group by concat(pp.FirstName, ' ', pp.LastName)





-- Text Functions
--Lower & Upper
select * from HumanResources.Employee

select upper(JobTitle), lower(Gender), * from HumanResources.Employee

select upper(lower(JobTitle)), lower(Gender), * from HumanResources.Employee


--Len
select
len(JobTitle) as JobTitleLength,
JobTitle,
len(Gender) as GenderLength,
Gender
from HumanResources.Employee


--Concat
--Manual
select
FirstName + ' ' + LastName as Fullname
from Person.Person


select
concat(FirstName, space(1), LastName) as Fullname
from Person.Person

select
concat(FirstName, space(15), LastName) as Fullname
from Person.Person



--Substring
select Name, substring(Name, 1, 5) from Production.Product

select 
Name, substring(Name, 1, 5) as Name1,
Name, upper(substring(Name, 1, 5)) as UpperName
from Production.Product


--Left & Right
select 
Name, substring(Name, 1, 5) as Name1,
left(Name, 3),
right(Name, 3)
from Production.Product