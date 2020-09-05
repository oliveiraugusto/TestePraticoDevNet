using System.Data.Entity;

namespace TestePraticoDevNet.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("TestePraticoDevNet")
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
