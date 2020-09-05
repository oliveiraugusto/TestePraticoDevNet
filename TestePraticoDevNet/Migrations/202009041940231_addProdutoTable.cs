namespace TestePraticoDevNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdutoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Fornecedores_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedores_ID)
                .Index(t => t.Fornecedores_ID);

            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 01', 10, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 01'));");
            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 02', 20, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 02'));");
            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 03', 30, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 03'));");
            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 04', 40, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 04'));");
            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 05', 50, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 05'));");
            Sql("INSERT INTO Produto  (ID, Nome, Quantidade, Fornecedores_ID) VALUES (NEWID(), 'Produto 06', 60, (SELECT ID FROM Fornecedor WHERE Nome = 'Empresa 06'));");            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "Fornecedores_ID", "dbo.Fornecedor");
            DropIndex("dbo.Produto", new[] { "Fornecedores_ID" });
            DropTable("dbo.Produto");
        }
    }
}
