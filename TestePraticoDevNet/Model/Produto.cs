using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDevNet.Model
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public Fornecedor Fornecedores { get; set; }
    }
}
