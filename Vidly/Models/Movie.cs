using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime releaseDate { get; set; }
        public DateTime dateAdded { get; set; }
        [Required]
        public Genre genre { get; set; }
        public byte genreId { get; set; }
    }
}