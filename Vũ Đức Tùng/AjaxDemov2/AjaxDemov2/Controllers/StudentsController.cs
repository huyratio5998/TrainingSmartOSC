using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AjaxDemov2.Models;

namespace AjaxDemov2.Controllers
{
    public class StudentsController : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult GetDetails(int ID)
        {
            var stundent = db.Students.Find(ID);
            return Json(new
            {
                data=stundent,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Create([Bind(Include = "Name,Local,StudentClass")] Student student)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                status = true;
                return Json(new
                {
                    status = status
                });
            }

            return Json(new
            {
                status = status
            });
        }

        // GET: Students/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Edit([Bind(Include = "ID,Name,Local,StudentClass")] Student student)
        {
            bool status = false;
            if (ModelState.IsValid)
            {


                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                status = true;
                return Json(new
                {
                    status = status
                });
            }
            return Json(new
            {
                status = status
            });
        }

        // GET: Students/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        // POST: Students/Delete/5
        [HttpPost]
        
        public ActionResult Delete(int ID)
        {
            Student student = db.Students.Find(ID);
            db.Students.Remove(student);
            db.SaveChanges();
            return Json(new
            {
                status = true
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpGet]
        public JsonResult loadData()
        {
            var model = db.Students.ToList();
            
            return Json(new
            {
                data=model,
                status=true
            },JsonRequestBehavior.AllowGet);
        }
    }
}
