using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieRatingAPI.Omdb
{
    public class OmdbApiClient : IDisposable
    {
        private const string BaseUrl = "http://www.omdbapi.com/?apikey=b9ec1d52";
        private readonly HttpClient httpClient;
        
        public OmdbApiClient()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<SearchMovieResult> SearchMoviesAsync(string searchString)
        {
            var searchResultString = await this.httpClient.GetStringAsync($"{BaseUrl}&s={searchString}");

            return JsonConvert.DeserializeObject<SearchMovieResult>(searchResultString);
        }

        public async Task<MovieData> GetMovieByImdbIdAsync(string imdbId)
        {
            var searchResultString = await this.httpClient.GetStringAsync($"{BaseUrl}&i={imdbId}");

            if (searchResultString.Contains("\"Response\":\"False\""))
                return null;

            return JsonConvert.DeserializeObject<MovieData>(searchResultString);
        }

        public void Dispose()
        {
            this.httpClient.Dispose();
        }
    }
}
