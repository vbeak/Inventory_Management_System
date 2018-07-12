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
            allpurchased displayAllItems = new allpurchased();
            displayAllItems.Show();
            displayAllItems.MdiParent = this;
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
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want to Logout?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainMDI mainForm = new MainMDI();
                Form1 Login = new Form1();
                MainMDI.ActiveForm.Dispose();
                Program.username = "";
                Login.Show();
                


            }
            
            

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void showAllStockItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock allStock = new Stock();
            allStock.Show();
            allStock.MdiParent = this;
        }

        private void addNewSoldItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoldItems newSold = new SoldItems();
            newSold.Show();
            newSold.MdiParent = this;
        }

        private void showAllSoldItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSoldItems alsi = new AllSoldItems();
            alsi.Show();
            alsi.MdiParent = this;
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersDetail userDetails = new UsersDetail();
            userDetails.Show();
            userDetails.MdiParent = this;
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {

        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPanel Up = new UserPanel();
            Up.Show();
            Up.MdiParent = this;
        }

        private void MainMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void MainMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
               
            }
            else
            {
                
            }
        }
    }
}
