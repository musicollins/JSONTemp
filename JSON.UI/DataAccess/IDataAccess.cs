using JSON.UI.DTOs;
using System.Collections.Generic;

namespace JSON.UI.DataAccess
{
    public interface IDataAccess<T>
    {
        IEnumerable<T>GetAll();
        T GetById(int id);
    }
}
