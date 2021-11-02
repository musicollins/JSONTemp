using JSON.UI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON.UI.DataAccess
{
    public class UserDataAccess : IDataAccess<UserDTO>
    {
        public UserDataAccess()
        {
            Users = new List<UserDTO>()
            {
                new UserDTO(){ Id=1, Name="Juan"},
                new UserDTO(){ Id=2, Name="John"},
                new UserDTO(){ Id=3, Name="Chian"},
                new UserDTO(){ Id=4, Name="Muhammed"},
            };
        }

        public List<UserDTO> Users { get; private set; }

        public IEnumerable<UserDTO> GetAll()
        {
            return Users;
        }

        public UserDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
