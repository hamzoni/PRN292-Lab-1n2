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
    public partial class FormOrderDetails : Form
    {
        private List<OrderDetail> list;
        private FormListOrder flo;
        public int orderID;
        public FormOrderDetails()
        {
            InitializeComponent();
        }

        public FormOrderDetails(FormListOrder flo)
        {
            InitializeComponent();
            this.flo = flo;
        }


        internal List<OrderDetail> List { get => list; set => list = value; }

        public void setup(int orderID)
        {
            list = DataModel.odtMdl.search(orderID);
            label_orderID.Text = list[0].orderID.ToString();
            // set columns
            table_productList.ColumnCount = 4;
            table_productList.Columns[0].Name = "ID";
            table_productList.Columns[0].Width = 30;
            table_productList.Columns[1].Name = "Name";
            table_productList.Columns[2].Name = "Price";
            table_productList.Columns[2].Width = 50;
            table_productList.Columns[3].Name = "Category";

            // set row data
            table_productList.Rows.Clear();
            foreach (OrderDetail ord in list)
            {
                Product prd = ord.product;
                table_productList.Rows.Add(prd.id, prd.name, prd.price, prd.category.name);
            }
        }

        private void table_productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_orderID_Click(object sender, EventArgs e)
        {

        }

        private void table_productList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");            
        }

        private void table_productList_EditModeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ok2");
        }

        private void table_productList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }
    }
}
