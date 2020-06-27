CREATE DATABASE HalfMillionQueue
GO

USE HalfMillionQueue
GO

CREATE TABLE dbo.ItemOrcResult
(
	Pk int IDENTITY(1,1) NOT NULL,
	ItoPk varchar(10),
	ItoCodFabr varchar(50),
	ItoDescrAplic varchar(250),
	ItoValorUnit varchar(10),
	ItoQtd varchar(10),
	ItoValorTotal varchar(10),
	ProCodFabr varchar(50),
	ProNcm varchar(50),
	ProDescr varchar(250),
	ProAplic varchar(250),
	ProEstoque varchar(10),
	CliPk varchar(10),
	CliNome varchar(250),
	OrcPk varchar(10),
	OrcValor decimal(10,6),
	VendPk varchar(10),
	PedCod varchar(10),
	PedValorPago decimal(10,6),
	PedCaixa varchar(50),
	VendNome varchar(250)
)
GO