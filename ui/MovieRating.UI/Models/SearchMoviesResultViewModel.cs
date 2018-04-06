using MovieRating.UI.MovieRatingApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.UI.Models
{
    public class SearchMoviesResultViewModel
    {
        public SearchMoviesResultViewModel(IEnumerable<MovieEntry> movies)
        {
            Movies = movies ?? Enumerable.Empty<MovieEntry>();
        }

        public IEnumerable<MovieEntry> Movies { get; }
    }
}
