using Microsoft.AspNetCore.Mvc;
using MovieRating.UI.Models;
using MovieRating.UI.MovieRatingApi;
using System;

namespace MovieRating.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieClient movieClient;

        public MovieController(MovieClient movieClient)
        {
            this.movieClient = movieClient ?? throw new ArgumentNullException(nameof(movieClient));
        }

        public IActionResult Search(string q)
        {
            if (q == null)
                return View();

            var result = this.movieClient.SearchAsync(q).Result;
            return View(new SearchMoviesResultViewModel(result));
        }

        public IActionResult Detail(string id)
        {
            var result = this.movieClient.GetAsync(id).Result;

            return View(result);
        }
    }
}
