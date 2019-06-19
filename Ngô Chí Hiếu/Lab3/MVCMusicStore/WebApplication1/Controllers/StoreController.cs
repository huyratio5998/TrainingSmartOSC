using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore1.Models;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        public string Browser(string genre)
        {
            //return "Hello from Store.Browser()";
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre" + genre);
            return message;
        }
        public string Details(int id)
        {
            //return "Hello from Store.Details()";
            ////string message = "Store.Details, ID = " + id;
            //return message;
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}