﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
            var movies = _context.Movies.Include(m => m.MovieType).ToList();
            return View(movies);
        }

        //Movie detail
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.MovieType).SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        public ActionResult New()
        {
            var movieTypes = _context.MovieTypes.ToList();
            var viewModel = new MovieFormViewModel()
            {
                MovieTypes = movieTypes
            };

            return View("MovieForm",viewModel);
        }
    }
}