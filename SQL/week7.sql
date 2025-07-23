    --Пример 4-21.
    -- Петимата служители, започвайки от 10-ти ред, подредени по дата на постъпване. 
	select fname,lname,HIRE_DATE
	from EMPLOYEES
	order by HIRE_DATE desc
	offset 9 rows
	fetch next 5 rows only
 
 select fname,lname,hire_date
 from employees
 order by HIRE_DATE desc
     --Задача 4-12. 
    --вторите 10 най-добре платени служители (подредени по заплата низходящо).
 select fname,lname,salary 
 from EMPLOYEES
 order by salary desc
 offset 9 rows
 fetch next 10 rows only

 select fname,lname,salary
 from EMPLOYEES
 order by salary desc
    --#0
    --В кой град се намира отделът, чийто служители получават най-голяма средна работна заплата.
	select top 1 d.city,d.NAME,AVG(e.salary) as average_salary
	from DEPARTMENTS d
	join EMPLOYEES e on e.DEPARTMENT_ID=d.DEPARTMENT_ID
	group by d.CITY,d.NAME
	order by average_salary desc

 
-----------------------------------------------------------------------------------------
--------------------------------Изгледи = Views------------------------------------------
-----------------------------Създаване на изгледи----------------------------------------
-----------------------------Промяна на изгледи------------------------------------------
 
    --Пример 5-1. 
    --Да се създаде изглед, който съдържа име и фамилия на клиентите, както и
    --номер и дата на поръчките, които те са направили.
     create view [custom_order] as
     select c.fname+' '+c.lname as name,o.ORDER_DATE
     from CUSTOMERS c,ORDERS o
     where c.CUSTOMER_ID=o.CUSTOMER_ID
	 go
	 select * from custom_order
    --Пример 5-2. 
    --Да се модифицира горният изглед така, че да съдържа и колона с името на
    --съответния служител, обработил поръчката.
	alter view custom_order as
	select c.FNAME+' '+c.LNAME as custom_name,o.ORDER_DATE,o.ORDER_ID,e.FNAME+' '+e.LNAME as employee
	from CUSTOMERS c,ORDERS o,EMPLOYEES e
	where c.CUSTOMER_ID=o.CUSTOMER_ID and o.EMPLOYEE_ID=e.EMPLOYEE_ID
	select* from custom_order
 
    --Пример 5-3
    -- Да се модифицира горния изглед така, че да съдържа само поръчките,
    --обработени от служител с идентификатор = 167.
	alter view custom_order as
	select c.FNAME+' '+c.LNAME as custom_name,o.ORDER_DATE,o.ORDER_ID,e.FNAME+' '+e.LNAME as employee,e.EMPLOYEE_ID
	from CUSTOMERS c,ORDERS o, EMPLOYEES e
	where c.CUSTOMER_ID=o.CUSTOMER_ID and e.EMPLOYEE_ID=o.EMPLOYEE_ID and e.employee_id=167

	select * from custom_order

    --Пример 5-4. 
    --Да се създаде изглед, съдържащ име и фамилия на служител и общата сума на
    --поръчките, които той е обработил.
	create view employee_order_price as
	select e.FNAME,e.LNAME,e.EMPLOYEE_ID, sum(unit_price*QUANTITY) as employee_total_sum
	from EMPLOYEES e,ORDERS ord,ORDER_ITEMS o
	where e.EMPLOYEE_ID=ord.EMPLOYEE_ID and o.ORDER_ID=ord.ORDER_ID
	group by e.FNAME,e.LNAME,e.EMPLOYEE_ID

	select * from employee_order_price
 
    --Пример 5-5. 
    --Да се създаде изглед, който съдържа имена, отдел и заплата на 5-мата
    --служители с най-висока заплата. 
 create view emp_salary as
 select e.FNAME,e.LNAME,d.NAME,e.SALARY
 from employees e, DEPARTMENTS d
 where e.DEPARTMENT_ID=d.DEPARTMENT_ID
 order by e.SALARY desc
 offset 0 rows
 fetch next 5 rows only

 select * from emp_salary

    ------------------------------------------------------------------------------------------
    --#1
    --Да се създаде изглед, съдържащ информация за служителите, 
    --които са и мениджъри и по колко починени имат.
        create view emp_info as
		select e.FNAME,e.LNAME,e.EMPLOYEE_ID,COUNT() AS DEPENDENT
		from EMPLOYEES e, JOBS j
		where e.JOB_ID=j.JOB_ID
		and j.JOB_TITLE like '%мениджър%'
    --#2
    --Да се създаде изглед, съдържащ информация за отделите, в които не работят 
    --никакви служители.
 
    --#3
    --Създайте изглед с име, фамилия, телефон и име на длъжност на служителите, 
    --които работят в отдел 100.
 
    --#4
    --Модифицирайте горния изглед като конкатенирате в една колона име и фамилия на служител,
    --и добавите колони заплата на служителя и идентификатора на неговия пряк ръководител (мениджър).
 
    --#5
    --Създайте изглед върху изгледа от предходната задача като в резултатния набор включите само колони: 
    --имена на служител и идентификатор на мениджър.
 
    --#6
    --Да се създаде изглед, който съдържа десетимата клиенти с най-голям брой
    --поръчки. Ако последният клиент има равен брой поръчки с други клиенти, 
    --те също да участват в изгледа.
	create view top_ten_customERS as
	select c.FNAME,c.LNAME,c.CUSTOMER_ID,count(o.CUSTOMER_ID) as custom_count
	from CUSTOMERS c,ORDERS o
	where c.CUSTOMER_ID=o.CUSTOMER_ID
	group by c.FNAME,c.LNAME,c.CUSTOMER_ID
	order by custom_count desc 
	--offset 0 rows
	--fetch next 10 rows ONLY
	--with check option

	select top 11 * from top_ten_customERS
	order by custom_count desc
 
    --#7
    --Да се създаде изглед с имената на държавите с повече от 5 клиента от тях.
	create view country as
	select c.NAME,count(cus.country_id) as cust_count
	from COUNTRIES c,CUSTOMERS cus
	where c.COUNTRY_ID=cus.COUNTRY_ID
	group by c.NAME
	having count(cus.country_id)>5

	select * from country
 
 ------------------------------------------------------------------------------------------
 
    --Задача 5-1. 
    --Да се създаде изглед, който съдържа имената на продуктите и общо поръчано
    --количество от продукт. Сортирайте спрямо количество низходящо.
	create view order_products as
	select p.NAME,COUNT(o.quantity) as product_quantity
	from PRODUCTS p,ORDER_ITEMS o
	group by p.NAME
	order by product_quantity desc
	offset 0 rows

	select* from order_products
 
    --------------------------------------------------------------------------
    ------------------5.4.Манипулиране на данни чрез изглед ------------------
    --------------------------------------------------------------------------
    --Пример 5-6.1
    --Създай изглед базиран на JOIN между таблиците COUNTRIES и CUSTOMERS
	create view custom_country as
	select custom.CUSTOMER_ID,custom.COUNTRY_ID,custom.ADDRESS,custom.EMAIL,custom.FNAME,custom.LNAME,custom.GENDER,
	c.NAME,c.REGION_ID
	from countries c, customers custom
	where c.COUNTRY_ID=custom.COUNTRY_ID
 
 select * from custom_country
    --Пример 5-6.2 
    --Да се добави нов запис в таблицата CUSTOMERS през изгледа от Пр. 5-6.1.
	insert into custom_country(CUSTOMER_ID,FNAME,LNAME,COUNTRY_ID) values(10,'Иван', 'Петров','BG')
    
    ---Пример 5-7.
    -- Да се промени фамилията на клиент с идентификатор 10.
	update custom_country 
	set lname='Колев'
	where customer_id=10



	--Създайте изглед с имената на държавите и съответния брой отдели в тях. Сортирайте спрямо броя на отделите низходящо.
	create view departments_count as
	select c.NAME, count(d.DEPARTMENT_ID) as department_count
	from COUNTRIES c, DEPARTMENTS d
	where c.COUNTRY_ID=d.COUNTRY_ID
	group by c.NAME
	order by department_count desc
	offset 0 rows

	select * from departments_count

	CREATE VIEW DEPARTMENTS_COUNT AS
	SELECT c.NAME,COUNT(d.DEPARTMENT_ID)AS DEPARTMENTS_COUNT
	FROM COUNTRIES c,DEPARTMENTS d
	WHERE c.COUNTRY_ID=d.COUNTRY_ID
	GROUP BY c.NAME
	ORDER BY DEPARTMENTS_COUNT DESC
	OFFSET 0 ROWS

	SELECT * FROM DEPARTMENTS_COUNT

	CREATE VIEW DEP_COUNT AS
	SELECT c.NAME,COUNT(d.DEPARTMENT_ID) AS DEPARTMENTS_COUNT
	FROM COUNTRIES c, DEPARTMENTS d
	WHERE c.COUNTRY_ID=d.COUNTRY_ID
	GROUP BY c.NAME

	SELECT * 
	FROM DEP_COUNT
	ORDER BY DEPARTMENTS_COUNT DESC

	create view d as
	select c.name,count(d.department_id) as dept_count
	from COUNTRIES c,DEPARTMENTS d
	where c.COUNTRY_ID=d.COUNTRY_ID
	group by c.NAME

	select * from d order by dept_count desc