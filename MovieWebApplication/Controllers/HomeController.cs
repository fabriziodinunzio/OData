using MovieWebApplication.MovieServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _service;

        public HomeController(IMovieService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {

           Movie[] listOfMovies = _service.GetMovies();
            return View(listOfMovies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}