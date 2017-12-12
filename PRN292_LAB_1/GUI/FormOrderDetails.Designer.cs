namespace PRN292_LAB_1
{
    partial class FormOrderDetails
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
            this.label_id = new System.Windows.Forms.Label();
            this.table_productList = new System.Windows.Forms.DataGridView();
            this.label_orderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_productList)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(13, 13);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(47, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Order ID";
            // 
            // table_productList
            // 
            this.table_productList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_productList.Location = new System.Drawing.Point(12, 38);
            this.table_productList.Name = "table_productList";
            this.table_productList.Size = new System.Drawing.Size(389, 211);
            this.table_productList.TabIndex = 1;
            this.table_productList.EditModeChanged += new System.EventHandler(this.table_productList_EditModeChanged);
            this.table_productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_productList_CellContentClick);
            this.table_productList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_productList_CellEndEdit);
            this.table_productList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_productList_CellValueChanged);
            // 
            // label_orderID
            // 
            this.label_orderID.AutoSize = true;
            this.label_orderID.Location = new System.Drawing.Point(66, 13);
            this.label_orderID.Name = "label_orderID";
            this.label_orderID.Size = new System.Drawing.Size(14, 13);
            this.label_orderID.TabIndex = 2;
            this.label_orderID.Text = "#";
            this.label_orderID.Click += new System.EventHandler(this.label_orderID_Click);
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.label_orderID);
            this.Controls.Add(this.table_productList);
            this.Controls.Add(this.label_id);
            this.Name = "FormOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.table_productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DataGridView table_productList;
        private System.Windows.Forms.Label label_orderID;
    }
}