using System.Data.Entity.Migrations;

namespace Data_Layer.Migrations
{
    public partial class AddedUserRates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Date = c.String(),
                        Unit = c.String(),
                        Currency = c.String(),
                        CurrentRate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRates");
        }
    }
}
