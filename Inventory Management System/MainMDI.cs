using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainMDI : Form
    {
        public MainMDI()
        {
            InitializeComponent();
            lblUsername.Text = Program.username;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            }

        private void newItemPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Purchased_Item newProductForm = new Add_New_Purchased_Item();
            newProductForm.Show();
            newProductForm.MdiParent = this;
        }

        private void showAllItemPurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddItemCategory addCategory = new AddItemCategory();
            addCategory.Show();
            addCategory.MdiParent = this;
        }

        private void addNewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct addproduct = new AddNewProduct();
            addproduct.Show();
            addproduct.MdiParent = this;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPanel Up = new UserPanel();
            Up.Show();
            Up.MdiParent = this;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMDI mdi = new MainMDI();
            LogOut lgo = new LogOut();
            lgo.Show();
            lgo.MdiParent = this;
            

        }
    }
}
