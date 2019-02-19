using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School.DAL.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace School.DAL.EF
{
  public  class Context : DbContext
    {
        public DbSet<SchoolClass> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        public Context()
            : base("School")
        {

        }

    }
}
