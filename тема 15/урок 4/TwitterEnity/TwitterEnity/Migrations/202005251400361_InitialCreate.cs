namespace TwitterEnity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HashTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HashTag = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrendName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tweets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextOfTweet = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Tweets");
            DropTable("dbo.Trends");
            DropTable("dbo.HashTags");
        }
    }
}
