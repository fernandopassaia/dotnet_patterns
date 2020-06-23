### Review for SQL Server, Queries, Profiler and other

**Difference between Indexes - Clustered and NonClustered**:
When you create a table, for DEFAULT SQL Server will create a clustered index.


**Query Tests**: Note: I'm running queries on JK DataBase because it has a lot of information. Please take the Backup from 062020 and use it to RUN those queries - I've saved this Database inside the folder "DataBase" as well. Before comment the commands, let's clarify what we have in this database at this moment.

(PED) Pedidos: 2869.
(ORC) Orcamentos: 273,924.
(ITE) Item Orcamento: 555,793. (will be used on Profiler)
(CLI) Clientes: 8.
(VEN) Vendedores: 6.


**Inner Join**:
SELECT CLI.CODIGO AS CLICODIGO, CLI.NOME AS CLINOME, CLI.RAZAOSOCIAL AS CLIRAZAO,
ORC.CODIGO AS ORCCOD, ORC.VALORFINAL AS ORCVALOR, ORC.FK_NUMVENDEDOR AS ORCVEND,
PED.CODIGO AS PEDCOD, PED.VALORFINALPAGO AS PEDVALORPAGO, PED.IDENTIFICACAO_CAIXA AS PEDCAIXA,
VEN.NOMEFANTASIA AS VENDNOME FROM ISORCAM765 ORC
INNER JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO
INNER JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO
INNER JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR

This query returns me 2869 rows, because it needs to be on ORC and PED at the same time. So just ORC with PED will returns.








**Disavantages of Microservices**:
(1) If Modules depends to much on each-other, like ORDER depends on Product/Stock/Delivery/Client/Finances modules and they are separated in the architecture, you could have the problem of data-dependency, too many calls from one API to other to get data (in case of scenarios where DB is not shared and are also isolated).
(2) Harder to understand the Architecture of the System, will be harder to new members on the team.
(3) More repositories, more services in production, more number of monitoring of these services. More Admins to make it all RUN.