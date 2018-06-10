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
        Receipt rcp = new Receipt();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SoldItems_Load(object sender, EventArgs e)
        {
            
            LoadCategory();
            NewInvoice();

            receiptBindingSource1.DataSource = new List<Receipt>();// init Empty List
        }

        private void NewInvoice()
        {
            DataTable dt = bli.getInvoice();
            if (dt.Rows.Count > 0)
            {
                string str = dt.Rows[0]["invoice_No"].ToString();
                string[] stararr = str.Split('-');
                string stdigit = (Convert.ToInt32(stararr[1]) + 1).ToString();
                txtInvoice.Text = stararr[0] + "-" + stdigit.ToString();
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
        public int i = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtSubTotal.Text))
            {
                Receipt obj = new Receipt()
                {
                    sn = i++,
                    categoryId = Convert.ToInt32(cmbCategory.SelectedValue.ToString()),
                    categoryname = cmbCategory.Text,
                    productId = Convert.ToInt32(cmbProductName.SelectedValue.ToString()),
                    productName = cmbProductName.Text,
                    price = Convert.ToDecimal(txtPrice.Text),
                    quantity = Convert.ToInt32(txtQuantity.Text),
                    total = Convert.ToDecimal(txtSubTotal.Text)
                };

                receiptBindingSource1.Add(obj);
                receiptBindingSource1.MoveLast();
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                
            }
            
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
            //dataGridView1.Rows[i].Cells["colCategoryId"].Value = cmbCategory.SelectedValue.ToString();
            //dataGridView1.Rows[i].Cells["colCategoryName"].Value = cmbCategory.Text;
            //dataGridView1.Rows[i].Cells["colProductId"].Value = cmbProductName.SelectedValue.ToString();
            //dataGridView1.Rows[i].Cells["colProductName"].Value = cmbProductName.Text;
            //dataGridView1.Rows[i].Cells["colProductPrice"].Value = txtPrice.Text;
            //dataGridView1.Rows[i].Cells["colQuantity"].Value = txtQuantity.Text;
            //dataGridView1.Rows[i].Cells["colSubTotal"].Value = txtSubTotal.Text;
            //i++;

            Decimal total = 0m;
            total = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtSubTotal.Text);
            txtTotal.Text = total.ToString();
            txtSubTotal.Text = string.Empty;
            MathOp(total);
        }

        private void MathOp(Decimal total)
        {
            Decimal ExciseDuty = Convert.ToDecimal(txtTotal.Text) * 7 / 100;
            txtExciseDuty.Text = ExciseDuty.ToString();
            Decimal TaxableAmount = total + ExciseDuty;
            txtTaxableAmount.Text = TaxableAmount.ToString();
            if (txtDiscountPercent.Text =="")
            {
                MessageBox.Show("Add Discount % First");
                dataGridView1.Rows.Clear();
                txtTotal.Text = "0.00";
                txtTaxableAmount.Clear();
                txtVat.Clear();
                txtGrandTotal.Clear();
                txtDiscount.Clear();
                txtExciseDuty.Clear();
                txtAfterDiscount.Clear();
            }
            else
            {

                Decimal discount = TaxableAmount * Convert.ToDecimal(txtDiscountPercent.Text) / 100;
                txtDiscount.Text = discount.ToString();
                Decimal afterDiscount = TaxableAmount - discount;
                txtAfterDiscount.Text = afterDiscount.ToString();
                Decimal vat = afterDiscount * 13 / 100;
                txtVat.Text = vat.ToString();
                Decimal grandTotal = afterDiscount + vat;
                txtGrandTotal.Text = grandTotal.ToString();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text!="")
            {

            int s=bli.CreateInvoice(txtInvoice.Text, Convert.ToDateTime(toolStripStatusLabel2.Text), txtCustomerName.Text, Convert.ToDecimal(txtGrandTotal.Text));
            if (s > 0)
            {

                int k = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    int categoryId = Convert.ToInt32(dataGridView1.Rows[i].Cells["categoryIdDataGridViewTextBoxColumn"].Value); //obj.categoryId;
                    int productId = Convert.ToInt32(dataGridView1.Rows[i].Cells["productIdDataGridViewTextBoxColumn"].Value);
                    string productName = dataGridView1.Rows[i].Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["quantityDataGridViewTextBoxColumn"].Value);
                    decimal total = Convert.ToInt32(dataGridView1.Rows[i].Cells["totalDataGridViewTextBoxColumn"].Value);
                    //string date = dataGridView1.Rows[i].Cells["colDate"].Value.ToString();

                    DataTable dt = blst.getQuantityByProductId(productId);
                    if (dt.Rows.Count > 0)
                    {
                        int stockQuantity = Convert.ToInt32(dt.Rows[0]["Quantity"].ToString());
                        int up = blst.UpdateQuantityByProductId(productId, stockQuantity - quantity);
                    }
                    else
                    {
                        MessageBox.Show("Product " + productId + "Out Of Stuck");
                        //int ins= blst.insertIntoTblStock(productId,quantity);
                    }
                    Decimal ExciseDuty = total * 7 / 100;
                    Decimal TaxableAmount = total + ExciseDuty;
                    Decimal discount = TaxableAmount * Convert.ToDecimal(txtDiscountPercent.Text) / 100;
                    Decimal afterDiscount = TaxableAmount - discount;
                    Decimal vat = afterDiscount * 13 / 100;
                    Decimal grandTotal = afterDiscount + vat;
                    k += bls.AddNewSalesItem(txtInvoice.Text, categoryId, productId, productName, quantity, total, ExciseDuty,discount, vat, grandTotal, Program.username, toolStripStatusLabel2.Text, txtCustomerName.Text);


                }
                if (k > 0)
                {
                    MessageBox.Show("Total Sales Item # " + k + " Added");
                }
            }
            dataGridView1.Rows.Clear();
            NewInvoice();
                
            }
            else
            {
                MessageBox.Show("Please Provide Customer Name");
            }
            

            
        }

        private void btnPrintSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtAddress.Text!="")
            {
                using (Printcs printForm = new Printcs(receiptBindingSource1.DataSource as List<Receipt>, txtTotal.Text, txtExciseDuty.Text,txtDiscount.Text, txtVat.Text, txtGrandTotal.Text, txtInvoice.Text, toolStripStatusLabel2.Text, txtCustomerName.Text,txtAddress.Text))
                {
                     printForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Customer Name and Address Field");
            }
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
                Receipt obj = receiptBindingSource1.Current as Receipt;
                if (obj != null)
                {
                    Decimal total = (Convert.ToDecimal(txtTotal.Text) - obj.total);
                    txtTotal.Text = total.ToString();
                    MathOp(total);
                }

                receiptBindingSource1.RemoveCurrent();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
