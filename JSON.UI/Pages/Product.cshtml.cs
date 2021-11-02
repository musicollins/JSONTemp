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
    public class ProductModel : PageModel
    {
        private readonly IDataAccess<ProductDTO> _dataAccess;

        public ProductModel(IDataAccess<ProductDTO> dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEnumerable<ProductDTO> Products { get; private set; }

        public void OnGet()
        {
            Products = _dataAccess.GetAll();
        }
    }
}
