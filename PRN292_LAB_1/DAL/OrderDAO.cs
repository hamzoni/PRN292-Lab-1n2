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
    class OrderDAO : DAO, IDAO<Order>
    {
        public void delete(object x)
        {
        }

        public void insert(Order x)
        {

        }

        public int insert2(Order x)
        {
            string sql = "INSERT INTO Orders(CustomerID, EmployeeID, RequiredDate)" +
                " OUTPUT Inserted.OrderID" +
                " VALUES(@cid, @eid, @date)";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@cid", x.customer.id);
            SqlParameter p2 = new SqlParameter("@eid", x.employee.id);
            SqlParameter p3 = new SqlParameter("@date", x.requiredDate);

            p1.SqlDbType = SqlDbType.NChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.DateTime;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public List<Order> list(DateTime from, DateTime to)
        {
            List<Order> list = new List<Order>();

            string sql = "SELECT * FROM Orders WHERE " +
                "RequiredDate BETWEEN @from AND @to ORDER BY OrderID DESC";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            string ffrom = from.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string fto = to.ToString("yyyy-MM-dd HH:mm:ss.fff");

            SqlParameter p1 = new SqlParameter("@from", from);
            SqlParameter p2 = new SqlParameter("@to", to);

            p1.SqlDbType = SqlDbType.DateTime;
            p2.SqlDbType = SqlDbType.DateTime;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int id = Int32.Parse(dr["OrderID"].ToString());
                int employeeID = Int32.Parse(dr["EmployeeID"].ToString());
                string customerID = dr["CustomerID"].ToString();

                DateTime date = DateTime.Parse(dr["RequiredDate"].ToString());

                Order order = new Order();
                order.id = id;
                order.customer = DataModel.ctmMdl.search(customerID);
                order.employee = DataModel.empMdl.search(employeeID);
                order.requiredDate = date;

                list.Add(order);
            }

            return list;
        }

        public List<Order> list(object x)
        {
            List<Order> list = new List<Order>();

            string sql = "SELECT * FROM Orders ORDER BY OrderID DESC";
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Int32.Parse(dr["OrderID"].ToString());
                int employeeID = Int32.Parse(dr["EmployeeID"].ToString());
                string customerID = dr["CustomerID"].ToString();

                DateTime date = DateTime.Parse(dr["RequiredDate"].ToString());

                Order order = new Order();
                order.id = id;
                order.customer = DataModel.ctmMdl.search(customerID);
                order.employee = DataModel.empMdl.search(employeeID);
                order.requiredDate = date;

                list.Add(order);
            }

            return list;
        }

        public void update(Order x)
        {
        }
    }
}
