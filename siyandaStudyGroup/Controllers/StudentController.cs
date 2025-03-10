using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace siyandaStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> student = new List<Models.StudentModel>();
            student.Add(new Models.StudentModel { StudentNumber = "u24765644", Name = "Siyanda", Surname = "Twala", EmailAddress = "siyanda.twala@tuks.co.za", myLink = "~/HTML/SiyandaTwala.html" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765747", Name = "Matthew", Surname = "Frolich", EmailAddress = "matthew.frolich@tuks.co.za", myLink = "~/HTML/MatthewFrolich.html" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765699", Name = "Nikhil", Surname = "Sunker", EmailAddress = "nikhil.sunker@tuks.co.za", myLink = "~/HTML/NikhilSunker.html" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765740", Name = "Aman", Surname = "Singh", EmailAddress = "aman.singh@tuks.co.za", myLink = "~/HTML/Aman.html" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765546", Name = "Keshav", Surname = "Singh", EmailAddress = "keshav.singh@tuks.co.za", myLink ="~/HTML/KeshavSingh.html" });
            return View(student);
        }
    }
}