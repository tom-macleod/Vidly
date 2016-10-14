using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie movie { get; set; }

        public List<Genre> genres { get; set; }

        public int? id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? genreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? releaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? numberInStock { get; set; }

        public string Title
        {
            get
            {
                return id != 0 ? "Edit Movie" : "New Movie";
            }
        }


        public MovieFormViewModel()
        {
            id = 0;
        }          

        public MovieFormViewModel(Movie movie)
        {
            id = movie.id;
            name = movie.name;
            releaseDate = movie.releaseDate;
            numberInStock = movie.numberInStock;
            genreId = movie.genreId;
        }

    }
}