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
    public partial class UsersDetail : Form
    {
        public UsersDetail()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        BLLRoles blr = new BLLRoles();
        private void UsersDetail_Load(object sender, EventArgs e)
        {
            GetUserId();
        }

        private void GetUserId()
        {
            txtUsername.Text = Program.username;
            DataTable dt = blu.getUserbyUserName(txtUsername.Text);
            if (dt.Rows.Count > 0)
            {
                txtUserId.Text = dt.Rows[0].ToString();
                txtPassword.Text = dt.Rows[2].ToString();
                int rolId = Convert.ToInt32(dt.Rows[3].ToString());
                txtRole.Text = blr.getRolebyId(rolId).ToString();
                txtFullName.Text = dt.Rows[4].ToString();
                txtAddress.Text = dt.Rows[5].ToString();
                txtPhoneNo.Text = dt.Rows[6].ToString();
            }
        }

        
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = blu.UpdateUser(txtUsername.Text, txtPassword.Text, txtFullName.Text,txtAddress.Text,txtPhoneNo.Text, Convert.ToInt32(txtUserId.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
