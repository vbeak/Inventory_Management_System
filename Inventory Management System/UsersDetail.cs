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

        int userId = Program.userId;
        private void GetUserId()
        {
            
            DataTable dt = blu.getUserbyUserId(userId);
            if (dt.Rows.Count > 0)
            {
                txtUsername.Text = dt.Rows[0][1].ToString();
                txtPassword.Text = dt.Rows[0][2].ToString();
                int rolId = Convert.ToInt32(dt.Rows[0][3].ToString());
                DataTable role = blr.getRolebyId(rolId);
                if (role.Rows.Count > 0)
                {
                    txtRole.Text = role.Rows[0][0].ToString();
                }
                txtFullName.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
                txtPhoneNo.Text = dt.Rows[0][6].ToString();
            }
        }

        
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = blu.UpdateUser(txtUsername.Text, txtPassword.Text, txtFullName.Text, txtAddress.Text, txtPhoneNo.Text, userId);
            if (i > 0)
            {
                MessageBox.Show("User Details Updated");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to cancel?", "Make Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        
    }
}
