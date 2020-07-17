using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement
{
    class Product
    {
        public string Name { get; set; }
        public string Code{ get; set; }
        public  string Price { get; set; }
        public DateTime Date{ get; set; }

        public string ManuFactory { get; set; }
        public string ProductInfo() => $"{Name}\t{Code}\t{Price}\t{Date.ToString("MMM dd yyyy")}\t{ManuFactory}";
    }
}
