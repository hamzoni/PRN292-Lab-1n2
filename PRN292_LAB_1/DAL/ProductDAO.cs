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
    class ProductDAO : DAO, IDAO<Product>
    {
        public ProductDAO()
        {
        }

        public Product search(int id)
        {
            List<Product> list = new List<Product>();

            string sql = "SELECT * FROM Products WHERE ProductID = @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@id", id);
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string name = dr["ProductName"].ToString();
                float price = float.Parse(dr["UnitPrice"].ToString());
                string qty = dr["QuantityPerUnit"].ToString();
                int ctg = Int32.Parse(dr["CategoryID"].ToString());
                bool dc = bool.Parse(dr["Discontinued"].ToString());

                Product prd = new Product();
                prd.id = id;
                prd.name = name;
                prd.price = price;
                prd.qty = qty;
                prd.category = DataModel.ctgMdl.search(ctg);
                prd.discontinued = dc;

                return prd;
            }

            return null;
        }

        public void delete(object id)
        {
            DataModel.odtMdl.delete((int)id);

            string sql = "DELETE FROM Products WHERE ProductID = @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@id", id);
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void insert(Product x)
        {
            string sql = "INSERT INTO Products(ProductName, CategoryID, QuantityPerUnit, UnitPrice, Discontinued) " +
                "VALUES(@name, @ctg, @qty, @price, @dc)";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@name", x.name);
            SqlParameter p2 = new SqlParameter("@ctg", x.category.id);
            SqlParameter p3 = new SqlParameter("@qty", x.qty);
            SqlParameter p4 = new SqlParameter("@price", x.price);
            SqlParameter p5 = new SqlParameter("@dc", x.discontinued);

            p1.SqlDbType = SqlDbType.NVarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.NVarChar;
            p4.SqlDbType = SqlDbType.Money;
            p5.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Product> list()
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM Products ";
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Int32.Parse(dr["ProductID"].ToString());
                string name = dr["ProductName"].ToString();
                float price = float.Parse(dr["UnitPrice"].ToString());
                string qty = dr["QuantityPerUnit"].ToString();
                int ctg = Int32.Parse(dr["CategoryID"].ToString());
                bool dc = bool.Parse(dr["Discontinued"].ToString());

                Product prd = new Product();
                prd.id = id;
                prd.name = name;
                prd.price = price;
                prd.qty = qty;
                prd.category = DataModel.ctgMdl.search(ctg);
                prd.discontinued = dc;

                list.Add(prd);
            }

            return list;
        }

        public List<Product> list(object categoryId)
        {
            if (categoryId == null) return new List<Product>();
            int ctdID = (int)categoryId;
            List<Product> list = new List<Product>();

            string sql = "SELECT * FROM Products ";
            if (categoryId != null) sql += "WHERE CategoryID = " + ctdID;
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Int32.Parse(dr["ProductID"].ToString());
                string name = dr["ProductName"].ToString();
                float price = float.Parse(dr["UnitPrice"].ToString());
                string qty = dr["QuantityPerUnit"].ToString();
                int ctg = Int32.Parse(dr["CategoryID"].ToString());
                bool dc = bool.Parse(dr["Discontinued"].ToString());

                Product prd = new Product();
                prd.id = id;
                prd.name = name;
                prd.price = price;
                prd.qty = qty;
                prd.category = DataModel.ctgMdl.search(ctg);
                prd.discontinued = dc;

                list.Add(prd);
            }

            return list;
        }

        public void update(Product x)
        {
            string sql = "UPDATE Products SET " +
                "ProductName = @name, CategoryID = @ctg, QuantityPerUnit = @qty," +
                "UnitPrice = @price, Discontinued = @dc WHERE ProductID = @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlParameter p1 = new SqlParameter("@name", x.name);
            SqlParameter p2 = new SqlParameter("@ctg", x.category.id);
            SqlParameter p3 = new SqlParameter("@qty", x.qty);
            SqlParameter p4 = new SqlParameter("@price", x.price);
            SqlParameter p5 = new SqlParameter("@dc", x.discontinued);
            SqlParameter p6 = new SqlParameter("@id", x.id);

            p1.SqlDbType = SqlDbType.NVarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.NVarChar;
            p4.SqlDbType = SqlDbType.Money;
            p5.SqlDbType = SqlDbType.Bit;
            p6.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
