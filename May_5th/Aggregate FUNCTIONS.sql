--Aggregate FUNCTIONS Examples
CREATE TABLE Students(
StudentID INT PRIMARY KEY,
FirstName VARCHAR(50),
Marks INT,
DOB DATE
);
INSERT INTO Students(StudentID,FirstName,Marks,DOB)
VALUES
(1,'Amit',92,'2003-05-10'),
(2,'Neha',78,'2002-11-15'),
(3,'Rahul',61,'2004-01-20'),
(4,'Sneha',49,'2003-09-01');

CREATE TABLE Employees(
	EmpID INT primary key,
	Name VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL (10,2),
	JoinDate DATE
); 
INSERT INTO Employees(EmpID,Name,Department,Salary,JoinDate)
VALUES
(1,'Jhon','HR',50000,'2021-06-01'),
(2,'Priya','Finance',60000,'2020-09-15'),
(3,'Amit','IT',75000,'2019-01-10'),
(4,'Priya','IT',75000,'2023-02-25'); 
--Aggregate FUNCTIONS Examples

SELECT  COUNT (*) AS TolStudents FROM Students;

SELECT AVG(Marks) AS AverageMarks FROM Students;

SELECT Department, Max(Salary) AS HighestSalary
FROM Employees
GROUP BY Department;