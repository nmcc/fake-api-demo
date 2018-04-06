using MovieRatingApi.Fake.Repository;
using MovieRatingAPI.Fake;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApi.Fake.Implementation
{
    public class MovieControllerImplementation : IMovieController
    {
        private readonly MoviesRepository moviesRepository;

        public MovieControllerImplementation(MoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository ?? throw new ArgumentNullException(nameof(moviesRepository));
        }

        public Task<MovieData> GetAsync(string id)
        {
            return Task.FromResult(moviesRepository.GetByImdbId(id));
        }

        public Task<List<MovieEntry>> SearchAsync(string q)
        {
            var movies = moviesRepository.Search(q)
                .Select(m => new MovieEntry
                {
                    ImdbID = m.ImdbID,
                    Poster = m.Poster,
                    Title = m.Title,
                    Type = "movie",
                    Year = m.Year
                });

            return Task.FromResult(movies.ToList());
        }
    }
}
