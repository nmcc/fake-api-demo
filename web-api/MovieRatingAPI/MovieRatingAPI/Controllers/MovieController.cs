using Microsoft.AspNetCore.Mvc;
using MovieRatingAPI.Omdb;
using System;
using System.Collections.Generic;

namespace MovieRatingAPI.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly OmdbApiClient omdbApiClient;

        public MovieController(OmdbApiClient omdbApiClient)
        {
            this.omdbApiClient = omdbApiClient ?? throw new ArgumentNullException(nameof(omdbApiClient));
        }

        // GET api/values
        [HttpGet("search")]
        public IEnumerable<SearchMovieResult.MovieEntry> Search(string q)
        {
            var searchResult = this.omdbApiClient.SearchMoviesAsync(q).Result;

            return searchResult.Movies;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var movie = this.omdbApiClient.GetMovieByImdbIdAsync(id).Result;

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }
    }
}
