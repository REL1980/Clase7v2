using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Clase7v2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7v2.Products.Dtos
{
    [AutoMap(typeof(Product))]
    public class ProductDto: EntityDto
    {
        public string Name { get; set; }
    }
}
