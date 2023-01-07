--In - Not In
select * from Production.Product;

select * from Production.Product where
ProductNumber = 'AR-5381' or
ProductNumber = 'BA-8327' or
ProductNumber = 'BE-2349' or
ProductNumber = 'BE-2908'

select * from Production.Product where
ProductNumber
IN(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908'
)

select * from Production.Product where
ProductNumber != 'AR-5381' and
ProductNumber != 'BA-8327' and
ProductNumber != 'BE-2349' and
ProductNumber != 'BE-2908'

select * from Production.Product where
ProductNumber
NOT IN(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908'
)

--Order By (sorting)
select * from Production.ProductModel where Name like '%a%' order by ProductModelID

--normal sorgu
select * from Production.ProductModel where Name like '%a%' order by Name

--artan siralama
select * from Production.ProductModel where Name like '%a%' order by Name

--azalan siralama
select * from Production.ProductModel where Name like '%a%' order by Name desc --descending

select * from Sales.Store order by SalesPersonID
select * from Sales.Store order by SalesPersonID asc

select * from Sales.Store order by SalesPersonID
select * from Sales.Store order by SalesPersonID desc

--A-Z siralama: asc
--Z-A siralama: desc




--Group By
select * from Production.Product;

select * from Production.Product where Color is not null

select Color, Sum(SafetyStockLevel) StockLevel, avg(ListPrice) AvgPrice from Production.Product
where Color is not null
group by Color






--Distinct
select * from Production.Product;

select distinct Color from Production.Product;
select distinct Color, Name from Production.Product;





select * from Sales.SalesOrderDetail;

select distinct ProductID from Sales.SalesOrderDetail;


select * from Production.Product
where
ProductID in
(
	select distinct ProductID from Sales.SalesOrderDetail
)



select Color, sum(ListPrice) from Production.Product
where
ProductID in
(
	select distinct ProductID from Sales.SalesOrderDetail
)
group by Color



select * from Production.Product;

select * from Production.Product where ListPrice >= 50 and ListPrice <= 100

select * from Production.Product where ListPrice between 50 and 100










--What is relational database?

/*
	Customers (table)
	--Id
	--Name
	--Surname
	--Gender
	--BirthDate
	--Email
	--PhoneNumber



	Customers (table)
	--Id
	--Name
	--Surname
	--Gender
	--BirthDate
	--Email
	--PhoneNumber1
	--PhoneNumber2
	--PhoneNumber3
	--PhoneNumber4
	--PhoneNumber5
	--PhoneNumber6
	--PhoneNumber7




	Customers (table)
	--Id
	--Name
	--Surname
	--Gender
	--BirthDate

	Contacts (table)
	--Id
	--CustomerId (Customer table'indaki musterinin Id'si bura gelecek)
	--Phone
	--Email




	Customers (table)
	--Id
	--Name
	--Surname
	--Gender
	--BirthDate

	ContactTypes (table) (Numune data: 1. Phone, 2. Email, 3. Fax)
	--Id
	--Name

	Contacts (table)
	--Id
	--CustomerId (Customer table'indaki musterinin Id'si bura gelecek)
	--ContactTypeId
	--Value
*/





--Inner Join
select * from Person.Person;
select * from Person.EmailAddress;

select * from Person.Person
inner join Person.EmailAddress
on Person.BusinessEntityID = EmailAddress.BusinessEntityID;


select * from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.BusinessEntityID;


select 
 pp.BusinessEntityID,
 pp.FirstName,
 pp.MiddleName,
 pp.LastName,
 pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.BusinessEntityID;




--Left Join

select * from Person.Person;
select * from Person.ContactType;

select * from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID


select 
 pp.BusinessEntityID,
 pp.FirstName,
 pp.MiddleName,
 pp.LastName,
 pct.*
from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID
order by pp.BusinessEntityID asc





--Right Join
select * from Person.Person;
select * from Person.ContactType;

select * from Person.ContactType pct
right join Person.Person pp 
on pp.BusinessEntityID = pct.ContactTypeID





--Sub query
select * from Person.Person;
select * from Person.EmailAddress;

--inner join ile
select 
	pp.FirstName,
	pp.LastName,
	pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID;


--sub query ile
select
FirstName,
LastName,
(select EmailAddress from Person.EmailAddress where EmailAddressID = Person.BusinessEntityID) as Email
from Person.Person;