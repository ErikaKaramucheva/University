create database bank

alter database bank collate Cyrillic_General_CI_AI

use bank

create table department(
department_id int primary key,
name varchar(30) not null
)

create table employee(
employee_id int primary key identity(1,1),
first_name varchar(20) not null,
last_name varchar(20) not null,
additional_name varchar(20) null,
address varchar(40) not null,
phone varchar(10) not null,
email varchar (20)not null,
job_name varchar (25) not null,
department_id int foreign key (department_id) references department,
manager_id int foreign key (employee_id) references employee
)

create table customers(
customer_id int primary key identity(1,1),
fist_name varchar(20) not null,
last_name varchar(20) not null,
address varchar(40) not null,
phone varchar(10) not null,
email varchar(30) not null
)

create table account(
account_id int primary key,
acc_no varchar (10) unique not null,
cash numeric (8,2),
customer_id int foreign key (customer_id) references customers,
currency char(5) default 'BGN'
)

insert into department values
(1001,'Управителен съвет'),
(1002,'Кредитен отдел'),
(1003,'Инвестиционен отдел'),
(1004,'Маркетингов отдел'),
(1005,'Администрация'),
(1006,'Касови и депозитни операции'),
(1007,'Отдел тръстови операции'),
(1008,'Ревизионен отдел'),
(1009,'Поддръжка')

insert into customers values
('Петър','Петров','София,район Възраждане, ул. Пиротска 10','0800000001','pesho@abv.bg'),
('Никола','Иванов','София, ул. Триадица 5','0800000002','niki@abv.bg'),
('Стефани','Ангелова','Пловдив, ул. Макгахан №10','0800000003','stefani_ang@abv.bg'),
('Виктория','Петрова','Пловдив, ул. Капитан Райчо №55','0800000004','viktoria@abv.bg')

select * from customers

alter table department 
add constraint FK_MANAGER foreign key (manager_id) references employee (employee_id)
