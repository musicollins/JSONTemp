using Newtonsoft.Json;

namespace JSON.UI.DTOs
{
    public class MovieDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("original_language")]
        public string Language { get; set; }
        [JsonProperty("overview")]
        public string Overview { get; set; }
        private string _posterPath;
        [JsonProperty("poster_path")]
        public string PosterPath
        {
            get { return _posterPath; }
            set { _posterPath = "https://image.tmdb.org/t/p/w500" + value; }
        }

    }
}
