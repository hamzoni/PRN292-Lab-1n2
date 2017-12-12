namespace PRN292_LAB_1
{
    partial class FormListProduct
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
            this.combobox_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.table_productlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_productlist)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_category
            // 
            this.combobox_category.FormattingEnabled = true;
            this.combobox_category.Location = new System.Drawing.Point(12, 12);
            this.combobox_category.Name = "combobox_category";
            this.combobox_category.Size = new System.Drawing.Size(179, 21);
            this.combobox_category.TabIndex = 0;
            this.combobox_category.SelectedIndexChanged += new System.EventHandler(this.combobox_category_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(197, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // table_productlist
            // 
            this.table_productlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_productlist.Location = new System.Drawing.Point(12, 41);
            this.table_productlist.Name = "table_productlist";
            this.table_productlist.Size = new System.Drawing.Size(332, 191);
            this.table_productlist.TabIndex = 2;
            this.table_productlist.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_productlist_CellMouseClick);
            this.table_productlist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_productlist_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "right-click to delete selected row";
            // 
            // FormListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_productlist);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.combobox_category);
            this.Name = "FormListProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Product";
            ((System.ComponentModel.ISupportInitialize)(this.table_productlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_category;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView table_productlist;
        private System.Windows.Forms.Label label1;
    }
}

