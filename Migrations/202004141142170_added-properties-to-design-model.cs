namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropertiestodesignmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Depiction", c => c.String());
            AddColumn("dbo.Artists", "Portrayal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Portrayal");
            DropColumn("dbo.Albums", "Depiction");
        }
    }
}
