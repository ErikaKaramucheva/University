--Задача 2-1. Да се създаде база от данни с име TESTDB.
 create database testdb
--Задача 2-2. Да се създаде таблица в тази база данни с име COUNTRIES и следните колони:
--country_code – с тип char(3);
--name – тип varchar(40);
--population – тип int.
create table countries(
country_code char(3),
name varchar(40),
population int)

--Задача 2-3. Да се добави нов атрибут в таблицата COUNTRIES 
--с име phone_code, което да съдържа цели числа до 3 цифри.
alter table countries
add phone_code char(3)
 
 --Задача 2-4. Да се добави ред в таблицата COUNTRIES със следните данни:
--country_code: BGR;
--name: Bulgaria;
--population: 7500000;
--phone_code: 359.
 insert into countries values ('BGR','Bulgaria',7500000,359)
--Задача 2-5. Да се промени населението на България на 6 милиона.
 update countries
 set population=6000000
 where country_code='BGR'
--Задача 2-6. Да се изтрият всички редове в таблицата COUNTRIES.
 DELETE countries
--Задача 2-7. Да се изтрие таблицата COUNTRIES от базата данни.
 drop table countries
--Задача 2-8. Да се изтрие базата данни TESTDB.
drop database testdb

create database trade
alter database trade collate CYRILLIC_GENERAL_CI_AI 
CREATE TABLE REGIONS(
REGION_ID SMALLINT primary key NOT NULL,
name varchar(25) not null)

create table countries (
country_id char(2) primary key not null,
name varchar(40) not null,
region_id smallint not null foreign key (region_id) references regions
)

create table departments (
department_id int primary key not null,
name varchar(30) not null,
manager_id int null,
country_id char(2) foreign key (country_id) references countries,
city varchar(30) not null,
state varchar(25) null,
address varchar(40) null,
postal_code varchar(12) null
)

create table jobs(
job_id varchar(10) primary key not null,
job_title varchar(35) not null,
min_salary numeric(6) null,
max_salary numeric(6) null
)

create table employees(
employee_id int primary key not null,
fname varchar(20) not null,
lname varchar(25) not null,
email varchar(40) unique not null,
phone varchar(20) null,
hire_date datetime not null,
salary numeric(8,2) not null,
job_id varchar(10) foreign key (job_id) references jobs,
manager_id int foreign key (employee_id) references employees,
department_id int foreign key(department_id) references departments
)

alter table departments
add constraint fk_manager_id foreign key (manager_id) references employees(employee_id)

create table customers(
customer_id numeric(6) primary key not null,
country_id char(2) foreign key (country_id) references countries,
fname varchar(20) not null,
lname varchar(20) not null,
address text null,
email varchar(30) null,
gender char(1) null
)

create table products(
product_id int primary key not null,
name varchar(70) not null,
price numeric(8,2) not null,
descr varchar(2000) null
)

create table orders(
order_id int primary key not null,
order_date datetime not null,
customer_id numeric(6) foreign key (customer_id) references customers,
employee_id int foreign key (employee_id) references employees,
ship_address varchar(150) null
)

create table order_items(
order_id int foreign key (order_id) references orders not null,
product_id integer foreign key (product_id) references products not null,
unit_price numeric(8,2) not null,
qualtity numeric(8) not null,
primary key (order_id,product_id)
)

/*Задача 3-2. 
    Да се увеличи количеството с 2 броя и да се намали единичната цена с 5% на
    продукт с идентификатор 2254 в поръчка с идентификатор 2354. */
 update order_items
 set quantity=quantity+2 ,unit_price*=0.95
 where product_id=2254 and order_id=2354

/*Задача 3-3.
    Да се изтрие служител с идентификатор 183.*/
	delete EMPLOYEES
	where EMPLOYEE_ID=183

	select * from EMPLOYEES
	where EMPLOYEE_ID=183
 
-------------------------------------------------------------------------------------------
/* Пример 4-1. 
    Да се изведат имената, датите на назначаване и заплатите на всички служители. */
	select fname, lname, HIRE_DATE,SALARY
	from EMPLOYEES
 
/*Пример 4-2. 
    Да се изведат всички данни за продуктите, с цена по-голяма от 2000. Резултатът
    нека бъде подреден по цена на продукт възходящо.*/
	select * from products
	where PRICE>2000
	order by PRICE asc
 
/*Пример 4-3.
    Да се изведе броя на всички служители.*/
	select count(employee_id)
	from EMPLOYEES
 
/*Пример 4-4.  
    Да се изведе броя служители, групирани по отдела, в който работят.*/
 select department_id, count(EMPLOYEE_ID)
 from EMPLOYEES
 group by DEPARTMENT_ID
-------------------------------------------------------------------------------------------
/*Задача. Да се изведат общата сума на заплатите и броя служители в отдел 60.*/
select sum(salary), count(employee_id)
from employees
where department_id=60
 
/*Задача.
    За всички поръчки да се изведат идентификатор на поръчка и обща стойност на
    поръчката. Резултатът да е подреден по стойност на поръчката в низходящ ред.*/
	select ORDER_ID,sum(unit_price*quantity) as sum
	from ORDER_ITEMS
	group by ORDER_ID
	order by sum desc

	--Задача #1 
--Изведете общото количество, в което продуктите (само с техните идентификатори) са били поръчани;
-- и сортирайте резултатния набор спрямо общото количество във възходящ ред.
select sum(quantity) as total_quantity, product_id
from ORDER_ITEMS
group by product_id
order by total_quantity asc
 
--Задача #2 
--Изведете от кои идентификатори на държави колко на брой клиенти има фирмата. 
--Сортирайте спрямо бройката на клиентите в низходящ ред.
 select count(CUSTOMER_ID) as custom_count, COUNTRY_ID
 from CUSTOMERS
 group by COUNTRY_ID
 order by custom_count desc

--Задача #3 
--Изведете броя поръчки, които е изпълнил всеки служител.
--В резултатния набор да участват само служители, изпълнили повече от 5 поръчки. 
select count (order_id) as order_count, employee_id
from ORDERS
group by EMPLOYEE_ID
having count(order_id)>5
 
--Задача #4 
--Изведете длъжностите със средна работна заплата над 10 000.
--Сортирайте спрямо средната работна заплата в низходящ ред.
select job_id, avg(salary) as avg_salary
from employees
group by job_id
having avg(salary)>10000
order by avg_salary desc


--Задача #5 
--Изведете колко служители са назначени на определен идентификатор на длъжност. 
--Но резултатът да включва само тези длъжности, на които има повече от 5 служителя.
--Сортирайте по броя служители на съответната длъжност във възходящ ред.
select count(employee_id) as employee_count, JOB_ID
from EMPLOYEES
group by JOB_ID
having count(employee_id)>5
order by employee_count asc
 
-------------------------------------------------------------------------------------------
-------------------------------------Set operators-----------------------------------------
---------------------------------------UNION ----------------------------------------------
/*  Резултатните набори, които се обединяват, трябва да отговарят на следните условия:
        -Всяка заявка в оператора UNION трябва да има еднакъв брой колони;
        -Колоните трябва да имат съвместими типове от данни;
        -В целия израз може да присъства само една клауза ORDER BY накрая, 
        сортираща обединения резултат. */
 
--Пример 4-5. 
    --Да се изведат идентификаторите на държавите, в които има клиенти или отдели на фирмата.
 select country_id from CUSTOMERS
 union 
 select country_id from DEPARTMENTS
--Пример 4-6. 
    --Да се изведат идентификаторите на държавите, в които има клиенти или отдели на фирмата. 
    --Нека в резултатния набор участват и дублиращите се записи.
 select country_id from customers
 union all
 select country_id from DEPARTMENTS
 
/*Задача 4-4. 
    Да се изведат всички малки имена на клиенти и служители с евентуалните
    повторения, сортирани в низходящ ред по име. */
 select fname from CUSTOMERS
 union all
 select fname from EMPLOYEES
 order by fname desc
 
/*Задача 4-5.
    Да се изведат име и фамилия на клиенти и служители без повторения, а като
    трета колона за клиентите да се използва израз, генериращ низа „Клиент
    (<идентификатор>)“, за служителите – „Служител (<идентификатор>)“. */
	select fname, lname, 'Клиент ('+cast(customer_id as varchar)+' )' from customers
	union
	select fname, lname, 'Служител ('+cast(employee_id as varchar)+' )' from EMPLOYEES
 
 
----------------------------------INTERSECT(сечение)---------------------------------------
/*Резултатът съдържа общите за двата резултатни набора редове, без дубликати. С условия:
     -Броят на колоните във всички заявки трябва да бъде еднакъв;
     -Колоните трябва да бъдат от съвместими типове от данни.
 
Пример 4-7. 
    Да се изведат id на държавите, в които има клиенти и отдели на фирмата едновременно.*/
	select country_id from CUSTOMERS
	intersect
	select country_id from DEPARTMENTS
 
--Задача 4-6. Да се изведат общите собствени имена на клиенти и служители.
select fname  from customers
intersect 
select fname from EMPLOYEES
 
----------------------------------EXCEPT---------------------------------------------------
/*Връща редовете, върнати от първата заявка, които не се срещат измежду редове от втората.
Условия:
    -Броят на колоните във двете заявки трябва да бъде еднакъв;
    -Колоните трябва да бъдат от съвместими типове от данни. */
 
--Пример 4-8.
--  Изведи id на държавите, в които има клиенти и в същото време няма отдели на фирмата.
select country_id from CUSTOMERS
except 
select country_id from DEPARTMENTS

select country_id from CUSTOMERS
where country_id not in (select country_id from DEPARTMENTS)
 
/*Задача 4-7. 
    Да се изведат собствени имена на клиенти, които не се срещат сред тези на служители.*/
	select fname from customers 
	except select fname from EMPLOYEES
 
-------------------------------------------------------------------------------------------
------------------------------------ JOIN -------------------------------------------------
--JOIN се използва за извличане на данни от две или повече таблици, като редовете им се
--комбинират чрез логическа връзка между таблиците, която може да бъде във FROM или WHERE.
--Обикновено тази връзка е първичен/външен ключ, но не задължително.
 
-------------------------------------INNER JOIN или просто JOIN-----------------------------
--Извежда редовете от две/повече таблици, които имат съвпадащи стойности в колоните,
--посочени в условието за сравнение.
 
--Пример 4-10. 
--  Да се изведат държавите и регионите, в които се намират.
select r.region_id, c. name from regions r
join countries c on c.region_id=r.REGION_ID
 
--Пример 4-11.
--  Изведи имена на клиенти, имена на държавите от които са, и имена на регионите на държавите.
select c.fname, c.lname , co.name, r.name
from CUSTOMERS c, countries co, REGIONS r
where c.COUNTRY_ID=co.country_id
and co.region_id=r.REGION_ID

select c.fname, c.lname , co.name, r.name
from CUSTOMERS c
join countries co on c.COUNTRY_ID=co.country_id
join REGIONS r on r.REGION_ID=co.region_id

 
    -- Пример 4-12. 
    -- Да се изведат регионите и държавите, които се намират в тях. Резултатният
    -- набор да включва и регионите, в които няма въведени държави.
 select * from REGIONS r
 left join countries c on r.REGION_ID=c.region_id

    -- Пример 4-13. 
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион.
	select * from regions r
	right join countries c on r.REGION_ID=c.region_id
 
    -- Пример 4-14.
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион и регионите, 
    -- за които няма въведени държави.
	select * from countries c
	full join regions r on r.REGION_ID=c.region_id
 
    -------------------------------------------------------------------------------------
    --#1. 
    --Изведете наименуванията на длъжностите с минимална заплата над 5000. 
    --Сортирайте резултатния набор по мин. заплата низходящо.
	select j.JOB_TITLE, j.MIN_SALARY
	from jobs j
	where j.MIN_SALARY>5000
	order by MIN_SALARY desc
 
    --#2. 
    --Изведете имената на служителите, наименованията на длъжностите им, 
    --и имената на отделите, в които работят.
 select e.fname, e.lname, j.job_title, d.name
 from EMPLOYEES e, jobs j, DEPARTMENTS d
 where e.JOB_ID=j.JOB_ID and d.department_id=e.department_id

    --#3. 
    --Извeдете имената и броя поръчки, които са изпълнили служителите,
    --като резултатният набор да включва всички служители и тези, които все още 
    --не са изпълнявали поръчки. Сортирайте по броя на поръчките във възходящ ред.
	select e.fname, e.lname,e.EMPLOYEE_ID,count(o.employee_id) as order_count
	from employees e
	left join ORDERS o on o.EMPLOYEE_ID=e.EMPLOYEE_ID
	group by e.fname, e.lname, e.EMPLOYEE_ID
	order by order_count asc
 

    --#4. 
    --Изведете имена, заплата и идентификатор на длъжност на служителите,
    --които работят в отдел 80 и не са обработвали поръчки до момента;
	SELECT FNAME, LNAME, SALARY, JOB_ID, ORDER_ID
    FROM EMPLOYEES E LEFT JOIN ORDERS O
    ON E.EMPLOYEE_ID = O.EMPLOYEE_ID
    WHERE DEPARTMENT_ID = 80 AND ORDER_ID IS NULL
 
    --#5.
    --Изведете имената на отделите и съответния брой служители, които работят в тях.
    --Нека в резултатния набор да участват само отделите, които се намират в държави 
    --с идентификатор 'BG' или 'DE', като в отделите работят не по-малко от 7 служители.
    --Сортирайте резултатния набор по броя на служителите във възходящ ред.
	select d.name, count(e.employee_id) as emp_count
	from DEPARTMENTS d join EMPLOYEES e on e.DEPARTMENT_ID=d.DEPARTMENT_ID
	where country_id in ( 'BG','DE')
	group by d.name, d.DEPARTMENT_ID
	having count(e.employee_id)>=7
	order by emp_count asc

 
    --#6.
    --Изведете идентификаторите на клиентите и общата стойност на поръчките им.
    --Нека участват само клиенти с обща стойност на поръчките над 900000 и под 1500000.
	select c.customer_id, sum(quantity*unit_price) as total_sum
	from customers c, orders o, ORDER_ITEMS i
	where c.CUSTOMER_ID=o.CUSTOMER_ID and i.ORDER_ID=o.ORDER_ID
	group by c.CUSTOMER_ID
	having sum(quantity*unit_price) between 900000 and 1500000
 
    -------------------------------------------------------------------------------------
 
    -- Задача 4-8. 
    -- Извлечи идентификатори, дати на поръчките и имена на служители, които са ги обработили.
	select o.order_id, o.ORDER_DATE, e.fname, e.lname
	from ORDERS o, employees e
	where e.EMPLOYEE_ID=o.EMPLOYEE_ID
    
    -- Задача 4-9. 
    -- Да се изведат имената на всички клиенти и id на поръчките им. 
    -- В резултатния набор да участват и клиентите, които все още не са правили поръчки.
    -- Нека NULL бъде заменена с низа 'none'
	select c.fname,c.lname, ISNULL(cast(o.customer_id as varchar),'none')
	from customers c
	left join ORDERS o on o.CUSTOMER_ID=c.customer_id
 
    -- Задача 4-11. 
    -- Да се изведат имената на всички клиенти, които са от държави в регион „Западна Европа“
	select c.fname, c.lname
	from customers c, countries co,regions r
	where c.COUNTRY_ID=co.country_id and r.REGION_ID=co.region_id
	and r.name like '%Западна%Европа%'

 
 
-----------------------------------------------------------------------------------------
------------------------------4.6.6. Други JOIN вариации---------------------------------
-----------------------------------------------------------------------------------------
 
    -- Пример 4-15. 
    -- Да се изведат държавите и регионите, в които се намират.
        --EQUI-JOIN /=/
		select * from countries c, REGIONS r
		where c.region_id=r.region_id
 
    -- Пример 4-16.
    -- Да се изведат отделите, в които има назначени служители.
        --SEMI-JOIN /IN/EXISTS/
		select department_id
		from DEPARTMENTS
		where DEPARTMENT_ID in (select DEPARTMENT_ID from EMPLOYEES)
 
    -- Пример 4-17.
    -- Да се изведат имената на клиентите, които все още не са правили поръчки.
        --ANTI-JOIN /NOT IN/NOT EXISTS/
		select c.fname, c.lname, c.CUSTOMER_ID
		from CUSTOMERS c
		where CUSTOMER_ID not in (select CUSTOMER_ID from ORDERS)
 
    -- Пример 4-18. 
    -- Да се изведат комбинациите от всички региони и държави, сортирани по име на държава.
        --CROSS (CARTESIAN) JOIN
		select * from regions cross join countries c
		order by c.name

 
-----------------------------------------------------------------------------------------
---------------------------------4.7.1. TOP ---------------------------------------------
-----------------------------------------------------------------------------------------
-- TOP връща първите N реда в неопределен ред => за желана подредба се използва ORDER BY! 
 
    --#7. 
    --На коя дата е първата направена поръчка за фирмата?
 select top 1 ORDER_DATE
 from orders 
 order by ORDER_DATE asc

    --#8. 
    --На коя дата е назначен първият служител на фирмата и какви са неговите имена?
    --Нека в резултатния набор участват и останалите служители назначени на същата дата (ако има такива).
	select top 1 with ties *
	from employees
	order by HIRE_DATE
 
    --#9. 
    --Изведете седемте продукта с най-ниска складова цена.
	select top 7 with ties *
	from products
	order by price asc
 
    --#10. 
    --Изведете имената и единичната цена на 7-те продукта с най-ниска цена, на която са били продадени.
	select distinct top 7 with ties p.name,o.UNIT_PRICE
	from products p, ORDER_ITEMS o
	where p.PRODUCT_ID=o.PRODUCT_ID
	order by UNIT_PRICE asc

	--#1
--Изведете имената на държавите, които не са свързани с никой регион.
select c.name,c.region_id
from countries c
where c.region_id is null
--where c.region_id not in (select r.region_id from regions r)
 
--#2
--На коя длъжност (като название) са назначени най-много служители?
select top 1 job_title,count(employee_id) as emp_count
from JOBS j join EMPLOYEES e on e.JOB_ID=j.JOB_ID
group by j.JOB_ID, job_title
order by emp_count desc
 
--#3
--Кои типове продукти са се продали в общо количество над 1500 бр.?
--Изведете техните имена и съответното общо количество.
select p.name,sum(o.quantity) as total_quantity
from PRODUCTS p join ORDER_ITEMS o on o.PRODUCT_ID=p.PRODUCT_ID
group by p.name, p.PRODUCT_ID
having sum(o.QUANTITY)>1500
 
--#4
--Изведете дата на продажба, броя на клиентите, направили покупки на тази дата,
--броя на служителите, изпълнили тези продажби, броя на продажбите
--и общата стойност на продажбите.
select o.order_date, count(o.customer_id),count(o.employee_id),count(o.order_id),sum(quantity*unit_price)
from ORDERS o join ORDER_ITEMS oi on o.ORDER_ID=oi.ORDER_ID
group by o.ORDER_DATE
 
--#5
--Изведете имената и телефонните номера на всички служители, които започват с 0878. 
select e.fname, e.lname, e.phone
from employees e
where phone like '0878%'
 
--#6
--Изведете имена на клиенти, чиито адрес включва бул.Марица (без значение от номера) Пловдив.
select c.fname, c.lname, c.address
from CUSTOMERS c
where ADDRESS like '%бул.%Марица%Пловдив%'
 
--#7
--Изведете служителите (с техните имена и заплати), получаващи по-голяма заплата от Матея Маврова
select e.fname, e.lname, e.salary
from employees e 
where e.salary>(select salary from employees where fname like '%Матея%' and lname like '%Маврова%')
 
--#8
--Изведете име, цена от Products и реална цена, на която са продадени продуктите. 
--Нека цената, на която са продадени бъде по-голяма от средната в Products цена на всички продукти.
select p.name, p.price ,oi.UNIT_PRICE
from products p join ORDER_ITEMS oi on oi.PRODUCT_ID=p.PRODUCT_ID
where oi.UNIT_PRICE>(select avg(price) from PRODUCTS)


--#9
--Изведете имената и заплатите (с форматиране за българска валута)
--на всеки един служител. Сортирайте по залплата в низходящ ред.
select e.fname, e.lname,cast( e.salary as varchar)+' лв'
from employees e
order by e.SALARY desc
 
--#10
-- Изведете имената на продуктите, единичната им цена, идентификаторите на поръчките 
-- и датите на които са направени. Но нека резултатния набор включва само тези от тях,
-- които са след 10.01.2018 г. Сортирайте по дата във възходящ ред.  
-- Забележка: 
-- нека ден, месец и година бъдат разпределени в отделни колони, а месецът 
-- да бъде представен с думи.
select p.name, p.price,
oi.unit_price, oi.order_id,
day(o.order_date) as day,
datename(month,o.order_date) as month, year(o.order_date) as year
from PRODUCTS p join ORDER_ITEMS oi on oi.PRODUCT_ID=p.PRODUCT_ID
join orders o on o.ORDER_ID=oi.ORDER_ID
where o.ORDER_DATE>'10.01.2018'
order by o.ORDER_DATE asc

--#11
--Изведете разликата в години на първата и последната поръчка на фирамата.
SELECT MIN(ORDER_DATE) FROM ORDERS
 SELECT MAX(ORDER_DATE) FROM ORDERS
 
 SELECT DATEDIFF(YEAR, MIN(ORDER_DATE), MAX(ORDER_DATE)) FROM ORDERS
 
--#12
--Изведете данните за клиентите, пазарували на 27.07.2017 г.
select o.order_id, o.customer_id ,c.FNAME,c.lname,c.ADDRESS,c.COUNTRY_ID,c.EMAIL,c.GENDER
from orders o, CUSTOMERS c
where cast(o.ORDER_DATE as date)='2017-07-27'

 
--#13
--Изведете клиентите, които са поръчвали през 2000 година.
select c.fname, c.lname,o.ORDER_DATE
from customers c, orders o
where o.CUSTOMER_ID=c.CUSTOMER_ID and year(ORDER_DATE)='2000'
 
--#14
--Изведете клиентите, които са поръчали само веднъж. Сортирайте по малко име във възходящ ред.
 select c.fname, c.lname,count(o.customer_id)
 from customers c join orders o on o.CUSTOMER_ID=c.CUSTOMER_ID
 group by c.FNAME,c.lname, c.CUSTOMER_ID
 having count(o.customer_id)=1
 order by c.fname asc
--#15
--Изведете минималната заплата на длъжностите, в които има назначени повече от 10 служителя.
select j.min_salary,j.JOB_TITLE, count(e.employee_id) as emp_count
from jobs j join employees e on j.JOB_ID=e.JOB_ID
group by j.MIN_SALARY,j.JOB_ID,j.JOB_TITLE
having count(e.employee_id)>10
 
--#16.
--Изведете длъжностите, на които няма назначени служители.
select j.job_id,j.job_title,count(e.employee_id)
from jobs j right join EMPLOYEES e on e.JOB_ID=j.JOB_ID
group by j.JOB_ID,j.JOB_TITLE
having count(e.employee_id)=0
 
--#17.
--Изведете име, фамилия и пол на клиентите, направили последните 5 поръчки.
select top 5 c.fname, c.lname,c.gender
from customers c, orders o
where o.CUSTOMER_ID=c.CUSTOMER_ID
order by ORDER_DATE desc

   --Пример 4-21.
    -- Петимата служители, започвайки от 10-ти ред, подредени по дата на постъпване. 
	select * from employees
	order by hire_date asc
	offset 10 rows
	fetch next 5 rows only


 
     --Задача 4-12. 
    --вторите 10 най-добре платени служители (подредени по заплата низходящо).
	select * from EMPLOYEES
	order by SALARY desc
	offset 10 rows
	fetch next 10 rows only
 
    --#0
    --В кой град се намира отделът, чийто служители получават най-голяма средна работна заплата.
	select top 1 d.name, avg(e.salary) as salary
	from DEPARTMENTS d, employees e
	where d.DEPARTMENT_ID=e.DEPARTMENT_ID
	group by d.name, d.DEPARTMENT_ID
	order by salary desc
 
-----------------------------------------------------------------------------------------
--------------------------------Изгледи = Views------------------------------------------
-----------------------------Създаване на изгледи----------------------------------------
-----------------------------Промяна на изгледи------------------------------------------
 
    --Пример 5-1. 
    --Да се създаде изглед, който съдържа име и фамилия на клиентите, както и
    --номер и дата на поръчките, които те са направили.
	create view cus_order as
	select c.fname, c.lname,o.order_id,o.ORDER_DATE
	from customers c join orders o on c.CUSTOMER_ID=o.CUSTOMER_ID
 
    --Пример 5-2. 
    --Да се модифицира горният изглед така, че да съдържа и колона с името на
    --съответния служител, обработил поръчката.
	alter view cus_order as
	select c.fname, c.lname, o.order_id, o.order_date,e.fname+' '+e.lname as employee
	from CUSTOMERS c join ORDERS o on c.CUSTOMER_ID=o.CUSTOMER_ID
	join EMPLOYEES e on o.EMPLOYEE_ID=e.EMPLOYEE_ID
 
    --Пример 5-3
    -- Да се модифицира горния изглед така, че да съдържа само поръчките,
    --обработени от служител с идентификатор = 167.
	alter view cus_order as
	select c.fname+' '+c.lname as customer, o.order_id, o.order_date,e.fname+' '+e.lname as employee
	from customers c join ORDERS o on c.CUSTOMER_ID=o.CUSTOMER_ID
	join EMPLOYEES e on e.EMPLOYEE_ID=o.EMPLOYEE_ID
	where e.EMPLOYEE_ID=167

	SELECT  C.FNAME + ' '+ C.LNAME AS CUSTOMER, 
            E.FNAME + ' ' + E.LNAME AS EMPLOYEE,
             ORDER_ID, ORDER_DATE 
    FROM CUSTOMERS C JOIN ORDERS O ON C.CUSTOMER_ID = O.CUSTOMER_ID
                     JOIN EMPLOYEES E ON E.EMPLOYEE_ID = O.EMPLOYEE_ID
    WHERE E.EMPLOYEE_ID = 167
    ORDER BY ORDER_ID
    OFFSET 0 ROWS 
 
    --Пример 5-4. 
    --Да се създаде изглед, съдържащ име и фамилия на служител и общата сума на
    --поръчките, които той е обработил.
	create view order_sum as
	select e.fname+' '+e.lname as employee, sum(quantity*unit_price)
	from EMPLOYEES e join ORDERS o on e.EMPLOYEE_ID=o.EMPLOYEE_ID
	join ORDER_ITEMS oi on oi.ORDER_ID=o.ORDER_ID
	group by e.fname, e.lname, e.EMPLOYEE_ID
 
    --Пример 5-5. 
    --Да се създаде изглед, който съдържа имена, отдел и заплата на 5-мата
    --служители с най-висока заплата. 
	create view max_salary as
	select e.fname, e.lname, e.department_id,e.salary
	from EMPLOYEES e
	order by SALARY desc
	offset 0 rows
	fetch next 5 rows only
 
    ------------------------------------------------------------------------------------------
    --#1
    --Да се създаде изглед, съдържащ имената на служителите и имената на техните преки началници,
    --нека в резултата участват и служителите, които нямат преки началници.
	create view emp_manager as
	select e.fname+' '+e.lname as employee,
	m.FNAME+' '+m.LNAME as manager
	from EMPLOYEES e left join EMPLOYEES m on e.EMPLOYEE_ID=m.MANAGER_ID
        
    --#2
    --Да се създаде изглед, съдържащ информация за отделите, в които не работят 
    --никакви служители.
	create view dep_info as
	select d.DEPARTMENT_ID,d.NAME,count(e.employee_id)as employee_count from departments d
	left join employees e on e.DEPARTMENT_ID=d.DEPARTMENT_ID
	group by d.DEPARTMENT_ID,d.NAME
	having count(e.employee_id)=0


    --#3
    --Създайте изглед с име, фамилия, телефон и име на длъжност на служителите, 
    --които работят в отдел 100.
	create view dep_100 as
	select e.fname, e.lname, e.phone,j.JOB_TITLE
	from employees e join JOBS j on j.JOB_ID=e.JOB_ID
	where e.DEPARTMENT_ID=100
 
    --#4
    --Модифицирайте горния изглед като конкатенирате в една колона име и фамилия на служител,
    --и добавите колони заплата на служителя и идентификатора на неговия пряк ръководител (мениджър).
	alter view dep_100 as
	select e.fname+' '+e.lname as employee, e.salary, e.phone, e.manager_id,j.job_title
	from EMPLOYEES e join JOBS j on j.JOB_ID=e.JOB_ID
	where e.DEPARTMENT_ID=100
 
    --#5
    --Създайте изглед върху изгледа от предходната задача като в резултатния набор включите само колони: 
    --имена на служител и идентификатор на мениджър.
	create view view_of_view as
	select employee,MANAGER_ID
	from dep_100
 
    --#6
    --Да се създаде изглед, който съдържа десетимата клиенти с най-голям брой
    --поръчки. Ако последният клиент има равен брой поръчки с други клиенти, 
    --те също да участват в изгледа.
	create view top_ten as
	select top 10 with ties c.CUSTOMER_ID,c.FNAME,c.LNAME,count(o.customer_id) as order_count from customers c, ORDERS o
	where o.CUSTOMER_ID=c.CUSTOMER_ID
	group by c.CUSTOMER_ID,c.FNAME,c.LNAME
	order by order_count desc
  SELECT TOP 10 WITH TIES C.FNAME, C.LNAME , COUNT(O.ORDER_ID) COUNT_ORDERS
    FROM CUSTOMERS C JOIN ORDERS O
    ON O.CUSTOMER_ID = C.CUSTOMER_ID
    GROUP BY C.FNAME, C.LNAME, C.CUSTOMER_ID
    ORDER BY COUNT_ORDERS DESC
    --#7
    --Да се създаде изглед с имената на държавите с повече от 5 клиента от тях.
	create view custom_country as
	select co.name,count(cu.customer_id)
	from countries co join CUSTOMERS cu on co.country_id=cu.COUNTRY_ID
	group by co.name
	having count(cu.customer_id)>5
 
 ------------------------------------------------------------------------------------------
 
    --Задача 5-1. 
    --Да се създаде изглед, който съдържа имената на продуктите и общо поръчано
    --количество от продукт. Сортирайте спрямо количество низходящо.
	create view order_product as
	select p.name,sum(quantity) as total_quantity
	from PRODUCTS p left join ORDER_ITEMS oi on oi.PRODUCT_ID=p.PRODUCT_ID
	group by p.name, p.PRODUCT_ID
	order by total_quantity desc
 
    --------------------------------------------------------------------------
    ------------------5.4.Манипулиране на данни чрез изглед ------------------
    --------------------------------------------------------------------------
    --Пример 5-6.1
    --Създай изглед базиран на JOIN между таблиците COUNTRIES и CUSTOMERS
	create view co_cu as
	select cu.CUSTOMER_ID,cu.ADDRESS,cu.FNAME,cu.LNAME,cu.gender,co.country_id,co.name 
	from CUSTOMERS cu full join countries co on cu.COUNTRY_ID=co.country_id
 
    --Пример 5-6.2 
    --Да се добави нов запис в таблицата CUSTOMERS през изгледа от Пр. 5-6.1.
    insert into co_cu(CUSTOMER_ID,ADDRESS,FNAME,LNAME,GENDER,country_id) values('10','бул.България','Виктор','Петров','М',5)
    
	 CREATE VIEW EXAMPLE
     AS
     SELECT CO.NAME, 
            CO.COUNTRY_ID AS CO_COUNTRY, 
            CU.COUNTRY_ID  AS CU_COUNTRY,
            CU.CUSTOMER_ID,
            CU.FNAME, 
            CU.LNAME,
            CU.GENDER,
            CU.EMAIL
     FROM CUSTOMERS CU JOIN COUNTRIES CO
     ON CO.COUNTRY_ID = CU.COUNTRY_ID
 
     SELECT * FROM EXAMPLE
	 INSERT INTO EXAMPLE (CUSTOMER_ID, FNAME, LNAME, GENDER, EMAIL, CU_COUNTRY)
    VALUES (10, 'Лорен', 'Гарнър', 'F', 'loreng@icloud.com', 'IT')
 
    SELECT * FROM EXAMPLE
    SELECT * FROM CUSTOMERS
	
	---Пример 5-7.
    -- Да се промени фамилията на клиент с идентификатор 10.
	update EXAMPLE 
	set fname='L'
	where CUSTOMER_ID=10

	--Пример 6-1. 
    --Да се създаде транзакция, която добавя нов клиент и създава поръчка за него, 
    --включваща два продукта.
	--Begin transaction
 
    /*Пример 6-2. 
    Транзакция, която променя фамилията на клиент с идентификатор = 1001, 
    след което отхвърля направените промени.*/
	begin tran t1
	update customers set lname='change'
	where customer_id=1001
	rollback tran

 
    /*Пример 6-3.
    Транзакция, която въвежда нов клиент, поставя точка на запис,
    въвежда поръчка, след което отхвърля промените до точката на запис, т.е.
    отхвърля се само поръчката.*/
	begin tran t2
	insert into CUSTOMERS(CUSTOMER_ID,COUNTRY_ID,fname, lname) values (1003, 'IT', 'Кей', 'Ромеро')
	save tran t5
	insert into orders (ORDER_ID, ORDER_DATE, EMPLOYEE_ID, CUSTOMER_ID)
        VALUES (2, GETDATE(), 137, 1003)
		rollback tran t5
		commit tran

--Да се създаде транзакция, която:

--- добавя нов служител с идентификатор 300;
--- после променя фамилията на клиент с идентификатор 111 на 'Маринова'; 
--- и след това добавя нова поръчка в таблица ORDERS, в която участват горепосочените идентификатори на служител и клиент;
--- нека след това извлече в резултат добавения запис в таблица ORDERS. 

--A промените от транзакцията останат постоянни!
 BEGIN TRAN homework
 INSERT INTO EMPLOYEES( EMPLOYEE_ID,FNAME,LNAME,EMAIL,HIRE_DATE,SALARY,JOB_ID) 
 VALUES (300,'Петър', 'Петров','p.petrov@abv.bg','2019-07-21',3800,'SA_REP')

 UPDATE CUSTOMERS 
 SET LNAME='Маринова'
 WHERE CUSTOMER_ID=111

INSERT INTO ORDERS(ORDER_ID,EMPLOYEE_ID,CUSTOMER_ID,ORDER_DATE) VALUES(10000,300,111,'2018-12-31')

 SELECT * FROM ORDERS WHERE ORDER_ID=10000

 COMMIT TRAN
    /*Задача 6-1. 
    Транзакция, която има за цел да изтрие отдел „Мениджмънт“,
    като преди това прехвърли всички служители от него в отдел „Администрация“.*/
	begin tran t3
	UPDATE EMPLOYEES
    SET DEPARTMENT_ID = 10
    WHERE DEPARTMENT_ID = 90
    --изтрие отдел „Мениджмънт“
    DELETE FROM DEPARTMENTS
    WHERE NAME = 'Мениджмънт'
    COMMIT TRAN
 
    SELECT D.NAME , D.DEPARTMENT_ID, E.EMPLOYEE_ID
    FROM EMPLOYEES E FULL JOIN DEPARTMENTS D
    ON D.DEPARTMENT_ID = E.DEPARTMENT_ID
    WHERE D.NAME = 'Мениджмънт' OR D.NAME = 'Администрация'
 
     /* Задача 6-2. 
    Транзакция, която изтрива продукт 1726 - първо го изтрива от всички поръчки 
    после от таблицата с продукти, и накрая отхвърля направените промени.*/
	begin tran t4
	select * from PRODUCTS where product_id=1726
	delete from ORDER_ITEMS
	where PRODUCT_ID=1726
	delete from PRODUCTS
	where product_id=1726
	rollback tran t4
 
    --Задача *
    --Да се създаде транзакция, която променя фамилията на служител с 
    --идентификатор 103 на 'Гочев', променя фамилията на служител с 
    --идентификатор 114 на 'Петров', както и фамилията на служител с 
    --идентификатор 118 на 'Маринов'. 
    --Нека след това извлече в резултат им и фамилия само за горепосочените 
    --променени служители. Като промените от транзакцията останат постоянни.
	begin tran t5
	update EMPLOYEES
	set fname='Гочев'
	where EMPLOYEE_ID=103
	update EMPLOYEES
	set lname='Петров'
	where EMPLOYEE_ID=114
	update EMPLOYEES
	set lname='Маринов'
	where EMPLOYEE_ID=118
	commit tran

    
    -------------------------------------------------------------------------------------
    ---------------------------------- ПРОЦЕДУРИ ----------------------------------------
    -------------------------------------------------------------------------------------
    --Пример 7-2. 
    --Да се създаде процедура, която за подадена като входен параметър идентификатор на 
    --поръчка извежда имена на служител, който я е обработил, както и общата й стойност.
  -- create procedure example 
   --as
   select e.fname,e.lname, o.order_id,sum(quantity*unit_price)
   from EMPLOYEES e join orders o on o.EMPLOYEE_ID=e.EMPLOYEE_ID
   join ORDER_ITEMS oi on oi.ORDER_id=o.ORDER_ID


    -------------------------------------------------------------------------------------
    ---------------------------------- ФУНКЦИИ ------------------------------------------
    -----1.--Скаларни -------------------------------------------------------------------
    --Пример 7-4. 
    --Да се създаде функция, връщаща като скаларна стойност текст, съдържащ името на 
    --отдел (подаден като параметър) и обща стойност на заплатите в него.

    
    -----2. Функции, връщащи резултатен набор ------------------------------------------
 
    --Пример 7-5.
    --Да се създаде функция, връщаща като резултат служителите с техните длъжности.
    
 
    -------------------------------------------------------------------------------------
    ----------------------------- Тригери -----------------------------------------------
    -------------------------------------------------------------------------------------
    /*Задача 9-1. 
    Да се създаде тригер, който при всяка промяна на фамилия на клиент
    записва ред в нова таблица CUSTOMERS_HISTORY с атрибути:
    • идентификатор на клиент;
    • стара фамилия;
    • нова фамилия.*/

	--1.1. В базата TRADECOMPANY създайте още една таблица под името SHIPPING,
	--в която ще се случва пренасочването към куриерска фирма (SPEEDY или ECONT).
	--Също така ще е нужен външен ключ към вече съществуващата таблица ORDERS(и по конкретно атрибут от нея ORDER_ID).
	CREATE TABLE SHIPPING(
	SHIPPING_ID INT PRIMARY KEY NOT NULL,
	ORDER_ID INT NOT NULL,
	COURIER VARCHAR(10) NOT NULL,
	CONSTRAINT FK_ORDER_ID FOREIGN KEY (ORDER_ID) REFERENCES ORDERS(ORDER_ID)
	)

--Забележка: Следвайте схемата! А таблица ORDERS остава каквато е била до сега, без допълнителни корекции от ваша страна.

--1.2 След това въведете данни в таблица SHIPPING за куриерски фирми
--относно поръчки с идентификатори 2374 и 2359 (по един  запис). 
INSERT INTO SHIPPING VALUES (1,2374,'ECONT'), (2,2359,'SPEEDY')

--1.3 Изведете всички данни чрез съединение (join) между новосъздадената таблица SHIPPING и таблица ORDERS.
SELECT s.SHIPPING_ID,o.ORDER_ID,s.COURIER,o.ORDER_DATE,o.CUSTOMER_ID,o.EMPLOYEE_ID,o.SHIP_ADDRESS
FROM SHIPPING s RIGHT JOIN ORDERS o ON o.ORDER_ID=s.ORDER_ID

SELECT s.*,o.*
FROM SHIPPING s RIGHT JOIN ORDERS o ON o.ORDER_ID=s.ORDER_ID
