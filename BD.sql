CREATE DATABASE RegistroEstudiante
GO
USE RegistroEstudiante;
GO
CREATE TABLE Estudiante
(
Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
Cedula int NOT NULL,
Nombre VARCHAR (50)NOT NULL,
Apellido VARCHAR (50) NOT NULL,
Telefono INT NOT NULL,
FechaNacimiento DATE NOT NULL,
FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
Estado BIT DEFAULT 1
)
 
 INSERT INTO Estudiante(cedula,Nombre,Apellido,Telefono,FechaNacimiento,FechaCreacion)
 values (123,'Diego','Madrid',234234,GETDATE(),GETDATE())
 
 CREATE TABLE Materia
(
Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
Nombre varchar(50),
FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
Estado BIT DEFAULT 1
)

INSERT INTO Materia (Nombre)
values
('Biologia molecular'),
('Ingles A1'),
('Programación basica'),
('Programación avanzada'),
('Inteligencia artificial'),
('Hacking etico'),
('Humanidades I'),
('Humanidades II'),
('Ingles A2'),
('Mineria de datos')


 
 CREATE TABLE Profesor
(
Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
Nombre varchar(50),
Apellido varchar(50),
Telefono INT NOT NULL,
FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
Estado BIT DEFAULT 1
)

INSERT INTO Profesor (Nombre, Apellido,Telefono)
values
('Julio', 'Ruiz',1234),
('Luisa', 'Leon',1234),
('Pedro', 'Guerra',1234),
('Camilo', 'Cortazar',1234),
('Armando', 'Rueda',1234)
 
 CREATE TABLE ProfesorMateria
(
Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
IdMateria UNIQUEIDENTIFIER not null FOREIGN KEY REFERENCES Materia(Id) ,
IdProfesor UNIQUEIDENTIFIER  not null FOREIGN KEY REFERENCES Profesor(Id) , 
)
 
insert into ProfesorMateria (IdProfesor,IdMateria) 
values
 ((select id from Profesor where Nombre='Julio'),  (select id from Materia where Nombre= 'Biologia molecular')),
 ((select id from Profesor where Nombre='Julio'),  (select id from Materia where Nombre= 'Ingles A1')),
 ((select id from Profesor where Nombre='Luisa'),  (select id from Materia where Nombre= 'Programación basica')),
 ((select id from Profesor where Nombre='Luisa'),  (select id from Materia where Nombre= 'Programación avanzada')),
 ((select id from Profesor where Nombre='Pedro'),  (select id from Materia where Nombre= 'Inteligencia artificial')),
 ((select id from Profesor where Nombre='Pedro'),  (select id from Materia where Nombre= 'Hacking etico')),
 ((select id from Profesor where Nombre='Camilo'),  (select id from Materia where Nombre= 'Humanidades I')),
 ((select id from Profesor where Nombre='Camilo'),  (select id from Materia where Nombre= 'Humanidades II')),
 ((select id from Profesor where Nombre='Armando'),  (select id from Materia where Nombre= 'Ingles A2')),
 ((select id from Profesor where Nombre='Armando'),  (select id from Materia where Nombre= 'Mineria de datos'))


 CREATE TABLE MateriaEstudiante
(
Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
IdProfesorMateria UNIQUEIDENTIFIER not null   FOREIGN KEY REFERENCES ProfesorMateria(Id),
IdEstudiante UNIQUEIDENTIFIER not null  FOREIGN KEY REFERENCES Estudiante(Id),
Creditos int
)



select * from ProfesorMateria a
inner join Profesor b on a.IdProfesor=b.Id

select * from Estudiante