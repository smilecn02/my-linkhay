namespace MyLinkhay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Linkhay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Linkhays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Description = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Linkhays");
        }
    }
}
