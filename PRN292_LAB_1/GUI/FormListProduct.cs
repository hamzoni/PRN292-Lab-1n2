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
    public partial class FormListProduct : Form
    {
        private List<Category> ctgList;
        private List<Product> prdList;
        private List<int> cellChanged;

        public FormListProduct()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            cellChanged = new List<int>();
            ctgList = DataModel.ctgMdl.list(null);
            prdList = DataModel.prdMdl.list(ctgList[0].id);

            // push product list to list
            foreach (Category ctg in ctgList)
            {
                combobox_category.Items.Add(ctg.name);
            }
            combobox_category.SelectedItem = ctgList[0].name;

            // work with product list
            updateProductList();
        }

        private void updateProductList()
        {
            // set data grid table columns
            table_productlist.ColumnCount = 4;
            table_productlist.Columns[0].Name = "ID";
            table_productlist.Columns[1].Name = "Name";
            table_productlist.Columns[2].Name = "Price";
            table_productlist.Columns[3].Name = "Quantity";

            table_productlist.Columns[0].Width = 30;
            table_productlist.Columns[2].Width = 40;

            // list product of current category to table
            table_productlist.Rows.Clear();
            foreach (Product prd in prdList)
            {
                table_productlist.Rows.Add(prd.id, prd.name, prd.price, prd.qty);
            }

        }

        private void combobox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = combobox_category.SelectedIndex;
            prdList = DataModel.prdMdl.list(ctgList[index].id);
            updateProductList();
        }

        private bool isValidID(int id)
        {
            foreach (Product prd in prdList)
            {
                if (prd.id == id) return true;
            }
            return false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in table_productlist.Rows)
            {
                if (row == null) continue;
                bool isRowNull = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        isRowNull = false;
                    }
                }
                if (isRowNull) continue;
                try
                {
                    string ids = null;
                    if (row.Cells[0].Value != null) ids = row.Cells[0].Value.ToString();

                    string sname = "";
                    if (row.Cells[1].Value != null) sname = row.Cells[1].Value.ToString();

                    string sprice = "0";
                    if (row.Cells[2].Value != null) sprice = row.Cells[2].Value.ToString();

                    string sqty = "0";
                    if (row.Cells[3].Value != null) sqty = row.Cells[3].Value.ToString();

                    int id = ids != null ? int.Parse((string)ids) : -1;
                    if (id != -1)
                    {
                        if (!isValidID(id)) continue;
                    }

                    float price = float.Parse(sprice);

                    Product prd = new Product();
                    prd.id = id;
                    prd.name = sname;
                    prd.category = ctgList[combobox_category.SelectedIndex];
                    prd.price = price;
                    prd.qty = sqty;

                    if (id != -1)
                    {
                        DataModel.prdMdl.update(prd);
                    }
                    else
                    {
                        DataModel.prdMdl.insert(prd);
                    }
                }
                catch (Exception exp) { }
            }
            updateProductList();
        }

        private void table_productlist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int idx = table_productlist.CurrentCell.RowIndex;
                if (idx < 0 || idx >= prdList.Count) return;
                
                int prdID = prdList[idx].id;
                if (!confirm("Do you want to delete product #" + prdID + "?", "Delete Confirm")) return;
                prdList.RemoveAt(idx);
                table_productlist.Rows.RemoveAt(idx);
                DataModel.prdMdl.delete(prdID);
            }
        }

        public bool confirm(string msg, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, caption, buttons);

            return result == DialogResult.Yes;
        }

        private void table_productlist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
