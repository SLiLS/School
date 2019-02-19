namespace School.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolClassId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ScoolClass_Id", "dbo.SchoolClasses");
            DropIndex("dbo.Students", new[] { "ScoolClass_Id" });
            RenameColumn(table: "dbo.Students", name: "ScoolClass_Id", newName: "SchoolClassId");
            AlterColumn("dbo.Students", "SchoolClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "SchoolClassId");
            AddForeignKey("dbo.Students", "SchoolClassId", "dbo.SchoolClasses", "Id", cascadeDelete: true);
            DropColumn("dbo.Students", "ClassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ClassId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "SchoolClassId", "dbo.SchoolClasses");
            DropIndex("dbo.Students", new[] { "SchoolClassId" });
            AlterColumn("dbo.Students", "SchoolClassId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "SchoolClassId", newName: "ScoolClass_Id");
            CreateIndex("dbo.Students", "ScoolClass_Id");
            AddForeignKey("dbo.Students", "ScoolClass_Id", "dbo.SchoolClasses", "Id");
        }
    }
}
