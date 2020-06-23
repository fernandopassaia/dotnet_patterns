### Review for SQL Server, Queries, Profiler and other

**Difference between Indexes - Clustered and NonClustered**:
When you create a table, for DEFAULT SQL Server will create a clustered index. Clustered indexes are stored physically on the table. This means they are the fastest and you can only have one clustered index per table - usually the PK. Non-clustered indexes are stored separately, and you can have as many as you want. It could be other indexes on same table.

**Query Tests**: Note: I'm running queries on JK DataBase because it has a lot of information. Please take the Backup from 062020 and use it to RUN those queries - I've saved this Database inside the folder "DataBase" as well. Before comment the commands, let's clarify what we have in this database at this moment.

(PED) Pedidos: 2869.
(ORC) Orcamentos: 273,924.
(CLI) Clientes: 8.
(VEN) Vendedores: 6.
(ITE) Item Orcamento: 555,793. (will be used on Profiler)
(PRO) Products: 20,693. (will be used on Profiler)


**Inner Join**:
SELECT CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO,
ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA,
VEN.NOMEFANTASIA AS VENDNOME FROM ISORCAM765 ORC
INNER JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
INNER JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
INNER JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

Theorical: INNER JOIN gets all records that are common between both tables based on the supplied ON clause.
Practical: This query returns me 2869 rows, because it needs to be on ORC and PED at the same time. So just ORC with PED will returns.

**Left Join**:
SELECT CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO,
ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA,
VEN.NOMEFANTASIA AS VENDNOME FROM ISORCAM765 ORC
LEFT JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
INNER JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
INNER JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

Theorical: LEFT JOIN gets all records from the LEFT linked and the related record from the right table ,but if you have selected some columns from the RIGHT table, if there is no related records, these columns will contain NULL.
Practical: This query returns me 273,924 rows, all the ORC, but PEDCOD, PEDVALORPAGO, PEDCAIXA are almost of times "NULL".
Note: You also have "NOT IN" clausule, that works preety similar as LEFT. You need to check by exam witch will be more performatic, depends on case.

**Right Join**:
SELECT CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO,
ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA,
VEN.NOMEFANTASIA AS VENDNOME FROM ISORCAM765 ORC
RIGHT JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
INNER JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
INNER JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

Theorical: is like the above (LEFT) but gets all records in the RIGHT table.
Practical: Again bring-me 2869 rows, so only if the registry exists on PED, it will returns. The result is the same of InnerJoin in this case.

**Full Join**:
SELECT CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO,
ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA,
VEN.NOMEFANTASIA AS VENDNOME FROM ISORCAM765 ORC
FULL JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
INNER JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
INNER JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

Theorical: It combines the results of both left and right outer joins. Gets all records from both tables and puts NULL in the columns where related records do not exist in the opposite table.
Practical: Again bring-me 273,924 rows, because it will join the RIGHT and LEFT, bring everything with "null" where there is no data. Same result as Left Join in this case.

**Note**: Take a Look to IMG1-5 to understand what this 4 types (Inner, Left, Right, Full) does.

**Stored Procedure**: This is an anatomy of a stored-procedure I've wrote on the past. The code talks by itself:

CREATE PROCEDURE [dbo].[sp_GravaOrcamento]
    @fk_numcliente INT ,
    @fk_numvendedor INT ,
    @tipoFrete VARCHAR(80) ,
    @prazoEntrega DATETIME,
    @garantia DATETIME,
    @validadeProposta  DATETIME,
    @funcionarioRetira VARCHAR(80),   
    @fkPagamento INT,
    @infoAdicional VARCHAR(250),
    @valorfinal DECIMAL(10, 4),
    @fkNumeroLoja INT,
    @nomePdv VARCHAR(50),
    @serialPDV VARCHAR(50),
    @pkPDV INT,
    @log_FkUsuarioCriador INT,
    @log_fkDataCriacao DATETIME,     
    @idClienteFuturaData INT,
    @ultimoOrcamento INT OUTPUT
    
AS 
INSERT INTO ISORCAM765
(FK_NUMCLIENTE
,FK_NUMVENDEDOR
,TIPOFRETE
,PRAZOENTREGA
,GARANTIA
,VALIDADEPROPOSTA
,FUNCIONARIO_RETIRA
,FK_PAGAMENTO
,INFOADICIONAL
,STATUSVENDIDO
,VALORFINAL
,FK_NUMEROLOJA
,NOMEPDV
,SERIALPDV
,IDPDV
,LOG_FKUSUARIOCRIADOR
,LOG_DATACRIACAO
,QTD_ALTERACOES
,LOG_FKCLIENTEFD
)        
    VALUES  (  @fk_numcliente,
    @fk_numvendedor,
    @tipoFrete,
    @prazoEntrega,
    @garantia,
    @validadeProposta,
    @funcionarioRetira,    
    @fkPagamento,
    @infoAdicional,
    'EM ABERTO',
    @valorfinal,
    @fkNumeroLoja,
    @nomePdv,
    @serialPDV,
    @pkPDV,
    @log_FkUsuarioCriador,
    @log_fkDataCriacao,
    0,
    @idClienteFuturaData)

    SELECT  @ultimoOrcamento = @@Identity
GO

**SQL Profile**: Here I'll mount a "Heavy" SQL Query based on the "ITE" (ItemOrcamento) that has 555,793 items. I'll also bring "PRO" fields (that have 26,693 registers), and also bring the fields of other queries from ORC, PED, CLI, VEN. So It will be a complex query. All images are saved on "Profiler" folder, about how to RUN the profiler, how to configure it, the query itself.

SELECT ITO.CODIGOFABRIC AS ITOCODFABR, ITO.DESCRICAOAPLICACAO AS ITODESCAPLIC, ITO.VALORUNITARIO AS ITOVALUNIT, ITO.QUANTIDADE AS ITOQUANT, ITO.VALORTOTAL AS ITOVALTOTAL,
PRO.CODIGOFABRIC AS PROCODFABR, PRO.NCM AS PRONCM, PRO.DESCRICAO AS PRODESC, PRO.APLICACAO AS PROAPLIC, PRO.QTD_ATUAL AS PROQTD,
CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO, ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA, VEN.NOMEFANTASIA AS VENDNOME
FROM ISITEMORCAM567 ITO
LEFT JOIN ISPRO101 PRO ON ITO.FK_NUMPRODUTO = PRO.PK_CODIGOSIST
LEFT JOIN ISORCAM765 ORC ON ITO.FK_NUMORCAMENTO = ORC.CODIGO
LEFT JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
LEFT JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
LEFT JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

This query takes 00:09s to RUN returning 555,793 rows, so ok, here we have how to analise data. Check the images to see info.

**DTA - DataBase Engine Tuning Advisor**: SQL Server also has a tool to inspect SQL Server, and supply the following information:

    Troubleshoot the performance of a specific problem query
    Tune a large set of queries across one or more databases
    Perform an exploratory what-if analysis of potential physical design changes
    Manage storage space

This tool does not comes with FREE Express editions. I've saved a PDF showing a lot of optimizations tips this tools gives, take a look in respective folder. The article shows recomendations the Tool gives to create indexes, and improve queries for example.