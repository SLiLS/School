using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.BLL.DTO;
using School.BLL.Services;
using AutoMapper;
using School.WEB.Models;

namespace School.WEB.Controllers
{
    public class TeacherController : Controller
    {

        TeacherService teacherService;
        ClassRepository classRepository;
        public TeacherController()
        {
            if (teacherService == null)
                teacherService = new TeacherService();
            if (classRepository == null)
                classRepository = new ClassRepository();
        }
        // GET: Teacher
        public ActionResult Index()
        {
            var map = new MapperConfiguration(c => c.CreateMap<TeacherDTO, TeacherViewModel>()).CreateMapper();

            return View(map.Map<IEnumerable<TeacherDTO>, IEnumerable<TeacherViewModel>>(teacherService.GetAll()));
        }
        public ActionResult Delete(int id)
        {
            teacherService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(TeacherViewModel item)
        {

            if (ModelState.IsValid)
            {

                teacherService.Create(new TeacherDTO
                {
                    MiddleName = item.MiddleName,
                    Position=item.Position,
                    Name = item.Name,
                
                    SurName = item.SurName

                });


            }
            else
            {
                ModelState.AddModelError("", "incorrect data");
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var map = new MapperConfiguration(c => c.CreateMap<TeacherDTO, TeacherViewModel>()).CreateMapper();

            


            return PartialView(map.Map<TeacherDTO, TeacherViewModel>(teacherService.Get(id)));
        }
        [HttpPost]
        public ActionResult Edit(TeacherViewModel item)
        {
            var map = new MapperConfiguration(c => c.CreateMap<TeacherViewModel, TeacherDTO>()).CreateMapper();



            teacherService.Update(map.Map<TeacherViewModel, TeacherDTO>(item));

            return RedirectToAction("Index");
        }
        public ActionResult Classes(int id )
        {
            ViewBag.Classes = new SelectList(classRepository.GetAll(), "Id", "Name");

            var map = new MapperConfiguration(c => c.CreateMap<SchoolClassDTO, SchoolClassViewModel>()).CreateMapper();
            
            return View(map.Map<IEnumerable<SchoolClassDTO>, IEnumerable<SchoolClassViewModel>>(teacherService.GetTeacherClasses(id)));
        }
      
    }
}