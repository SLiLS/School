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
            context.Students.AddOrUpdate(new Entities.Student { Name = "Иван", SurName = "Иванов", MiddleName = "Иванович", Sex = "Мужской", SchoolClassId = 1 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "Олег", SurName = "Соболев", MiddleName = "Игоревич", Sex = "Мужской", SchoolClassId = 2 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "Владислав", SurName = "Чернов", MiddleName = "Эдуардович", Sex = "Женкий", SchoolClassId = 3 });
            context.Students.AddOrUpdate(new Entities.Student { Name = "Игорь", SurName = "Желтов", MiddleName = "Владиславович", Sex = "Женский", SchoolClassId = 4 });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "Иван", SurName = "Желтов", MiddleName = "Игоревич", Position = "Директор" });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "Игорь", SurName = "Чернов", MiddleName = "Владиславович", Position = "Завуч" });
            context.Teachers.AddOrUpdate(new Entities.Teacher { Name = "Владислав", SurName = "Соболев", MiddleName = "Эдуардович", Position = "Учитель" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
