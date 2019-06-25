//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using Microsoft.AspNet.Identity.EntityFramework;

//namespace MvcMusicStore.Models
//{
//    public class MusicStoreEntities : IdentityDbContext
//    {
//        public MusicStoreEntities() : base("SmartMVC")
//        {
            
//        }
//        public DbSet<Album> Albums { get; set; }
//        public DbSet<Genre> Genres { get; set; }
//        public DbSet<Artist> Artists { get; set; }
//        public DbSet<Cart> Carts { get; set; }
//        public DbSet<Order> Orders { get; set; }
//        public DbSet<OrderDetail> OrderDetails { get; set; }

//        public System.Data.Entity.DbSet<MvcMusicStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
//    }
//}