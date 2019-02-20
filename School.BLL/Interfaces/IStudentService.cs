using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.BLL.DTO;

namespace School.BLL.Interfaces
{
   public  interface IStudentService
    {
        void Delete(int id);
        void Create(StudentDTO item);
        void Update(StudentDTO item);
        StudentDTO Get(int id);
        IEnumerable<StudentDTO> GetAll();
        IEnumerable<StudentDTO> Search(int? schoolclass,string sex);
        void Dispose();
    }
}
