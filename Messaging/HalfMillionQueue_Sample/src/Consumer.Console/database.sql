CREATE DATABASE HalfMillionQueue
GO

USE HalfMillionQueue
GO

CREATE TABLE dbo.ItemOrcResult(
	Pk int IDENTITY(1,1) NOT NULL,
	ItoPk INT,
	ItoCodFabr varchar(50),
	ItoDescrAplic varchar(250),
	ItoValorUnit decimal(10,6),
	ItoQtd decimal(10,6),
	ItoValorTotal decimal(10,6),
	ProCodFabr varchar(50),
	ProNcm varchar(50),
	ProDescr varchar(250),
	ProAplic varchar(250),
	ProEstoque decimal(10,6),
	CliPk  INT,
	CliNome varchar(250),
	OrcPk INT,
	OrcValor decimal(10,6),
	VendPk INT,
	PedCod INT,
	PedValorPago decimal(10,6),
	PedCaixa varchar(50),
	VendNome varchar(250))
GO