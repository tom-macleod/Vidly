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
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime releaseDate { get; set; }
        public DateTime dateAdded { get; set; }
        [ForeignKey("genreId")]
        public virtual Genre genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public int genreId { get; set; }
        [Range(1, 20)]
        [Required]
        [Display(Name = "Number in Stock")]
        public byte numberInStock { get; set; }
    }
}