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
    public class HomeController : Controller
    {
        StudentService studentService;
        ClassRepository classRepository;
        public HomeController()
        {
            if (studentService == null)
                studentService = new StudentService();
            if (classRepository == null)
                classRepository   = new ClassRepository();
        }

        public ActionResult Index(int? schoolclass,string sex)
        {
            var maper = new MapperConfiguration(c => c.CreateMap<SchoolClassDTO, SchoolClassViewModel>()).CreateMapper();

            var classes=maper.Map<IEnumerable<SchoolClassDTO>, List<SchoolClassViewModel>>(classRepository.GetAll());
          
            classes.Insert(0, new SchoolClassViewModel { Id = 0, Name = "Все" });
        

            ViewBag.Classes = new SelectList(classes, "Id", "Name");

            var map = new MapperConfiguration(c => c.CreateMap<StudentDTO, StudentViewModel>()).CreateMapper();
             
            return View(map.Map<IEnumerable<StudentDTO>, IEnumerable<StudentViewModel>>(studentService.Search(schoolclass,sex)));
        }
        public ActionResult Delete(int id)
        {
            studentService.Delete(id);
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Classes = new SelectList(classRepository.GetAll(), "Id", "Name");
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(StudentViewModel item)
        {

            if (ModelState.IsValid)
            {

                studentService.Create(new StudentDTO
                {
                   MiddleName=item.MiddleName,
                   ClassId=item.ClassId,
                   Name=item.Name,
                  Sex=item.Sex,
                  SurName=item.SurName
                  
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
            var map = new MapperConfiguration(c => c.CreateMap<StudentDTO, StudentViewModel>()).CreateMapper();

            ViewBag.Classes = new SelectList(classRepository.GetAll(), "Id", "Name");


            return PartialView(map.Map<StudentDTO, StudentViewModel>(studentService.Get(id)));
        }
        [HttpPost]
        public ActionResult Edit(StudentViewModel item)
        {
            var map = new MapperConfiguration(c => c.CreateMap<StudentViewModel, StudentDTO>()).CreateMapper();

            
        
        studentService.Update(map.Map<StudentViewModel, StudentDTO>(item));

            return RedirectToAction("Index");
        }

    }
}