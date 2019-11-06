--create database DbMarket
go
use DbMarket
go
create schema Maintenance
go
create schema Payment
go
create schema Setting
go
create schema Authorize
GO
CREATE TABLE [Setting.Clase](
	IdClase			INT IDENTITY(1,1) NOT NULL,
	nClase			INT NOT NULL,-- 101-> Docu. Personales, 102-> Docu. Procesos
	cDescripcion	VARCHAR(50) NOT NULL,
	cDescrCorta		VARCHAR(10) NOT NULL,
	nActivo			BIT NOT NULL,
	dFechaCrea		DATETIME NOT NULL,
	CONSTRAINT PK_Clase_IdClase PRIMARY KEY (IdClase),
	CONSTRAINT DF_Clase_nActivo DEFAULT(1) FOR nActivo WITH VALUES,
	CONSTRAINT DF_Clase_dFechaCrea DEFAULT(GETDATE()) FOR dFechaCrea WITH VALUES
)
GO
INSERT INTO [Setting.Clase] VALUES(100,'DOCUMENTOS PERSONALES','DOCU-PERS'),
								  (200,'DOCUMENTOS SUNAT','DOCU-SUNAT'),
								  (300,'SERVICIOS','SERVICIO')
GO
CREATE TABLE [Maintenance.Documento](
	IdDocumento		INT IDENTITY(1,1) NOT NULL,
	cDescr			VARCHAR(50) NOT NULL,
	cSigla			VARCHAR(10) NOT NULL,
	cCodSUNAT		VARCHAR(3) NULL, --> 15-DNI
	nClase			INT NOT NULL, -->para agrupar
	nActivo			BIT NOT NULL,
	dFechaCrea		DATETIME NOT NULL,
	CONSTRAINT PK_Documento_IdDocumento PRIMARY KEY (IdDocumento),
	CONSTRAINT UQ_Documento_cSigla UNIQUE(cSigla),  
	CONSTRAINT FK_Documento_Clase_nClase FOREIGN KEY (nClase)  REFERENCES [Setting.Clase],
	CONSTRAINT DF_Documento_nActivo DEFAULT(1) FOR nActivo WITH VALUES,
	CONSTRAINT DF_Documento_dFechaCrea DEFAULT(GETDATE()) FOR dFechaCrea WITH VALUES
)
GO
INSERT INTO [Maintenance.Documento] VALUES('Documento Nacional Identidad','D.N.I','25',101),
											('PASAPORTE','PASAPORTE','28',101),
											('CARNÉ DE EXTRANJERÍA','CEDULA','22',101),
											('RECIBO INGRESOS','REC-ING','75',102)
GO
CREATE TABLE [Setting.NumeracionDocu](
	IdNumeracionDocu	INT IDENTITY(1,1) NOT NULL,
	IdDocumento			INT,
	cSerie				VARCHAR(5) NOT NULL,
	nNumeracion			INT NOT NULL,
	cCaja				CHAR(2) NOT NULL,
	IdUsuario			VARCHAR(15),
	dFechaCrea			DATETIME,
	CONSTRAINT PK_NumeracionDocu_IdNumeracionDocu PRIMARY KEY (IdNumeracionDocu),
	CONSTRAINT FK_NumeracionDocu_Documento_IdDocumento FOREIGN KEY (IdDocumento)  REFERENCES [Maintenance.Documento],
	CONSTRAINT DF_NumeracionDocu_cCaja DEFAULT('01') FOR cCaja WITH VALUES,
	CONSTRAINT UQ_Documento_IdDocumento_cSerie_cCaja UNIQUE(IdDocumento,cSerie,cCaja)
)
GO
CREATE TABLE [Maintenance.Persona](
	IdPersona	INT IDENTITY(1,1) NOT NULL,
	cApellido	VARCHAR(100) NOT NULL,
	cNombre		VARCHAR(100) NOT NULL,
	IdDocumento INT NOT NULL,
	cNumero		VARCHAR(18) NOT NULL, 
	dFechaCrea	DATETIME NOT NULL,
	CONSTRAINT PK_Persona_IdPersona PRIMARY KEY (IdPersona),
	CONSTRAINT FK_Persona_Documento_IdDocumento FOREIGN KEY (IdDocumento)  REFERENCES [Maintenance.Documento],
	CONSTRAINT DF_Persona_dFechaCrea DEFAULT(GETDATE()) FOR dFechaCrea WITH VALUES
)
GO
CREATE TABLE [Authorize.Usuario](
	IdUsuario	INT IDENTITY(1,1) NOT NULL,
	cNameUser	VARCHAR(15) NOT NULL,
	cContrasena	VARCHAR(25) NOT NULL,
	dFechaCrea	DATETIME NOT NULL,
	CONSTRAINT PK_Usuario_IdUsuario PRIMARY KEY (IdUsuario),
	CONSTRAINT DF_Usuario_dFechaCrea DEFAULT(GETDATE()) FOR dFechaCrea WITH VALUES
)
GO
CREATE TABLE [Maintenance.Puesto](
	IdPuesto	INT IDENTITY(1,1) NOT NULL,
	cDescr		VARCHAR(30),
	IdPersona	INT NOT NULL, -->Responsable
	--> Abarrotes, Jugos, Carnes, Ropa, Menú
	Detalle		TEXT NULL,
	dFechaCrea  DATETIME NOT NULL,
	CONSTRAINT PK_Puesto_IdPuesto PRIMARY KEY (IdPuesto),
	CONSTRAINT DF_Puesto_dFechaCrea DEFAULT(GETDATE()) FOR dFechaCrea WITH VALUES
)
GO
CREATE TABLE [Maintenance.Servicio](
	IdServicio	INT IDENTITY(1,1) NOT NULL,
	cServicio	VARCHAR(50) NOT NULL -->AGUA , LUZ, TARIFA

	CONSTRAINT PK_Servicios_IdServicio PRIMARY KEY (IdServicio)
)