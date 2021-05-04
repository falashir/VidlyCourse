using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyCourse.Models;

namespace VidlyCourse.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View(GetMovies());
        }

        public ActionResult Details(int Id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == Id);

            return View(movie);
        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Die Hard"},
                new Movie() { Id = 2, Name = "Die Hard 2"},
                new Movie() { Id = 3, Name = "Die Hard 3"}
            };
        }


        [Route("movies/release/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content( year + " / " + month);
        }
    }
}