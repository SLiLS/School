using System;
using System.Collections.Generic;
using System.Linq;
using School.DAL.EF;
using School.DAL.Entities;
using School.DAL.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL.Repositories
{
  public  class ClassRepository : IClassRepository
    {

        Context db;
        public ClassRepository(Context context)
        {
            db = context;
        }
        public IEnumerable<SchoolClass> GetAll()
        {
            return db.Classes;
        }

    }
}
