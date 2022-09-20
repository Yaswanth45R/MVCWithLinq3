using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithLinq2.Models;

namespace MVCWithLinq2.Controllers
{
    public class StudentController : Controller
    {
        MVCDBDataContext dc = new MVCDBDataContext();
        public ViewResult DisplayStudents()
        {
            List<Student_SelectResult> students = dc.Student_Select(null,true).ToList(); 
            return View(students);
        }
    }
}