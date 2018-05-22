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
    public partial class SoldItems : Form
    {
        public SoldItems()
        {
            InitializeComponent();
        }

        BllCategory blc = new BllCategory();
        BLLProduct blp = new BLLProduct();
        BLLInvoice bli = new BLLInvoice();
        BLLStock blst = new BLLStock();
        BLLsales bls = new BLLsales();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SoldItems_Load(object sender, EventArgs e)
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

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedIndex != 0)
            {
                DataTable dt = blp.getProductbyProductId(Convert.ToInt32(cmbProductName.SelectedValue.ToString()));
                txtPrice.Text = dt.Rows[0]["ProductPrice"].ToString();
                txtQuantity.Focus();
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

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQuantity.Text.Length > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal subTotal = Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
                    txtSubTotal.Text = subTotal.ToString();
                    btnAdd.Select();
                }
            }
        }
        public int i = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
            dataGridView1.Rows[i].Cells["colCategoryId"].Value = cmbCategory.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colCategoryName"].Value = cmbCategory.Text;
            dataGridView1.Rows[i].Cells["colProductId"].Value = cmbProductName.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colProductName"].Value = cmbProductName.Text;
            dataGridView1.Rows[i].Cells["colProductPrice"].Value = txtPrice.Text;
            dataGridView1.Rows[i].Cells["colQuantity"].Value = txtQuantity.Text;
            dataGridView1.Rows[i].Cells["colSubTotal"].Value = txtSubTotal.Text;
            i++;

            Decimal total = 0m;
            total = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtSubTotal.Text);
            txtTotal.Text = total.ToString();

            MathOp(total);
        }

        private void MathOp(Decimal total)
        {
            Decimal ExciseDuty = Convert.ToDecimal(txtTotal.Text) * 5 / 100;
            txtExciseDuty.Text = ExciseDuty.ToString();
            Decimal TaxableAmount = total + ExciseDuty;
            txtTaxableAmount.Text = TaxableAmount.ToString();
            Decimal vat = TaxableAmount * 13 / 100;
            txtVat.Text = vat.ToString();
            Decimal grandTotal = TaxableAmount + vat;
            txtGrandTotal.Text = grandTotal.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int s=bli.CreateInvoice(txtInvoice.Text, Convert.ToDateTime(toolStripStatusLabel2.Text), txtCustomerName.Text, Convert.ToDecimal(txtGrandTotal.Text));
            if (s > 0)
            {

                int k = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    int categoryId = Convert.ToInt32(dataGridView1.Rows[i].Cells["colCategoryId"].Value);
                    int productId = Convert.ToInt32(dataGridView1.Rows[i].Cells["colProductId"].Value);
                    string productName = dataGridView1.Rows[i].Cells["colProductName"].Value.ToString();
                    int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["colQuantity"].Value);
                    decimal total = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colSubTotal"].Value);
                    //string date = dataGridView1.Rows[i].Cells["colDate"].Value.ToString();

                    DataTable dt = blst.getQuantityByProductId(productId);
                    if (dt.Rows.Count > 0)
                    {
                        int stockQuantity = Convert.ToInt32(dt.Rows[0]["Quantity"].ToString());
                        int up = blst.UpdateQuantityByProductId(productId, stockQuantity - quantity);
                    }
                    else
                    {
                        MessageBox.Show("Product "+productId + "Out Of Stuck");
                        //int ins= blst.insertIntoTblStock(productId,quantity);
                    }
                    Decimal ExciseDuty = total * 5 / 100;
                    Decimal TaxableAmount = total + ExciseDuty;
                    Decimal vat = TaxableAmount * 13 / 100;
                    Decimal grandTotal = TaxableAmount + vat;
                    k += bls.AddNewSalesItem(txtInvoice.Text, categoryId, productId,productName,quantity,total,ExciseDuty,vat,grandTotal,Program.username,toolStripStatusLabel2.Text,txtCustomerName.Text);

                    
                }
                if (k > 0)
                {
                    MessageBox.Show("Total Sales Item #" + k + " Sold");
                }
            }

            dataGridView1.Rows.Clear();
        }

        private void btnPrintSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SoldItems sItem = new SoldItems();
            if (MessageBox.Show("Are you sure you want to cancel?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //do something
                this.Close();
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    Decimal total = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(dr.Cells["colSubTotal"].Value.ToString()));
                    txtTotal.Text = total.ToString();
                    MathOp(total);
                    dr.DataGridView.Rows.Remove(dr);
                }
            }
        }
    }
}
