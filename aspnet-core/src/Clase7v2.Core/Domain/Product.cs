using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7v2.Domain
{
    public class Product: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Entry { get; set; } // día de ingreso
        public float Price { get; set; }
        public int Stock { get; set; }


    }
}
