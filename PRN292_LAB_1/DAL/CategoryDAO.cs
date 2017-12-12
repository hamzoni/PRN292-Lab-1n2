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
    class CategoryDAO : DAO, IDAO<Category>
    {
        public void delete(object x)
        {
        }

        public void insert(Category x)
        {
        }

        public Category search(int id)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryID = @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@id", id);
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int cid = Int32.Parse(dr["CategoryID"].ToString());
                string name = dr["CategoryName"].ToString();

                Category ctg = new Category(cid, name);
                return ctg;
            }

            return null;
        }

        public List<Category> list(object x)
        {
            List<Category> list = new List<Category>();

            string sql = "SELECT * FROM Categories";
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Int32.Parse(dr["CategoryID"].ToString());
                string name = dr["CategoryName"].ToString();

                Category ctg = new Category(id, name);
                list.Add(ctg);
            }

            return list;
        }

        public void update(Category x)
        {
        }
    }
}
