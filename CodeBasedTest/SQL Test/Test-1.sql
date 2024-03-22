Create Database Assessment

use Assessment

CREATE TABLE Book (
    id INT PRIMARY KEY,
    title VARCHAR(30),
    author VARCHAR(30),
    isbn VARCHAR(13) UNIQUE,
    reviewerName VARCHAR(20),
    publish_date DATETIME,
    ratings INT
)

INSERT INTO Book (id, title, author, isbn, reviewerName, publish_Date, ratings)
VALUES 
    (1,'My First SQL book','Mary Parker','981483029127','John Smith','2012-02-22 12:08:17',4),
    (2,'My SECOND SQL book','John Mayer','857300923713','John Smith','1972-07-03 09:22:45',5),
    (3,'My THIRD SQL book','Cary Flint','523120967812','Alice Walker','2017-10-22 23:47:10',1)

	--  Write a query to fetch the details of the books written by author whose name ends with er.

SELECT * FROM Book
WHERE author LIKE '%er'

--Display the Title ,Author and ReviewerName for all the books from the above table 
SELECT title, author, reviewerName FROM Book

--Display the  reviewer name who reviewed more than one book.
SELECT reviewerName
FROM Book
GROUP BY reviewerName
HAVING COUNT(*) > 1



CREATE TABLE Customer (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    address VARCHAR(100),
    age INT,
    salary FLOAT
)

INSERT INTO Customer (id, name, address, age, salary)
VALUES 
    (1, 'RAMESH', 'AHMEDABAD',  32, 2000.00),
    (2, 'KHILAN', 'DELHI', 25, 1500.00),
    (3, 'KAUSHIK', 'KOTA', 23, 2000.00),
	(4,'CHAITALI','MUMBAI',25,6500.00),
	(5,'HARDIK','BHOPAL',27,8500.00),
	(6,'KOMAL','MP',22,4500),
	(7,'MUFFY','INDORE',24,10000)

SELECT * FROM Customer

--Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
SELECT name
FROM Customer
WHERE address LIKE '%o%'

CREATE TABLE ORDERS (
    ORDERID INT PRIMARY KEY,
    ORDER_DATE DATETIME,
    CUSTOMER_ID INT,
    AMOUNT FLOAT,
    FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER(ID)
)

INSERT INTO ORDERS (ORDERID, ORDER_DATE, CUSTOMER_ID, AMOUNT) 
VALUES (102, '2009-10-08 00:00:00', 3, 3000),
       (100, '2009-10-08 00:00:00', 3, 1500),
       (101, '2008-05-20 00:00:00',2, 1560),
	   (103, '2008-05-20 00:00:00',4, 2060)


	   --Write a query to display the   Date,Total no of customer  placed order on same Date
SELECT order_date, COUNT(DISTINCT customer_id) AS TotalCustomers
FROM ORDERS
GROUP BY order_date



CREATE TABLE EMPLOYEE (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    address VARCHAR(100),
    age INT,
    salary FLOAT
)


INSERT INTO EMPLOYEE(id, name, address, age, salary)
VALUES 
    (1, 'RAMESH', 'AHMEDABAD',  32, 2000.00),
    (2, 'KHILAN', 'DELHI', 25, 1500.00),
    (3, 'KAUSHIK', 'KOTA', 23, 2000.00),
	(4,'CHAITALI','MUMBAI',25,6500.00),
	(5,'HARDIK','BHOPAL',27,8500.00),
	(6,'KOMAL','MP',22,NULL),
	(7,'MUFFY','INDORE',24,NULL)


--Display the Names of the Employee in lower case, whose salary is null 
SELECT LOWER(name) AS LowercaseName
FROM Employee
WHERE salary IS NULL






CREATE TABLE Students (
    reg INT PRIMARY KEY,
    name VARCHAR(100),
    age INT,
    qualification VARCHAR(100),
    mobile_no VARCHAR(15),
    mail_id VARCHAR(100),
    location VARCHAR(255),
    gender CHAR(1)
)


INSERT INTO Students (reg, name,  age, qualification, mobile_no, mail_id, location, gender)
VALUES 
    (2, 'SAI', 22, 'BE', '9952836777', 'SAI@GMAIL.COM', 'CHENNAI', 'M'),
    (3, 'KUMAR', 20, 'BSC', '7890125648', 'KUMAR@GMAIL.COM', 'MADURAI', 'M'),
    (4, 'SELVI',  22, 'B  TECH', '8904567342', 'SELVI@GMAIL.COM', 'SELAM', 'F'),
 (5, 'NISHA',  25, 'ME', '7834672310', 'NISHA@GMAIL.COM', 'THENI', 'F'),
  (6, 'SAISARAN',  21, 'BA', '7890345678', 'SARAN@GMAIL.COM', 'MADURAI', 'F'),
   (7, 'TOM',  23, 'BCA', '8901234675', 'TOM@GMAIL.COM', 'PUNE', 'M')

--Write a sql server query to display the Gender,Total no of male and female from the above 
                 --  relation    .

 SELECT gender, COUNT(*) AS TotalEmployees
FROM Students
GROUP BY gender
