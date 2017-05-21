namespace PrimeSolutions.Common
{
    partial class frm_BarcodePrint
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
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.rbt_CustomeSelect = new System.Windows.Forms.RadioButton();
            this.rbt_SellectAll = new System.Windows.Forms.RadioButton();
            this.dgv_BarcodeDetail = new System.Windows.Forms.DataGridView();
            this.bttn_View = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BarcodeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Date
            // 
            this.pnl_Date.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Date.Controls.Add(this.bttn_View);
            this.pnl_Date.Controls.Add(this.rbt_SellectAll);
            this.pnl_Date.Controls.Add(this.rbt_CustomeSelect);
            this.pnl_Date.Controls.Add(this.lbl_EndDate);
            this.pnl_Date.Controls.Add(this.lbl_StartDate);
            this.pnl_Date.Controls.Add(this.dtp_End);
            this.pnl_Date.Controls.Add(this.dtp_Start);
            this.pnl_Date.Location = new System.Drawing.Point(3, 5);
            this.pnl_Date.Name = "pnl_Date";
            this.pnl_Date.Size = new System.Drawing.Size(434, 60);
            this.pnl_Date.TabIndex = 0;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(77, 7);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(95, 20);
            this.dtp_Start.TabIndex = 0;
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(77, 33);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(95, 20);
            this.dtp_End.TabIndex = 1;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(10, 8);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StartDate.TabIndex = 2;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(10, 39);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_EndDate.TabIndex = 3;
            this.lbl_EndDate.Text = "End Date";
            // 
            // bttn_Print
            // 
            this.bttn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.Green;
            this.bttn_Print.Location = new System.Drawing.Point(379, 489);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 23);
            this.bttn_Print.TabIndex = 1;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            // 
            // rbt_CustomeSelect
            // 
            this.rbt_CustomeSelect.AutoSize = true;
            this.rbt_CustomeSelect.BackColor = System.Drawing.SystemColors.Control;
            this.rbt_CustomeSelect.ForeColor = System.Drawing.Color.Black;
            this.rbt_CustomeSelect.Location = new System.Drawing.Point(190, 36);
            this.rbt_CustomeSelect.Name = "rbt_CustomeSelect";
            this.rbt_CustomeSelect.Size = new System.Drawing.Size(93, 17);
            this.rbt_CustomeSelect.TabIndex = 349;
            this.rbt_CustomeSelect.Text = "Custom Select";
            this.rbt_CustomeSelect.UseVisualStyleBackColor = false;
            // 
            // rbt_SellectAll
            // 
            this.rbt_SellectAll.AutoSize = true;
            this.rbt_SellectAll.BackColor = System.Drawing.SystemColors.Control;
            this.rbt_SellectAll.ForeColor = System.Drawing.Color.Black;
            this.rbt_SellectAll.Location = new System.Drawing.Point(190, 11);
            this.rbt_SellectAll.Name = "rbt_SellectAll";
            this.rbt_SellectAll.Size = new System.Drawing.Size(69, 17);
            this.rbt_SellectAll.TabIndex = 350;
            this.rbt_SellectAll.Text = "Select All";
            this.rbt_SellectAll.UseVisualStyleBackColor = false;
            // 
            // dgv_BarcodeDetail
            // 
            this.dgv_BarcodeDetail.AllowUserToAddRows = false;
            this.dgv_BarcodeDetail.AllowUserToDeleteRows = false;
            this.dgv_BarcodeDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BarcodeDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_BarcodeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BarcodeDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.SrNo,
            this.Barcode,
            this.Category,
            this.SubCategory,
            this.PurchaseAmt,
            this.SellingAmt,
            this.Qty,
            this.Total});
            this.dgv_BarcodeDetail.Location = new System.Drawing.Point(3, 71);
            this.dgv_BarcodeDetail.Name = "dgv_BarcodeDetail";
            this.dgv_BarcodeDetail.ReadOnly = true;
            this.dgv_BarcodeDetail.Size = new System.Drawing.Size(800, 412);
            this.dgv_BarcodeDetail.TabIndex = 1;
            // 
            // bttn_View
            // 
            this.bttn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_View.ForeColor = System.Drawing.Color.Blue;
            this.bttn_View.Location = new System.Drawing.Point(308, 20);
            this.bttn_View.Name = "bttn_View";
            this.bttn_View.Size = new System.Drawing.Size(75, 23);
            this.bttn_View.TabIndex = 351;
            this.bttn_View.Text = "View";
            this.bttn_View.UseVisualStyleBackColor = true;
            this.bttn_View.Click += new System.EventHandler(this.bttn_View_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.ForeColor = System.Drawing.Color.Red;
            this.bttn_Close.Location = new System.Drawing.Point(470, 486);
            this.bttn_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(76, 28);
            this.bttn_Close.TabIndex = 24;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // Chk
            // 
            this.Chk.HeaderText = "Chk";
            this.Chk.Name = "Chk";
            this.Chk.ReadOnly = true;
            this.Chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
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
            // PurchaseAmt
            // 
            this.PurchaseAmt.HeaderText = "PurchaseAmt";
            this.PurchaseAmt.Name = "PurchaseAmt";
            this.PurchaseAmt.ReadOnly = true;
            // 
            // SellingAmt
            // 
            this.SellingAmt.HeaderText = "SellingAmt";
            this.SellingAmt.Name = "SellingAmt";
            this.SellingAmt.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // frm_BarcodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.dgv_BarcodeDetail);
            this.Controls.Add(this.pnl_Date);
            this.Controls.Add(this.bttn_Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BarcodePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Print";
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BarcodeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Date;
        private System.Windows.Forms.Button bttn_View;
        private System.Windows.Forms.RadioButton rbt_SellectAll;
        private System.Windows.Forms.RadioButton rbt_CustomeSelect;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.DataGridView dgv_BarcodeDetail;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}