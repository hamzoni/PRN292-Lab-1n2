using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.Entities
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
