using MovieRatingAPI.Fake;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieRatingApi.Fake.Repository
{
    public class MoviesRepository
    {
        private readonly static List<MovieData> movies = BuildMovies();

        public IEnumerable<MovieData> Search(string queryString) 
            => movies.Where(m => m.Title.Contains(queryString, StringComparison.OrdinalIgnoreCase) 
                || m.Director.Contains(queryString, StringComparison.OrdinalIgnoreCase));

        public MovieData GetByImdbId(string imdbId) => movies.FirstOrDefault(m => string.Equals(m.ImdbID, imdbId, StringComparison.OrdinalIgnoreCase));

        private static List<MovieData> BuildMovies() =>
            new List<MovieData>
            {
                new MovieData
                {
                    ImdbID =  "tt0093870",
                    Title = "RoboCop (from fake)",
                    Year = "1987",
                    Director = "Paul Verhoeven",
                    Poster=  "https://ia.media-imdb.com/images/M/MV5BZWVlYzU2ZjQtZmNkMi00OTc3LTkwZmYtZDVjNmY4OWFmZGJlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                },
                new MovieData
                {
                    ImdbID =  "tt1234721",
                    Title = "RoboCop (from fake)",
                    Year = "2014",
                    Director = "Paul Verhoeven",
                    Poster=  "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAyOTUzMTcxN15BMl5BanBnXkFtZTgwMjkyOTc1MDE@._V1_SX300.jpg"
                },
                new MovieData
                {
                    ImdbID =  "tt0100502",
                    Title = "RoboCop 2 (from fake)",
                    Year = "1990",
                    Director = "Paul Verhoeven",
                    Poster=  "https://ia.media-imdb.com/images/M/MV5BNGQ5ZjI3YzYtNjM2Ni00MTFjLWEyOWMtOTEwNjI5MThlZTlmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                }
            };
    }
}
