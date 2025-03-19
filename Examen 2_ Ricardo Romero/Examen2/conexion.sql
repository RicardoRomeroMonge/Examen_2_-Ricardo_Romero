CREATE DATABASE CLINICAUH;
USE CLINICAUH;

CREATE TABLE Pacientes (
    IdPaciente INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(20) UNIQUE NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Edad INT CHECK (Edad > 0),
    Telefono VARCHAR(15) NOT NULL,
    Direccion TEXT NOT NULL
);

CREATE TABLE Medicos (
    IdMedico INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(20) UNIQUE NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Especialidad VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL
);

CREATE TABLE Consultorios (
    IdConsultorio INT IDENTITY(1,1) PRIMARY KEY,
    NumeroConsultorio VARCHAR(10) UNIQUE NOT NULL
);

CREATE TABLE Consultas (
    IdConsulta INT IDENTITY(1,1) PRIMARY KEY,
    IdPaciente INT NOT NULL,
    IdMedico INT NOT NULL,
    IdConsultorio INT NOT NULL,
    FechaConsulta DATE NOT NULL,
    HoraConsulta TIME NOT NULL,
    Diagnostico TEXT NOT NULL,
    FOREIGN KEY (IdPaciente) REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE,
    FOREIGN KEY (IdMedico) REFERENCES Medicos(IdMedico) ON DELETE CASCADE,
    FOREIGN KEY (IdConsultorio) REFERENCES Consultorios(IdConsultorio) ON DELETE SET NULL
);

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) UNIQUE NOT NULL,
    Contraseña VARCHAR(255) NOT NULL,
    TipoUsuario VARCHAR(20) CHECK (TipoUsuario IN ('Administrador', 'Medico', 'Recepcionista')) NOT NULL
);