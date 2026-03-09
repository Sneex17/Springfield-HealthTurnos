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
go

-- Insertar Especialidad
CREATE PROCEDURE spInsertarEspecialidad
    @Nombre VARCHAR(100),
    @Salario DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Especialidad (Nombre, Salario)
    VALUES (@Nombre, @Salario)
END
go

-- Actualizar Especialidad
CREATE PROCEDURE spActualizarEspecialidad
    @IdEspecialidad INT,
    @Nombre VARCHAR(100),
    @Salario DECIMAL(10,2)
AS
BEGIN
    UPDATE Especialidad
    SET Nombre = @Nombre,
        Salario = @Salario
    WHERE IdEspecialidad = @IdEspecialidad
END


select * from Empleado
select * from Medico
select * from Asistente
select * from Especialidad
select * from Rol
select * from Usuario

--1/3/26
--procedimientos medicos 

create view vwListaAsistente
with schemabinding
as
select e.IdEmpleado, e.Nombre, e.Apellido, e.Email, a.Turno, a.Area
from dbo.Asistente as a 
inner join dbo.Empleado as e on a.IdEmpleado = e.IdEmpleado
go


CREATE PROCEDURE spInsertarMedico
    @IdEmpleado     INT,
    @IdEspecialidad INT,
    @NroLicencia    VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Medico (IdEmpleado, IdEspecialidad, NroLicencia)
    VALUES (@IdEmpleado, @IdEspecialidad, @NroLicencia);
END
go

CREATE PROCEDURE spActualizarMedico
    @IdEmpleado     INT,
    @IdEspecialidad INT,
    @NroLicencia    VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Medico
    SET IdEspecialidad = @IdEspecialidad,
        NroLicencia    = @NroLicencia
    WHERE IdEmpleado = @IdEmpleado;
END
go


--procedimientos asistente
create proc spVerAsistente
as 
set nocount on
begin
select * from vwListaAsistente
end
go


CREATE PROCEDURE spInsertarAsistente
    @IdEmpleado INT,
    @Turno      VARCHAR(50),
    @Area       VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Asistente (IdEmpleado, Turno, Area)
    VALUES (@IdEmpleado, @Turno, @Area);
END
GO

CREATE PROCEDURE spActualizarAsistente
    @IdEmpleado INT,
    @Turno      VARCHAR(50),
    @Area       VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Asistente
    SET Turno = @Turno,
        Area  = @Area
    WHERE IdEmpleado = @IdEmpleado;
END
go



select * from Asistente

select * from Empleado

select * from Usuario

--Roles de Usuario
create proc spVerRoles
as
set nocount on
begin
select * from Rol
end

CREATE PROCEDURE spInsertarRol
    @Nombre VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Rol (Nombre)
    VALUES (@Nombre);
END
GO

CREATE PROCEDURE spActualizarRol
    @IdRol INT,
    @Nombre VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Rol
    SET Nombre = @Nombre
    WHERE IdRol = @IdRol;
END
GO

select * from Usuario


--procedimienos usuarios
create or alter view vwVerUsuarios
with schemabinding
as
select u.IdUsuario, e.IdEmpleado, e.Nombre, e.Apellido, 
u.Username as Usuario, u.Passwords as Contraseña, r.Nombre as Rol
from dbo.Usuario as u
inner join dbo.Empleado as e on u.IdEmpleado = e.IdEmpleado
inner join dbo.Rol as r on u.IdRol = r.IdRol

create or alter proc spVerUsuarios
as
set nocount on
begin
select * from vwVerUsuarios
end
go

CREATE PROCEDURE spInsertarUsuario
    @IdEmpleado INT,
    @IdRol      INT,
    @Username   VARCHAR(50),
    @Passwords  VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (IdEmpleado, IdRol, Username, Passwords)
    VALUES (@IdEmpleado, @IdRol, @Username, @Passwords);
END
GO

CREATE PROCEDURE spActualizarUsuario
    @IdUsuario  INT,
    @IdEmpleado INT,
    @IdRol      INT,
    @Username   VARCHAR(50),
    @Passwords  VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Usuario
    SET IdEmpleado = @IdEmpleado,
        IdRol      = @IdRol,
        Username   = @Username,
        Passwords  = @Passwords
    WHERE IdUsuario = @IdUsuario;
END
GO


select * from Usuario

select * from Especialidad
select * from Rol
select * from Medico
delete rol where IdRol = 4

--Martes 3/3/2026
CREATE TABLE Prioridad (
    IdPrioridad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre      VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255) NULL
);
go

CREATE PROCEDURE spVerPrioridades
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdPrioridad,
        Nombre,
        Descripcion
    FROM Prioridad
    ORDER BY IdPrioridad;
END
go


INSERT INTO Prioridad (Nombre, Descripcion) VALUES
('Normal',      'Solicitud de atención estándar, sin urgencia.'),
('Prioritario', 'Requiere atención antes que las solicitudes normales.'),
('Emergencia',  'Atención inmediata, situación crítica.');
go


--tabla de estados
CREATE TABLE Estado (
    IdEstado INT IDENTITY(1,1) PRIMARY KEY,
    Estado   VARCHAR(100) NOT NULL
);
go

INSERT INTO Estado (Estado) VALUES
('Pendiente'),
('En Atención'),
('Atendido'),
('Cancelado');

--tabla turnos

create table Turno(
IdTurno int primary key identity,
IdPaciente int not null,
IdAsistente int not null,
IdMedico int not null,
IdPrioridad int not null,
Observaciones varchar(max),
Fecha date not null,
IdEstado int not null

constraint FK_TurnoAsistente foreign key (IdAsistente) references Asistente(IdEmpleado),
constraint FK_TurnoMedico foreign key (IdMedico) references Medico(IdEmpleado),
constraint FK_TurnoPrioridad foreign key (IdPrioridad) references Prioridad(IdPrioridad),
constraint FK_TurnoEstado foreign key (IdEstado) references Estado(IdEstado)
)
go

CREATE OR ALTER PROCEDURE spInsertarTurno
    @IdPaciente    INT,
    @Paciente varchar(50),
    @Sexo varchar(15),
    @IdAsistente   INT,
    @Fecha         DATETIME,
    @IdMedico      INT,
    @IdPrioridad   INT,
    @Observaciones VARCHAR(max) = NULL,
    @IdEstado      INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Turno (IdPaciente, Paciente, Sexo, IdAsistente, Fecha, IdMedico, IdPrioridad, Observaciones, IdEstado)
    VALUES           (@IdPaciente, @Paciente, @Sexo, @IdAsistente, @Fecha, @IdMedico, @IdPrioridad, @Observaciones, @IdEstado);

END
go


create view vwListaTurnos
with schemabinding
as
select t.IdTurno, t.IdPaciente, t.Paciente, t.Sexo,
a.IdEmpleado IdAsistente,  a.Nombre,
m.IdEmpleado IdMedico, m.Nombre Medico,
p.Nombre Prioridad, t.Observaciones, t.Fecha,
e.Estado Estado
from dbo.Turno as t
inner join dbo.Empleado as a on t.IdAsistente = a.IdEmpleado
inner join dbo.Empleado as m on t.IdMedico = m.IdEmpleado
inner join dbo.Prioridad as p on t.IdPrioridad = p.IdPrioridad
inner join dbo.Estado as e on t.IdEstado = e.IdEstado
go


create proc spListaTurnos
@id int
as
begin
set nocount on
select * from vwListaTurnos where IdAsistente = @id or IdMedico = @id
end


--miercoles 4/3/2026
select * from Empleado
select * from Usuario
select * from Rol
go

CREATE PROCEDURE spValidarUsuario
    @Username  NVARCHAR(50),
    @Passwords NVARCHAR(50)
AS
BEGIN
    SELECT IdUsuario 
    FROM Usuario
    WHERE Username = @Username 
      AND Passwords = @Passwords
END

update Usuario set Username = 'sa', Passwords = 'sa'
where IdUsuario = 4
go


select * from Asistente

select * from Turno
select * from vwListaMedicos
select * from Especialidad

select * from vwVerUsuarios


select * from vwListaTurnos where IdAsistente = 7 or IdMedico = 7

update Usuario set IdEmpleado = 2 where IdUsuario = 1
select * from Usuario
delete turno where IdMedico = 2
 
select top 1 * from Turno where IdEstado = 1 order by IdTurno asc

select * from Estado

update Turno set IdEstado =  1 where IdTurno = 5
update Turno set IdEstado =  3 where IdTurno = 1

select * from Usuario
select * from Empleado

delete Turno
delete Usuario where IdUsuario = 10

update Usuario set Username = 'ha' where IdUsuario = 5


SELECT COUNT(*) FROM Asistente WHERE IdEmpleado = 6

select* from Empleado
select * from Usuario
select * from Asistente
select * from Medico

--Jueves 5/3/26
select * from Turno

update Turno set IdEstado =  1 where IdTurno = 9
go

create or alter proc spPrimerTurno
(
@IdMedico int
)
as
begin
select top 1 t.IdTurno, t.Fecha, t.IdPaciente, t.Paciente, t.Sexo,
p.Nombre as Prioridad, t.Observaciones, e.Estado as Estado
from Turno as t
inner join Prioridad as p on p.IdPrioridad = t.IdPrioridad
inner join Estado as e on e.IdEstado = t.IdEstado
where (t.IdEstado = 2 or t.IdEstado = 1) and 
(t.IdPrioridad = 3 or t.IdPrioridad = 2 or t.IdPrioridad = 1) and 
IdMedico = @IdMedico order by IdTurno asc
end

go

CREATE PROCEDURE spActualizarTurno
    @IdTurno    INT,
    @Observaciones  NVARCHAR(500),
    @IdEstado   INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Turno
    SET
        Observaciones   = @Observaciones,
        IdEstado        = @IdEstado
    WHERE
        IdTurno = @IdTurno;
END
GO

--Viernes 6

create view vwReportesTurnosAtendidos
with schemabinding
as
select t.IdTurno, t.IdPaciente, t.Paciente, t.Sexo,
a.IdEmpleado IdAsistente,  a.Nombre,
m.IdEmpleado IdMedico, m.Nombre Medico,
p.Nombre Prioridad, t.Observaciones, t.Fecha,
e.Estado Estado
from dbo.Turno as t
inner join dbo.Empleado as a on t.IdAsistente = a.IdEmpleado
inner join dbo.Empleado as m on t.IdMedico = m.IdEmpleado
inner join dbo.Prioridad as p on t.IdPrioridad = p.IdPrioridad
inner join dbo.Estado as e on t.IdEstado = e.IdEstado
where t.IdEstado = 3
go


create view vwReportesTurnosCancelados
with schemabinding
as
select t.IdTurno, t.IdPaciente, t.Paciente, t.Sexo,
a.IdEmpleado IdAsistente,  a.Nombre,
m.IdEmpleado IdMedico, m.Nombre Medico,
p.Nombre Prioridad, t.Observaciones, t.Fecha,
e.Estado Estado
from dbo.Turno as t
inner join dbo.Empleado as a on t.IdAsistente = a.IdEmpleado
inner join dbo.Empleado as m on t.IdMedico = m.IdEmpleado
inner join dbo.Prioridad as p on t.IdPrioridad = p.IdPrioridad
inner join dbo.Estado as e on t.IdEstado = e.IdEstado
where t.IdEstado = 4
go

--- Procedimientos de los reportes

create proc spVerReporteTurnosAtentidos
(
@id int
)
as
set nocount on
begin
select * from vwReportesTurnosAtendidos where IdAsistente = @id or IdMedico = @id
end
go

create proc spVerReporteTurnosCancelados
(
@id int
)
as
set nocount on
begin
select * from vwReportesTurnosCancelados where IdAsistente = @id or IdMedico = @id
end
go

create view vwReportesTurnosFechas
with schemabinding
as
select t.IdTurno, t.IdPaciente, t.Paciente, t.Sexo,
a.IdEmpleado IdAsistente,  a.Nombre,
m.IdEmpleado IdMedico, m.Nombre Medico,
p.Nombre Prioridad, t.Observaciones, t.Fecha,
e.Estado Estado
from dbo.Turno as t
inner join dbo.Empleado as a on t.IdAsistente = a.IdEmpleado
inner join dbo.Empleado as m on t.IdMedico = m.IdEmpleado
inner join dbo.Prioridad as p on t.IdPrioridad = p.IdPrioridad
inner join dbo.Estado as e on t.IdEstado = e.IdEstado
where t.IdEstado in(3,4)
go

create proc spVerReporteTurnosRangoFecha
(
@id int,
@Inicio date,
@Fin date
)
as
set nocount on
begin
select * from vwReportesTurnosFechas where IdAsistente = @id or IdMedico = @id and Fecha between @Inicio and @Fin
end
go
--Domingo 8/3/26
select * from Turno


select * from vwListaAsistente

select * from Prioridad

select * from vwVerUsuarios

create proc spTotalTurnos
as
set nocount on
begin
select * from Turno
end 

--Lunes 9/3/26

select* from Empleado
select * from Usuario
select * from Asistente
select * from Medico