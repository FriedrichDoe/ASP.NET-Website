using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class oldMoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            // dont use viewData or viewBag 
            //-> muss in der view extra umgecastet werden um auf gewünschte variable zu greifen zu können
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); // weiterleitung zur home seite
            //return new EmptyResult(); // leere seite
            //return HttpNotFound("ääätsch"); // seite nicht gefunden -> default page
            //return Content("Hello World JUUUNG"); // neue (leere) seite, string wird dargestellt
            return View(viewModel);
        }




        /**
         * Beispiele
         * */

        // :regex -> google -> asp.net mvc attribute route constraints
        // validierung der parameter
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }

        public ActionResult Edit(int id) // id weil definiert in RouteConfig.cs
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}