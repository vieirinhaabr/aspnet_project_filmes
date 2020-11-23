namespace Locadora.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoAutor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Album", "Autor", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Album", "Autor");
        }
    }
}
