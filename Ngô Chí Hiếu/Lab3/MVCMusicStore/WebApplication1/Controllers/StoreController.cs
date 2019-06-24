using MVCMusicStore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDb = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            //return "Hello from Store.Index()";
            /*var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazzz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);*/

            var genres = storeDb.Genres.ToList();
            return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            //return "Hello from Store.Browser()";
            //string message = HttpUtility.HtmlEncode("Store.Browse,Genre" + genre);
            //return message;
            ///var genreModel = new Genre { Name = genre };
            var genreModel = storeDb.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);

        }
        public ActionResult Details(int id)
        {
            //return "Hello from Store.Details()";
            ////string message = "Store.Details, ID = " + id;
            //return message;
            var album = new Album { Title = "Album" + id };
            return View(album);
        }

    }
}