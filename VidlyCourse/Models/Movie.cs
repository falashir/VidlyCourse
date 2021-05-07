using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyCourse.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Reales Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Adding Date")]
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "No. in the stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}