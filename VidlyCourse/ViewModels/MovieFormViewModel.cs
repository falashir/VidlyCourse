using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyCourse.Models;

namespace VidlyCourse.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}