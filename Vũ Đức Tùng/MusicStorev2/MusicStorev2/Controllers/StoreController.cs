using MusicStorev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusicStorev2.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        // GET: Store
        public ActionResult Index()
        {
            ApplicationDbContext storeDB = new ApplicationDbContext();
            //var genres = new List<Genre>

            {
                var genres = storeDB.Genres.ToList();
                return View(genres);
            };
            
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(a=>a.Name== genre);
            return View(genreModel);
        }

        //
        // GET: /Store/Details
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