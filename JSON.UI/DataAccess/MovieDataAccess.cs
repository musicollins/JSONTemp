using JSON.DataSource;
using JSON.UI.DTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace JSON.UI.DataAccess
{
    public class MovieDataAccess : IDataAccess
    {
        private readonly JSONDataSource _dataSource;

        public MovieDataAccess(JSONDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public IEnumerable<MovieDTO> GetAll()
        {
            var jsonResponse = _dataSource.MoviesDataProvider();
            var movies = JsonConvert.DeserializeObject<List<MovieDTO>>(jsonResponse);
            return movies;
        }

        public MovieDTO GetById(int id)
        {
            var jsonResponse = _dataSource.MovieDataProvider();
            var movie = JsonConvert.DeserializeObject<MovieDTO>(jsonResponse);
            return movie;
        }
    }


}
