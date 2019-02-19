using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School.DAL.Entities;
using System.Threading.Tasks;

namespace School.DAL.Interfaces
{
   public interface IClassRepository
    {
        IEnumerable<SchoolClass> GetAll();
    }
}
