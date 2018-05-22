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
    public partial class AddItemCategory : Form
    {
        public AddItemCategory()
        {
            InitializeComponent();
        }
        BllCategory blcat = new BllCategory();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = blcat.AddCategory(txtAddCategory.Text);
            if (i > 0)
            {
                loadCategory();
                MessageBox.Show("Product Category Added");
            }
            else
            {
                MessageBox.Show("Some Error Occured, Try Again");
            }
           
        }

        private void AddItemCategory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void loadCategory()
        {
            DataTable dt = blcat.gellAllCategory();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update This Category ?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int i = blcat.UpdateCategory(txtAddCategory.Text, id);
                if (i > 0)
                {
                    MessageBox.Show("Category Updated");
                    loadCategory();
                }
                else
                {
                    txtAddCategory.Clear();
                    txtAddCategory.Focus();
                    btnAdd.Enabled = true;
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete This Product Category?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //do something
                
                int i = blcat.DeleteCategory(id);
                if (i > 0)
                {
                    MessageBox.Show("Category Deleted Successfully");
                    loadCategory();
                }

            }
            else
            {
                txtAddCategory.Clear();
                txtAddCategory.Focus();
                btnAdd.Enabled = true;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCategory();
        }
        int id = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            id= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtAddCategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }


    }
}
