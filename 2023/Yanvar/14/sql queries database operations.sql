/*
create database School

drop database School
*/

--Table Operations
create table Students
(
	Id int,
	Name nvarchar(100), --mətn tipi
	Surname nvarchar(100) --mətn tipi
)

drop table Students

alter table Students
add CreateDate datetime

alter table Students
add TestColumn datetime

alter table Students
drop column TestColumn

alter table Students
alter column Name nvarchar(250)


--Restrictionis
--Not null: 
create table Persons(
	Id int,
	Name nvarchar(100),
	Surname nvarchar(100)
)

create table PersonsWithNotNull(
	Id int not null,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)

--Unique
create table NotConstraintUniqueTest(
	Id int not null, --Id tekrarlana biler
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null --Email tekrarlana biler
)

create table ConstraintUniqueTest(
	Id int not null unique, --Id tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null unique --Email tekrarlana bilmez
)


--Primary Key
create table Employee(
	Id int not null unique, --Id null ola ve ya tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)

create table EmployeePKey(
	Id int primary key, --Id null ola ve ya tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)

--Check
create table EmployeeConstraintCheck(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age >= 18)
)

create table StudentsConstraintCheck(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age <= 35)
)


--Default
select getdate();

create table ConstraintDefault(
	Id int primary key,
	Name nvarchar(100) not null default 'Ad daxil edilmeyib',
	Surname nvarchar(100) not null,
	Age int not null default 18 check(Age <= 35),
	CreateDate datetime default getdate()
)






-- Table Relations

create table Customers --relation olmayan versiya
(
	Id int primary key,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
)

create table Addresses --relation olmayan versiya
(
	Id int primary key,
	FullAddress nvarchar(500) not null,
)

drop table Customers
drop table Addresses

create table Customers --relation ile yazsaq nece yazariq?
(
	Id int primary key,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
)

create table Addresses --relation ile yazsaq nece yazariq?
(
	Id int primary key,
	FullAddress nvarchar(500) not null,
	CustomerId int,
	foreign key (CustomerId) references Customers(Id)
)

delete from Addresses where Id = 3;
delete from Customers where Id = 2;





--Insert
select * from Students;

--insert yazilis qaydasi
-- insert into table_name (columnt1, column2, column3) values ('', '', 100)
-- insert into table_name values ('', '', 100)

insert into Students (Id, Name, Surname, EmailAddress) values (6, 'Orkhan', 'Farajov', 'orkhankhf@gmail.com')





--Update
select * from Students;

--update yazilis qaydasi
--update table_name set columnName = 'some value'
--update table_name set columnName = 'some value' where Id = 1

update Students set Surname = 'Ferecov' where Id = 1

update Students set Surname = 'Ferecov', EmailAddress = 'orkhan@gmail.com' where Id = 1

update Students set Surname = 'Farajov'



--Delete
delete Students

delete Students where Id = 1
delete Students where Id > 5
delete Students where Id >= 5
delete Students where Name = '';
delete Students where Name = '' and Surname = '';
delete Students where Name = '' and Surname = '' or Id > 1;
