using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePraticoDevNet.Model
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cnpj { get; set; }

        [Required]
        public string Endereco { get; set; }

        [DefaultValue("1")]
        public bool Ativo { get; set; }
    }
}
