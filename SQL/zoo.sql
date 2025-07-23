create database zoo

--1.
create table animals(
animal_id int primary key not null,
animal_type varchar(20) not null
)

create table visitors(
visitor_id int primary key not null,
fname varchar(30) not null,
lname varchar(30) not null
)

create table animal_visits(
animal_id int not null references animals,
visitor_id int not null references visitors,
price decimal(6,2) not null,
visit_day varchar(20) not null,
primary key(animal_id, visitor_id)
)

--2.
alter table animal_visits
add ticket varchar(5) check (ticket in ('ADULT','CHILD'))

--3.
insert into animals values	(1,'monkey'),
							(2,'panda')

insert into visitors values	(1,'Ana','Georgieva'),
							(2,'Dimiter','Petrov'),
							(3,'Vesela','Marinova')

insert into animal_visits values	(1,1,4.5,'Sunday','CHILD'),
									(2,1,3.6,'Sunday','CHILD'),
									(1,2,6,'Friday','ADULT'),
									(2,2,5.7,'Friday','ADULT'),
									(1,3,6,'Sunday','ADULT')

--4.
delete from animal_visits
where visitor_id=2

delete from visitors
where visitor_id=2

--5.
select fname, lname, ticket 
from visitors v join animal_visits av
on v.visitor_id=av.visitor_id
order by fname desc

--6.
select animal_type, ticket, count(av.ticket) as ticket_count
from animals a left join animal_visits av
on a.animal_id=av.animal_id
group by animal_type,ticket,av.animal_id
order by ticket_count asc

--7.
create view animal_and_ticket as
select animal_type, ticket, sum (price) as total_sum
from animals a join animal_visits av
on a.animal_id=av.animal_id
group by animal_type,ticket, av.animal_id
having sum(price)>2
