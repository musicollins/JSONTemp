using JSON.DataSource;
using JSON.UI.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON.UI.DataAccess
{
    public class MoviesDataAccess : IDataAccess<MovieDTO>
    {
        private readonly JSONDataSource _dataSource;

        public MoviesDataAccess(JSONDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public IEnumerable<MovieDTO> GetAll()
        {
            var jsonString = _dataSource.MoviesDataProvider();
            var Results = JsonConvert.DeserializeObject<ResultsDTO>(jsonString);
            return Results.Results;
        }

        public MovieDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
