create database DBHealthTurnos
use DBHealthTurnos
go

--tablas de Administrador de Sistema 
-- Tabla: Especialidad
CREATE TABLE Especialidad (
    IdEspecialidad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre         VARCHAR(100) NOT NULL,
    Salario        DECIMAL(10,2) NOT NULL
)

-- Tabla base: Empleado
CREATE TABLE Empleado (
    IdEmpleado   INT IDENTITY(1,1) PRIMARY KEY,
    Nombre       VARCHAR(100) NOT NULL,
    Apellido     VARCHAR(100) NOT NULL,
    Email        VARCHAR(150) UNIQUE,
    Telefono     VARCHAR(20),
    FechaIngreso DATE NOT NULL
)

-- Tabla: Médico
CREATE TABLE Medico (
    IdEmpleado     INT PRIMARY KEY,
    IdEspecialidad INT NOT NULL,
    NroLicencia    VARCHAR(50) UNIQUE NOT NULL,
    CONSTRAINT FK_Medico_Empleado     FOREIGN KEY (IdEmpleado)
        REFERENCES Empleado(IdEmpleado),
    CONSTRAINT FK_Medico_Especialidad FOREIGN KEY (IdEspecialidad)
        REFERENCES Especialidad(IdEspecialidad)
)

-- Tabla: Asistente
CREATE TABLE Asistente (
    IdEmpleado INT PRIMARY KEY,
    Turno      VARCHAR(20) NOT NULL CHECK (Turno IN ('Mañana', 'Tarde', 'Noche')),
    Area       VARCHAR(100) NOT NULL,
    CONSTRAINT FK_Asistente_Empleado FOREIGN KEY (IdEmpleado)
        REFERENCES Empleado(IdEmpleado)
)
go

--insert
-- Especialidades
INSERT INTO Especialidad (Nombre, Salario) VALUES
('Cardiología',   95000.00),
('Pediatría',     80000.00),
('Neurología',   105000.00),
('Dermatología',  75000.00),
('Traumatología', 90000.00);

-- Empleados (10)
INSERT INTO Empleado (Nombre, Apellido, Email, Telefono, FechaIngreso) VALUES
('Cristal',    'Ramirez',     'cristal.ramirez@HealthTurnos.com',       '809-555-0000', '2017-03-15'),
('Carlos',    'Ruiz',     'carlos.ruiz@HealthTurnos.com',       '809-555-0001', '2020-03-15'),
('María',     'González', 'maria.gonzalez@HealthTurnos.com',    '809-555-0002', '2019-07-01'),
('Luis',      'Martínez', 'luis.martinez@HealthTurnos.com',     '809-555-0003', '2021-01-10'),
('Ana',       'Pérez',    'ana.perez@HealthTurnos.com',         '809-555-0004', '2018-11-20'),
('Jorge',     'Díaz',     'jorge.diaz@HealthTurnos.com',        '809-555-0005', '2022-05-05'),
('Sofía',     'Herrera',  'sofia.herrera@HealthTurnos.com',     '809-555-0006', '2020-08-18'),
('Pedro',     'López',    'pedro.lopez@HealthTurnos.com',       '809-555-0007', '2017-04-22'),
('Valentina', 'Torres',   'valentina.torres@HealthTurnos.com',  '809-555-0008', '2023-02-14'),
('Miguel',    'Ramírez',  'miguel.ramirez@HealthTurnos.com',    '809-555-0009', '2016-09-30'),
('Gabriela',  'Castillo', 'gabriela.castillo@HealthTurnos.com', '809-555-0010', '2022-12-01');

-- Médicos (empleados 1 al 5)
INSERT INTO Medico (IdEmpleado, IdEspecialidad, NroLicencia) VALUES
(2, 1, 'LIC-00001'),
(3, 2, 'LIC-00002'),
(4, 3, 'LIC-00003'),
(5, 4, 'LIC-00004'),
(6, 5, 'LIC-00005');

-- Asistentes (empleados 6 al 10)
INSERT INTO Asistente (IdEmpleado, Turno, Area) VALUES
(6,  'Mañana', 'Urgencias'),
(7,  'Tarde',  'Pediatría'),
(8,  'Noche',  'Cardiología'),
(9,  'Mañana', 'Neurología'),
(10, 'Tarde',  'Dermatología');

--Usuarios y roles

-- Tabla: Rol
CREATE TABLE Rol (
    IdRol  INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

-- Tabla: Usuario
CREATE TABLE Usuario (
    IdUsuario  INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL UNIQUE,
    IdRol      INT NOT NULL,
    Username   VARCHAR(100) NOT NULL UNIQUE,
    Passwords   VARCHAR(255) NOT NULL,
    CONSTRAINT FK_Usuario_Empleado FOREIGN KEY (IdEmpleado)
        REFERENCES Empleado(IdEmpleado),
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (IdRol)
        REFERENCES Rol(IdRol)
);

-- Roles
INSERT INTO Rol (Nombre) VALUES
('Administrador'),
('Medico'),
('Asistente');

-- Usuarios (2 médicos, 2 asistentes)
INSERT INTO Usuario (IdEmpleado, IdRol, Username, Passwords) VALUES
(1, 2, 'carlos.ruiz',    'Hashed_001'),
(2, 2, 'maria.gonzalez', 'Hashed_002'),
(6, 3, 'sofia.herrera',  'Hashed_006'),
(7, 3, 'pedro.lopez',    'Hashed_007');

--procedimientos empleados
create proc spVerEmpleados
as
set nocount on
select * from Empleado
go 
--insert
CREATE PROCEDURE spInsertarEmpleado
    @Nombre       VARCHAR(100),
    @Apellido     VARCHAR(100),
    @Email        VARCHAR(150),
    @Telefono     VARCHAR(20),
    @FechaIngreso DATE
AS
set nocount on
BEGIN
    INSERT INTO Empleado (Nombre, Apellido, Email, Telefono, FechaIngreso)
    VALUES (@Nombre, @Apellido, @Email, @Telefono, @FechaIngreso)
END
go
--update
CREATE PROCEDURE spActualizarEmpleado
    @IdEmpleado   INT,
    @Nombre       VARCHAR(100),
    @Apellido     VARCHAR(100),
    @Email        VARCHAR(150),
    @Telefono     VARCHAR(20),
    @FechaIngreso DATE
AS
set nocount on
BEGIN
    UPDATE Empleado
    SET
        Nombre       = @Nombre,
        Apellido     = @Apellido,
        Email        = @Email,
        Telefono     = @Telefono,
        FechaIngreso = @FechaIngreso
    WHERE IdEmpleado = @IdEmpleado
END

--procedimientos medicos 

create view vwListaMedicos
with schemabinding
as
select e.IdEmpleado, e.Nombre, e.Apellido, e.Email, m.NroLicencia, x.Nombre as Especialidad
from dbo.Medico as m 
inner join dbo.Empleado as e on m.IdEmpleado = e.IdEmpleado
inner join dbo.Especialidad as x on m.IdEspecialidad = x.IdEspecialidad

create proc spVerMedicos
as 
set nocount on
begin
select * from vwListaMedicos
end


--procedimientos especialidad medicos
create proc spVerEspecialidad
as
set nocount on
begin
select * from Especialidad
end



select * from Empleado
select * from Medico
select * from Asistente
select * from Especialidad
select * from Rol
select * from Usuario

