using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDevNet.Classes
{
    public class Fornecedor
    {
        protected SqlConnection Connection { get; set; }

        public Fornecedor()
        {
            Connection = new SqlConnection(TestePraticoDevNet.Keys.DbString);
        }

        public DataTable SelectAll()
        {
            try
            {
                string sql = "SELECT * FROM dbo.Fornecedor ORDER BY Nome ASC";

                var dt = new DataTable();

                Connection.Open();
                var data = new SqlDataAdapter(sql, Connection);
                data.Fill(dt);
                return dt;
            }
            catch (Exception  ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }            
        }

        public DataTable GetNameFornecedores()
        {
            try
            {
                string sql = "SELECT Nome FROM dbo.Fornecedor WHERE Ativo  = 1 ORDER BY Nome"; // filtra por ativos

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
