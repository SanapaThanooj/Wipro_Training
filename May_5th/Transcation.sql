BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 2000
WHERE Department ='IT';

COMMIT; 
--Over()
SELECT
	Name,
	Department,
	Salary,
	avg(Salary) OVER() AS AvgSalary
FROM Employees; 
--PARTITION BY
SELECT
	Name,
	Department,
	Salary,
	AVG(Salary)OVER(PARTITION BY Department ) AS DeptAvgSalary
FROM Employees; 
----Ranking function 
--ROW_NUMBER
SELECT
	Name,
	Department,
	Salary,
	ROW_NUMBER()OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum
FROM Employees; 
--Rank
SELECT 
	Name,
	Salary,
	Rank()Over(ORDER BY Salary DESC) AS RankBySalary
From Employees; 