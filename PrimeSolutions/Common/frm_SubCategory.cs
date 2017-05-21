﻿using PrimeSolutions.ClassFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class frm_SubCategory : Form
    {
        public frm_SubCategory()
        {
            InitializeComponent();
        }
        AllClassFile _objCustmor = new AllClassFile();
        private void frm_Category_Load(object sender, EventArgs e)
        {
            txt_SubCategory.Select();
            FillGrid();
            bttn_Update.Enabled = false;
            bttn_Delete.Enabled = false;
            lbl_SrNo.ResetText();
            txt_SubCategory.ResetText();
        }

        private void FillGrid()
        {
            DataTable dt = _objCustmor.GetSubCategory();
             for (int i =0; i < dt.Rows.Count;i++)
                {
                    dgv_SubCategory.Rows.Add();
                    dgv_SubCategory.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["SubCategory"].ToString();
                    dgv_SubCategory.Rows[i].Cells["SrNo"].Value = dt.Rows[i]["SrNo"].ToString();
                   
                }
           
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {
                _objCustmor.InsertSubCategory(txt_SubCategory.Text);
                dgv_SubCategory.Rows.Clear();
                FillGrid();
                txt_SubCategory.Select();
                txt_SubCategory.ResetText();
            }
            else
            {
                MessageBox.Show("Insert Category");
            }
        }

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bttn_Update.Enabled = true;
                bttn_Delete.Enabled = true;
                bttn_Add.Enabled = false;
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    lbl_SrNo.Text = dgv_SubCategory.Rows[dgv_SubCategory.CurrentRow.Index].Cells["SrNo"].Value.ToString();
                    txt_SubCategory.Text = dgv_SubCategory.Rows[dgv_SubCategory.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
               
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {
                _objCustmor.updateSubCategory(lbl_SrNo.Text, txt_SubCategory.Text);
                dgv_SubCategory.Rows.Clear();
                FillGrid();
                txt_SubCategory.ResetText();
                lbl_SrNo.ResetText();
                MessageBox.Show("Update SuccessFully");
            }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_SubCategory.Text != "")
            {

                _objCustmor.DeleteSubCategory(lbl_SrNo.Text);
            dgv_SubCategory.Rows.Clear();
            FillGrid();
            txt_SubCategory.ResetText();
            lbl_SrNo.ResetText();
            MessageBox.Show("Deleted SuccessFully");
            }
        }

        private void frm_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}