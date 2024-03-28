use Assessment


--1. Write a query to display your birthday( day of week)
DECLARE @YourBirthday DATE = '2001-06-13'
SELECT DATENAME(WEEKDAY, @YourBirthday) AS Birthday_DayOfWeek
 
 --OUTPUT
 Wednesday


 --2.Write a query to display your age in days

DECLARE @YourBirthday DATE = '2001-06-13'
SELECT DATEDIFF(DAY, @YourBirthday, GETDATE()) AS AgeInDays

--OUTPUT
8324



--3.Write a query to display all employees information those who joined before 5 years in the current month

SELECT * FROM Employees1
WHERE doj <= DATEADD(YEAR, -5, GETDATE())
AND MONTH(doj) = MONTH(GETDATE())

--OUTPUT
1	Sahana	50000.00	2019-03-15
4	Manya	52000.00	2017-03-28



--4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    -- c. Delete first row.
     --After completing above all actions how to recall the deleted row without losing increment of second row.

 use Assessment

CREATE TABLE Employee2 (
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    sal FLOAT,
    doj DATE
)


BEGIN  TRANSACTION

INSERT INTO Employee2(empno, ename, sal, doj)
VALUES 
    (1, 'Sahana',8000, '2019-06-13'),
    (2, 'Yash', 7000, '2020-12-18'),
    (3, 'Tejas', 6500, '2023-04-22');


UPDATE Employee2
SET sal = sal * 1.15

DELETE FROM Employee2
WHERE empno = 1

COMMIT 
ROLLBACK

SELECT * FROM Employee2

--OUTPUT
2	Yash	8050	2020-12-18
3	Tejas	6500	2023-04-22



--5.Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions

Use Assignment	

CREATE or ALTER FUNCTION CalculateBonus (@deptno INT, @sal FLOAT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @bonus FLOAT

    IF @deptno = 10
        SET @bonus = @sal * 0.15
    ELSE IF @deptno = 20
        SET @bonus = @sal * 0.20
    ELSE
        SET @bonus = @sal * 0.05

    RETURN @bonus
END



--a.     For Deptno 10 employees 15% of sal as bonus.
SELECT ename, sal, dbo.CalculateBonus(deptno, sal) AS bonus
FROM tblEmp
WHERE deptno = 10
--OUTPUT
KING	5000	750
MILLER	1500	225



--b.     For Deptno 20 employees  20% of sal as bonus
SELECT ename, sal, dbo.CalculateBonus(deptno, sal) AS bonus
FROM tblEMP
WHERE deptno = 20

--OUTPUT
SMITH	1080	216
JONES	3372.5	674.5
SCOTT	3300	660
ADAMS	1410	282
FORD	3300	660


--c      For Others employees 5%of sal as bonus
SELECT ename, sal, dbo.CalculateBonus(deptno, sal) AS bonus
FROM tblEMP
WHERE deptno NOT IN (10, 20)

--OUTPUT
ALLEN	1800	90
WARD	1450	72.5
MARTIN	1450	72.5
BLAKE	3050	152.5
TURNER	1700	85
JAMES	1150	57.5

