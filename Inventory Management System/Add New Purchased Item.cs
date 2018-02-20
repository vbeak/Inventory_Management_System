using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Inventory_Management_System
{
    public partial class Add_New_Purchased_Item : Form
    {
        public Add_New_Purchased_Item()
        {
            InitializeComponent();
        }
        BllCategory blc = new BllCategory();
        BLLProduct blp = new BLLProduct();
        BLLInvoice bli = new BLLInvoice();
        BLLpurchase blphs = new BLLpurchase();

        private void Add_New_Purchased_Item_Load(object sender, EventArgs e)
        {
            LoadCategory();
            DataTable dt = bli.getInvoice();
            if (dt.Rows.Count > 0)
            {
                string str = dt.Rows[0]["invoice_No"].ToString();
                string[] stararr = str.Split('-');
                string stdigit = (Convert.ToInt32(stararr[1]) + 1).ToString();
                txtInvoice.Text = stararr[0] + "-"+stdigit.ToString();
            }
            else
            {
                txtInvoice.Text = "INV-1";
            }
            toolStripStatusLabel4.Text = Program.username;
            
        }

        private void LoadCategory()
        {
            DataTable dt = blc.gellAllCategory();
            if (dt.Rows.Count > 0)
            {
                
                DataRow dr = dt.NewRow();
                dr["CategoryName"] = "Choose Category";
                dt.Rows.InsertAt(dr, 0);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != 0)
            {
                DataTable dt = blp.getProductbyCategoryId(Convert.ToInt32(cmbCategory.SelectedValue.ToString()));
                
                    
                    DataRow dr = dt.NewRow();
                    dr["ProductName"] = "Choose Product";
                    dt.Rows.InsertAt(dr, 0);
                    cmbProductName.DataSource = dt;
                    cmbProductName.DisplayMember = "ProductName";
                    cmbProductName.ValueMember = "ProductId";
                
            }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProductName.SelectedIndex!=0)
            {
            DataTable dt = blp.getProductbyProductId(Convert.ToInt32(cmbProductName.SelectedValue.ToString()));
           txtProductPrice.Text = dt.Rows[0]["ProductPrice"].ToString();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQuantity.Text.Length > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal Total = Convert.ToDecimal(txtProductPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
                    txtTotal.Text = Total.ToString();
                    btnAdd.Select();
                }
            }
        }
        int i = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
            dataGridView1.Rows[i].Cells["colCategoryId"].Value = cmbCategory.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colCategoryName"].Value = cmbCategory.Text;
            dataGridView1.Rows[i].Cells["colProductId"].Value = cmbProductName.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colProductName"].Value = cmbProductName.Text;
            dataGridView1.Rows[i].Cells["colProductPrice"].Value = txtProductPrice.Text;
            dataGridView1.Rows[i].Cells["colQuantity"].Value = txtQuantity.Text;
            dataGridView1.Rows[i].Cells["colTotal"].Value = txtTotal.Text;
            dataGridView1.Rows[i].Cells["colUser"].Value = toolStripStatusLabel4.Text;
            dataGridView1.Rows[i].Cells["colDate"].Value = toolStripStatusLabel2.Text;
            i++;

            decimal total = 0m;
            total =Convert.ToDecimal(txtGrandTotal.Text)+ Convert.ToDecimal(txtTotal.Text);
            txtGrandTotal.Text = total.ToString();
            txtTotal.Clear();
            cmbCategory.Select();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                int categoryId=Convert.ToInt32(dataGridView1.Rows[i].Cells["colCategoryId"].Value);
                int productId=Convert.ToInt32(dataGridView1.Rows[i].Cells["colProductId"].Value);
                int quantity =Convert.ToInt32(dataGridView1.Rows[i].Cells["colQuantity"].Value);
                decimal total=Convert.ToDecimal(dataGridView1.Rows[i].Cells["colTotal"].Value);
                string date=dataGridView1.Rows[i].Cells["colDate"].Value.ToString();

                k += blphs.AddPurchase(txtInvoice.Text,categoryId,productId,quantity,total,date);

                if (k > 0)
                {
                    MessageBox.Show("Total purchased Item #" +k +" Added");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                txtGrandTotal.Text = (Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(dr.Cells["colTotal"].Value.ToString())).ToString();
                dr.DataGridView.Rows.Remove(dr);
            }
        }
    }
}
