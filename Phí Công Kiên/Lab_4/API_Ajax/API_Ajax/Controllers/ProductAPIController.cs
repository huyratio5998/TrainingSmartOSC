using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Data.Entity;
using API_Ajax.Models;
using Newtonsoft.Json.Linq;

namespace API_Ajax.Controllers
{
    public class ProductAPIController : ApiController
    {
        DataContext db = new DataContext();

        //[System.Web.Http.Route("api/GetProductAPI")]
        // GET: ProductAPI
        //[System.Web.Http.HttpGet]
        public JToken Get()//int page, int pageSize = 3
        {
            ////var product = db.Products.OrderBy(p => p.Name).ToList();
            ////var prt =  product.Skip((page - 1) * pageSize).Take(pageSize);
            //int totalRow = db.Products.Count();

            return JToken.FromObject(db.Products);//new { data = prt, total = totalRow, status = true }
        }

        // POST: ProductAPI
        //[System.Web.Http.Route("api/CreateProductAPI")]
        //[System.Web.Http.HttpPost]
        public IHttpActionResult Post(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok("Save data successfully!");
            }
            else
                return NotFound();          
        }

        [System.Web.Http.Route("api/UpdateProductAPI")]
        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return Ok("Successful change!");
            }
            else
                return NotFound();
        }

        [System.Web.Http.Route("api/DeleteAPI")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0) return NotFound();
            var product = db.Products.Find(id);
            if (product == null)
                return NotFound();
            else
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Ok("Successful delete!");
            }
               
        }
    }
}