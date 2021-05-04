using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyCourse.Models;

namespace VidlyCourse.ViewModels
{
    public class CustomerMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}