namespace Jobzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeduserRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "userType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "userType");
        }
    }
}
