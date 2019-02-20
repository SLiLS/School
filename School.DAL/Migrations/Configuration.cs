namespace School.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<School.DAL.EF.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(School.DAL.EF.Context context)
        {
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "11" });
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "10" });
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "9" });
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "8" });
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "7" });
            context.Classes.AddOrUpdate(new Entities.SchoolClass { Name = "6" });
            context.Students.AddOrUpdate(new Entities.Student { Name = "����", SurName = "������", MiddleName = "��������", Sex = "�������", SchoolClassId = 1 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "����", SurName = "�������", MiddleName = "��������", Sex = "�������", SchoolClassId = 2 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "���������", SurName = "������", MiddleName = "����������", Sex = "������", SchoolClassId = 3 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "�����", SurName = "������", MiddleName = "�������������", Sex = "�������", SchoolClassId = 4 });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "����", SurName = "������", MiddleName = "��������", Position = "��������" });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "�����", SurName = "������", MiddleName = "�������������", Position = "�����" });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "���������", SurName = "�������", MiddleName = "����������", Position = "�������" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
