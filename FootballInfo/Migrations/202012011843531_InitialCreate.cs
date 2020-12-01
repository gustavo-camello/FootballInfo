namespace FootballInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Tournament_TournamentId = c.Int(),
                    })
                .PrimaryKey(t => t.ClubId)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_TournamentId)
                .Index(t => t.Tournament_TournamentId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        TournamentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TournamentStart = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TournamentId);
            
            CreateTable(
                "dbo.PlayerClubs",
                c => new
                    {
                        Player_PlayerId = c.Int(nullable: false),
                        Club_ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_PlayerId, t.Club_ClubId })
                .ForeignKey("dbo.Players", t => t.Player_PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.Clubs", t => t.Club_ClubId, cascadeDelete: true)
                .Index(t => t.Player_PlayerId)
                .Index(t => t.Club_ClubId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clubs", "Tournament_TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.PlayerClubs", "Club_ClubId", "dbo.Clubs");
            DropForeignKey("dbo.PlayerClubs", "Player_PlayerId", "dbo.Players");
            DropIndex("dbo.PlayerClubs", new[] { "Club_ClubId" });
            DropIndex("dbo.PlayerClubs", new[] { "Player_PlayerId" });
            DropIndex("dbo.Clubs", new[] { "Tournament_TournamentId" });
            DropTable("dbo.PlayerClubs");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Players");
            DropTable("dbo.Clubs");
        }
    }
}
