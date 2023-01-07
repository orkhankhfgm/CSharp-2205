/* SELECT */
select * from person.Person;
select BusinessEntityID, FirstName, MiddleName, LastName from person.Person;

--Columnlari birlesdirerek ve ya yeniden adlandiraraq select etmek
select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName from person.Person;

select BusinessEntityID Sira, FirstName Ad, LastName Soyad from person.Person;

select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName Fullname from person.Person;

--Column adinda iki ferqli sözden istifade etmek

select BusinessEntityID, FirstName + ' ' + LastName [Ad Soyad] from person.Person;


/* TOP CLAUSE */
--Table'daki bütün datalari getir
select * from person.Address;

--Table'daki ilk 20 datani getir
select top 20 * from person.Address;
/* PERCENT */
select top 20 percent * from person.Address;
select top 30 percent * from person.Address;


/* WHERE CLAUSE */
select * from person.Person;

--Adi John olan bütün personlari getir
select * from person.Person where FirstName = 'John';

--ID'si 9 olan bütün personlari getir
select * from person.Person where BusinessEntityID = 9;

/*
	Task In Lesson 1:
	1. Person.EmailAddress table'ından EmailAddressID'si 3 olan məlumatların bütün column'larını gətir.
	2. Production.ProductDocument table'ından ProductID'si 517 olan məlumatların bütün column'larını gətir.
	3. Sales.Currency table'ından CurrencyCode'u 'AZM' olan məlumatların bütün column'larını gətir.
	4. Sales.SalesTerritory table'ından TerritoryID'si 6 olan məlumatların sadəcə Name və CountryRegionCode column'larını gətir.
*/

select * from Person.EmailAddress where EmailAddressID = 3;--1
select * from Production.ProductDocument where ProductID = 517;--2
select * from Sales.Currency where CurrencyCode = 'AZM';--3
select Name, CountryRegionCode from Sales.SalesTerritory where TerritoryID = 6;--4

select [group] from Sales.SalesTerritory;



/* Multiple Where Clause */

--and (and operatorunda butun sertler temin edilmelidir)
select * from Person.Person where FirstName = 'John' and LastName = 'Berry'
select * from Person.Person where PersonType = 'EM' and BusinessEntityID = '4'

--or
select * from Person.Person where FirstName = 'John' or LastName = 'Rob'
select * from Person.Person where FirstName = 'Orkhan' or LastName = 'Rob'
select * from Person.Person where FirstName = 'John' or LastName = 'Duffy'

select * from Person.Person where (FirstName = 'John' or FirstName='Rob') and PersonType = 'IN'
select * from Person.Person where (FirstName = 'John' or FirstName='Rob') and PersonType = 'IN'





/* Comparsion Operators */
select * from Production.Product
-- > (boyukdur)
select * from Production.Product where ListPrice > 500
select * from Production.Product where ListPrice > 350

-- < (kicikdir)
select * from Production.Product where ListPrice < 600
select * from Production.Product where ListPrice < 50

-- >= (boyukdur beraberdir)
select * from Production.Product where ListPrice >= 500
select * from Production.Product where ListPrice >= 350

-- <= (kicikdir beraberdir)
select * from Production.Product where ListPrice <= 500
select * from Production.Product where ListPrice <= 350

-- = (beraberdir)
select * from Production.Product where Color = 'Black'
select * from Production.Product where Color = 'Yellow'

-- != (beraberdir)
select * from Production.Product where Color != 'Black'
select * from Production.Product where Color != 'Yellow'


/*
	Task In Lesson 2:
	1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
	2. Production.Product table'ından ProductID'si 20-dən kiçik olan məlumatların bütün column'larını gətir.
	3. Production.Product table'ından ListPrice'ı 200-dən böyük, 500-dən kiçik olan məlumatların ProductID, Name və ListPrice
	column'larını gətir.
	4. Production.Product table'ından SafetyStockLevel'i 900-dən böyük, 1500-dən kiçik olan və ProductID'si 10 olmayan məlumatların
	bütün column'larını gətir.
	5. Production.Product table'ından ProductNumber'ı 'BA-8327' olmayan, Color'u 'Black' olan ilk 50 dənə məlumatın bütün column'larını gətir.
	6. Production.Product table'ından ListPrice'ı 500-dən kiçik və ya bərabər olan məlumatların 50%'ni gətir.
	7. Production.Product table'ından ListPrice'ı 1001-dən böyük və ya bərabər olan məlumatların 25%'ni gətir.

	8. Production.Product table'ından Color'u 'Black' və ya 'Red' olan, Color'u 'Yellow' olmayan məlumatların bütün column'larını gətir.
	9. Production.Product table'ından ProductID'si 100-dən böyük, 500-dən kiçik olan və 300, 500 olmayan məlumatların ProductID
	column'unu gətir.
	10. Production.Product table'ından SafetyStockLevel'i 800 və ya 1000 olan amma Color'u 'Black' və ya 'Blue' olmayan məlumatların
	bütün column'larını gətir.
	11. Person.Address table'ından City, PostalCode və AddressLine1 column'larının dəyərlərini aralarında vergül olmaqla FullAddress
	column adı ilə çəkin.
*/

select * from Production.Product where ProductID > 20; --1
select * from Production.Product where ProductID < 20; --2
select ProductID, Name, ListPrice from Production.Product where ListPrice > 200 and ListPrice < 500; --3
select * from Production.Product where SafetyStockLevel > 900 and SafetyStockLevel < 1500 and ProductID != 10 --4
select top 50 * from Production.Product where ProductNumber != 'BA-8327' and Color = 'Black'; --5
select top 50 * from Production.Product where ListPrice <= 500; --6
select top 25 percent * from Production.Product where ListPrice >= 1001; --7
select * from Production.Product where (Color = 'Black' or Color = 'Red') and Color != 'Yellow'; --8
select * from Production.Product where ProductID > 100 and ProductID < 500 and ProductID != 300 and ProductID != 500 --9
select * from Production.Product where (SafetyStockLevel = 800 or SafetyStockLevel = 1000) and (Color != 'Black' and Color != 'Blue'); --10
select City + ', ' + PostalCode + ', ' + AddressLine1 as FullAddress from Person.Address; --11



/* Like operator */

-- a herfiyle baslayan
-- like 'a%'

-- b herfiyle biten
-- like '%b'

-- icinde t herfi olan
-- like '%t%'

select * from Person.Person where FirstName like 'a%'
select * from Person.Person where FirstName like '%b'
select * from Person.Person where FirstName like '%t%'


select * from Person.Person where FirstName like '%al'
select * from Person.Person where FirstName like '%son%'

