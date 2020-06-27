using Dapper;
using Publisher.Console.Dto;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Publisher.Console.Repository
{
    public class ItemOrcRepository
    {
        private string _connectionStringJk = "";
        public ItemOrcRepository(string connectionStringJk)
        {
            _connectionStringJk = connectionStringJk;
        }

        public IEnumerable<ItemOrcResult> Get()
        {
            StringBuilder str = new StringBuilder();
            str.Append("SELECT ITO.PK_ID as ItoPk, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(ITO.CODIGOFABRIC, '\', ''), ' / ', ''), '\"', ''), '', '')  AS ItoCodFabr, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(ITO.DESCRICAOAPLICACAO, '\', ''), ' / ', ''), '\"', ''), '', '')  AS ItoDescrAplic, ");
            str.Append("ITO.VALORUNITARIO AS ItoValorUnit, ");
            str.Append("ITO.QUANTIDADE AS ItoQtd, ");
            str.Append("ITO.VALORTOTAL AS ItoValorTotal, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(PRO.CODIGOFABRIC, '\', ''), ' / ', ''), '\"', ''), '', '')  AS ProCodFabr, ");
            str.Append("PRO.NCM AS ProNcm, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(PRO.DESCRICAO, '\', ''), ' / ', ''), '\"', ''), '', '')  AS ProDescr,  ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(PRO.APLICACAO, '\', ''), ' / ', ''), '\"', ''), '', '')  AS ProAplic,  ");
            str.Append("PRO.QTD_ATUAL AS ProEstoque, ");
            str.Append("CLI.CODIGO AS CliPk, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(CLI.NOME, '\', ''), ' / ', ''), '\"', ''), '', '')  AS CliNome, ");
            str.Append("ORC.CODIGO AS OrcPk, ");
            str.Append("ORC.VALORFINAL AS OrcValor, ");
            str.Append("ORC.FK_NUMVENDEDOR AS VendPk, ");
            str.Append("PED.CODIGO AS PedCod, ");
            str.Append("PED.VALORFINALPAGO AS PedValorPago, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(PED.IDENTIFICACAO_CAIXA, '\', ''), ' / ', ''), '\"', ''), '', '')  AS PedCaixa, ");
            str.Append("REPLACE(REPLACE(REPLACE(REPLACE(VEN.NOMEFANTASIA, '\', ''), ' / ', ''), '\"', ''), '', '')  AS VendNome ");
            str.Append("FROM ISITEMORCAM567 ITO ");
            str.Append("LEFT JOIN ISPRO101 PRO ON ITO.FK_NUMPRODUTO = PRO.PK_CODIGOSIST ");
            str.Append("LEFT JOIN ISORCAM765 ORC ON ITO.FK_NUMORCAMENTO = ORC.CODIGO ");
            str.Append("LEFT JOIN ISPEDIDO332 PED ON PED.FK_CODIGOORC = ORC.CODIGO ");
            str.Append("LEFT JOIN ISCLIE876 CLI ON ORC.FK_NUMVENDEDOR = CLI.CODIGO ");
            str.Append("LEFT JOIN TB_VENDEDORES222 VEN ON VEN.PK_CODIGO = ORC.FK_NUMVENDEDOR ");

            using (var conn = new SqlConnection(_connectionStringJk))
            {
                conn.Open(); 
                //var data = conn.Query(str.ToString());
                return conn.Query<ItemOrcResult>(str.ToString());
            }
        }
    }
}
