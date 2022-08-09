namespace ProvaFornecedorProduto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        FornecedorId = c.Long(nullable: false),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Fornecedors", t => t.FornecedorId, cascadeDelete: true)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        FornecedorId = c.Long(nullable: false, identity: true),
                        NomeFornecedor = c.String(),
                        Email = c.String(),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                    })
                .PrimaryKey(t => t.FornecedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "FornecedorId", "dbo.Fornecedors");
            DropIndex("dbo.Produtoes", new[] { "FornecedorId" });
            DropTable("dbo.Fornecedors");
            DropTable("dbo.Produtoes");
        }
    }
}
