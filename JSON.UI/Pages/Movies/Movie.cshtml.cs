using System.Threading.Tasks;
using JSON.UI.DataAccess;
using JSON.UI.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSON.UI.Pages.Movies
{
    public class MovieModel : PageModel
    {
        private readonly IApiDataAccess _dataAccess;

        public MovieDTO Movie { get; set; }
        public MovieModel(IApiDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task OnGet(int id)
        {
            Movie = await _dataAccess.GetById(id);
        }
    }
}
