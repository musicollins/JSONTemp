using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSON.UI.DataAccess;
using JSON.UI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSON.UI.Pages.Movies
{
    public class MoviesModel : PageModel
    {
        private readonly IDataAccess<MovieDTO> _dataAccess;

        public List<MovieDTO> Movies { get; set; }

        public MoviesModel(IDataAccess<MovieDTO> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void OnGet()
        {
            var movies = _dataAccess.GetAll();
            if(movies is not null)
            {
                Movies = movies.ToList();
            }       
        }
    }
}
