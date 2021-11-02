using JSON.UI.DataAccess;
using JSON.UI.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApiDataAccess _dataAccess;

        public List<MovieDTO> Movies { get; private set; }

        public IndexModel(IApiDataAccess dataAccess)
        {
            Movies = new List<MovieDTO>();
            _dataAccess = dataAccess;
        }


        public async Task OnGet()
        {
            var movies = await _dataAccess.GetAll();
            if (movies != null)
            {
                Movies = movies.Cast<MovieDTO>().ToList();

            }
        }


    }
}
