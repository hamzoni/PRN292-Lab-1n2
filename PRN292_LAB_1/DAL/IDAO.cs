using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.DAL
{
    interface IDAO <T>
    {
        List<T> list(object x);
        void insert(T x);
        void update(T x);
        void delete(object x);
    }
}
