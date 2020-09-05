namespace TestePraticoDevNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForncedorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false),
                        Cnpj = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 01', '18708847000190', 'Rua Um, Jardim Planalto - Botucatu/SP', 1);");
            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 02', '18708847000190', 'Rua Dois, Jardim Paraiba - Boraceia/SP', 0);");
            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 03', '18708847000190', 'Rua Três, Jardim Primavera - Buri/SP', 1);");
            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 04', '18708847000190', 'Rua Quatro, Jardim Paraiso - Bofete/SP', 0);");
            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 05', '18708847000190', 'Rua Cinco, Jardim Piaui - Bariri/SP', 1);");
            Sql("INSERT INTO Fornecedor (ID, Nome, Cnpj,Endereco, Ativo)  VALUES (NEWID(), 'Empresa 06', '18708847000190', 'Rua Seis, Jardim Pernambuco - Barretos/SP', 0);");
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedor");
        }
    }
}
