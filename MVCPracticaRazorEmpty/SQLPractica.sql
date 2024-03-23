CREATE DATABASE PruebaMVC;
GO
USE PruebaMVC;
GO
CREATE TABLE USUARIOS (
	idUser int PRIMARY KEY IDENTITY,
	nombre nvarchar(100),
	pass nvarchar(100),
	genero nvarchar(1),
	direccion nvarchar(400),
	curso nvarchar(50),
)