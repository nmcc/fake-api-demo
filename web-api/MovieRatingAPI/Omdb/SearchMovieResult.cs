using Newtonsoft.Json;

namespace MovieRatingAPI.Omdb
{
    [JsonObject]
    public sealed class SearchMovieResult
    {
        [JsonProperty(PropertyName = "Search")]
        public MovieEntry[] Movies { get; set; }
    }

    public class MovieEntry
    {
        [JsonProperty(PropertyName = "imdbID")]
        public string ImdbId { get; set; }
        [JsonProperty]
        public string Title { get; set; }
        [JsonProperty]
        public string Year { get; set; }
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "Poster")]
        public string PosterUrl { get; set; }
    }
}
