using API_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Data.Entity;

namespace API_Ajax.Controllers
{
    public class CartAPIController : ApiController
    {
        DataContext db = new DataContext();
        // GET: CartAPI
        public IHttpActionResult Get()
        {
            return Ok(db.Carts);
        }
        // GET: CartAPI/id
        public IHttpActionResult Get(int id)
        {
            if (id <= 0) return NotFound();
            var cart = db.ProductCarts.Where(c => c.CartId == id).Include(c => c.OrderedProduct);
            if (cart == null) return NotFound();
            return Ok(cart);
        }
        // POST: CartAPI
        public IHttpActionResult Post(Cart cart)
        {
            if (cart == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                cart.OrderDate = DateTime.Now;
                db.Carts.Add(cart);
                db.SaveChanges();
                return Ok("Save data successfully!");
            }
            else
                return NotFound();          
        }

        public IHttpActionResult Put(Cart ct)
        {
            if (ct == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                db.Entry(ct).State = EntityState.Modified;
                db.SaveChanges();
                return Ok("Successful change!");
            }
            else
                return NotFound();
        }

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0) return NotFound();
            var cart = db.Carts.Find(id);
            if (cart == null)
            {
                return NotFound();
            }
            else
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
                return Ok("Successful delete!");
            }
        }
    }
}