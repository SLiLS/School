using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.BLL.DTO;

namespace School.BLL.Interfaces
{
   public interface IClassService
    {
        IEnumerable<SchoolClassDTO> GetAll();
    }
}
