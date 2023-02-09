CREATE DATABASE Academy
USE Academy

CREATE TABLE Students (
	[Id] INT PRIMARY KEY IDENTITY(1, 1),
	[Name] NVARCHAR(30) NOT NULL,
	[Surname] NVARCHAR(30) NOT NULL,
	[Age] INT CHECK(Age > 0 AND Age < 150) NOT NULL
);


INSERT INTO Students([Name], [Surname], [Age]) VALUES(N'Elvin', N'Azimov', 200);

SELECT * FROM Students

SELECT [Id], [Name] FROM Students
