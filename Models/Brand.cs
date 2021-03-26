using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLiqourCentre.Models
{
    public class Brand
    {
        [key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
