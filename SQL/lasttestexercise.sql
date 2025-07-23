--Задача 2-1. Да се създаде база от данни с име TESTDB.
 create database testdb;


--Задача 2-2. Да се създаде таблица в тази база данни с име COUNTRIES и следните колони:
--country_code – с тип char(3);
--name – тип varchar(40);
--population – тип int.
create table countries (
country_code char(3) not null,
name varchar(40) not null,
population int not null
)
 
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
delete countries
 
--Задача 2-7. Да се изтрие таблицата COUNTRIES от базата данни.
 drop table countries
--Задача 2-8. Да се изтрие базата данни TESTDB.
drop database testdb

/*Задача 3-2. 
    Да се увеличи количеството с 2 броя и да се намали единичната цена с 5% на
    продукт с идентификатор 2254 в поръчка с идентификатор 2354. */
	update ORDER_ITEMS
	set quantity+=2, UNIT_PRICE-=0.05
	where PRODUCT_ID=2254 and ORDER_ID=2354

	select * from ORDER_ITEMS where PRODUCT_ID=2254 and ORDER_ID=2354
 
/*Задача 3-3.
    Да се изтрие служител с идентификатор 183.*/
	delete EMPLOYEES
	where employee_id=183
 
-------------------------------------------------------------------------------------------
/* Пример 4-1. 
    Да се изведат имената, датите на назначаване и заплатите на всички служители. */
	select fname, lname, hire_date, salary
	from EMPLOYEES
 
/*Пример 4-2. 
    Да се изведат всички данни за продуктите, с цена по-голяма от 2000. Резултатът
    нека бъде подреден по цена на продукт възходящо.*/
	select * from PRODUCTS
	where PRICE>2000
	order by price asc
 
/*Пример 4-3.
    Да се изведе броя на всички служители.*/
	select count(employee_id)
	from employees
 
/*Пример 4-4.  
    Да се изведе броя служители, групирани по отдела, в който работят.*/
	select department_id, count(employee_id) as emp_count
	from EMPLOYEES
	group by DEPARTMENT_ID
 
-------------------------------------------------------------------------------------------
/*Задача. Да се изведат общата сума на заплатите и броя служители в отдел 60.*/
select sum(salary), count(employee_id)
from EMPLOYEES
where DEPARTMENT_ID=60
 
/*Задача.
    За всички поръчки да се изведат идентификатор на поръчка и обща стойност на
    поръчката. Резултатът да е подреден по стойност на поръчката в низходящ ред.*/
	select order_id, sum(quantity*unit_price) as total_sum
	from ORDER_ITEMS
	group by order_id
	order by total_sum desc

	--Задача #1 
--Изведете общото количество, в което продуктите (само с техните идентификатори) са били поръчани;
-- и сортирайте резултатния набор спрямо общото количество във възходящ ред.
select PRODUCT_ID, sum(quantity) as total_quantity
from ORDER_ITEMS
group by PRODUCT_ID
order by total_quantity asc
 
--Задача #2 
--Изведете от кои идентификатори на държави колко на брой клиенти има фирмата. 
--Сортирайте спрямо бройката на клиентите в низходящ ред.
select country_id, count(customer_id) as custom_count
from CUSTOMERS
group by country_id
order by custom_count desc
--Задача #3 
--Изведете броя поръчки, които е изпълнил всеки служител.
--В резултатния набор да участват само служители, изпълнили повече от 5 поръчки. 
 select employee_id, count(order_id) as order_count
 from ORDERS
 group by EMPLOYEE_ID
 having count(order_id)>5

--Задача #4 
--Изведете длъжностите със средна работна заплата над 10 000.
--Сортирайте спрямо средната работна заплата в низходящ ред.
select job_id, avg(salary) as avg_salary
from EMPLOYEES
group by job_id
having avg(salary)>10000
order by avg_salary desc

 
--Задача #5 
--Изведете колко служители са назначени на определен идентификатор на длъжност. 
--Но резултатът да включва само тези длъжности, на които има повече от 5 служителя.
--Сортирайте по броя служители на съответната длъжност във възходящ ред.
 select job_id,count(employee_id) as employee_count
 from EMPLOYEES
 group by job_id
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
 select country_id from departments
 union select country_id from customers
--Пример 4-6. 
    --Да се изведат идентификаторите на държавите, в които има клиенти или отдели на фирмата. 
    --Нека в резултатния набор участват и дублиращите се записи.
 select country_id from customers
 union all 
 select country_id from DEPARTMENTS
 
/*Задача 4-4. 
    Да се изведат всички малки имена на клиенти и служители с евентуалните
    повторения, сортирани в низходящ ред по име. */
 select fname from customers
 union all 
 select fname from employees
 order by fname desc
 
/*Задача 4-5.
    Да се изведат име и фамилия на клиенти и служители без повторения, а като
    трета колона за клиентите да се използва израз, генериращ низа „Клиент
    (<идентификатор>)“, за служителите – „Служител (<идентификатор>)“. */
 select fname, lname, 'Клиент(<'+cast(customer_id as varchar)+'>)'
 from customers
 union 
 select fname, lname, 'Служител(<'+cast(employee_id as varchar)+'>)'
 from EMPLOYEES
----------------------------------INTERSECT(сечение)---------------------------------------
/*Резултатът съдържа общите за двата резултатни набора редове, без дубликати. С условия:
     -Броят на колоните във всички заявки трябва да бъде еднакъв;
     -Колоните трябва да бъдат от съвместими типове от данни.
 
Пример 4-7. 
    Да се изведат id на държавите, в които има клиенти и отдели на фирмата едновременно.*/
 select country_id
 from customers
 intersect
 select country_id
 from departments

--Задача 4-6. Да се изведат общите собствени имена на клиенти и служители.
 select fname from customers
 intersect 
 select fname from employees
----------------------------------EXCEPT---------------------------------------------------
/*Връща редовете, върнати от първата заявка, които не се срещат измежду редове от втората.
Условия:
    -Броят на колоните във двете заявки трябва да бъде еднакъв;
    -Колоните трябва да бъдат от съвместими типове от данни. */
 
--Пример 4-8.
--  Изведи id на държавите, в които има клиенти и в същото време няма отдели на фирмата.
 select distinct country_id from customers 
 minus 
 select country_id from departments
/*Задача 4-7. 
    Да се изведат собствени имена на клиенти, които не се срещат сред тези на служители.*/
	select fname from CUSTOMERS
	except 
	select fname from EMPLOYEES
 
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
select c.name,r.name
from countries c
join regions r on r.REGION_ID=c.region_id
 
--Пример 4-11.
--  Изведи имена на клиенти, имена на държавите от които са, и имена на регионите на държавите.
select c.fname+' '+c.lname as custom_name, cu.name, r.name
from customers c
join countries cu on cu.country_id=c.COUNTRY_ID
join REGIONS r on r.REGION_ID=cu.region_id

   -- Пример 4-12. 
    -- Да се изведат регионите и държавите, които се намират в тях. Резултатният
    -- набор да включва и регионите, в които няма въведени държави.
	select r.name, c.name
	from regions r left join countries c on r.REGION_ID=c.region_id
 
    -- Пример 4-13. 
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион.
	select r.name, c.name
	from regions r right join countries c on c.region_id=r.REGION_ID
 
    -- Пример 4-14.
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион и регионите, 
    -- за които няма въведени държави.
 select r.name, c.name
 from regions r full join countries c on c.region_id=r.region_id
    -------------------------------------------------------------------------------------
    --#1. 
    --Изведете наименуванията на длъжностите с минимална заплата над 5000. 
    --Сортирайте резултатния набор по мин. заплата низходящо.
 select job_title, MIN_SALARY
 from jobs
 where MIN_SALARY>5000
 order by 2 desc
    --#2. 
    --Изведете имената на служителите, наименованията на длъжностите им, 
    --и имената на отделите, в които работят.
	select fname, lname, job_title, name
	from employees e join jobs j on e.JOB_ID=j.JOB_ID
	join DEPARTMENTS d on d.DEPARTMENT_ID=e.DEPARTMENT_ID
 
    --#3. 
    --Извeдете имената и броя поръчки, които са изпълнили служителите,
    --като резултатният набор да включва всички служители и тези, които все още 
    --не са изпълнявали поръчки. Сортирайте по броя на поръчките във възходящ ред.
	select fname, lname, count(order_id) as order_count
	from employees e left join orders o on o.EMPLOYEE_ID=e.EMPLOYEE_ID
	group by fname, lname, e.EMPLOYEE_ID
	order by order_count asc
 
 SELECT E.FNAME + ' '+ E.LNAME AS служители,
           COUNT(ORDER_ID) 'броя на поръчките'
    FROM EMPLOYEES E LEFT JOIN ORDERS O
    ON O.EMPLOYEE_ID = E.EMPLOYEE_ID
    GROUP BY E.FNAME + ' '+ E.LNAME, E.EMPLOYEE_ID
    ORDER BY 'броя на поръчките'
    --#4. 
    --Изведете имена, заплата и идентификатор на длъжност на служителите,
    --които работят в отдел 80 и не са обработвали поръчки до момента;
	select fname, lname, salary, job_id
	from employees
	where department_id=80
	and employee_id not in(select employee_id from orders)
  SELECT FNAME, LNAME, SALARY, JOB_ID, ORDER_ID
    FROM EMPLOYEES E LEFT JOIN ORDERS O
    ON E.EMPLOYEE_ID = O.EMPLOYEE_ID
    WHERE DEPARTMENT_ID = 80 AND ORDER_ID IS NULL
 
 
    --#5.
    --Изведете имената на отделите и съответния брой служители, които работят в тях.
    --Нека в резултатния набор да участват само отделите, които се намират в държави 
    --с идентификатор 'BG' или 'DE', като в отделите работят не по-малко от 7 служители.
    --Сортирайте резултатния набор по броя на служителите във възходящ ред.
	select d.name, count(employee_id) as emp_count
	from departments d join employees e on e.DEPARTMENT_ID=d.DEPARTMENT_ID
	where d.COUNTRY_ID='BG' OR d.country_id='DE'
	group by d.name, d.DEPARTMENT_ID
	having count(employee_id)>=7
	order by emp_count asc

	SELECT NAME,  
           COUNT(EMPLOYEE_ID) AS 'брой служители'
    FROM DEPARTMENTS D JOIN EMPLOYEES E
    ON E.DEPARTMENT_ID = D.DEPARTMENT_ID
    WHERE COUNTRY_ID IN ('BG', 'DE')
    GROUP BY NAME
    HAVING  COUNT(EMPLOYEE_ID) >= 7
    ORDER BY 'брой служители' ASC
	
 
    --#6.
    --Изведете идентификаторите на клиентите и общата стойност на поръчките им.
    --Нека участват само клиенти с обща стойност на поръчките над 900000 и под 1500000.
	select c.customer_id, sum(unit_price*quantity)
	from customers c join orders o on o.CUSTOMER_ID=c.CUSTOMER_ID
	join order_items oi on o.ORDER_ID=oi.ORDER_ID
	group by c.CUSTOMER_ID
	having sum(unit_price* quantity) between 900000 and 1500000
 
    -------------------------------------------------------------------------------------
 
    -- Задача 4-8. 
    -- Извлечи идентификатори, дати на поръчките и имена на служители, които са ги обработили.
    select order_id, order_date, e.fname+' '+e.lname as employee
	from orders o join employees e on e.EMPLOYEE_ID=o.EMPLOYEE_ID

    -- Задача 4-9. 
    -- Да се изведат имената на всички клиенти и id на поръчките им. 
    -- В резултатния набор да участват и клиентите, които все още не са правили поръчки.
    -- Нека NULL бъде заменена с низа 'none'
	select fname, lname, ISNULL(cast(ORDER_ID as varchar),'none') as order_id
	from customers c left join orders o on o.CUSTOMER_ID=c.CUSTOMER_ID
 
    -- Задача 4-11. 
    -- Да се изведат имената на всички клиенти, които са от държави в регион „Западна Европа“
	select region_id from regions where name like '%Западна%Европа%'
	select fname, lname,region_id from customers c join countries cu on cu.country_id=c.COUNTRY_ID
	where cu.region_id=5
 
 
-----------------------------------------------------------------------------------------
------------------------------4.6.6. Други JOIN вариации---------------------------------
-----------------------------------------------------------------------------------------
 
    -- Пример 4-15. 
    -- Да се изведат държавите и регионите, в които се намират.
        --EQUI-JOIN /=/
		select r.name, r.region_id, c.country_id,  c.name
		from regions r , countries c
		where c.region_id=r.region_id
 
    -- Пример 4-16.
    -- Да се изведат отделите, в които има назначени служители.
        --SEMI-JOIN /IN/EXISTS/
		select distinct d.department_id, d.name from departments d
		where department_id in (select department_id from EMPLOYEES)
 
    -- Пример 4-17.
    -- Да се изведат имената на клиентите, които все още не са правили поръчки.
        --ANTI-JOIN /NOT IN/NOT EXISTS/
		select fname, lname, employee_id
		from employees
		where employee_id not in( select employee_id from orders)
 
    -- Пример 4-18. 
    -- Да се изведат комбинациите от всички региони и държави, сортирани по име на държава.
        --CROSS (CARTESIAN) JOIN
		select * from regions cross join countries
 
-----------------------------------------------------------------------------------------
---------------------------------4.7.1. TOP ---------------------------------------------
-----------------------------------------------------------------------------------------
-- TOP връща първите N реда в неопределен ред => за желана подредба се използва ORDER BY! 
 
    --#7. 
    --На коя дата е първата направена поръчка за фирмата?
	select top 1 order_date
	from ORDERS
	order by ORDER_DATE asc
 
    --#8. 
    --На коя дата е назначен първият служител на фирмата и какви са неговите имена?
    --Нека в резултатния набор участват и останалите служители назначени на същата дата (ако има такива).
 select top 1 with ties hire_date, fname, lname
 from employees
 order by hire_date asc

    --#9. 
    --Изведете седемте продукта с най-ниска складова цена.
	select top 7 *
	from products
	order by price asc
 
    --#10. 
    --Изведете имената и единичната цена на 7-те продукта с най-ниска цена, на която са били продадени.
	select top 7 with ties p.name,oi.unit_price
	from products p join ORDER_ITEMS oi on p.PRODUCT_ID=oi.PRODUCT_ID
	order by oi.UNIT_PRICE asc

	--#1
--Изведете имената на държавите, които не са свързани с никой регион.
 select c.name,c.region_id
 from countries c
 where c.region_id not in (select distinct region_id from regions)

--#2
--На коя длъжност (като название) са назначени най-много служители?
select top 1 j.job_title, count(e.employee_id) as employee_count
from JOBS j join EMPLOYEES e
on e.JOB_ID=j.JOB_ID
group by j.JOB_ID,j.JOB_TITLE
order by employee_count desc

 
--#3
--Кои типове продукти са се продали в общо количество над 1500 бр.?
--Изведете техните имена и съответното общо количество.
select  p.name, sum(oi.quantity) as total_quantity
from products p join ORDER_ITEMS oi
on oi.PRODUCT_ID=p.PRODUCT_ID
group by p.name, p.PRODUCT_ID
having sum(oi.quantity)>1500
 
--#4
--Изведете дата на продажба, броя на клиентите, направили покупки на тази дата,
--броя на служителите, изпълнили тези продажби, броя на продажбите
--и общата стойност на продажбите.
 select ORDER_DATE,count(distinct o.customer_id), count(distinct(o.employee_id)),
 count(o.order_id),sum(quantity*unit_price)
 from orders o join order_items oi 
 on o.ORDER_ID=oi.ORDER_ID
 group by order_date

--#5
--Изведете имената и телефонните номера на всички служители, които започват с 0878. 
 select fname, lname, phone from employees
 where phone like '0878%'

--#6
--Изведете имена на клиенти, чиито адрес включва бул.Марица (без значение от номера) Пловдив.
 select fname , lname, address
 from CUSTOMERS
 where ADDRESS like '%бул.%Марица%Пловдив%'


--#7
--Изведете служителите (с техните имена и заплати), получаващи по-голяма заплата от Матея Маврова
 select e.fname, e.lname, e.salary from employees e
 where e.salary>(select salary from employees where fname='Матея' and lname='Маврова')
--#8
--Изведете име, цена от Products и реална цена, на която са продадени продуктите. 
--Нека цената, на която са продадени бъде по-голяма от средната в Products цена на всички продукти.
 select distinct price, name, UNIT_PRICE
 from products p join order_items oi
 on oi.PRODUCT_ID=p.PRODUCT_ID
where unit_price> (select avg(price) from products)

--#9
--Изведете имената и заплатите (с форматиране за българска валута)
--на всеки един служител. Сортирайте по залплата в низходящ ред.
select fname, lname, format(salary,'C','BG-BG')  as salary
from EMPLOYEES
order by salary desc
 
--#10
-- Изведете имената на продуктите, единичната им цена, идентификаторите на поръчките 
-- и датите на които са направени. Но нека резултатния набор включва само тези от тях,
-- които са след 10.01.2018 г. Сортирайте по дата във възходящ ред.  
-- Забележка: 
-- нека ден, месец и година бъдат разпределени в отделни колони, а месецът 
-- да бъде представен с думи.
 select name, unit_price, oi.order_id, day(order_date) as day,datename(month,order_date) as month, year(order_date) as year
 from orders o join ORDER_ITEMS oi
 on oi.ORDER_ID=o.ORDER_ID
 join products p
 on oi.PRODUCT_ID=p.product_id
 where order_date>'2018-01-10'
 order by order_date asc


--#11
--Изведете разликата в години на първата и последната поръчка на фирамата.
select DATEDIFF( year,(select top 1 order_date from orders order by ORDER_DATE asc),
(select top 1 order_date from orders order by ORDER_DATE desc))
SELECT DATEDIFF(YEAR, MIN(ORDER_DATE), MAX(ORDER_DATE)) FROM ORDERS
 
 
 
--#12
--Изведете данните за клиентите, пазарували на 27.07.2017 г.
 select * 
 from customers c join orders o
 on c.CUSTOMER_ID=o.CUSTOMER_ID
 where CAST (O.ORDER_DATE AS DATE) = '2017-07-27'
--#13
--Изведете клиентите, които са поръчвали през 2000 година.
select fname, lname ,o.customer_id 
from customers c join orders o
on o.CUSTOMER_ID=c.CUSTOMER_ID
where year(ORDER_DATE)='2000'
 
--#14
--Изведете клиентите, които са поръчали само веднъж. Сортирайте по малко име във възходящ ред.
 select c.fname,c.lname, c.customer_id, count(o.order_id) as order_count
 from customers c join orders o
 on o.CUSTOMER_ID=c.CUSTOMER_ID
 group by c.fname, c.LNAME, c.CUSTOMER_ID
 having count(o.order_id)=1
 order by fname asc

--#15
--Изведете минималната заплата на длъжностите, в които има назначени повече от 10 служителя.
 
--#16.
--Изведете длъжностите, на които няма назначени служители.
 
--#17.
--Изведете име, фамилия и пол на клиентите, направили последните 5 поръчки.





create database test_preparation
 create table pizzas(
 pizza_id int primary key not null,
 pizza_type varchar(20) not null
 )
 create table clients (
 client_id int primary key not null,
 name varchar(30) not null,
 phone varchar(10) not null
 )
 create table pizza_orders(
 pizza_id int foreign key(pizza_id) references pizzas,
 client_id int foreign key (client_id) references clients,
 quantity int not null,
 size char(1) check (size in('S','B')),
 datetime datetime
 primary key (pizza_id, client_id)
 )

 alter table pizza_orders 
 add price decimal(5,2) check (price>=0)

 alter table clients
 drop column phone

 insert into pizzas values (1,'Vegan'),(2,'Margarita'),(3,'Caprichoza')
 insert into clients values (1, 'Georgi'),(2,'Ana'),(3,'Veselina'),(4,'Peter')
 insert into pizza_orders values 
 --(1,1,2,'B','2022-02-14',12.4),
 (1,2,3,'S','2022-07-13',6.1),
 (1,1,5,'S','2022-11-29',4.4),(2,4,1,'S','2022-11-30',6.8)

 update pizza_orders
 set quantity=5
 where pizza_id=1 and client_id=1

 select * from pizza_orders

 delete from pizza_orders
 where pizza_id=2 and client_id=4

 delete from pizzas where pizza_id=3

 select name, datetime
 from pizza_orders po join clients c on c.client_id=po.client_id
 where size='S'
 order by name desc

 insert into clients values (5,'Nina')

 select name, count(po.client_id) as client_orders
 from clients c left join pizza_orders po 
 on po.client_id=c.client_id
 group by name, c.client_id

 select p.pizza_type, p.pizza_id, sum(quantity) as total_pizzas
 from pizzas p join pizza_orders po on po.pizza_id=p.pizza_id
 group by p.pizza_type, p.pizza_id
 having sum(quantity)>1

 create view type_and_size as
 select p.pizza_id, p.pizza_type, sum(quantity*price) as total_sum
 from pizzas p join pizza_orders po on p.pizza_id=po.pizza_id
 group by p.pizza_id,p.pizza_type
