use AdventureWorks2017;
select * from AdventureWorks2017.Person.Address;

--This is single line comment

/*
 This
 is
 multi
 line
 comment
*/

--Select: Table'dan məlumatları çəkən əmr
--From: Haradan və ya hansı qaynaqdan məlumatları götürəcəyini bildirir
--Yazılış qaydası: select column_adları (və ya *) from table_adi
select * from Person.Address;

select AddressID, AddressLine1, City, PostalCode, ModifiedDate from Person.Address;

select * from Person.Person;