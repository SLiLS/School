using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.DAL.Entities;
using School.BLL.DTO;
using School.BLL.Interfaces;
using School.DAL.Repositories;
using AutoMapper;

namespace School.BLL.Services
{
   public class ClassRepository : IClassService
    {
        UnitOfWork uow;
        public ClassRepository()
        {
            if (uow == null)
                uow = new UnitOfWork();
        }
        public IEnumerable<SchoolClassDTO> GetAll()
        {
            var map = new MapperConfiguration(c => c.CreateMap<SchoolClass, SchoolClassDTO>()).CreateMapper();
            return map.Map<IEnumerable<SchoolClass>, IEnumerable<SchoolClassDTO>>(uow.SchoolClasses.GetAll());

        }
    }
}
