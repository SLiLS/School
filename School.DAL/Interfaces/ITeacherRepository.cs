using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.DAL.Entities;

namespace School.DAL.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        void AddNewClass( ClassTeacher item);
    }
}
