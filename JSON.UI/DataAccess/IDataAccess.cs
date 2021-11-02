using JSON.UI.DTOs;
using System.Collections.Generic;

namespace JSON.UI.DataAccess
{
    public interface IDataAccess
    {
        IEnumerable<MovieDTO>GetAll();
        MovieDTO GetById(int id);
    }
}
