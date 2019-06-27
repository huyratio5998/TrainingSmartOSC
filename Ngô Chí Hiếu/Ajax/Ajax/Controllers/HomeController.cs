using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Ajax.Models;
namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        StudentEntities studentEntities = new StudentEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Block1()
        {
            return View();
        }

        public ActionResult Block2()
        {
            return View();
        }

        public ActionResult  Block3()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Student()
        {
            List<Student> listStudent = new List<Student>();

            Student s1 = new Student("Cristiano Ronaldo", 33, "Nam", "CR7@gmail.com", "0977777777");
            Student s2 = new Student("Sergio Ramos", 30, "Nam", "SR4@gmail.com", "0944444444");
            Student s3 = new Student("Luka Modric", 29, "Nam", "LM10@gmail.com", "0910000000");
            Student s4 = new Student("Toni Kroos", 28, "Nam", "TK8@gmail.com", "0988888888");
            Student s5 = new Student("Karim Benzema", 30, "Nam", "KB9@gmail.com", "0999999999");

            listStudent.Add(s1);
            listStudent.Add(s2);
            listStudent.Add(s3);
            listStudent.Add(s4);
            listStudent.Add(s5);

            return Json(new
            {
                data = listStudent,
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult takeData(string strUser)
        {
            JavaScriptSerializer seriallizer = new JavaScriptSerializer();
            User user = seriallizer.Deserialize<User>(strUser);
            
            studentEntities.Users.Add(user);
            studentEntities.SaveChanges();

            return Json(new
            {
                data = user
            }, JsonRequestBehavior.AllowGet);
        }
    }
}