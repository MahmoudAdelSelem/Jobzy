namespace Jobzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catogriesadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false),
                        categoryDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
