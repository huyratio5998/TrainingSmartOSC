using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        // GET: Store
        public ActionResult Index()                                 
        {
            // return "Hello from Store.Index()";\
            //var genres = new List<Genre>
            //{
            //    new Genre {Name = "Disco"},
            //    new Genre{Name = "Jazz"},
            //    new Genre {Name = "Rock"}
            //};
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            //  return "Hello from Store.Browse()";
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            //return message;
            //var genreModel = new Genre { Name = genre };
            var genreModel = storeDB.Genres.Include("Albums")
            .Single(g => g.Name == genre);
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Detail(int id)
        {
            //  return "Hello from Store.Details()";
            //string message = "Store.Details, ID = " + id;
            //return message;
            //var album = new Album { Title = "Album " + id };
            var album = storeDB.Albums.Find(id);
            return View();
        }

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();

            return PartialView(genres);
        }

    }
}