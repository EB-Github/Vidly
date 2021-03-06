﻿using System;
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
        //Temporary- Hardcoded Movies for testing
        List<Movie> movies = new List<Movie>
       {
           new Movie {Id=1,Name="Shrek!"},
           new Movie {Id=2,Name="Wall-e" }
       };
        //GET Movies/Details/{ID}
        public ActionResult Details(int id)
        {
            var movie = movies.Single(Movie => Movie.Id == id);
            return View(movie);
        }
        //GET Movies/Index
        public ActionResult Index()
        {
            return View()
        }
    }
}