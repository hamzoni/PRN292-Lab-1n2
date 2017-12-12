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

namespace PRN292_LAB_1
{
    public partial class FormListOrder : Form
    {
        private List<Order> orderList;
        private List<OrderDetail> ordtList;

        public FormListOrder()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            refresh();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        public void refresh()
        {
            // setup data
            orderList = DataModel.ordMdl.list(null);

            // setup order table
            orderListing();
        }

        private void orderListing()
        {
            // setup table for order listing
            table_orderList.ColumnCount = 4;
            table_orderList.Columns[0].Name = "ID";
            table_orderList.Columns[1].Name = "Customer";
            table_orderList.Columns[2].Name = "Employee";
            table_orderList.Columns[3].Name = "Required Date";

            // fill in data
            table_orderList.Rows.Clear();
            foreach (Order ord in orderList)
            {
                table_orderList.Rows.Add(ord.id, ord.customer.name, ord.employee.name, ord.requiredDate);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime from = calender_from.Value;
            DateTime to = calender_to.Value;

            orderList = DataModel.ordMdl.list(from, to);
            orderListing();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormAddOrder(this).ShowDialog();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            int index = table_orderList.CurrentCell.RowIndex;
            int orderID = orderList[index].id;
            ordtList = DataModel.odtMdl.search(orderID);
            FormOrderDetails fod = new FormOrderDetails(this);
            fod.orderID = orderID;
            fod.setup(orderID);
            fod.ShowDialog();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            FormListProduct flp = new FormListProduct();
            flp.ShowDialog();
        }
    }
}
