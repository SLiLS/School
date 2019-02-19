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
    public class StudentRepository : IStudentRepository
    {
        Context db;
        public StudentRepository(Context context)
        {
            db = context;
        }

        public Student Get(int id)
        {

            return db.Students.Include(c => c.ScoolClass).Where(d => d.Id == id).FirstOrDefault();
        }
        public IEnumerable<Student> GetAll()
        {
           
            return db.Students.Include(c => c.ScoolClass);
        }
        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
        }
        public void Create(Student item)
        {
            db.Students.Add(item);
        }
        public void Update(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

    }
}
