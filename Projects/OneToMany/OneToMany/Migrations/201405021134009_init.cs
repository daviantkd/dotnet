namespace OneToMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boyfriend",
                c => new
                    {
                        BoyfriendId = c.Int(nullable: false, identity: true),
                        BoyfriendName = c.String(nullable: false),
                        GirlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BoyfriendId)
                .ForeignKey("dbo.Girl", t => t.GirlId, cascadeDelete: true)
                .Index(t => t.GirlId);
            
            CreateTable(
                "dbo.Girl",
                c => new
                    {
                        GirlId = c.Int(nullable: false, identity: true),
                        GirlName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GirlId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boyfriend", "GirlId", "dbo.Girl");
            DropIndex("dbo.Boyfriend", new[] { "GirlId" });
            DropTable("dbo.Girl");
            DropTable("dbo.Boyfriend");
        }
    }
}
