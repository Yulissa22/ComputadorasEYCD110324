create database ComputadorasEYCD110324Db

USE ComputadorasEYCD110324Db

CREATE TABLE Computadoras(
Id INT PRIMARY KEY IDENTITY(1,1),
FechaLlegada date,
Marca VARCHAR (50),
Tipo VARCHAR (50)
)

CREATE TABLE Componentes(
Id INT PRIMARY KEY IDENTITY (1,1),
IdComputadoras INT,
Procesador VARCHAR(50),
MemoriaRAMGB INT,
AlmacenamientoGB INT,
FOREIGN KEY (IdComputadoras) REFERENCES Computadoras (Id)
)