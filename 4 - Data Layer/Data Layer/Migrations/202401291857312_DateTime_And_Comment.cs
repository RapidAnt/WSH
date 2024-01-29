using System.Data.Entity.Migrations;

namespace Data_Layer.Migrations
{
    public partial class DateTime_And_Comment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRates", "Comment", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserRates", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserRates", "Date", c => c.String());
            DropColumn("dbo.UserRates", "Comment");
        }
    }
}
