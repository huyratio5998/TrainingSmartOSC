using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace API_Ajax.Models
{
    public class Product
    {
        public Product()
        {
            this.Pcs = new HashSet<ProductCart>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, Range(0, 1000000)]
        public int Price { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual ICollection<ProductCart> Pcs { get; set; }
    }
}