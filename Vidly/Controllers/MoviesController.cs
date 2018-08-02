using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "customer 1"},
                new Customer {Name = "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };



            return View(viewModel);
            //return Content("Hello world!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

//        public ActionResult ByReleaseDate(int year, int month)
//        {
//            return Content("year:" + year + "month:" + month);
//        }

        public ActionResult Edit(int? id)
        {
            return Content("id=" + id);
        }
    }
}