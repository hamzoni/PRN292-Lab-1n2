namespace PRN292_LAB_1
{
    partial class FormAddOrder
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
            this.list_employee = new System.Windows.Forms.ComboBox();
            this.list_customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_requiredDate = new System.Windows.Forms.DateTimePicker();
            this.list_products = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_moveTo = new System.Windows.Forms.Button();
            this.btn_moveBack = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.list_cart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_employee
            // 
            this.list_employee.FormattingEnabled = true;
            this.list_employee.Location = new System.Drawing.Point(98, 9);
            this.list_employee.Name = "list_employee";
            this.list_employee.Size = new System.Drawing.Size(280, 21);
            this.list_employee.TabIndex = 0;
            this.list_employee.SelectedIndexChanged += new System.EventHandler(this.list_employee_SelectedIndexChanged);
            // 
            // list_customer
            // 
            this.list_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_customer.FormattingEnabled = true;
            this.list_customer.Location = new System.Drawing.Point(98, 39);
            this.list_customer.Name = "list_customer";
            this.list_customer.Size = new System.Drawing.Size(280, 21);
            this.list_customer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Required Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer";
            // 
            // date_requiredDate
            // 
            this.date_requiredDate.Location = new System.Drawing.Point(98, 66);
            this.date_requiredDate.Name = "date_requiredDate";
            this.date_requiredDate.Size = new System.Drawing.Size(278, 20);
            this.date_requiredDate.TabIndex = 6;
            // 
            // list_products
            // 
            this.list_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.list_products.FullRowSelect = true;
            this.list_products.Location = new System.Drawing.Point(12, 113);
            this.list_products.Name = "list_products";
            this.list_products.Size = new System.Drawing.Size(234, 164);
            this.list_products.TabIndex = 7;
            this.list_products.UseCompatibleStateImageBehavior = false;
            this.list_products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Products Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cart";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_moveTo
            // 
            this.btn_moveTo.Location = new System.Drawing.Point(252, 161);
            this.btn_moveTo.Name = "btn_moveTo";
            this.btn_moveTo.Size = new System.Drawing.Size(50, 23);
            this.btn_moveTo.TabIndex = 11;
            this.btn_moveTo.Text = ">";
            this.btn_moveTo.UseVisualStyleBackColor = true;
            this.btn_moveTo.Click += new System.EventHandler(this.btn_moveTo_Click);
            // 
            // btn_moveBack
            // 
            this.btn_moveBack.Location = new System.Drawing.Point(252, 190);
            this.btn_moveBack.Name = "btn_moveBack";
            this.btn_moveBack.Size = new System.Drawing.Size(50, 23);
            this.btn_moveBack.TabIndex = 12;
            this.btn_moveBack.Text = "<";
            this.btn_moveBack.UseVisualStyleBackColor = true;
            this.btn_moveBack.Click += new System.EventHandler(this.btn_moveBack_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(463, 283);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 13;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // list_cart
            // 
            this.list_cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_cart.FullRowSelect = true;
            this.list_cart.Location = new System.Drawing.Point(308, 113);
            this.list_cart.Name = "list_cart";
            this.list_cart.Size = new System.Drawing.Size(234, 164);
            this.list_cart.TabIndex = 14;
            this.list_cart.UseCompatibleStateImageBehavior = false;
            this.list_cart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Category";
            this.columnHeader6.Width = 80;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 313);
            this.Controls.Add(this.list_cart);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_moveBack);
            this.Controls.Add(this.btn_moveTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_products);
            this.Controls.Add(this.date_requiredDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_customer);
            this.Controls.Add(this.list_employee);
            this.Name = "FormAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox list_employee;
        private System.Windows.Forms.ComboBox list_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_requiredDate;
        private System.Windows.Forms.ListView list_products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_moveTo;
        private System.Windows.Forms.Button btn_moveBack;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView list_cart;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}