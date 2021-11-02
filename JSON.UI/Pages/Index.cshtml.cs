using JSON.UI.DataAccess;
using JSON.UI.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace JSON.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDataAccess _dataAccess;

        public IndexModel(IDataAccess dataAccess)
        {
            NAME = "John";
            _dataAccess = dataAccess;
        }

        public IEnumerable<MovieDTO> Movies { get; private set; }
        public string NAME { get; private set; }

        public void OnGet()
        {
            Movies = _dataAccess.GetAll();
        }


    }
}
