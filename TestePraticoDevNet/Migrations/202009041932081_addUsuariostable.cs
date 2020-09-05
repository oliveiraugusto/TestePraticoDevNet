namespace TestePraticoDevNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsuariostable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            //Login: admin 
            //Senha: admin
            Sql("INSERT INTO Usuario(ID, Nome, Login, Senha, Ativo) VALUES(NEWID(), 'Administrador do Sistema', 'admin', 'D033E22AE348AEB5660FC2140AEC35850C4DA997', 1)");
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
