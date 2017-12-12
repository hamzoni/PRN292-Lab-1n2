using PRN292_LAB_1.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.DAL
{
    class CustomerDAO : DAO, IDAO<Customer>
    {

        public Customer search(string id)
        {
            string sql = "SELECT * FROM Customers WHERE CustomerID =  @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@id", id);
            p1.SqlDbType = SqlDbType.NChar;
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string cid = dr["CustomerID"].ToString();
                string name = dr["ContactName"].ToString();

                return new Customer(cid, name);
            }
            return null;
        }

        public void delete(object x)
        {
        }

        public void insert(Customer x)
        {
        }

        public List<Customer> list(object x)
        {
            List<Customer> list = new List<Customer>();

            string sql = "SELECT * FROM Customers";
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                string id = dr["CustomerID"].ToString();
                string name = dr["ContactName"].ToString();

                Customer ctm = new Customer(id, name);
                list.Add(ctm);
            }
            return list;
        }

        public void update(Customer x)
        {
        }
    }
}
