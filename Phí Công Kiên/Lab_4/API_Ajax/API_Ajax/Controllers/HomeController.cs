﻿using API_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Creat";

            return View();
        }
    }
}
