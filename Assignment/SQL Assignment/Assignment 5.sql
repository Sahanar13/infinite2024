use Assignment

CREATE OR ALTER PROCEDURE GeneratePayslip
    @empId INT
AS
BEGIN
    DECLARE @Salary float
    DECLARE @HRA float
    DECLARE @DA float
    DECLARE @PF float
    DECLARE @IT float
    DECLARE @Deductions float

   
    SELECT @Salary = sal
    FROM tblEMP
    WHERE empno = @empId


    SET @HRA = @Salary * 0.10
    SET @DA = @Salary * 0.20
    SET @PF = @Salary * 0.08
    SET @IT = @Salary * 0.05

   
    SET @Deductions = @PF + @IT

	 PRINT 'Employee Payslip for Employee ID: ' + CAST(@empId AS VARCHAR(10))

    PRINT 'Basic Salary: ' + CAST(@Salary AS VARCHAR(20))
    PRINT 'HRA: ' + CAST(@HRA AS VARCHAR(20))
    PRINT 'DA: ' + CAST(@DA AS VARCHAR(20))
    PRINT 'PF: ' + CAST(@PF AS VARCHAR(20))
    PRINT 'IT: ' + CAST(@IT AS VARCHAR(20))

    PRINT 'Total Deductions: ' + CAST(@Deductions AS VARCHAR(20))
    PRINT 'Net Salary: ' + CAST((@Salary - @Deductions) AS VARCHAR(20))
END


	EXEC GeneratePayslip @empId = 7369

	SELECT * FROM tblEMP



 
