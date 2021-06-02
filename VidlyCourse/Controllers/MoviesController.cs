using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyCourse.Models;
using VidlyCourse.ViewModels;

namespace VidlyCourse.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            if (User.IsInRole("CanManageMovies"))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = "CanManageMovies")]
        public ActionResult New()
        {
            var movie = new Movie();
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = "CanManageMovies")]
        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == Id);

            if (movie == null)
                return HttpNotFound();

            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "CanManageMovies")]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if(movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;

            }
            
            
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        [Route("movies/release/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content( year + " / " + month);
        }
    }
}