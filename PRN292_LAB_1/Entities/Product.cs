using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.Entities
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string qty { get; set; }
        public Category category { get; set; }
        public bool discontinued { get; set; }

        public Product()
        {

        }
    }
}
