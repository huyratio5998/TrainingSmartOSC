using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    [Table("Albums")]
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }

        
        public int ArtistId { get; set; }
        [StringLength(255)]
        [Column(TypeName ="nvarchar")]
        [Required]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
       

        public virtual IEnumerable<Genre> Genre { get; set; }
    }
}