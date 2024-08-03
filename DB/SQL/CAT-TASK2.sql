USE COMPANY
--1  Retrieve employee information including their department name by joining the Employees and Departments tables.
SELECT E.*, D.DEPARTMENTNAME
	FROM EMPLOYEES E INNER JOIN DEPARTMENTS D
	ON D.DEPARTMENTID = E.DEPARTMENT

--2 Calculate the average salary of employees.
SELECT AVG(SALARY) AS [AVERAGE SALARY]
	FROM EMPLOYEES

--3  List departments with the number of employees in each, ordered by the number of employees.
SELECT D.DEPARTMENTNAME ,COUNT(E.ID) AS [NUMBER]
	FROM EMPLOYEES E INNER JOIN DEPARTMENTS D
	ON D.DEPARTMENTID = E.DEPARTMENT
	GROUP BY D.DEPARTMENTNAME
	ORDER BY NUMBER DESC
--4 Fetch the top 10 highest-paid employees.
SELECT TOP 10 (SALARY)
	FROM EMPLOYEES
--5 Find employees who work in departments located in the 'East' region.
SELECT *
	FROM EMPLOYEES
	WHERE DEPARTMENT IN (SELECT DEPARTMENTID
							FROM DEPARTMENTS
							WHERE LOC = 'EAST')

--6  Create a view named ActiveEmployees that displays only active employees.
CREATE VIEW ActiveEmployees
AS
SELECT *
	FROM EMPLOYEES E
	WHERE E.ISACTIVE = 1;

--7 Create a stored procedure named GetEmployeeDetails to fetch all employee details.
CREATE PROCEDURE GetEmployeeDetails
AS
BEGIN
		SELECT *
			FROM EMPLOYEES E
END

EXEC GetEmployeeDetails

--8 Format the HireDate column of the Employees table as 'dd/MM/yyyy'.
SELECT FORMAT(E.HIREDATE, 'dd/MM/yyyy')
	FROM EMPLOYEES E

--9  Define a function named CalculateBonus to compute a 10% bonus on the salary.
CREATE FUNCTION CalculateBonus (@SALARY DECIMAL)
RETURNS DECIMAL AS
BEGIN
		RETURN @SALARY * 0.1
END

SELECT dbo.CalculateBonus(SALARY) AS [BONUS]
	FROM EMPLOYEES

--10 Declare a temporary table to store the IDs and names of top-performing employees.
DECLARE @TOP_PERFORMING_EMP TABLE (
	ID INT,
	NAME VARCHAR(MAX)
)
INSERT INTO @TOP_PERFORMING_EMP
	SELECT E.ID, E.NAME
		FROM EMPLOYEES E
		WHERE ISACTIVE = 1
SELECT * FROM @TOP_PERFORMING_EMP

--11  Implement error handling to catch and log any errors occurring during database operations.
BEGIN TRY
	INSERT INTO EMPLOYEES
	VALUES (10,'AHMEEE', 3999,100,1,'10-2-3323')
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE(),ERROR_NUMBER()
END CATCH
 
--12Create a trigger to update the EmployeeCount column in the Departments table after an employee insertion or deletion.
CREATE OR ALTER TRIGGER UPD_EMP_COUN_COL
ON EMPLOYEES
AFTER INSERT, DELETE
AS
BEGIN
	SET NOCOUNT ON
	UPDATE DEPARTMENTS
	SET EMPLOYEECOUNT +=1
	FROM inserted I
	WHERE DEPARTMENTID = I.DEPARTMENT
		
	UPDATE DEPARTMENTS
	SET EMPLOYEECOUNT -=1
	FROM deleted D
	WHERE DEPARTMENTID = D.DEPARTMENT
END

	