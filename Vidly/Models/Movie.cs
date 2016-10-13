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
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public DateTime releaseDate { get; set; }
        public DateTime dateAdded { get; set; }
        [ForeignKey("genreId")]
        public virtual Genre genre { get; set; }
        [Required]
        public int genreId { get; set; }
        public byte numberInStock { get; set; }
    }
}