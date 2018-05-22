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
    public partial class allpurchased : Form
    {
        public allpurchased()
        {
            InitializeComponent();
        }
        BLLpurchase blp = new BLLpurchase();
        private void allpurchased_Load(object sender, EventArgs e)
        {
            DataTable dt = blp.SelectAllPurchasedItems();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            else
            {
                MessageBox.Show("No Items To Display");
            }
        }
    }
}
