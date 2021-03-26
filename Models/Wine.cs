using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLiqourCentre.Models
{
    public class Wine
       
    {
        [key]
        public int ID { get; set; } //primary key
       //other variables
        public string name { get;set; }
   

    }
}
