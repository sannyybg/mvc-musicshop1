using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace musicshop.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }

        public double Price { get; set; }

        public string AlbumUrl { get; set; }

        public int ReleaseYear { get; set; }
        
        public Artist Artist { get; set; }

        public Genre Genre { get; set; }

    }
}