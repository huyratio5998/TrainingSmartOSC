using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models.ViewModels
{
    public class ShopingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}