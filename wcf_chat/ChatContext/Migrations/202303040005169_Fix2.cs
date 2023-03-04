namespace ChatContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "SendDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "SendDateTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
