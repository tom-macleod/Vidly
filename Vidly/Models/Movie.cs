using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("genreId")]
        public virtual Genre genre { get; set; }
        public int genreId { get; set; }
        public byte numberInStock { get; set; }
    }
}