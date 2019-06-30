using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_Ajax.Models
{
    public class ProductCart
    {
        public ProductCart()
        {
            Price = 0;
            Quantity = 0;
        }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Key, Column(Order = 2)]
        public int CartId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("CartId")]
        public virtual Cart BeLongCart { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product OrderedProduct { get; set; }
    }
}