using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDevNet.Classes
{
    public class Usuario
    {
        private SqlConnection Connection { get; set; }

        public Usuario()
        {
            Connection = new SqlConnection(TestePraticoDevNet.Keys.DbString);
        }

        ////public bool Login(string login)
        ////{

        ////}

        /// <summary>
        /// String para SHA1
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Retorna SHA1 do string</returns>
        public static string Hash(string text)
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
            var cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            return hash;
        }
    }
}
