using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.DAL.Entities;
using School.DAL.Interfaces;
using School.DAL.EF;
using System.Data.Entity;

namespace School.DAL.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        Context db;
        public TeacherRepository(Context context)
        {
            db = context;
        }
        public void Create(Teacher item)
        {
            db.Teachers.Add(item);
        }

        public Teacher Get(int id)
        {
           
            return db.Teachers.Include(s => s.ClassTeachers).Where(i => i.Id == id).FirstOrDefault();
        }
        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers.Include(s => s.ClassTeachers);
        }
        public void Update(Teacher item)
        {
            db.Entry(item).State = EntityState.Modified;

        }
        public void Delete(int id)
        {
            db.Teachers.Remove(db.Teachers.Find(id));
        }
        public void AddNewClass(ClassTeacher item)
        {
            db.Teachers.Where(s => s.Id == item.TeacherId).FirstOrDefault().ClassTeachers.Add(db.Classes.Where(i => i.Id == item.SchoolClassId).FirstOrDefault());
        }
    }
}
