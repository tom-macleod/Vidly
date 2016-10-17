using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        public DateTime releaseDate { get; set; }

        public DateTime dateAdded { get; set; }

        [Required]
        public int genreId { get; set; }

        [Range(1, 20)]
        [Required]
        public byte numberInStock { get; set; }

    }
}