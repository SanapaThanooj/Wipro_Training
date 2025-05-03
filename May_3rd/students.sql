/* INSERT INTO Students(StudentID, FirstName ,LastName, Age ,Department, Marks)
VALUES
(1,'Amit','sharam','21','Computer Science', 85),
(2,'Neha','Kumar','22','Electronics', 75),
(3,'Rahul','sharam','20','Mechanical', 66),
(4,'Sneha','Singh','23','Computer Science', 91); */
/* Select * From Students
Where Department ='Computer Science'; */
/* SELECT FirstName, Marks FROM Students
--WHERE Marks > 80; */
/* UPDATE Students
SET Marks = 95
Where StudentID = 2 */
/* 
UPDATE Students 
Set Marks = 88
Where StudentID in (1,3) */
/*INSERT INTO Students(StudentID, FirstName, LastName, Age, Department, Marks)
VALUES
(5,'kumar','varam','21','Mechanical', 92),
(6,'sumanth','shetty','21','Electronics', 90); */
--select * from Students
/*UPDATE Students
SET Age = 24
Where LastName = 'shetty'; */
/*UPDATE Students
SET LastName = 'sanapa'
Where FirstName = 'sumanth';*/
--select * from Students
--Delete From Students Where StudentID =1;
--DELETE FROM Students WHERE Marks < 88;
--DELETE FROM Students WHERE StudentID IN(3,5);
--TRUNCATE TABLE Students; -- data is removed but table is present
--Drop Table Students;--To remove table