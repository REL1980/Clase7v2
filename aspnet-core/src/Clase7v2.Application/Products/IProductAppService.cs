using Abp.Application.Services;
using Clase7v2.Products.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clase7v2.Products
{
    public interface IProductAppService: IApplicationService
    {
        List<ProductDto> GetAll();
        Task<ProductDto> Get(int id);
        Task Create(ProductDto product);
        Task Update(ProductDto product);
        Task Delete(int id);


    }
}