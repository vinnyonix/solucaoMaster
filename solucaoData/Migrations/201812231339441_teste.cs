namespace solucaoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classificado",
                c => new
                    {
                        IDClassificado = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 150, unicode: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDClassificado);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Classificado");
        }
    }
}
