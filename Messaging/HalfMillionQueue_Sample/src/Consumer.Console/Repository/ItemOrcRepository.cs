using Consumer.Console.Dto;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Consumer.Console.Repository
{
    public class ItemOrcRepository
    {
        private string _connectionStringJk = "";
        public ItemOrcRepository(string connectionStringJk)
        {
            _connectionStringJk = connectionStringJk;
        }

        public void Create(ItemOrcResult iteOrc)
        {
            using (var conn = new SqlConnection(_connectionStringJk))
            {
                conn.Open();
                //var data = conn.Query(str.ToString());
                conn.Insert(iteOrc);
            }
        }
    }
}
