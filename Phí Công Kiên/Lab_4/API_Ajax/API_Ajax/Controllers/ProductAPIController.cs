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

        // GET: ProductAPI
        public JToken Get()
        {
            return JToken.FromObject(db.Products);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/SearchProductAPI")]
        public JToken Get(string txtSearch, int page, int pageSize = 10)
        {
            if (txtSearch == null)
            {
                var products = db.Products.OrderBy(p => p.Name).ToList();
                var product = products.Skip((page - 1) * pageSize).Take(pageSize);
                int totalRows = db.Products.Count();

                return JToken.FromObject(new { data = product, totalRow = totalRows, status = true });
            }
            else
            {
                var products = db.Products.Where(p => p.Name.Contains(txtSearch)).OrderBy(p => p.Name).ToList();
                var product = products.Skip((page - 1) * pageSize).Take(pageSize);
                int totalRows = products.Count();
                return JToken.FromObject(new { data = product, totalRow = totalRows, status = true });
            }          
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/GetProductAPI")]
        public JToken Get(int page, int pageSize = 10)
        {
            var products = db.Products.OrderBy(p => p.Name).ToList();
            var product = products.Skip((page - 1) * pageSize).Take(pageSize);
            int totalRows = db.Products.Count();

            return JToken.FromObject(new { data = product, totalRow = totalRows, status = true });
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
        [System.Web.Http.HttpDelete]
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