using Newtonsoft.Json;

namespace MovieRatingAPI.Omdb
{
    [JsonObject]
    public class MovieData
    {
        [JsonProperty(PropertyName = "imdbID")]
        public string ImdbID { get; set; }
        [JsonProperty]
        public string Title { get; set; }
        [JsonProperty]
        public string Year { get; set; }
        [JsonProperty]
        public string Director { get; set; }
        [JsonProperty(PropertyName = "imdbRating")]
        public decimal ImdbRating { get; set; }
        [JsonProperty(PropertyName = "Poster")]
        public string PosterUrl { get; set; }
    }
}
