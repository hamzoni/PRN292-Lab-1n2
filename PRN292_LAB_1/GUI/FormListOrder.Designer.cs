namespace PRN292_LAB_1
{
    partial class FormListOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_addorder = new System.Windows.Forms.Button();
            this.table_orderList = new System.Windows.Forms.DataGridView();
            this.calender_from = new System.Windows.Forms.DateTimePicker();
            this.calender_to = new System.Windows.Forms.DateTimePicker();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(424, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_addorder
            // 
            this.btn_addorder.Location = new System.Drawing.Point(505, 9);
            this.btn_addorder.Name = "btn_addorder";
            this.btn_addorder.Size = new System.Drawing.Size(75, 23);
            this.btn_addorder.TabIndex = 2;
            this.btn_addorder.Text = "Add";
            this.btn_addorder.UseVisualStyleBackColor = true;
            this.btn_addorder.Click += new System.EventHandler(this.button3_Click);
            // 
            // table_orderList
            // 
            this.table_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_orderList.Location = new System.Drawing.Point(12, 38);
            this.table_orderList.Name = "table_orderList";
            this.table_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_orderList.Size = new System.Drawing.Size(565, 211);
            this.table_orderList.TabIndex = 3;
            // 
            // calender_from
            // 
            this.calender_from.Location = new System.Drawing.Point(12, 12);
            this.calender_from.Name = "calender_from";
            this.calender_from.Size = new System.Drawing.Size(200, 20);
            this.calender_from.TabIndex = 6;
            // 
            // calender_to
            // 
            this.calender_to.Location = new System.Drawing.Point(218, 12);
            this.calender_to.Name = "calender_to";
            this.calender_to.Size = new System.Drawing.Size(200, 20);
            this.calender_to.TabIndex = 7;
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(502, 255);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(75, 23);
            this.btn_detail.TabIndex = 8;
            this.btn_detail.Text = "View Detail";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(13, 256);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(123, 23);
            this.btn_products.TabIndex = 9;
            this.btn_products.Text = "Product Lists";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // FormListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 286);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.calender_to);
            this.Controls.Add(this.calender_from);
            this.Controls.Add(this.table_orderList);
            this.Controls.Add(this.btn_addorder);
            this.Controls.Add(this.btn_search);
            this.Name = "FormListOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Order";
            ((System.ComponentModel.ISupportInitialize)(this.table_orderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_addorder;
        private System.Windows.Forms.DataGridView table_orderList;
        private System.Windows.Forms.DateTimePicker calender_from;
        private System.Windows.Forms.DateTimePicker calender_to;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_products;
    }
}