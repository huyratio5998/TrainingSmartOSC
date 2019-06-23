using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
namespace Practice.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            //var example = storeDB.Genres.Single(p => p.Name == "Disco");
           
            return View(genres);
        }
        public ActionResult Browser(string Genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(p => p.Name == Genre);
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }

    }
}
