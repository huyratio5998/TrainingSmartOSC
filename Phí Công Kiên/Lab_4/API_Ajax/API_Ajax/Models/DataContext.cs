using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace API_Ajax.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ProductDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<ProductCart> ProductCarts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}