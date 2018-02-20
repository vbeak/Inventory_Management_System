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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MainMDI mdi = new MainMDI();
            Form1 login = new Form1();
            Program.username = "";
            mdi.Dispose();

            login.Show();
            this.Close();

            
        }
    }
}
