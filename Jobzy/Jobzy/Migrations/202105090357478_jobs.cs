namespace Jobzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jobs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        jobTitle = c.String(nullable: false),
                        jobDescription = c.String(nullable: false),
                        jobImage = c.String(),
                        catogoryId = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Jobs", new[] { "Category_Id" });
            DropTable("dbo.Jobs");
        }
    }
}
