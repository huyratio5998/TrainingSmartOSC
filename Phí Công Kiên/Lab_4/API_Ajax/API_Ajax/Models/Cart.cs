using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace API_Ajax.Models
{
    public class Cart
    {
        public Cart()
        {
            this.Pcs = new HashSet<ProductCart>();
        }
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Buyer { get; set; }
        public int TotalPrice { get; set; }
        public virtual ICollection<ProductCart> Pcs { get; set; }
    }
}