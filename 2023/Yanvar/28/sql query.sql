--
select * from Staffs;

--Stored procedure istifade etmeden melumat elave etmek
insert into Staffs
(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
values
('Orkhan', 'Farajov', 'orkhankhf@gmail.com', getdate(), null, 0)


--Procedure yazilis qaydasi
create proc some_procedure_name
(
--qebul edeceyi parametrler
@id int,
@name nvarchar(50)
)
as
begin
--body hissesi
select 1;
end




create proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(250)
)
as
begin
	insert into Staffs
	(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
	values
	(@name, @surname, @email, getdate(), null, 0);
end

exec spAddNewStaff @name='Murad', @surname='Semedov', @email='murad@gmail.com'





create proc GetStaffs
as
begin
	select * from Staffs;
end

exec GetStaffs;




--------------------------------------------------------
--Edit procedures
--------------------------------------------------------
alter proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(250)
)
as
begin
	insert into Staffs
	(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
	values
	(@name, @surname, @email, getdate(), null, 0);
end


drop proc spAddNewStaff



--------------------------------------------------------
--Encryption Stored Procedures
--------------------------------------------------------
create proc spAddBook
(
@name nvarchar(50),
@author nvarchar(50),
@page int
)
with encryption
as
begin
	insert into Books
	(Name, Author, Page, CreateDate, EditDate, IsDeleted)
	values
	(@name, @author, @page, getdate(), null, 0);
end


alter proc spAddBook
(
@name nvarchar(50),
@author nvarchar(50),
@page int
)
with encryption
as
begin
	insert into Books
	(Name, Author, Page, CreateDate, EditDate, IsDeleted)
	values
	(@name, @author, @page, getdate(), null, 0);
end




--------------------------------------------------------
--Optional Procedure Parameters
--------------------------------------------------------
create proc spGetEmployees
(
@gender char(1) = 'M'
)
with encryption
as
begin
	select * from HumanResources.Employee where Gender = @gender;
end


exec spGetEmployees;
exec spGetEmployees @gender='F';