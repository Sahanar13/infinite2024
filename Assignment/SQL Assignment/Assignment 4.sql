use Assignment


--Write a T-SQL Program to find the factorial of a given number
DECLARE @Number INT = 8
DECLARE @Factorial INT = 1
DECLARE @Counter INT = 1

WHILE @Counter <= @Number
BEGIN
    SET @Factorial = @Factorial * @Counter
    SET @Counter = @Counter + 1
END

PRINT 'Factorial of ' + CAST(@Number AS VARCHAR(10)) + ' is: ' + CAST(@Factorial AS VARCHAR(20))





--Create a stored procedure to generate multiplication tables up to a given number.
CREATE or alter PROC GenerateMultiplicationTables
    @maxNumber INT
AS
BEGIN
    DECLARE @multiplicand INT = 1

    WHILE @multiplicand <= @maxNumber
    BEGIN
        DECLARE @multiplier INT = 1

        WHILE @multiplier <= @maxNumber
        BEGIN
            DECLARE @result INT = @multiplicand * @multiplier
            PRINT CONCAT(@multiplicand, ' * ', @multiplier, ' = ', @result)
            SET @multiplier = @multiplier + 1
        END

        SET @multiplicand = @multiplicand + 1
        PRINT ''
    END
END


EXEC GenerateMultiplicationTables @maxNumber = 10





--  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc


CREATE TABLE Holiday (
    holiday_date DATE PRIMARY KEY,
    holiday_name VARCHAR(100)
)


INSERT INTO Holiday (holiday_date, holiday_name)
VALUES 
    ('2024-08-15', 'Independence Day'),
    ('2024-01-26', 'Republic Holiday'),
    ('2024-12-25', 'Christmas'),
    ('2025-01-01', 'New Year')


CREATE OR ALTER TRIGGER RestrictDataManipulationOnHolidays
ON tblEmp
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @IsHoliday BIT

    SELECT @IsHoliday = CASE 
                            WHEN EXISTS (SELECT 1 FROM Holiday WHERE holiday_date = CONVERT(DATE, GETDATE())) THEN 1 
                            ELSE 0 
                       END

    IF @IsHoliday = 1
    BEGIN
      
        DECLARE @HolidayName VARCHAR(100)
        SELECT @HolidayName = holiday_name FROM Holiday WHERE holiday_date = CONVERT(DATE, GETDATE())

       
        RAISERROR('Due to %s, you cannot manipulate data.', 16, 1, @HolidayName)
    END
    ELSE
    BEGIN
        DECLARE @DateToCheck DATE = '2024-01-26'

        IF EXISTS (
            SELECT 1 
            FROM Holiday 
            WHERE holiday_date = @DateToCheck
        )
        BEGIN
            PRINT 'Insertion is not allowed on holidays.'
        END
        ELSE
        BEGIN
            PRINT 'Insertion is allowed on non-holiday dates.'

            
             --INSERT INTO tblEMP (empno, ename, sal)
             --VALUES (1558, 'Samiya', 3000)

             UPDATE tblEMP SET ename = 'Varsha'
             WHERE ename = 'Suchithra'

            -- DELETE FROM tblEMP WHERE empno = 1552
        END
    END
END

Select * from tblEMP