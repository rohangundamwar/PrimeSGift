using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;
using PrimeSolutions.ClassFile;

namespace PrimeSolutions.Report
{
    public partial class frm_Stock : Form
    {
        public frm_Stock()
        {
            InitializeComponent();
        }
        clsCommon _common = new clsCommon();
        AllClassFile _objstock = new AllClassFile();
        
        private void frm_Stock_Load(object sender, EventArgs e)
        {
            dgv_stock.Rows.Clear();
            stock();
            bttn_Check1.Visible = true;
        }

        private void stock()
        {
            string category;
            category = cmb_Category.Text;
            DataTable dt = _objstock.GetStockAll(category);
            DataTable dt3 = _objstock.GetCategory();
            DataTable dt1 = new DataTable(); //SubCategory
            DataTable dt2 = new DataTable(); // Size
            string a, b;
            int x = 0, gcount = 0;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                dt1 = _objstock.GetSubCategoryByCategory(dt3.Rows[i]["category"].ToString());
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    dt2 = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                    for (int k = 0; k < dt2.Rows.Count; k++)
                    {
                        dgv_stock.Rows.Add();
                        x = x + 1;
                        dgv_stock.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                        dgv_stock.Rows[gcount].Cells["Category"].Value = dt3.Rows[i]["category"].ToString();
                        dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[j]["sub_category"].ToString();
                        DataTable X = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                        dgv_stock.Rows[gcount].Cells["Size"].Value = X.Rows[k]["size"].ToString();
                        DataTable Q = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());

                        if (Q.Rows.Count > 0)
                        {
                            a = Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), X.Rows[k]["size"].ToString(), dt1.Rows[j]["PurchaseBill"].ToString()));
                            dgv_stock.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                        }
                        else
                        {
                            a = Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), "", dt1.Rows[j]["PurchaseBill"].ToString()));
                            dgv_stock.Rows[gcount].Cells["Quantity"].Value = a;
                        }
                        gcount = gcount + 1;
                    }

                }

            }
        }
        private void Fillgrid()
        {
           
            DataTable dt1 = _objstock.GetSubCategory();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
               
                dgv_stock.Rows.Add();
                int gcount = Convert.ToInt32(this.dgv_stock.Rows.Count);
                gcount = gcount - 1;
                dgv_stock.Rows[gcount].Cells["Srno"].Value = i + 1;
                dgv_stock.Rows[gcount].Cells["Category"].Value = _objstock.GetCategory(dt1.Rows[i]["sub_category"].ToString());
                dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[i]["sub_category"].ToString();
                dgv_stock.Rows[gcount].Cells["Size"].Value = _objstock.GetSize(dt1.Rows[i]["sub_category"].ToString());
                dgv_stock.Rows[gcount].Cells["Quantity"].Value = _objstock.getQty(dt1.Rows[i]["sub_category"].ToString());
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmb_Sorting.Text == "Category")
            {
                cmb_Category.Visible = true;
                cmb_SubCategory.Visible = false;
                txt_Size.Visible = false;
                cmb_Category.DataSource = _common.GetCategory();
                
               
            }
            else if (cmb_Sorting.Text == "SubCategory")
            {
                cmb_Category.Visible = false;
                cmb_SubCategory.Visible = true;
                txt_Size.Visible = false;
                cmb_SubCategory.DataSource = _common.GetSubCategory();
            }
            else if (cmb_Sorting.Text=="Size")
            {
                cmb_Category.Visible = false;
                cmb_SubCategory.Visible = false;
                txt_Size.Visible = true;
            }
        }

        private void bttn_Check_Click(object sender, EventArgs e)
        {
            dgv_stock.Rows.Clear();
            int j = 0;
            if (cmb_Sorting.Text == "Category" && cmb_Category.Text != "")
            {
                DataTable dt = _objstock.getStockByCategory(cmb_Category.Text);
                DataTable dt1 = _objstock.GetSubCategoryByCategory(cmb_Category.Text); 
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    j = j + 1;
                    dgv_stock.Rows.Add();
                    int gcount = Convert.ToInt32(this.dgv_stock.Rows.Count);
                    gcount = gcount - 1;
                    dgv_stock.Rows[gcount].Cells["Srno"].Value = j;
                    dgv_stock.Rows[gcount].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                    dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[i]["sub_category"].ToString();
                    dgv_stock.Rows[gcount].Cells["Size"].Value = _objstock.GetSize(dt1.Rows[i]["sub_category"].ToString());
                    dgv_stock.Rows[gcount].Cells["Quantity"].Value = _objstock.getQty(dt1.Rows[i]["sub_category"].ToString());
                }

            }
            else if (cmb_Sorting.Text == "SubCategory" && cmb_SubCategory.Text != "")
            {
                DataTable dt = _objstock.getStockBySubCategory(cmb_SubCategory.Text);
                DataTable dt1 = _objstock.GetCategoryBySubCategory(cmb_SubCategory.Text);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    j = j + 1;
                    dgv_stock.Rows.Add();
                    int gcount = Convert.ToInt32(this.dgv_stock.Rows.Count);
                    gcount = gcount - 1;
                    dgv_stock.Rows[gcount].Cells["Srno"].Value = j;
                    dgv_stock.Rows[gcount].Cells["Category"].Value = dt1.Rows[i]["category"].ToString();
                    dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[i]["sub_category"].ToString();
                    dgv_stock.Rows[gcount].Cells["Size"].Value = _objstock.GetSize(dt1.Rows[i]["sub_category"].ToString());
                    dgv_stock.Rows[gcount].Cells["Quantity"].Value = _objstock.getQty(dt1.Rows[i]["sub_category"].ToString());
                }
            }
            else if (cmb_Sorting.Text == "Size" && txt_Size.Text != "")
            {
                DataTable dt = _objstock.getStockBySize(txt_Size.Text);
                DataTable dt1 = _objstock.GetAllBySize(txt_Size.Text);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {

                    dgv_stock.Rows.Add();
                    int gcount = Convert.ToInt32(this.dgv_stock.Rows.Count);
                    gcount = gcount - 1;
                    dgv_stock.Rows[gcount].Cells["Srno"].Value = j + 1;
                    dgv_stock.Rows[gcount].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                    dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[i]["sub_category"].ToString();
                    dgv_stock.Rows[gcount].Cells["Size"].Value = _objstock.GetSize(dt1.Rows[i]["sub_category"].ToString());
                    dgv_stock.Rows[gcount].Cells["Quantity"].Value = _objstock.getQty(dt1.Rows[i]["sub_category"].ToString());
                }

            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_stock.Rows.Clear();
            string category="", subcategory="", size="",quantity="";
            DataTable dt;
            //AllSelected
            if ( cmb_Category.Text!="" && cmb_SubCategory.Text!= "" && cmb_Size.Text != "")
            {
                category = cmb_Category.Text;
                subcategory = cmb_SubCategory.Text;
                size = cmb_Size.Text;

                dt = _objstock.GetStockAll(category, subcategory, size);
                dgv_stock.Rows.Add();
                quantity = (_objstock.getQty(category, subcategory, size,"")).ToString();
                dgv_stock.Rows[0].Cells["Quantity"].Value = quantity ;

            }

            //Category Selected
            if (cmb_Category.Text!="" && cmb_SubCategory.Text == "" && cmb_Size.Text == "")
            {
                category = cmb_Category.Text;
                dt = _objstock.GetStockAll(category);
                DataTable dt1 = _objstock.GetSubCategoryByCategory(cmb_Category.Text);
                DataTable dt2 = _objstock.GetSizeByCatAndSubCat(cmb_Category.Text,cmb_SubCategory.Text);
                string a, b;
                int x=0;
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        for (int k = 0; k < dt.Rows.Count; k++)
                        {
                            dgv_stock.Rows[0].Cells["SrNo"].Value = x+1;
                            dgv_stock.Rows[i].Cells["SubCategory"].Value = dt1.Rows[i]["sub_category"].ToString();
                            dgv_stock.Rows[j].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                            dgv_stock.Rows[k].Cells["Size"].Value = _objstock.GetSizeByCatAndSubCat(dt.Rows[i]["category"].ToString(), dt.Rows[i]["category"].ToString());

                        }

                    }

                }

            }

            //CAtegory and SubCategory Selected
            if (cmb_Category.Text != "" && cmb_SubCategory.Text != "" && cmb_Size.Text == "")
            {
                category = cmb_Category.Text;
                dt = _objstock.GetStockAll(category);
                DataTable dt3 = _objstock.GetCategory();
                DataTable dt1 = new DataTable(); //SubCategory
                DataTable dt2 = new DataTable(); // Size
                string a, b;
                int x = 0,gcount=0;

                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    dt1 = _objstock.GetSubCategoryByCategory(dt3.Rows[i]["category"].ToString());
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        dt2 = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                        for (int k = 0; k < dt2.Rows.Count; k++)
                        {
                            dgv_stock.Rows.Add();
                            x = x + 1;
                            dgv_stock.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                            dgv_stock.Rows[gcount].Cells["Category"].Value = dt3.Rows[i]["category"].ToString();
                            dgv_stock.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[j]["sub_category"].ToString();
                            DataTable X= _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                            dgv_stock.Rows[gcount].Cells["Size"].Value = X.Rows[k]["size"].ToString();
                            DataTable Q = _objstock.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                            
                                if (Q.Rows.Count > 0)
                            {
                                a= Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), X.Rows[k]["size"].ToString(),""));
                                dgv_stock.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                            }
                            else
                            {
                                a= Convert.ToString(_objstock.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), "",""));
                                dgv_stock.Rows[gcount].Cells["Quantity"].Value = a;
                            }
                            gcount = gcount + 1;
                        }

                    }

                }

            }

            //SubCategory Selected

            if (cmb_Category.Text == "" && cmb_SubCategory.Text != "" && txt_Size.Text == "")
            {
                category = cmb_Category.Text;
                subcategory = cmb_SubCategory.Text;
                dt = _objstock.GetStockAll(subcategory,"","","");
            }
            
            dt = _objstock.GetStockAll(category,subcategory,size);

        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SubCategory.DataSource = _objstock.GetSubCategory(cmb_Category.Text);
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Size.DataSource = _objstock.GetSizeByCatAndSubCat(cmb_Category.Text, cmb_SubCategory.Text);
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {

        }
    }
}

