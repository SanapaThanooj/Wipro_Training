Create Table Employees(
EmpolyeeID INT PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Department VARCHAR(50),
Salary DECIMAL(10,2),
HireDate DATE
);

INSERT INTO Employees(EmpolyeeID,FirstName,LastName ,Department ,Salary ,HireDate )
VALUES
(1,'Amit','sharam','HR',30000.00, '03-05-25'),
(2,'kumar','varma','devloper',70000.00, '04-05-25'),
(3,'Amit','sharam','Data Analyst',40000.00, '05-05-25');

DELETE FROM Employees Where salary <40000.00;

UPDATE Employees 
SET EmpolyeeID = 3
Where Salary = 50000.00

select * from Employees