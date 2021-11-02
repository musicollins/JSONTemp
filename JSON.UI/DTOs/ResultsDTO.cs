using Newtonsoft.Json;
using System.Collections.Generic;

namespace JSON.UI.DTOs
{
    public class ResultsDTO
    {
        [JsonProperty("results")]
        public  List<MovieDTO> Results { get; set; }

    }
}
