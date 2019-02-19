using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School.DAL.Entities
{
   public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public ICollection<SchoolClass> ClassTeachers { get; set; }
        public Teacher()
        {
            ClassTeachers = new List<SchoolClass>();
        }
    }
}
