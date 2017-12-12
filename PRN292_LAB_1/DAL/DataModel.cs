using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.DAL
{
    class DataModel
    {
        public static CategoryDAO ctgMdl = new CategoryDAO();
        public static CustomerDAO ctmMdl = new CustomerDAO();
        public static EmployeeDAO empMdl = new EmployeeDAO();
        public static OrderDAO ordMdl = new OrderDAO();
        public static OrderDetailDAO odtMdl = new OrderDetailDAO();
        public static ProductDAO prdMdl = new ProductDAO();
    }
}
