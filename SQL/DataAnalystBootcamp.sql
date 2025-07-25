CREATE DATABASE DataAnalystBootcamp

CREATE TABLE EmployeeDemograpics
(EmployeeID int, 
FirstName varchar(50),
LastName varchar(50),
Age int,
Gender varchar(50)
)

CREATE TABLE EmployeeSalary(
EmployeeID int,
JobTitle varchar (50),
Salary int)

INSERT INTO EmployeeDemograpics Values 
(1001,'Jim','Halpert',30,'Male'),
(1002,'Pam','Beasley',30,'Female'),
(1003,'Dwight','Schrute',29,'Male'),
(1004,'Angela','Martin',31,'Female'),
(1005,'Toby','Flenderson',32,'Male'),
(1006,'Michael','Scott',35,'Male'),
(1007,'Meredith','Palmer',32,'Female'),
(1008,'Staneley','Hudson',38,'Male'),
(1009,'Kevin','Malone',31,'Male')

INSERT INTO EmployeeSalary VALUES
(1001,'Salesman',45000),
(1002,'Receptionist',36000),
(1003,'Salesman',63000),
(1004,'Accountant',47000),
(1005,'HR',50000),
(1006,'Regional Manager',65000),
(1007,'Supplier Relations',41000),
(1008,'Salesman',48000),
(1009,'Accountant',42000)

SELECT *FROM EmployeeDemograpics
SELECT Firstname,LastName FROM EmployeeDemograpics
SELECT Firstname FROM EmployeeDemograpics
SELECT TOP 5* FROM EmployeeDemograpics
select distinct EmployeeID FROM EmployeeDemograpics
SELECT DISTINCT Gender FROM EmployeeDemograpics
Select Count(LastName) as LastNameCount from EmployeeDemograpics

SELECT * FROM EmployeeSalary
SELECT MAX(Salary) FROM EmployeeSalary
SELECT MIN(Salary) FROM EmployeeSalary
SELECT AVG(Salary) FROM EmployeeSalary

SELECT * FROM EmployeeDemograpics WHERE FirstName='Jim'
SELECT * FROM EmployeeDemograpics WHERE FirstName<>'Jim' --difference
SELECT * FROM EmployeeDemograpics WHERE Age>30
SELECT * FROM EmployeeDemograpics WHERE Age>=30
SELECT * FROM EmployeeDemograpics WHERE Age<=32 AND Gender='Male'
SELECT * FROM EmployeeDemograpics WHERE Age<=32 OR Gender='Male'
SELECT * FROM EmployeeDemograpics WHERE Age<=32 OR Gender='Male'
SELECT * FROM EmployeeDemograpics WHERE LastName like 'S%'
SELECT * FROM EmployeeDemograpics WHERE LastName like '%S%'
SELECT * FROM EmployeeDemograpics WHERE LastName like 'S%o%'
SELECT * FROM EmployeeDemograpics WHERE FirstName is NOT NULL
SELECT * FROM EmployeeDemograpics WHERE FirstName in ('Jim','Michael')

SELECT Gender,COUNT(Gender) FROM EmployeeDemograpics GROUP BY Gender
SELECT Gender,COUNT(Gender),Age FROM EmployeeDemograpics GROUP BY Gender,Age
SELECT Gender,COUNT(Gender) AS CountGender FROM EmployeeDemograpics WHERE Age>31 GROUP BY Gender ORDER BY CountGender DESC
select *from EmployeeDemograpics ORDER BY Age DESC
select *from EmployeeDemograpics ORDER BY Age ASC,Gender DESC

--INTERMEDIATE
INSERT INTO EmployeeDemograpics VALUES
(1011,'Ryan','Howard',26,'Male')
INSERT INTO EmployeeDemograpics(FirstName,LastName)VALUES
('Holly','Flax')
INSERT INTO EmployeeDemograpics(EmployeeID,FirstName,LastName,Gender) VALUES
(1013,'Darryl','Phibin','Male')

SELECT * FROM EmployeeDemograpics JOIN EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT * FROM EmployeeDemograpics Full Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT * FROM EmployeeDemograpics Left Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT * FROM EmployeeDemograpics Right Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT EmployeeDemograpics.EmployeeID,FirstName,LastName,JobTitle,Salary FROM EmployeeDemograpics Right Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT EmployeeSalary.EmployeeID,FirstName,LastName,JobTitle,Salary FROM EmployeeDemograpics Right Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT EmployeeSalary.EmployeeID,FirstName,LastName,JobTitle,Salary FROM EmployeeDemograpics Left Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
SELECT EmployeeSalary.EmployeeID,FirstName,LastName,JobTitle,Salary FROM EmployeeDemograpics full Outer Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID WHERE FirstName<>'Michael' ORDER BY Salary DESC
SELECT JobTitle,AVG(Salary) FROM EmployeeDemograpics INNER Join EmployeeSalary ON EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID WHERE JobTitle='Salesman' GROUP BY JobTitle

Create Table WareHouseEmployeeDemographics 
(EmployeeID int, 
FirstName varchar(50), 
LastName varchar(50), 
Age int, 
Gender varchar(50)
)
Insert into WareHouseEmployeeDemographics VALUES
(1013, 'Darryl', 'Philbin', NULL, 'Male'),
(1050, 'Roy', 'Anderson', 31, 'Male'),
(1051, 'Hidetoshi', 'Hasagawa', 40, 'Male'),
(1052, 'Val', 'Johnson', 31, 'Female')
SELECT * FROM EmployeeDemograpics UNION ALL SELECT * FROM WareHouseEmployeeDemographics ORDER BY EmployeeID
SELECT EmployeeID,FirstName,Age FROM EmployeeDemograpics UNION ALL SELECT EmployeeID,JobTitle,Salary FROM EmployeeSalary ORDER BY EmployeeID

SELECT FirstName, LastName, Age,
CASE
WHEN Age>30 THEN 'Old'
ELSE 'Young'
END
FROM EmployeeDemograpics WHERE Age is NOT NULL ORDER BY Age

SELECT FirstName, LastName, Age,
CASE
WHEN Age>30 THEN 'Old'
when Age between 27 and 30 then 'Young'
ELSE 'Baby'
END
FROM EmployeeDemograpics WHERE Age is NOT NULL ORDER BY Age

SELECT FirstName, LastName, Age,
CASE
when Age=38 THEN 'Stanley'
WHEN Age>30 THEN 'Old'
ELSE 'Baby'
END
FROM EmployeeDemograpics WHERE Age is NOT NULL ORDER BY Age

SELECT FirstName, LastName, JobTitle,Salary from EmployeeDemograpics JOIN EmployeeSalary on EmployeeDemograpics.EmployeeID=EmployeeSalary.employeeID

SELECT FirstName, LastName, JobTitle,Salary ,
CASE WHEN JobTitle='Salesman' THEN Salary+(Salary*.10)
WHEN JobTitle='Accountant' THEN Salary+(Salary*.05)
WHEN JobTitle='HR' THEN Salary+(Salary*.000001)
ELSE Salary+(Salary*.03)
END AS SalaryAfterRaise
from EmployeeDemograpics JOIN EmployeeSalary on EmployeeDemograpics.EmployeeID=EmployeeSalary.employeeID

SELECT JobTitle, COUNT(JobTitle) from EmployeeDemograpics 
join EmployeeSalary on EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
GROUP BY JobTitle
HAVING COUNT(JobTitle)>1

SELECT JobTitle, avg(Salary) from EmployeeDemograpics 
join EmployeeSalary on EmployeeDemograpics.EmployeeID=EmployeeSalary.EmployeeID
GROUP BY JobTitle
HAVING AVG(Salary)>45000
ORDER BY AVG(Salary)

UPDATE EmployeeDemograpics
SET EmployeeID=1012
WHERE FirstName='Holly' AND LastName='Flax'
SELECT * FROM EmployeeDemograpics

UPDATE EmployeeDemograpics
SET Age=31,Gender='Female'
WHERE FirstName='Holly' AND LastName='Flax'-- EmployeeID=1012

delete from EmployeeDemograpics
where EmployeeID=1005

select firstname as Fname from EmployeeDemograpics-- we cannot use as -just with space
select firstname +' '+lastname as FullName from EmployeeDemograpics
select avg(Age) avgAge from EmployeeDemograpics
select demo.employeeid,sal.salary from EmployeeDemograpics as demo join EmployeeSalary as sal on demo.EmployeeID=sal.EmployeeID

SELECT FirstName,LastName,Gender,Salary,
COUNT(Gender)OVER (PARTITION BY Gender) as TotalGender 
FROM EmployeeDemograpics dem
join EmployeeSalary sal on dem.EmployeeID=sal.EmployeeID

SELECT FirstName,LastName,Gender,Salary,COUNT(Gender)
FROM EmployeeDemograpics dem
join EmployeeSalary sal on dem.EmployeeID=sal.EmployeeID
GROUP BY FirstName,LastName,Gender,Salary


--advanced
--CTE'S
;WITH CTE_Employee as(
SELECT FirstName,LastName,Gender,Salary,
COUNT(Gender)OVER (PARTITION BY Gender) as TotalGender,
COUNT(Salary)OVER (PARTITION BY Gender) as AvgSalary
FROM EmployeeDemograpics dem
join EmployeeSalary sal on dem.EmployeeID=sal.EmployeeID
where salary>'45000'
)
select firstname, avgsalary from CTE_Employee
--TEMP TABLE
CREATE TABLE #temp_Employee (
EmployeeID int, 
JobTitle varchar(100), 
Salary int
)
INSERT INTO #temp_Employee VALUES 
('1001','HR','4500')

SELECT * FROM #temp_Employee;

INSERT INTO #temp_Employee SELECT * FROM EmployeeSalary

DROP TABLE IF EXISTS #temp_EmployeeTwo
create table #temp_EmployeeTwo
(JobTitle varchar(50),
EmployeesPerJob int,
AvgAge int,
AvgSalary int)

INSERT INTO #temp_EmployeeTwo
SELECT JobTitle,Count(JobTitle),Avg(Age),AVG(Salary)
FROM EmployeeDemograpics emp join EmployeeSalary sal
on emp.EmployeeID=sal.EmployeeID
GROUP BY JobTitle

SELECT * FROM #temp_EmployeeTwo

CREATE TABLE EmployeeErrors (
EmployeeID varchar(50),
FirstName varchar(50),
LastName varchar(50)
)
INSERT INTO EmployeeErrors VALUES
('1001 ','Jimbo','Halbert'),
(' 1002','Pamela','Beasely'),
('1005','TOby','Flenderson-Fired')
SELECT * FROM EmployeeErrors
--TRIM
SELECT EmployeeID, trim(EmployeeID) as IDTRIM FROM EmployeeErrors
SELECT EmployeeID, Ltrim(EmployeeID) as IDTRIM FROM EmployeeErrors
SELECT EmployeeID, Rtrim(EmployeeID) as IDTRIM FROM EmployeeErrors
--REPLACE
SELECT LastName, REPLACE(LastName,'-Fired','')as LastNameFixed FROM EmployeeErrors
--substring -specify strat and end
SELECT SUBSTRING(FirstName, 1,3) FROM EmployeeErrors
SELECT err.FirstName,dem.FirstName FROM EmployeeErrors err JOIN EmployeeDemograpics dem ON SUBSTRING(err.FirstName,1,3)=SUBSTRING(dem.FirstName,1,3)
--UPPER AND LOWER
SELECT FirstName,LOWER(Firstname) as LowerFirstName FROM EmployeeErrors
SELECT FirstName,UPPER(Firstname) as UpperFirstName FROM EmployeeErrors;

--stored procedures
CREATE PROCEDURE TEST AS SELECT * FROM EmployeeDemograpics
EXEC TEST

create procedure temp_employee as 
--@JobTitle varchar(100),
create table #temp
(JobTitle varchar(50),
EmployeesPerJob int,
AvgAge int,
AvgSalary int)

INSERT INTO #temp
SELECT JobTitle,Count(JobTitle),Avg(Age),AVG(Salary)
FROM EmployeeDemograpics emp join EmployeeSalary sal
on emp.EmployeeID=sal.EmployeeID
--where JobTitle=@JobTitle
GROUP BY JobTitle

select * from #temp

exec temp_employee  --@JobTitle='Salesman'

--subquery
SELECT * FROM EmployeeSalary
SELECT EmployeeID,Salary,(SELECT AVG(SALARY) FROM EmployeeSalary) AS AllAvgSalary
FROM EmployeeSalary
SELECT EmployeeID,Salary,AVG(SALARY) OVER() AS AllAvgSalary
FROM EmployeeSalary

SELECT EmployeeID,Salary,AVG(SALARY) AS AllAvgSalary
FROM EmployeeSalary
GROUP BY EmployeeID, Salary
ORDER BY 1,2

SELECT A.EmployeeID,AllAvgSalary FROM( SELECT EmployeeID,Salary,AVG(SALARY) OVER() AS AllAvgSalary
FROM EmployeeSalary) A

SELECT EmployeeID,Salary,JobTitle
FROM EmployeeSalary
WHERE EmployeeID IN (SELECT EmployeeID FROM EmployeeDemograpics
where age>30)




