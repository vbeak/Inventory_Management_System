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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }
        BllCategory blc = new BllCategory();
        BLLProduct blp = new BLLProduct();
        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct();
        }

        private void LoadProduct()
        {
            
            DataTable dt = blp.GetAllProduct();
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                    dataGridView1.Rows[i].Cells["colcategoryId"].Value = dt.Rows[i]["categoryId"].ToString();
                    dataGridView1.Rows[i].Cells["colCategoryName"].Value = dt.Rows[i]["categoryName"].ToString();
                    dataGridView1.Rows[i].Cells["colProductId"].Value = dt.Rows[i]["productId"].ToString();
                    dataGridView1.Rows[i].Cells["colProductName"].Value = dt.Rows[i]["ProductName"].ToString();
                    dataGridView1.Rows[i].Cells["colProductPrice"].Value = dt.Rows[i]["ProductPrice"].ToString();
                }
                
                
                
            }
        }

        private void LoadCategory()
        {
            DataTable dt = blc.gellAllCategory();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["CategoryName"] = "Choose Category";
                dt.Rows.InsertAt(dr,0);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = blp.AddProduct(Convert.ToInt32(cmbCategory.SelectedValue.ToString()),txtProduct.Text,Convert.ToDecimal(txtPrice.Text));
            if (i > 0)
            {
                LoadProduct();
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show("Something Wrong Happen,Please Insert Again !");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want Update Details? This will Change your Stock,Sales and Purchased Details too?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int i = blp.UpdateProduct(Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtProduct.Text, Convert.ToDecimal(txtPrice.Text), id);
                if (i > 0)
                {
                    MessageBox.Show("Product Detail Updated");
                    LoadProduct();
                }
            }
            else
            {
                txtProduct.Clear();
                txtProduct.Focus();
                txtPrice.Clear();
                btnAdd.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Delete This Product? It will Erase your stock,sales and purchased details.","Make Sure",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
            int i = blp.DeleteProduct(id);
            if (i > 0)
            {
                
                MessageBox.Show("Product Details Deleted");
                LoadProduct();
            }
            else
            {
                 MessageBox.Show("You Can not Delete This Product");
            }
            
            }
            else
            {
                txtProduct.Clear();
                txtProduct.Focus();
                txtPrice.Clear();
                btnAdd.Enabled=true;
            }
            

        }
        int id = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id=Convert.ToInt32(dataGridView1.CurrentRow.Cells["colProductId"].Value);
            cmbCategory.Text = dataGridView1.CurrentRow.Cells["colCategoryName"].Value.ToString();
            txtProduct.Text = dataGridView1.CurrentRow.Cells["colProductName"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["colProductPrice"].Value.ToString();
            btnAdd.Enabled = false;
        }
    }
}
