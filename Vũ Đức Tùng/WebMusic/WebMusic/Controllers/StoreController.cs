using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMusic.Models;

namespace WebMusic.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreDb storeDB = new MusicStoreDb();
        // GET: Store
        public ActionResult Index()
        {
            MusicStoreDb storeDB = new MusicStoreDb();
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
    }
}