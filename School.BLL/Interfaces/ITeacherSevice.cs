using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.BLL.DTO;

namespace School.BLL.Interfaces
{
   public interface ITeacherSevice
    {
        void Create(TeacherDTO item);
        void Update(TeacherDTO item);
        void Delete(int id);
        void AddNewClass(ClassTeacherDTO item);
        TeacherDTO Get(int id);
        IEnumerable<TeacherDTO> GetAll();
        IEnumerable<SchoolClassDTO> GetTeacherClasses(int id);
        void Dispose();
    }
}
