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
    class OrderDetailDAO : DAO, IDAO<OrderDetail>
    {
        public void delete(object x)
        {
        }

        public void delete(int productID)
        {
            string sql = "DELETE FROM [Order Details] WHERE ProductID = @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@id", productID);
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<OrderDetail> search(int orderID)
        {
            List<OrderDetail> list = new List<OrderDetail>();

            string sql = "SELECT * FROM [Order Details] WHERE OrderID = @orderID";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@orderID", orderID);
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int pid = Int32.Parse(dr["ProductID"].ToString());
                float price = float.Parse(dr["UnitPrice"].ToString());
                int qty = Int32.Parse(dr["Quantity"].ToString());
                float dc = float.Parse(dr["Discount"].ToString());

                OrderDetail odt = new OrderDetail();
                odt.orderID = orderID;
                odt.productID = pid;
                odt.product = DataModel.prdMdl.search(pid);
                odt.price = price;
                odt.qty = qty;
                odt.discount = dc;

                list.Add(odt);
            }

            return list;
        }

        public void insert(OrderDetail x)
        {
            string sql = "INSERT INTO [Order Details](OrderID, ProductID) VALUES(@oid, @pid)";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@oid", x.orderID);
            SqlParameter p2 = new SqlParameter("@pid", x.productID);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<OrderDetail> list(object x)
        {
            return null;
        }

        public void update(OrderDetail x)
        {
        }
    }
}
