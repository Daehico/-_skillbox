namespace TwitterEnity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TwitterMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Users_Id = c.Int(),
                        Users_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id1)
                .Index(t => t.Users_Id)
                .Index(t => t.Users_Id1);
            
            CreateTable(
                "dbo.TweetsHashTags",
                c => new
                    {
                        Tweets_Id = c.Int(nullable: false),
                        HashTags_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tweets_Id, t.HashTags_Id })
                .ForeignKey("dbo.Tweets", t => t.Tweets_Id, cascadeDelete: true)
                .ForeignKey("dbo.HashTags", t => t.HashTags_Id, cascadeDelete: true)
                .Index(t => t.Tweets_Id)
                .Index(t => t.HashTags_Id);
            
            AddColumn("dbo.Tweets", "Users_Id", c => c.Int());
            AddColumn("dbo.Users", "Subscriber_Id", c => c.Int());
            AddColumn("dbo.Users", "Subscriber_Id1", c => c.Int());
            CreateIndex("dbo.Tweets", "Users_Id");
            CreateIndex("dbo.Users", "Subscriber_Id");
            CreateIndex("dbo.Users", "Subscriber_Id1");
            AddForeignKey("dbo.Users", "Subscriber_Id", "dbo.Subscribers", "Id");
            AddForeignKey("dbo.Users", "Subscriber_Id1", "dbo.Subscribers", "Id");
            AddForeignKey("dbo.Tweets", "Users_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscribers", "Users_Id1", "dbo.Users");
            DropForeignKey("dbo.Tweets", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Subscribers", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Subscriber_Id1", "dbo.Subscribers");
            DropForeignKey("dbo.Users", "Subscriber_Id", "dbo.Subscribers");
            DropForeignKey("dbo.TweetsHashTags", "HashTags_Id", "dbo.HashTags");
            DropForeignKey("dbo.TweetsHashTags", "Tweets_Id", "dbo.Tweets");
            DropIndex("dbo.TweetsHashTags", new[] { "HashTags_Id" });
            DropIndex("dbo.TweetsHashTags", new[] { "Tweets_Id" });
            DropIndex("dbo.Subscribers", new[] { "Users_Id1" });
            DropIndex("dbo.Subscribers", new[] { "Users_Id" });
            DropIndex("dbo.Users", new[] { "Subscriber_Id1" });
            DropIndex("dbo.Users", new[] { "Subscriber_Id" });
            DropIndex("dbo.Tweets", new[] { "Users_Id" });
            DropColumn("dbo.Users", "Subscriber_Id1");
            DropColumn("dbo.Users", "Subscriber_Id");
            DropColumn("dbo.Tweets", "Users_Id");
            DropTable("dbo.TweetsHashTags");
            DropTable("dbo.Subscribers");
        }
    }
}
