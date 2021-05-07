namespace VidlyCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNullableIsSubscripeFromUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean());
        }
    }
}
