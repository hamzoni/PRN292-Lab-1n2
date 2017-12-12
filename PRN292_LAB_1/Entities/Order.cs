using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.Entities
{
    class Order
    {
        public int id { get; set; }
        public Customer customer { get; set; }
        public Employee employee { get; set; }
        public DateTime requiredDate { get; set; }

        public Order()
        {

        }
    }
}
