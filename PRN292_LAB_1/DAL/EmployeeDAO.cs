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
    class EmployeeDAO : DAO, IDAO<Employee>
    {
        public Employee search(int id)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeID =  @id";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@id", id);
            cmd.Parameters.Add(p1);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int eid = Int32.Parse(dr["EmployeeID"].ToString());
                string ln = dr["LastName"].ToString();
                string fn = dr["FirstName"].ToString();
                string name = ln + " " + fn;

                Employee emp = new Employee();
                emp.id = eid;
                emp.name = name;

                return emp;
            }
            return null;
        }

        public void delete(object x)
        {
        }

        public void insert(Employee x)
        {
        }

        public List<Employee> list(object x)
        {
            List<Employee> list = new List<Employee>();

            string sql = "SELECT * FROM Employees";
            DataTable dt = getTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Int32.Parse(dr["EmployeeID"].ToString());
                string ln = dr["LastName"].ToString();
                string fn = dr["FirstName"].ToString();
                string name = ln + " " + fn;

                Employee emp = new Employee();
                emp.id = id;
                emp.name = name;

                list.Add(emp);
            }
            return list;
        }

        public void update(Employee x)
        {
        }
    }
}
