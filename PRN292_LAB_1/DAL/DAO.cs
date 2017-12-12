using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB_1.DAL
{
    class DAO
    {
        protected string cs;
        public DAO()
        {
            cs = ConfigurationManager.ConnectionStrings["connection"].ToString();
        }

        public DataTable getTable(string sql)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);
            return ds.Tables[0];
        }
    }
}
