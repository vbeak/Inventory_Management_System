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
                MessageBox.Show("Item Category Added");
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


    }
}
