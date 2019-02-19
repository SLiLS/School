using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.DAL.Entities;
using School.DAL.Interfaces;
using School.DAL.EF;

namespace School.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private Context db;
        private TeacherRepository teacherRepository;
        private StudentRepository studentRepository;
        private ClassRepository classRepository;



        public UnitOfWork()
        {
            db = new Context();
        }

        public IStudentRepository Students
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentRepository(db);
                return studentRepository;
            }
        }
        public IClassRepository SchoolClasses
        {
            get
            {
                if (classRepository == null)
                    classRepository = new ClassRepository(db);
                return classRepository;
            }
        }
        public ITeacherRepository Teachers
        {
            get
            {
                if (teacherRepository == null)
                    teacherRepository = new TeacherRepository(db);
                return teacherRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
