using JSON.UI.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JSON.UI.DataAccess
{
    public interface IApiDataAccess
    {
        Task<IEnumerable<MovieDTO>> GetAll();
        Task<MovieDTO> GetById(int id);
    }
}
