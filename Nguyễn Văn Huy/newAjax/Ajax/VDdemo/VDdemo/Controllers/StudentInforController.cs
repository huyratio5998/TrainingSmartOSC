
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using VDdemo.Models;
namespace VDdemo.Controllers
{
    public class StudentInforController : Controller
    {
        VDdemoEntities entities = new VDdemoEntities();
        // GET: Student
        
        

        public ActionResult Index()
        {
            
            ViewBag.lstUser = entities.users.ToList();                                  
            return View( );
        }
        public string displaySecond()
        {
            var lstUser = entities.users.ToList();
            string rs = "";
            foreach (var x in lstUser)
            {
                rs+= "<tr><td>" + x.username + "</td><td>" + x.password + "</td><td>" + x.fullname + "</td><td>" + x.gender + "</td></tr>";
            }
            
            return rs;

        }
        [HttpPost]
        public JsonResult bai2()
        {
            List<Student> lstStudent = new List<Student>();
            Student student = new Student("Phí Kiên", 19, "Nam", "phikien@gmail.com", "099213123");
            Student student2 = new Student("Hiếu", 24, "Nam", "Hieu@gmail.com", "0432423424234");
            Student student3 = new Student("Tung", 25, "Nam", "Tung@gmail.com", "065465487132");
            lstStudent.Add(student);
            lstStudent.Add(student2);
            lstStudent.Add(student3);

            return Json(lstStudent);
        }        
        [HttpPost]
        public bool laydulieu(string lst)
        {
            JavaScriptSerializer seri = new JavaScriptSerializer();
            User x = seri.Deserialize<User>(lst);
            User check = entities.users.Where(p => p.username == x.username).FirstOrDefault();
            string rs = "";
            if (check == null)
            {
                entities.users.Add(x);
                //rs = "<tr><td>" + x.username + "</td><td>" + x.password + "</td><td>" + x.fullname + "</td><td>" + x.gender + "</td></tr>";
                entities.SaveChanges();
            }
            else return false ;
            return true;
        }
       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            entities.students.Add(student);
            entities.SaveChanges();
            return View(student);
        }
    }
}