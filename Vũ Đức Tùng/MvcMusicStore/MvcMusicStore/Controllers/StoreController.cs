using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "hello from Store.Index()";
        }
        public string Browse(string gender) 
        {
            string message = HttpUtility.HtmlEncode("store.browse, gende= " + gender);
            return message;
        }
        public string Details(int id)
        {
            string Message = "store.details, ID " + id;
            return Message;
        }
    }
}