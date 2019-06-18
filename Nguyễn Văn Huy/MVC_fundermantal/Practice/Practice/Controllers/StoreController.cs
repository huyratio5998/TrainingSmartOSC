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
            //var genres = new List<Genre>
            //{
            //    new Genre{ Name="Nguyễn Văn Huy"},
            //    new Genre{ Name="Kiên"},
            //    new Genre{ Name="Hùng"},
            //    new Genre{ Name="Lan Anh"}
            //};
            return View(genres);
        }
        public ActionResult Browse(string s)
        {
            var genreModel = new Genre() { Name = s };
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            var al = new Album { Title = "Album" + id };
            return View(al);
        }
            
    }
}
