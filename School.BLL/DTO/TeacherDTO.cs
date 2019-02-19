using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL.DTO
{
  public  class TeacherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
