using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDevNet.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Senha { get; set; }

        [DefaultValue("1")]
        public bool Ativo { get; set; }
    }
}
