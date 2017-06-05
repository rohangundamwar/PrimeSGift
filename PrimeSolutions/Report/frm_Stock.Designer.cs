namespace PrimeSolutions.Report
{
    partial class frm_Stock
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
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_StockDetail = new System.Windows.Forms.Label();
            this.grp_Filter = new System.Windows.Forms.GroupBox();
            this.bttn_Check1 = new System.Windows.Forms.Button();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.bttn_Check = new System.Windows.Forms.Button();
            this.cmb_Sorting = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.bttn_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.grp_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AllowUserToAddRows = false;
            this.dgv_stock.AllowUserToDeleteRows = false;
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Category,
            this.SubCategory,
            this.Size,
            this.Quantity});
            this.dgv_stock.Location = new System.Drawing.Point(0, 125);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.Size = new System.Drawing.Size(740, 429);
            this.dgv_stock.TabIndex = 0;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // bttn_Close
            // 
            this.bttn_Close.Location = new System.Drawing.Point(633, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 33);
            this.bttn_Close.TabIndex = 1;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 558);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(742, 44);
            this.pnl_Bottom.TabIndex = 12;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Top.Controls.Add(this.dtp_Date);
            this.pnl_Top.Controls.Add(this.lbl_Date);
            this.pnl_Top.Controls.Add(this.lbl_StockDetail);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(742, 44);
            this.pnl_Top.TabIndex = 13;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(607, 10);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(104, 22);
            this.dtp_Date.TabIndex = 10;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Date.Location = new System.Drawing.Point(553, 12);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 9;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_StockDetail
            // 
            this.lbl_StockDetail.AutoSize = true;
            this.lbl_StockDetail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_StockDetail.Location = new System.Drawing.Point(259, 9);
            this.lbl_StockDetail.Name = "lbl_StockDetail";
            this.lbl_StockDetail.Size = new System.Drawing.Size(131, 22);
            this.lbl_StockDetail.TabIndex = 0;
            this.lbl_StockDetail.Text = "Stock Deatail";
            // 
            // grp_Filter
            // 
            this.grp_Filter.BackColor = System.Drawing.SystemColors.Info;
            this.grp_Filter.Controls.Add(this.bttn_Excel);
            this.grp_Filter.Controls.Add(this.cmb_Size);
            this.grp_Filter.Controls.Add(this.bttn_Check1);
            this.grp_Filter.Controls.Add(this.txt_Size);
            this.grp_Filter.Controls.Add(this.cmb_SubCategory);
            this.grp_Filter.Controls.Add(this.cmb_Category);
            this.grp_Filter.Controls.Add(this.bttn_Check);
            this.grp_Filter.Controls.Add(this.cmb_Sorting);
            this.grp_Filter.Controls.Add(this.lbl_Category);
            this.grp_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Filter.ForeColor = System.Drawing.Color.Gray;
            this.grp_Filter.Location = new System.Drawing.Point(6, 50);
            this.grp_Filter.Name = "grp_Filter";
            this.grp_Filter.Size = new System.Drawing.Size(729, 69);
            this.grp_Filter.TabIndex = 14;
            this.grp_Filter.TabStop = false;
            this.grp_Filter.Text = "Filter";
            this.grp_Filter.Visible = false;
            // 
            // bttn_Check1
            // 
            this.bttn_Check1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttn_Check1.Location = new System.Drawing.Point(188, 14);
            this.bttn_Check1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Check1.Name = "bttn_Check1";
            this.bttn_Check1.Size = new System.Drawing.Size(76, 40);
            this.bttn_Check1.TabIndex = 9;
            this.bttn_Check1.Text = "Check";
            this.bttn_Check1.UseVisualStyleBackColor = true;
            this.bttn_Check1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(564, 0);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(59, 24);
            this.txt_Size.TabIndex = 2;
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.AllowDrop = true;
            this.cmb_SubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SubCategory.DisplayMember = "sub_category";
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(378, 26);
            this.cmb_SubCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(172, 26);
            this.cmb_SubCategory.TabIndex = 8;
            this.cmb_SubCategory.ValueMember = "SubCategory";
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.AllowDrop = true;
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Category.DisplayMember = "Category";
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(188, 26);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(172, 26);
            this.cmb_Category.TabIndex = 7;
            this.cmb_Category.ValueMember = "Category";
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // bttn_Check
            // 
            this.bttn_Check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttn_Check.Location = new System.Drawing.Point(641, 14);
            this.bttn_Check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Check.Name = "bttn_Check";
            this.bttn_Check.Size = new System.Drawing.Size(76, 22);
            this.bttn_Check.TabIndex = 4;
            this.bttn_Check.Text = "Check";
            this.bttn_Check.UseVisualStyleBackColor = true;
            this.bttn_Check.Click += new System.EventHandler(this.bttn_Check_Click);
            // 
            // cmb_Sorting
            // 
            this.cmb_Sorting.FormattingEnabled = true;
            this.cmb_Sorting.Items.AddRange(new object[] {
            "Category",
            "SubCategory",
            "Size"});
            this.cmb_Sorting.Location = new System.Drawing.Point(6, 26);
            this.cmb_Sorting.Name = "cmb_Sorting";
            this.cmb_Sorting.Size = new System.Drawing.Size(164, 26);
            this.cmb_Sorting.TabIndex = 1;
            this.cmb_Sorting.SelectedIndexChanged += new System.EventHandler(this.cmb_Sorting_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(89, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(64, 18);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Sort By";
            // 
            // cmb_Size
            // 
            this.cmb_Size.DisplayMember = "size";
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(564, 30);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(59, 26);
            this.cmb_Size.TabIndex = 10;
            // 
            // bttn_Excel
            // 
            this.bttn_Excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttn_Excel.Location = new System.Drawing.Point(326, 14);
            this.bttn_Excel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Excel.Name = "bttn_Excel";
            this.bttn_Excel.Size = new System.Drawing.Size(120, 40);
            this.bttn_Excel.TabIndex = 11;
            this.bttn_Excel.Text = "Excel";
            this.bttn_Excel.UseVisualStyleBackColor = true;
            this.bttn_Excel.Click += new System.EventHandler(this.bttn_Excel_Click);
            // 
            // frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(742, 602);
            this.Controls.Add(this.grp_Filter);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Stock";
            this.Text = "frm_Stock";
            this.Load += new System.EventHandler(this.frm_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.grp_Filter.ResumeLayout(false);
            this.grp_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_StockDetail;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.GroupBox grp_Filter;
        private System.Windows.Forms.ComboBox cmb_Sorting;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Button bttn_Check;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.Button bttn_Check1;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Button bttn_Excel;
    }
}