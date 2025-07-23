CREATE DATABASE TESTDB
go

USE TESTDB
create table COUNTRIES(
country_code char(3),
name varchar(40),
population int
)
go

ALTER TABLE COUNTRIES ADD phone_code int
go
INSERT INTO COUNTRIES (country_code, name, population,phone_code) VALUES ('BGN','България',7500000,359)
go
UPDATE COUNTRIES 
SET population=6000000
go
DELETE COUNTRIES
go
DROP TABLE COUNTRIES
GO
drop database TESTDB
go

create database mydb
use mydb
create table student(
stud_num varchar(10) not null,
stud_name varchar(30) not null, 
phone varchar(10)
)
alter table student add address varchar(30)
select * from student
drop table student
insert into student values
('951921','Maria Petrova','032 673453','gr.Plovdiv')
delete  from student
select * from student where stud_name like 'Ivan Ivanov'

update student 
set address='gr.Yambol'
where stud_num='951921'

delete from student where stud_num='951921'

create database libraryEx
use libraryEx

create table books(
isbn int not null primary key,
title varchar(40) not null,
price numeric(6,2),
year DATETIME
)
create table authors(
personal_number varchar(10) primary key not null,
fname varchar(30) not null,
lname varchar(30) not null
)
create table clients(
egn varchar(10) primary key not null,
fname varchar(30) not null,
lname varchar(30) not null,
telephone varchar(10),
address varchar(30)
)
create table book_author(
book_isbn int foreign key references books(isbn),
author varchar(10) foreign key references authors(personal_number)
)
create table client_book(
client_egn varchar(10) foreign key references clients(egn),
book int foreign key references books(isbn),
date_get datetime, 
date_return datetime
)

insert into books values
(1549656035,'Vavedenie v SQL',10.30,1997),
(1549656031,'Transact-SQL',28.10,1997),
(1549656039,'Nauchete sami SQL (chast 1)',6.50,1998),
(1549656047,'Nauchete sami SQL (chast 2)',6.50,1998),
(1558605762,'SQLforSmarties:advancedSQLprogramming',95.00,1999),
(1778945675,'SQL Server 7.0',17.80,1999),
(121377959,'Alhimikat',14.60,2006)

insert into authors values
('64','Evlogi','Geotgiev'),
('56','Joe','Celko'),
('72','Svetla','Koleva'),
('54','Petar','Dimitrov'),
('98','Paulu','Kuelu')

insert into book_author values
('1549656039','64'),
('1549656047','64'),
('1558605762','56'),
('1549656035','64'),
('1549656035','56'),
('1549656035','54'),
('121377959','98')

insert into clients (egn,fname, lname,address,telephone)
values
('6812138761','Stefan','Georgiev',null,'032651219'),
('8809112342','Ivan','Peev','Plovdiv,bul Skopie','679088'),
('7607053453','Maria','Petrova','Plovdiv,bul Iztochen','0897825365'),
('9112314654','Elena','Simeonova','Sofia,bul VasilLevski','0886547324'),
('7509157765','Dimitar','Georgiev',null,'231098'),
('8510231100','Hristo','Ivanov',null,'046762376')

select * from clients

insert into client_book values
--('6812138761',1549656035,'1999.10.23 18:30','1999-11-03 8:15:9'),
('6812138761',1549656039,'2001-2-23 7:28:44','2001-3-25 19:20'),
('6812138761',1558605762,'2003-10-23 13:02',null),
('8809112342',121377959,'1999-10-23 18:30',null)

update clients
set fname='Michael', lname='Yordanov'
where egn='8510231100'
delete from clients
where egn='8510231100'

select * from books
select * from books 
order by title asc

select * from books 
order by title desc

select * from books
order by year asc

select * from books
order by year desc

select * from books
order by title, year asc

select * from books
order by title, year desc

select * from books
order by price asc

select * from books
order by price desc

select * from authors 
order by lname asc

select * from authors 
order by lname desc

select * from clients
order by fname asc

select * from clients
order by fname desc

select SUM(price) as total_price from books

select SUM(price) as total_price from books
where year>1998

select year,SUM(price) as total_price from books
group by year

select SUM(price) as total_price, AVG(price) as avg_price,MIN(price) as min_price,MAX(price) as max_price, COUNT(isbn)
from books
group by year

select* from authors 
where fname='Joe'

select * from authors
where lname like '%ev'

select top 1* from books
order by price desc

select top 1* from books
order by price asc

select * from books
where price=(select MAX(price) from books)
union
select * from books
where price=(select MIN(price) from books)

select fname, lname,telephone from clients

select * from authors a
join  book_author b on a.personal_number=b.author

select fname, lname, b.book_isbn from authors a
left join book_author b on b.author=a.personal_number

select * from client_book cb
right join clients c on c.egn=cb.client_egn

select * from authors a
join book_author ba on ba.author=a.personal_number

select * from books ba
where price=(select MIN(price) from books b )
or
price=(select Max(price) from books b)

select fname, lname from authors a, book_author ba
where a.personal_number=ba.author
and ba.book_isbn=(
select top 1 isbn from books b order by b.price)
or
ba.book_isbn=(
select top 1 isbn from books b order by price desc)

select fname, lname from authors a, book_author ba
where a.personal_number=ba.author
and ba.book_isbn=(
select top 1 isbn from books b order by b.year)
or
ba.book_isbn=(
select top 1 isbn from books b order by year desc)

select * from books b
where b.isbn in (select isbn from client_book)

select * from clients c
where c.egn in (select egn from client_book cb 
join books b on b.isbn=cb.book
where b.title='Alhimikat')

select b.title, count(*)
from books b join client_book cb on cb.book=b.isbn
group by isbn,b.title
having COUNT(*)<= all(select COUNT(b.title)
from books b, client_book cb 
where cb.book=b.isbn
group by b.title)
or
COUNT(*)>= all(select COUNT(b.title)
from books b, client_book cb 
where cb.book=b.isbn
group by b.title)

select * from books b, client_book cb, clients c
where cb.book=b.isbn and cb.client_egn=c.egn
and fname='Ivan' and lname='Peev'

select * from clients c, client_book cb, books b
where b.isbn=cb.book and cb.client_egn=c.egn
and fname='Ivan'and lname='Peev'
and cb.date_get<='2002'

select c.fname,c.lname,b.title from clients c, client_book cb, books b
where cb.book=b.isbn and cb.client_egn=c.egn
and cb.date_return is null

begin tran
update clients set address='Smolyan, ul.Brqst-11'
where egn='8809112342'
commit transaction
select * from clients

begin tran
print 'Author information before update' 
select * from authors where personal_number=54

update authors set lname='Kolev' where personal_number=54

print 'Author information after update'
select * from authors where personal_number=54

rollback tran
print 'Author information after removing transaction'
select * from authors where personal_number=54

create procedure get_authors
as
select * from authors
exec get_authors

create procedure get_info @client_egn text
as
select fname+lname as name, COUNT(book) as getBooks 
from clients c, client_book cb
where c.egn=cb.client_egn and c.egn=client_egn
group by c.fname, c.lname, c.egn
exec get_info '54'

create procedure get_author_book_count @au_count int output, @book_count int output
as 
select @au_count=COUNT(*) from authors
select @book_count=COUNT(*) from books

declare @ac int, @bc int
exec get_author_book_count @ac output, @bc output
print 'Authors count: ' +cast(@ac as varchar)
print 'Books count: ' +convert(varchar,@bc)

create procedure factorial @n int
as
declare @one_less int, @answer int
if(@n<0 or @n>12)
begin print 'Nepozvoleni stoinosti na parametara'
return -1
end

if(@n=0 or @n=1)
set @answer=1
else
begin 
set @one_less=@n-1
exec @answer=factorial @one_less
if(@answer=-1)
return -1
set @answer=@answer*@n
if(@@ERROR<>0)
return -1
end 
return @answer

declare @result int
exec @result=factorial 9
print '9!=' +cast(@result as varchar)

create function client_books_count (@cl_egn char(10))
returns varchar(200)
as
begin declare @cnt int, @name varchar(30), @taken varchar, @not_returned varchar

select @name=c.fname+' '+lname,
@taken=COUNT(cb.date_get),@not_returned=COUNT(cb.date_return)

from client_book cb right join clients c
on c.egn=cb.client_egn
where c.egn=@cl_egn
group by c.egn,c.fname,c.lname
return 'Клиентът '+@name+' (ЕГН= '+@cl_egn+
') е взел '+cast(@taken as varchar)+
' книги, не е върнал '+cast(@not_returned as varchar)
end

select dbo.client_books_count (egn) from clients

create function BooksByAuthor()
returns table
as
return (select a.personal_number,a.lname,b.title
from authors a, book_author ba,books b
where a.personal_number=ba.author and ba.book_isbn=b.isbn)

select * from BooksByAuthor()

create trigger insertauthor
on authors after insert as
print 'New records in author were inserted!'
print 'The inserted records are:  '
select * from inserted

insert into authors (personal_number, fname, lname)
values ('1234','John','Smith')
insert into clients (egn,fname, lname)
select personal_number, fname, lname from authors

create trigger insupdclient
on clients
instead of insert, update as
print ' Slednite zapisi nqma da badat dobaveni ili promeneni:'
select * from inserted
update clients set fname='Spas' where egn='6812138761'
insert into clients (egn,fname, lname)
select SUBSTRING (egn,1,5)+ 'N', fname+' 2',lname+' 2'
from clients

declare @cl_egn char(10), @f_name varchar (15), @l_name varchar(15)
declare client_cursor cursor for
select egn, fname, lname
from clients
where address is not null
open client_cursor
fetch next from client_cursor into @cl_egn,@f_name,@l_name
print 'Klienti, chiito adresi sa izvestni, sa: '
print '------------'
while @@FETCH_STATUS=0
begin
print @f_name+' '+@l_name+' (egn= '+@cl_egn+')'
fetch next from client_cursor into @cl_egn, @f_name, @l_name end

close client_cursor
deallocate client_cursor
