using Microsoft.AspNetCore.Mvc;
using MovieRating.UI.MovieRatingApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var result = this.movieClient.SearchAsync(q);

            return View(result);
        }
    }
}
