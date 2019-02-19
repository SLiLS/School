using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITeacherRepository Teachers { get; }
        IStudentRepository Students { get; }
        IClassRepository SchoolClasses { get; }
       
        void Save();

    }
}
