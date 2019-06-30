namespace API_Ajax.Migrations
{
    using API_Ajax.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<API_Ajax.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "API_Ajax.Models.DataContext";
        }

        protected override void Seed(API_Ajax.Models.DataContext context)
        {
            if (context.Products.Count() <= 0)
            {
                context.Products.Add(new Product { Name = "Ngo Cay", Price = 10000, Status = true });
                context.Products.Add(new Product { Name = "Nuoc Muoi", Price = 12000, Status = true });
                context.Products.Add(new Product { Name = "Cocacola", Price = 10500, Status = false });
                context.Products.Add(new Product { Name = "Nuoc Tranh", Price = 10000, Status = true });
                context.Products.Add(new Product { Name = "Hanh Kho", Price = 1000, Status = true });
                context.Products.Add(new Product { Name = "Nuoc Mam", Price = 100000, Status = false });
                context.Products.Add(new Product { Name = "Keo Bong", Price = 12300, Status = true });
                context.SaveChanges();
            }
            
        }
    }
}
