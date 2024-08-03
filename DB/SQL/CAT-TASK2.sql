USE COMPANY1
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


