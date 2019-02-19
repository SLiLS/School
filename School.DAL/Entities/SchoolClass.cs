using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL.Entities
{
  public  class SchoolClass
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
      
        public ICollection<Teacher> Teachers { get; set; }
        public SchoolClass()
        {
            Teachers = new List<Teacher>();
          

        }

    }
}
