using Store_Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Store_Music.Controllers
{
    public class HomeController : Controller
    {
        private StoreMusicContext storeDB;

        public HomeController()
        {
            storeDB = new StoreMusicContext();
        }

        public ActionResult Index(int? page)
        {
            var albums = storeDB.Albums.ToList();

            albums = albums.OrderBy(a => a.AlbumId).ToList();

            return View(albums.ToPagedList(page == null ? 1 : page.Value, 39));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}