using PRN292_LAB_1.DAL;
using PRN292_LAB_1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace PRN292_LAB_1
{
    public partial class FormAddOrder : Form
    {
        private List<Employee> empsList;
        private List<Customer> ctmsList;
        private List<Product> prdsList;

        private List<int> pidLeft;
        private List<int> pidRight;

        private FormListOrder flo;
        public FormAddOrder()
        {
            InitializeComponent();
            setup();
        }

        public FormAddOrder(FormListOrder flo)
        {
            InitializeComponent();
            this.flo = flo;
            setup();
        }

        private void setup()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            // setup data
            empsList = DataModel.empMdl.list(null);
            ctmsList = DataModel.ctmMdl.list(null);
            prdsList = DataModel.prdMdl.list();

            // fill data to form
            listingEmployees();
            listingCustomers();
            listingProducts();
        }

        private void listingCustomers()
        {
            foreach (Customer ctm in ctmsList)
            {
                list_customer.Items.Add(ctm.name);
            }
            if (ctmsList.Count != 0)
                list_customer.SelectedIndex = 0;
        }

        private void listingEmployees()
        {
            foreach (Employee emp in empsList)
            {
                list_employee.Items.Add(emp.name);
            }
            if (empsList.Count != 0)
                list_employee.SelectedIndex = 0;
        }

        private void listingProducts()
        {
            pidLeft = new List<int>();
            pidRight = new List<int>();
            foreach (Product prd in prdsList)
            {
                ListViewItem item = new ListViewItem(prd.id.ToString());
                pidLeft.Add(prd.id);
                item.SubItems.Add(prd.name);
                item.SubItems.Add(prd.category.name);
                list_products.Items.Add(item);
            }
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int empID = empsList[list_employee.SelectedIndex].id;
            string ctmID = ctmsList[list_customer.SelectedIndex].id;
            DateTime date = date_requiredDate.Value;

            Order order = new Order();
            order.employee = DataModel.empMdl.search(empID);
            order.customer = DataModel.ctmMdl.search(ctmID);
            order.requiredDate = date;

            int orderID = DataModel.ordMdl.insert2(order);
            foreach (int productID in pidRight)
            {
                OrderDetail ordDt = new OrderDetail(orderID, productID);
                DataModel.odtMdl.insert(ordDt);
            }
            flo.refresh();
            Close();
        }

        private void list_employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_moveTo_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection indices = list_products.SelectedIndices;
            List<int> pids = new List<int>();


            if (indices.Count == 0) return;
            List<int> indices2 = new List<int>();
            foreach (int i in indices)
            {
                indices2.Add(i);
            }

            foreach (int i in indices2.OrderByDescending(v => v))
            {
                ListViewItem item = (ListViewItem)list_products.Items[i].Clone();
                list_cart.Items.Add(item);
                list_products.Items.Remove(list_products.Items[i]);

                pids.Add(pidLeft[i]);
            }
            pidLeft = pidLeft.Except(pids).ToList();
            for (int i = 0; i < pids.Count; i++)
            {
                pidRight.Add(pids[i]);
            }
        }

        private void btn_moveBack_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection indices = list_cart.SelectedIndices;
            List<int> pids = new List<int>();

            if (indices.Count == 0) return;
            List<int> indices2 = new List<int>();
            foreach (int i in indices)
            {
                indices2.Add(i);
            }
            foreach (int i in indices2.OrderByDescending(v => v))
            {
                ListViewItem item = (ListViewItem)list_cart.Items[i].Clone();
                list_products.Items.Add(item);
                list_cart.Items.Remove(list_cart.Items[i]);

                pids.Add(pidRight[i]);
            }

            pidRight = pidRight.Except(pids).ToList();
            for (int i = 0; i < pids.Count; i++)
            {
                pidLeft.Add(pids[i]);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
