using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.Entities
{
    class OrderDetail
    {
        public int orderID { get; set; }
        public int productID { get; set; }
        public Product product { get; set; }
        public float price { get; set; }
        public int qty { get; set; }
        public float discount { get; set; }

        public OrderDetail()
        {

        }

        public OrderDetail(int orderID, int productID)
        {
            this.orderID = orderID;
            this.productID = productID;
        }
    }
}
