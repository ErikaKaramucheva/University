/*Задача 3-2. 
    Да се увеличи количеството с 2 броя и да се намали единичната цена с 5% на
    продукт с идентификатор 2254 в поръчка с идентификатор 2354. */
 update ORDER_ITEMS
 set quantity+=2 , unit_price*=0.5
 where product_id=2254 and ORDER_ID=2354

/*Задача 3-3.
    Да се изтрие служител с идентификатор 183.*/
 delete from EMPLOYEES where employee_id=183
-------------------------------------------------------------------------------------------
/* Пример 4-1. 
    Да се изведат имената, датите на назначаване и заплатите на всички служители. */
 select concat(fname,' ',lname) as employee, hire_date,salary from employees

/*Пример 4-2. 
    Да се изведат всички данни за продуктите, с цена по-голяма от 2000. Резултатът
    нека бъде подреден по цена на продукт възходящо.*/
 select * from PRODUCTS
 where price>=2000
 order by price asc


/*Пример 4-3.
    Да се изведе броя на всички служители.*/
 select count(employee_id) as employee_count from EMPLOYEES

/*Пример 4-4.  
    Да се изведе броя служители, групирани по отдела, в който работят.*/
 select count(employee_id) as employee_count, department_id 
 from employees
 group by department_id
-------------------------------------------------------------------------------------------
/*Задача. Да се изведат общата сума на заплатите и броя служители в отдел 60.*/
 
 select sum(salary) as salary_sum, sum(employee_id) as employee_count
 from employees 
 where department_id=60

/*Задача.
    За всички поръчки да се изведат идентификатор на поръчка и обща стойност на
    поръчката. Резултатът да е подреден по стойност на поръчката в низходящ ред.*/
 select order_id, sum(unit_price*quantity) as total_sum from ORDER_ITEMS
  group by order_id
 order by total_sum desc

 --Задача #1 
--Изведете общото количество, в което продуктите (само с техните идентификатори) са били поръчани;
-- и сортирайте резултатния набор спрямо общото количество във възходящ ред.
select sum(quantity) as total_quantity, product_id from ORDER_ITEMS
group by PRODUCT_ID
order by total_quantity asc
 
--Задача #2 
--Изведете от кои идентификатори на държави колко на брой клиенти има фирмата. 
--Сортирайте спрямо бройката на клиентите в низходящ ред.
select country_id, count(customer_id) as customer_count
from customers
group by country_id
order by customer_count desc
 
--Задача #3 
--Изведете броя поръчки, които е изпълнил всеки служител.
--В резултатния набор да участват само служители, изпълнили повече от 5 поръчки. 
select count(order_id) as order_count, employee_id
from orders
group by employee_id
having count(order_id)>=5

 
--Задача #4 
--Изведете длъжностите със средна работна заплата над 10 000.
--Сортирайте спрямо средната работна заплата в низходящ ред.
 select avg(salary) as avg_salary, job_id
 from EMPLOYEES
  group by job_id
 having avg(salary)>10000
 order by avg_salary

--Задача #5 
--Изведете колко служители са назначени на определен идентификатор на длъжност. 
--Но резултатът да включва само тези длъжности, на които има повече от 5 служителя.
--Сортирайте по броя служители на съответната длъжност във възходящ ред.
 select count(employee_id) as employee_count,job_id
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
 select country_id from customers 
 union 
 select country_id from departments 
--Пример 4-6. 
    --Да се изведат идентификаторите на държавите, в които има клиенти или отдели на фирмата. 
    --Нека в резултатния набор участват и дублиращите се записи.
 select country_id from customers
 union all
 select country_id from departments
 
/*Задача 4-4. 
    Да се изведат всички малки имена на клиенти и служители с евентуалните
    повторения, сортирани в низходящ ред по име. */
 select fname from customers
 union all
 select fname from employees
 order by fname asc
 
/*Задача 4-5.
    Да се изведат име и фамилия на клиенти и служители без повторения, а като
    трета колона за клиентите да се използва израз, генериращ низа „Клиент
    (<идентификатор>)“, за служителите – „Служител (<идентификатор>)“. */
 select fname, lname, concat('Служител- ',employee_id) from employees
 union 
 select fname, lname, concat('Клиент-',customer_id) from customers
 
----------------------------------INTERSECT(сечение)---------------------------------------
/*Резултатът съдържа общите за двата резултатни набора редове, без дубликати. С условия:
     -Броят на колоните във всички заявки трябва да бъде еднакъв;
     -Колоните трябва да бъдат от съвместими типове от данни.
 
Пример 4-7. 
    Да се изведат id на държавите, в които има клиенти и отдели на фирмата едновременно.*/
 select country_id from customers
 intersect
 select country_id from DEPARTMENTS
--Задача 4-6. Да се изведат общите собствени имена на клиенти и служители.
 select fname from customers
 intersect
 select fname from EMPLOYEES

----------------------------------EXCEPT---------------------------------------------------
/*Връща редовете, върнати от първата заявка, които не се срещат измежду редове от втората.
Условия:
    -Броят на колоните във двете заявки трябва да бъде еднакъв;
    -Колоните трябва да бъдат от съвместими типове от данни. */
 
--Пример 4-8.
--  Изведи id на държавите, в които има клиенти и в същото време няма отдели на фирмата.
 select country_id from customers 
 except
 select country_id from departments
/*Задача 4-7. 
    Да се изведат собствени имена на клиенти, които не се срещат сред тези на служители.*/
 select distinct fname from CUSTOMERS
where fname not in
 (select fname from EMPLOYEES)
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
 select c.name, d.name 
 from COUNTRIES as c, DEPARTMENTS as d
 where c.COUNTRY_ID=d.COUNTRY_ID
--Пример 4-11.
--  Изведи имена на клиенти, имена на държавите от които са, и имена на регионите на държавите.
select concat(c.fname,' ',c.lname) as customer,co.name,r.name
from CUSTOMERS as c, COUNTRIES as co, REGIONS as r
where c.COUNTRY_ID=co.COUNTRY_ID and co.REGION_ID=r.REGION_ID

-- Пример 4-12. 
    -- Да се изведат регионите и държавите, които се намират в тях. Резултатният
    -- набор да включва и регионите, в които няма въведени държави.
 select r.name,c.name 
 from countries as c right join REGIONS as r
 on c.REGION_ID=r.REGION_ID
    -- Пример 4-13. 
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион.
 select r.name, c.name
 from countries as c left join REGIONS as r
 on c.REGION_ID=r.REGION_ID
    -- Пример 4-14.
    -- Да се изведат държавите и регионите, в които се намират. 
    -- Резултатният набор да включва държавите, за които няма въведен регион и регионите, 
    -- за които няма въведени държави.
 select r.name, c.name 
 from countries as c full outer join regions as r
 on r.REGION_ID=c.REGION_ID
    -------------------------------------------------------------------------------------
    --#1. 
    --Изведете наименуванията на длъжностите с минимална заплата над 5000. 
    --Сортирайте резултатния набор по мин. заплата низходящо.
 select job_title, MIN_SALARY from jobs
 where MIN_SALARY>5000
 order by min_salary desc
    --#2. 
    --Изведете имената на служителите, наименованията на длъжностите им, 
    --и имената на отделите, в които работят.
 select concat(fname,' ' ,lname), job_title, name
 from EMPLOYEES as e, jobs as j, departments as d
 where e.JOB_ID=j.JOB_ID and e.department_id=d.DEPARTMENT_ID
    --#3. 
    --Извeдете имената и броя поръчки, които са изпълнили служителите,
    --като резултатният набор да включва всички служители и тези, които все още 
    --не са изпълнявали поръчки. Сортирайте по броя на поръчките във възходящ ред.
 select concat(fname,' ',lname) as employee, count(o.employee_id) as order_count
 from employees as e left join orders as o
 on e.EMPLOYEE_ID=o.EMPLOYEE_ID
 group by concat(fname,' ',lname)
 order by order_count asc
    --#4. 
    --Изведете имена, заплата и идентификатор на длъжност на служителите,
    --които работят в отдел 80 и не са обработвали поръчки до момента;
 select concat(fname,' ',lname) as customer,SALARY,EMPLOYEE_ID, job_id, DEPARTMENT_ID
 from EMPLOYEES as e
 where e.DEPARTMENT_ID=80 and employee_id not in(select employee_id from ORDERS)

   SELECT FNAME, LNAME, SALARY, JOB_ID, ORDER_ID
    FROM EMPLOYEES E LEFT JOIN ORDERS O
    ON E.EMPLOYEE_ID = O.EMPLOYEE_ID
    WHERE DEPARTMENT_ID = 80 AND ORDER_ID IS NULL
    --#5.
    --Изведете имената на отделите и съответния брой служители, които работят в тях.
    --Нека в резултатния набор да участват само отделите, които се намират в държави 
    --с идентификатор 'BG' или 'DE', като в отделите работят не по-малко от 7 служители.
    --Сортирайте резултатния набор по броя на служителите във възходящ ред.
 select d.name, count(e.department_id) as employee_count
 from DEPARTMENTS as d, EMPLOYEES as e, COUNTRIES as c
 where d.DEPARTMENT_ID=e.DEPARTMENT_ID and (d.COUNTRY_ID='BG' or d.COUNTRY_ID='DE')
 group by d.name
 having count(e.department_id)>=7
 order by 2 asc
    --#6.
    --Изведете идентификаторите на клиентите и общата стойност на поръчките им.
    --Нека участват само клиенти с обща стойност на поръчките над 900000 и под 1500000.
 select c.customer_id, sum(o.unit_price*o.quantity) as total_sum
 from CUSTOMERS as c, order_items as o, orders as ord
  where c.CUSTOMER_ID=ord.CUSTOMER_ID and ord.order_id=o.order_id
  group by c.customer_id
 having sum(o.unit_price*o.quantity)>900000 and sum(o.unit_price*o.quantity)<1500000
    -------------------------------------------------------------------------------------
 
    -- Задача 4-8. 
    -- Извлечи идентификатори, дати на поръчките и имена на служители, които са ги обработили.
    select order_id, order_date, concat(fname,' ',lname)as employees
	from orders as o, employees as e
	where o.EMPLOYEE_ID=e.EMPLOYEE_ID
    -- Задача 4-9. 
    -- Да се изведат имената на всички клиенти и id на поръчките им. 
    -- В резултатния набор да участват и клиентите, които все още не са правили поръчки.
    -- Нека NULL бъде заменена с низа 'none'
	 select fname, lname, isnull(cast(order_id as varchar(4)),'none') 
	 from customers as c left join orders as o
	 on o.CUSTOMER_ID=c.CUSTOMER_ID

 
    -- Задача 4-11. 
    -- Да се изведат имената на всички клиенти, които са от държави в регион „Западна Европа“
 select fname, lname,r.name from customers as c,REGIONS as r, countries as co
 where c.COUNTRY_ID=co.COUNTRY_ID and r.REGION_ID=co.REGION_ID and r.name='Западна Европа'
 
-----------------------------------------------------------------------------------------
------------------------------4.6.6. Други JOIN вариации---------------------------------
-----------------------------------------------------------------------------------------
 
    -- Пример 4-15. 
    -- Да се изведат държавите и регионите, в които се намират.
        --EQUI-JOIN /=/
 select c.name, r.name from countries as c, regions as r where r.REGION_ID=c.REGION_ID
    -- Пример 4-16.
    -- Да се изведат отделите, в които има назначени служители.
        --SEMI-JOIN /IN/EXISTS/
 select department_id, name from departments where department_id in (select department_id from EMPLOYEES)
    -- Пример 4-17.
    -- Да се изведат имената на клиентите, които все още не са правили поръчки.
        --ANTI-JOIN /NOT IN/NOT EXISTS/
 select fname, lname from customers where customer_id not in(select customer_id from ORDERS)
    -- Пример 4-18. 
    -- Да се изведат комбинациите от всички региони и държави, сортирани по име на държава.
        --CROSS (CARTESIAN) JOIN
 select * from REGIONS 
 cross join COUNTRIES
-----------------------------------------------------------------------------------------
---------------------------------4.7.1. TOP ---------------------------------------------
-----------------------------------------------------------------------------------------
-- TOP връща първите N реда в неопределен ред => за желана подредба се използва ORDER BY! 
 
    --#7. 
    --На коя дата е първата направена поръчка за фирмата?
 select top 1 order_date from ORDERS order by order_date asc
    --#8. 
    --На коя дата е назначен първият служител на фирмата и какви са неговите имена?
    --Нека в резултатния набор участват и останалите служители назначени на същата дата (ако има такива).
 select top 1 with ties hire_date, concat(e.fname,' ',e.lname) as employee
 from employees as e
 order by hire_date asc

 SELECT TOP 1 WITH TIES FNAME, LNAME, HIRE_DATE
    FROM EMPLOYEES
    ORDER BY HIRE_DATE ASC
    --#9. 
    --Изведете седемте продукта с най-ниска складова цена.
 select distinct top 7 unit_price, product_id, order_id
 from order_items
 order by unit_price asc
    --#10. 
    --Изведете имената и единичната цена на 7-те продукта с най-ниска цена, на която са били продадени.
select distinct top 7  p.name, o.unit_price
from products as p, order_items as o
where p.PRODUCT_ID=o.PRODUCT_ID
order by o.unit_price asc

--#1
--Изведете имената на държавите, които не са свързани с никой регион.
 select name from countries
 where REGION_ID is null
--#2
--На коя длъжност (като название) са назначени най-много служители?
 select top 1 job_title, count(e.job_id) from jobs as j, EMPLOYEES as e
 where e.JOB_ID=j.JOB_ID
 group by job_title,j.JOB_ID
 order by 2 desc

 SELECT TOP 1 JOB_TITLE, COUNT(EMPLOYEE_ID) служител
FROM JOBS J JOIN EMPLOYEES E
ON E.JOB_ID = J.JOB_ID
GROUP BY JOB_TITLE, J.JOB_ID
ORDER BY 2 DESC
--#3
--Кои типове продукти са се продали в общо количество над 1500 бр.?
--Изведете техните имена и съответното общо количество.
 select p.name, sum(quantity) as quantity
 from products as p, order_items as o
 where p.PRODUCT_ID=o.PRODUCT_ID
 group by p.name
 having sum (quantity)>1500
--#4
--Изведете дата на продажба, броя на клиентите, направили покупки на тази дата,
--броя на служителите, изпълнили тези продажби, броя на продажбите
--и общата стойност на продажбите.
 select cast(o.order_date as date), count(distinct o.customer_id) as customer, count(distinct o.employee_id) as employee, 
 count(distinct o.order_id) as order_count, sum(distinct ord.quantity*ord.unit_price)
 from orders as o, order_items as ord
 where o.ORDER_ID=ord.ORDER_ID
 group by cast(order_date as date)

 SELECT CAST(ORDER_DATE AS DATE)    'ДАТА НА ПРОДАЖБА',
       COUNT(DISTINCT CUSTOMER_ID) 'БРОЙ КЛИЕНТИ',
       COUNT(DISTINCT EMPLOYEE_ID) 'БРОЙ СЛУЖИТЕЛИ',
       COUNT(DISTINCT OI.ORDER_ID) 'БРОЙ ПРОДАЖБИ',
       SUM(UNIT_PRICE*QUANTITY)    'ОБЩА СТОЙНОСТ'
FROM ORDERS O FULL JOIN ORDER_ITEMS OI 
ON OI.ORDER_ID  = O.ORDER_ID 
GROUP BY CAST(ORDER_DATE AS DATE)
--#5
--Изведете имената и телефонните номера на всички служители, които започват с 0878. 
 select fname, lname, phone 
 from EMPLOYEES
 where phone like '%0878%'
--#6
--Изведете имена на клиенти, чиито адрес включва бул.Марица (без значение от номера) Пловдив.
 SELECT FNAME, LNAME, ADDRESS FROM CUSTOMERS WHERE ADDRESS LIKE '%бул.%Марица%Пловдив%'
--#7
--Изведете служителите (с техните имена и заплати), получаващи по-голяма заплата от Матея Маврова
 select fname, lname, salary from employees where salary >(select salary from employees
 where fname like '%Матея%' and lname like '%Маврова%')
--#8
--Изведете име, цена от Products и реална цена, на която са продадени продуктите. 
--Нека цената, на която са продадени бъде по-голяма от средната в Products цена на всички продукти.
 select distinct name, price, unit_price 
 from products as p, order_items as o
 where o.PRODUCT_ID=p.PRODUCT_ID
and unit_price>(select avg(price) from PRODUCTS)
--#9
--Изведете имената и заплатите (с форматиране за българска валута)
--на всеки един служител. Сортирайте по залплата в низходящ ред.
 select fname, lname, format(salary,'C','BG')
 from employees
 order by 3 desc
--#10
-- Изведете имената на продуктите, единичната им цена, идентификаторите на поръчките 
-- и датите на които са направени. Но нека резултатния набор включва само тези от тях,
-- които са след 10.01.2018 г. Сортирайте по дата във възходящ ред.  
-- Забележка: 
-- нека ден, месец и година бъдат разпределени в отделни колони, а месецът 
-- да бъде представен с думи.
select p.name,oi.unit_price, o.order_id,year(o.order_date) as year,datename(month,o.order_date) as month,day(o.order_date) as day
from ORDER_ITEMS as oi, PRODUCTS as p, ORDERS as o
where o.ORDER_ID=oi.ORDER_ID and p.PRODUCT_ID=oi.PRODUCT_ID
and o.ORDER_DATE>'2018-01-10'
order by cast(ORDER_DATE as date) asc

 
--#11
--Изведете разликата в години на първата и последната поръчка на фирамата.

-- select DATEDIFF(YEAR,
 --(select top 1 year(order_date) from ORDERS order by year(order_date) desc),
 --(select top 1 year(order_date)from ORDERS order by year(ORDER_DATE) asc))

 SELECT DATEDIFF(YEAR, MIN(ORDER_DATE), MAX(ORDER_DATE)) FROM ORDERS
--#12
--Изведете данните за клиентите, пазарували на 27.07.2017 г.
 select * from customers as c, orders as o
 where c.CUSTOMER_ID=o.CUSTOMER_ID and cast(ORDER_DATE as date)='2017-07-27'
--#13
--Изведете клиентите, които са поръчвали през 2000 година.
 select fname, lname from customers as c, orders as o
 where c.CUSTOMER_ID=o.CUSTOMER_ID and year(ORDER_DATE)=2000
--#14
--Изведете клиентите, които са поръчали само веднъж. Сортирайте по малко име във възходящ ред.
 select c.fname, c.lname, c.customer_id,count(o.customer_id) as order_count
 from customers as c, orders as o
 where c.CUSTOMER_ID=o.CUSTOMER_ID
 group by c.CUSTOMER_ID,c.fname, c.lname 
 having count(o.customer_id)=1
 order by fname asc
--#15
--Изведете минималната заплата на длъжностите, в които има назначени повече от 10 служителя.
 select j.min_salary, j.job_title, count(e.job_id) as employees 
 from jobs as j,employees as e
 where e.job_id=j.JOB_ID
 group by j.job_id,j.JOB_TITLE,j.MIN_SALARY
 having count(e.job_id)>10
--#16.
--Изведете длъжностите, на които няма назначени служители.
 select job_id, job_title 
 from jobs 
where job_id not in (select job_id from EMPLOYEES)
--#17.
--Изведете име, фамилия и пол на клиентите, направили последните 5 поръчки.
select top 5 concat(fname,' ',lname),gender , order_date
from customers as c, orders as o
where c.CUSTOMER_ID=o.CUSTOMER_ID
order by order_date desc

 --Пример 4-21.
    -- Петимата служители, започвайки от 10-ти ред, подредени по дата на постъпване. 
 select fname, lname, hire_date from employees 
 order by hire_date
 offset 9 rows
 fetch next 5 rows only
     --Задача 4-12. 
    --вторите 10 най-добре платени служители (подредени по заплата низходящо).
 select * from employees
 order by SALARY desc
 offset 9 rows
 fetch next 10 rows only
    --#0
    --В кой град се намира отделът, чийто служители получават най-голяма средна работна заплата.
 SELECT TOP 1 D.CITY, E.DEPARTMENT_ID , AVG(SALARY)
    FROM DEPARTMENTS D JOIN EMPLOYEES E
    ON D.DEPARTMENT_ID = E.DEPARTMENT_ID
    GROUP BY D.CITY, E.DEPARTMENT_ID
    ORDER BY 3 DESC
-----------------------------------------------------------------------------------------
--------------------------------Изгледи = Views------------------------------------------
-----------------------------Създаване на изгледи----------------------------------------
-----------------------------Промяна на изгледи------------------------------------------
 
    --Пример 5-1. 
    --Да се създаде изглед, който съдържа име и фамилия на клиентите, както и
    --номер и дата на поръчките, които те са направили.
 create view view1 as
 select fname, lname, order_id, order_date
 from CUSTOMERS as c join orders as o
 on c.CUSTOMER_ID=o.CUSTOMER_ID
    --Пример 5-2. 
    --Да се модифицира горният изглед така, че да съдържа и колона с името на
    --съответния служител, обработил поръчката.
alter view view1 as
select concat(e.fname,' ',e.lname) as employee,
concat(c.fname,' ',c.lname) as customer,
order_id, order_date from employees as e, customers as c, orders as o
where c.CUSTOMER_ID=o.CUSTOMER_ID and e.EMPLOYEE_ID=o.EMPLOYEE_ID
    --Пример 5-3
    -- Да се модифицира горния изглед така, че да съдържа само поръчките,
    --обработени от служител с идентификатор = 167.
 alter view view1 as
 select concat(e.fname,' ',e.lname) as employee,
 concat(c.fname,' ',c.lname) as customer,
 order_id, order_date from orders as o, customers as c, employees as e
 where o.CUSTOMER_ID=c.CUSTOMER_ID and e.EMPLOYEE_ID=o.EMPLOYEE_ID and e.EMPLOYEE_ID=167
    --Пример 5-4. 
    --Да се създаде изглед, съдържащ име и фамилия на служител и общата сума на
    --поръчките, които той е обработил.
 create view view2 as
 select concat(e.fname,' ',e.lname) as employee,
 sum(quantity*unit_price) as total_sum
 from employees as e, ORDER_ITEMS as oi
 group by e.fname, e.lname, e.employee_id
    --Пример 5-5. 
    --Да се създаде изглед, който съдържа имена, отдел и заплата на 5-мата
    --служители с най-висока заплата. 
 create view view3 as
 select top 5 fname, lname, d.name, salary
 from employees as e, DEPARTMENTS as d
 where e.DEPARTMENT_ID=d.DEPARTMENT_ID
 order by salary desc
    ------------------------------------------------------------------------------------------
    --#1
    --Да се създаде изглед, съдържащ имената на служителите и имената на техните преки началници,
    --нека в резултата участват и служителите, които нямат преки началници.
        create view view4 as
		select concat(e.fname,' ', e.lname) as employee,
		concat (m.fname,' ',m.lname) as manager
		from employees as e left join employees as m
		on e.MANAGER_ID=m.EMPLOYEE_ID
    --#2
    --Да се създаде изглед, съдържащ информация за отделите, в които не работят 
    --никакви служители.
 create view view5 as
    SELECT D.* , E.EMPLOYEE_ID
    FROM DEPARTMENTS D LEFT JOIN EMPLOYEES E
    ON D.DEPARTMENT_ID = E.DEPARTMENT_ID 
    WHERE E.EMPLOYEE_ID IS NULL
    --#3
    --Създайте изглед с име, фамилия, телефон и име на длъжност на служителите, 
    --които работят в отдел 100.
 create view view6 as
 select fname, lname, phone, j.job_title
 from employees as e, jobs as j
 where j.JOB_ID=e.JOB_ID and DEPARTMENT_ID=100
    --#4
    --Модифицирайте горния изглед като конкатенирате в една колона име и фамилия на служител,
    --и добавите колони заплата на служителя и идентификатора на неговия пряк ръководител (мениджър).
 alter view view6 as
 select concat (e.fname,' ',e.lname) as employee, phone, job_title, salary, e.manager_id 
 from EMPLOYEES as e, jobs as j
 where j.JOB_ID=e.JOB_ID

    --#5
    --Създайте изглед върху изгледа от предходната задача като в резултатния набор включите само колони: 
    --имена на служител и идентификатор на мениджър.
 create view view6_1 as
 select  employee, manager_id from view6
    --#6
    --Да се създаде изглед, който съдържа десетимата клиенти с най-голям брой
    --поръчки. Ако последният клиент има равен брой поръчки с други клиенти, 
    --те също да участват в изгледа.
 create view view7 as
 select top 10 with ties concat(c.fname,' ',c.lname) as customer, count(o.customer_id) as order_count
 from CUSTOMERS as c, ORDERS as o
 where o.CUSTOMER_ID=c.CUSTOMER_ID
 group by c.fname, c.lname, c.CUSTOMER_ID
 order by 2 desc
    --#7
    --Да се създаде изглед с имената на държавите с повече от 5 клиента от тях.
 create view view7 as
 select  c.country_id, co.name, count(c.country_id) as cus_count
 from customers as c, COUNTRIES as co
 where c.COUNTRY_ID=co.COUNTRY_ID
 group by c.country_id,co.name
 having count(c.country_id)>5

 ------------------------------------------------------------------------------------------
 
    --Задача 5-1. 
    --Да се създаде изглед, който съдържа имената на продуктите и общо поръчано
    --количество от продукт. Сортирайте спрямо количество низходящо.
 create view view8 as
 select p.name,p.product_id, sum(o.quantity) as quantity
 from products as p, order_items as o
 where p.product_id=o.product_id
 group by p.name, p.product_id
 order by 3 desc
    --------------------------------------------------------------------------
    ------------------5.4.Манипулиране на данни чрез изглед ------------------
    --------------------------------------------------------------------------
    --Пример 5-6.1
    --Създай изглед базиран на JOIN между таблиците COUNTRIES и CUSTOMERS
create view view9 as 
 select c.*,cu.ADDRESS,cu.CUSTOMER_ID,cu.EMAIL,cu.FNAME,cu.LNAME,cu.GENDER from countries as c join CUSTOMERS as cu on c.COUNTRY_ID=cu.COUNTRY_ID

    --Пример 5-6.2 
    --Да се добави нов запис в таблицата CUSTOMERS през изгледа от Пр. 5-6.1.
   select * from view9 where CUSTOMER_ID=10
   insert into view9(COUNTRY_ID,CUSTOMER_ID,email,fname, lname, gender) values('BE',10000,'alo@abv.bg','Alexander','Stoyanov','F')
    ---Пример 5-7.
    -- Да се промени фамилията на клиент с идентификатор 10.
	update view9 
	set fname='АБВГ', LNAME='ДЕЖЗ'
	WHERE CUSTOMER_ID=10
	
	--Пример 6-1. 
    --Да се създаде транзакция, която добавя нов клиент и създава поръчка за него, 
    --включваща два продукта.
    SELECT * FROM PRODUCTS
 
    --#1
    BEGIN TRAN TRAN1
        --OPERATION 1:
        INSERT INTO CUSTOMERS(CUSTOMER_ID, COUNTRY_ID, FNAME, LNAME, ADDRESS, EMAIL, GENDER)
        VALUES(1001, 'BG', 'Ива', 'Илиева', 'гр. Пловдив Ж.К. Тракия', 'ii@abv.bg', 'F')
        --OPERAION 2:
        INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, CUSTOMER_ID, EMPLOYEE_ID)
        VALUES(1, GETDATE(), 1001, 125)
        --OPERATION 3:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 1726, 1, 99.00)
        --OPERATION 4:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 2245, 1, 42)
    COMMIT TRAN TRAN1
 
    SELECT * FROM ORDER_ITEMS
    WHERE ORDER_ID = 1
 
    --#1 --NO atomic
    BEGIN TRAN TRAN1
        --OPERATION 1:
        INSERT INTO CUSTOMERS(CUSTOMER_ID, COUNTRY_ID, FNAME, LNAME, ADDRESS, EMAIL, GENDER)
        VALUES(1002, 'BG', 'Ива', 'Илиева', 'гр. Пловдив Ж.К. Тракия', 'ii@abv.bg', 'F')
        --OPERAION 2:
        INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, CUSTOMER_ID, EMPLOYEE_ID)
        VALUES(1, GETDATE(), 1001, 125)
        --OPERATION 3:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 1726, 1, 99.00)
        --OPERATION 4:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 2245, 1, 42)
    COMMIT TRAN TRAN1
 
    SELECT * FROM CUSTOMERS
 
    --#2
    BEGIN TRAN TRAN1
        --OPERATION 1:
        INSERT INTO CUSTOMERS(CUSTOMER_ID, COUNTRY_ID, FNAME, LNAME, ADDRESS, EMAIL, GENDER)
        VALUES(1003, 'BG', 'Ива', 'Илиева', 'гр. Пловдив Ж.К. Тракия', 'ii@abv.bg', 'F')
        IF @@ERROR <> 0 ROLLBACK
 
        --OPERAION 2:
        INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, CUSTOMER_ID, EMPLOYEE_ID)
        VALUES(1, GETDATE(), 1001, 125)
        IF @@ERROR <> 0 ROLLBACK
 
        --OPERATION 3:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 1726, 1, 99.00)
        IF @@ERROR <> 0 ROLLBACK
 
        --OPERATION 4:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 2245, 1, 42)
        IF @@ERROR <> 0 ROLLBACK
 
    COMMIT TRAN TRAN1
 
    SELECT * FROM CUSTOMERS
 
    --#3
    BEGIN TRAN TRAN1
    SET XACT_ABORT ON
        --OPERATION 1:
        INSERT INTO CUSTOMERS(CUSTOMER_ID, COUNTRY_ID, FNAME, LNAME, ADDRESS, EMAIL, GENDER)
        VALUES(1003, 'BG', 'Ива', 'Илиева', 'гр. Пловдив Ж.К. Тракия', 'ii@abv.bg', 'F')
        --OPERAION 2:
        INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, CUSTOMER_ID, EMPLOYEE_ID)
        VALUES(1, GETDATE(), 1001, 125)
        --OPERATION 3:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 1726, 1, 99.00)
        --OPERATION 4:
        INSERT INTO ORDER_ITEMS(ORDER_ID, PRODUCT_ID, QUANTITY, UNIT_PRICE)
        VALUES(1, 2245, 1, 42)
    COMMIT TRAN TRAN1
 
    SELECT * FROM CUSTOMERS
 
    /*Пример 6-2. 
    Транзакция, която променя фамилията на клиент с идентификатор = 1001, 
    след което отхвърля направените промени.*/
    BEGIN TRAN 
            --1
            SELECT LNAME 
            FROM CUSTOMERS  
            WHERE CUSTOMER_ID = 1001
            --2
            UPDATE CUSTOMERS  
            SET LNAME = 'Димитрова'
            WHERE CUSTOMER_ID = 1001
            --3
            SELECT LNAME 
            FROM CUSTOMERS  
            WHERE CUSTOMER_ID = 1001
    ROLLBACK TRAN
            SELECT LNAME 
            FROM CUSTOMERS  
            WHERE CUSTOMER_ID = 1001
 
    /*Пример 6-3.
    Транзакция, която въвежда нов клиент, поставя точка на запис,
    въвежда поръчка, след което отхвърля промените до точката на запис, т.е.
    отхвърля се само поръчката.*/
    SELECT * FROM EMPLOYEES
 
 
    --START.............POINT1 ......... 2.... 3 ROLLBACK POINT1
 
    BEGIN TRAN 
        --OPERATION 1:
        INSERT INTO CUSTOMERS(CUSTOMER_ID, COUNTRY_ID, FNAME, LNAME)
        VALUES(1003, 'IT', 'Кей', 'Ромеро')
    SAVE TRAN POINT1
        --OPERATION 2:
        INSERT INTO ORDERS(ORDER_ID, ORDER_DATE, EMPLOYEE_ID, CUSTOMER_ID)
        VALUES (2, GETDATE(), 137, 1003)
    ROLLBACK TRAN POINT1
    COMMIT TRAN
 
    SELECT * FROM ORDERS
    SELECT * FROM CUSTOMERS
 
    /*Задача 6-1. 
    Транзакция, която има за цел да изтрие отдел „Мениджмънт“,
    като преди това прехвърли всички служители от него в отдел „Администрация“.
    */
    SELECT D.NAME , D.DEPARTMENT_ID, E.EMPLOYEE_ID
    FROM EMPLOYEES E FULL JOIN DEPARTMENTS D
    ON D.DEPARTMENT_ID = E.DEPARTMENT_ID
    WHERE D.NAME = 'Мениджмънт' OR D.NAME = 'Администрация'
 
    BEGIN TRAN 
    ---прехвърли всички служители  „Мениджмънт“ --> „Администрация“
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
    SELECT * 
    FROM PRODUCTS P JOIN ORDER_ITEMS OI
    ON P.PRODUCT_ID = OI.PRODUCT_ID
    WHERE P.PRODUCT_ID = 1726
 
    BEGIN TRAN
        --OPER 1
        SELECT * FROM PRODUCTS
        WHERE PRODUCT_ID = 1726
        --OPER 2:
        DELETE FROM ORDER_ITEMS
        WHERE PRODUCT_ID = 1726
        --OPER 3:
        DELETE FROM PRODUCTS
        WHERE PRODUCT_ID = 1726
        --OPER 3:
        SELECT * FROM PRODUCTS
        WHERE PRODUCT_ID = 1726
    ROLLBACK TRAN
 
    SELECT * 
    FROM PRODUCTS P JOIN ORDER_ITEMS OI
    ON P.PRODUCT_ID = OI.PRODUCT_ID
    WHERE P.PRODUCT_ID = 1726
 
    --Задача *
    --Да се създаде транзакция, която променя фамилията на служител с 
    --идентификатор 103 на 'Гочев', променя фамилията на служител с 
    --идентификатор 114 на 'Петров', както и фамилията на служител с 
    --идентификатор 118 на 'Маринов'. 
    --Нека след това извлече в резултат име и фамилия само за горепосочените 
    --променени служители. 
    --Като промените от транзакцията останат постоянни!
    BEGIN TRAN
        ---OPER 1:
        SELECT FNAME, LNAME
        FROM EMPLOYEES
        WHERE EMPLOYEE_ID IN (103, 114, 118)
        ---OPER 2:
        UPDATE EMPLOYEES
        SET LNAME = 'Гочев'
        WHERE EMPLOYEE_ID = 103
        ---OPER 3:
        UPDATE EMPLOYEES
        SET LNAME = 'Петров'
        WHERE EMPLOYEE_ID = 114
        ---OPER 4:
        UPDATE EMPLOYEES
        SET LNAME = 'Маринов'
        WHERE EMPLOYEE_ID = 118
        ---OPER 5:
        SELECT FNAME, LNAME
        FROM EMPLOYEES
        WHERE EMPLOYEE_ID IN (103, 114, 118)
    COMMIT TRAN
 
        SELECT FNAME, LNAME
        FROM EMPLOYEES
        WHERE EMPLOYEE_ID IN (103, 114, 118)
 
    -------------------------------------------------------------------------------------
    ---------------------------------- ПРОЦЕДУРИ ----------------------------------------
    -------------------------------------------------------------------------------------
    --Пример 7-2. 
    --Да се създаде процедура, която за подаден като входен параметър идентификатор на 
    --поръчка извежда имена на служител, който я е обработил, както и общата й стойност.
    CREATE PROCEDURE EMPLOYEE_TOTAL_ORDER_PROC @ORDER INT 
    AS
    SELECT FNAME, LNAME, O.ORDER_ID, SUM(UNIT_PRICE*QUANTITY) AS TOTAL
    FROM EMPLOYEES E JOIN ORDERS O ON O.EMPLOYEE_ID = E.EMPLOYEE_ID
                     JOIN ORDER_ITEMS OI  ON OI.ORDER_ID = O.ORDER_ID
    WHERE O.ORDER_ID =  @ORDER
    GROUP BY FNAME, LNAME, O.ORDER_ID
 
    EXEC EMPLOYEE_TOTAL_ORDER_PROC @ORDER  = 2356
   
    -------------------------------------------------------------------------------------
    ---------------------------------- ФУНКЦИИ ------------------------------------------
    -----1.--Скаларни -------------------------------------------------------------------
    --Пример 7-4. 
    --Да се създаде функция, връщаща като скаларна стойност текст, съдържащ името на 
    --отдел (подаден като параметър) и обща стойност на заплатите в него.
    CREATE FUNCTION DEPT_NAME_SUM_SALARIES_FUNC (@DEPT_ID INT ) RETURNS VARCHAR(200)
    AS 
    BEGIN 
    DECLARE @NAME VARCHAR(50) , @SUM_SALARY  NUMERIC(10,2)
 
    SELECT @NAME = D.NAME , @SUM_SALARY = SUM(E.SALARY) 
    FROM EMPLOYEES E  JOIN DEPARTMENTS D
    ON E.DEPARTMENT_ID = D.DEPARTMENT_ID
    WHERE D.DEPARTMENT_ID = @DEPT_ID
    GROUP BY D.NAME, D.DEPARTMENT_ID
 
    RETURN 'СУМАТА ОТ ЗАПЛАТИТЕ В ' 
            + @NAME + ' С ID= ' + CAST(@DEPT_ID AS varchar) + 'Е '
             + CAST(@SUM_SALARY  AS varchar) +'. '
    END
 
    SELECT DBO.DEPT_NAME_SUM_SALARIES_FUNC(DEPARTMENT_ID) FROM DEPARTMENTS
 
    
    -----2. Функции, връщащи резултатен набор ------------------------------------------
 
    --Пример 7-5.
    --Да се създаде функция, връщаща като резултат служителите с техните длъжности.
    CREATE FUNCTION EMP_JOBS_FUNCTION () RETURNS TABLE
    AS
    RETURN
        SELECT FNAME, LNAME, JOB_TITLE 
        FROM EMPLOYEES E JOIN JOBS J
        ON E.JOB_ID = J.JOB_ID
 
    SELECT * FROM DBO.EMP_JOBS_FUNCTION()
    ORDER BY JOB_TITLE
 
    -------------------------------------------------------------------------------------
    ----------------------------- Тригери -----------------------------------------------
    -------------------------------------------------------------------------------------
    /*Задача 9-1. 
    Да се създаде тригер, който при всяка промяна на фамилия на клиент
    записва ред в нова таблица CUSTOMERS_HISTORY с атрибути:
    • идентификатор на клиент;
    • стара фамилия;
    • нова фамилия.*/
 
    CREATE TABLE CUSTOMERS_HISTORY 
    (
        CUSTOMER_ID INT,
        OLD_LNAME VARCHAR(50),
        NEW_LNAME VARCHAR(50)
    )
 
    CREATE TRIGGER CUST_HISTORY_TRIGGER
    ON CUSTOMERS  FOR UPDATE 
    AS 
     IF UPDATE(LNAME)
     BEGIN 
        INSERT INTO CUSTOMERS_HISTORY(CUSTOMER_ID, OLD_LNAME, NEW_LNAME)
        SELECT I.CUSTOMER_ID, D.LNAME, I.LNAME 
        FROM inserted  I, deleted D
        WHERE I.CUSTOMER_ID = D.CUSTOMER_ID
     END
 
UPDATE CUSTOMERS
SET LNAME = 'ИВАНОВ'
WHERE CUSTOMER_ID = 101
 
 
SELECT * FROM CUSTOMERS_HISTORY