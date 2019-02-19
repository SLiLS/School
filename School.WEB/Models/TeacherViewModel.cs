using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.WEB.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
    }
}