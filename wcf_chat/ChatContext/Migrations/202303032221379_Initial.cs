namespace ChatContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 500),
                        SendDateTime = c.DateTime(nullable: false, storeType: "date"),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Messages", new[] { "ContactId" });
            DropTable("dbo.Messages");
            DropTable("dbo.Contacts");
        }
    }
}
