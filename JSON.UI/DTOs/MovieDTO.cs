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
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
    }
}
