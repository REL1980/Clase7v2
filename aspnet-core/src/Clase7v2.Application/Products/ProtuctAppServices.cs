using Clase7v2.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7v2.Products
{
    public class ProtuctAppServices : Clase7v2AppServiceBase, IProductAppService
    {
        public Task Create(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
