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
            student.Add(new Models.StudentModel { StudentNumber = "u24765644", Name = "Siyanda", Surname = "Twala", EmailAddress = "siyanda.twala@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765747", Name = "Aiden", Surname = "Brooks", EmailAddress = "aiden.brooks@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765699", Name = "Noah", Surname = "Evans", EmailAddress = "noah.evans@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765740", Name = "Tshepho", Surname = "Ledwaba", EmailAddress = "tshepho.ledwaba@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24765546", Name = "Lucas", Surname = "Gray", EmailAddress = "lucas.gray@tuks.co.za" });
            return View(student);
        }
    }
}