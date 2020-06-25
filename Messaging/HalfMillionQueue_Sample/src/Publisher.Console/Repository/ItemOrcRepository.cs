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
            str.Append("SELECT ITO.PK_ID as ItoPk, ITO.CODIGOFABRIC AS ItoCodFabr, ITO.DESCRICAOAPLICACAO AS ItoDescrAplic, ITO.VALORUNITARIO AS ItoValorUnit, ITO.QUANTIDADE AS ItoQtd, ");
            str.Append("ITO.VALORTOTAL AS ItoValorTotal, PRO.CODIGOFABRIC AS ProCodFabr, PRO.NCM AS ProNcm, PRO.DESCRICAO AS ProDescr, PRO.APLICACAO AS ProAplic, PRO.QTD_ATUAL AS ProEstoque, ");
            str.Append("CLI.CODIGO AS CliPk, CLI.NOME AS CliNome, ORC.CODIGO AS OrcPk, ORC.VALORFINAL AS OrcValor, ORC.FK_NUMVENDEDOR AS VendPk, ");
            str.Append("PED.CODIGO AS PedCod, PED.VALORFINALPAGO AS PedValorPago, PED.IDENTIFICACAO_CAIXA AS PedCaixa, VEN.NOMEFANTASIA AS VendNome ");
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
