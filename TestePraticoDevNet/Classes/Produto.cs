using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDevNet.Classes
{
    public class Produto
    {
        protected SqlConnection Connection { get; set; }

        public Produto()
        {
            Connection = new SqlConnection(TestePraticoDevNet.Keys.DbString);
        }

        public DataTable SelectAll()
        {
            try
            {
                string sql = "SELECT p.ID, p.Nome, p.Quantidade, f.Nome AS Fornecedor FROM dbo.Produto AS p INNER JOIN dbo.Fornecedor AS f ON p.Fornecedores_ID = f.ID ORDER BY p.Nome ASC ";

                var dt = new DataTable();

                Connection.Open();
                var data = new SqlDataAdapter(sql, Connection);
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
