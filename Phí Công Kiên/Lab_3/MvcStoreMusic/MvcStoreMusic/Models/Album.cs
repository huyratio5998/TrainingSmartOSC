using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcStoreMusic.Models
{
    public class Album
    {
        [Key, Column(Order = 1)]
        public int AlbumId { get; set; }

        [Key, Column(Order = 2)]
        public int GenreId { get; set; }

        [Key, Column(Order = 3)]
        public int ArtistId { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
    }
}