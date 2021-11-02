using JSON.UI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON.UI.DataAccess
{
    public class ProductDataAccess : IDataAccess<ProductDTO>
    {
        public ProductDataAccess()
        {
            Products = new List<ProductDTO>()
            {
                new ProductDTO(){ Id=1, ProductName="iPhone"},
                new ProductDTO(){ Id=2, ProductName="Samsung"},
                new ProductDTO(){ Id=3, ProductName="Lg"},
                new ProductDTO(){ Id=4, ProductName="Motorola"},
            };
        }

        public List<ProductDTO> Products { get; private set; }

        public IEnumerable<ProductDTO> GetAll()
        {
            return Products;
        }

        public ProductDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
