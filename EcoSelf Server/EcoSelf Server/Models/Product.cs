using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSelf_Server.Models
{
    public class Product
    {
        public string BarCode { get;} 
        public string Name { get; set; }
        public string RecycMatr { get; set; }
        public string Desc { get; set; }
    }
}
