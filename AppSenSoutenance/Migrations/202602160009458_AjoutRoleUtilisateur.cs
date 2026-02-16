namespace AppSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutRoleUtilisateur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "Role", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilisateurs", "Role");
        }
    }
}
