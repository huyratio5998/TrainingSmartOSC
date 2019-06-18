using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcStoreMusic.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 2)]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Album> Albs { get; set; }
    }
}