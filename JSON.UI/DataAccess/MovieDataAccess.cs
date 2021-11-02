using JSON.DataSource;
using JSON.UI.DTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace JSON.UI.DataAccess
{
    public class MovieDataAccess : IApiDataAccess
    {
        //private readonly JSONDataSource _dataSource;

        public MovieDataAccess()
        {
        }

        public List<MovieDTO> Movies { get; private set; }

        public async Task<IEnumerable<MovieDTO>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                var uri = "https://api.themoviedb.org/3/discover/movie?api_key=b856829afbcdd6bd2f38f041b3bec53e&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_genres=28&with_watch_monetization_types=flatrate";
                HttpResponseMessage reponse = await client.GetAsync(uri);
                var jsonResponse = await reponse.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<ResultsDTO>(jsonResponse);
                Movies = results.Results;
                return results.Results;
                
            }

        }

        public async Task<MovieDTO> GetById(int id)
        {
            using(HttpClient client = new HttpClient())
            {
                var uri = $"https://api.themoviedb.org/3/movie/{id}?api_key=b856829afbcdd6bd2f38f041b3bec53e&language=en-US";
                HttpResponseMessage reponse = await client.GetAsync(uri);
                var jsonResponse = await reponse.Content.ReadAsStringAsync();
                var movie = JsonConvert.DeserializeObject<MovieDTO>(jsonResponse);
                return movie;
            }
            
        }
    }


}
