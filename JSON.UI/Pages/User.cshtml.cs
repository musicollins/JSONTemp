using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSON.UI.DataAccess;
using JSON.UI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSON.UI.Pages
{
    public class UserModel : PageModel
    {
        private readonly IDataAccess<UserDTO> _dataAccess;

        public UserModel(IDataAccess<UserDTO> dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEnumerable<UserDTO> Users { get; private set; }

        public void OnGet()
        {
            Users = _dataAccess.GetAll();
        }
    }
}
