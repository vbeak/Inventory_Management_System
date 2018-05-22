using BusinessLogicLayer;
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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        BLLRoles blr = new BLLRoles();
        BLLUser blu = new BLLUser();
        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadUser();
            txtUsername.Focus();
        }

        private void LoadUser()
        {
            DataTable dt = blu.getAllUser();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                    dataGridView1.Rows[i].Cells["colUserId"].Value = dt.Rows[i]["userId"].ToString();
                    dataGridView1.Rows[i].Cells["colUserName"].Value = dt.Rows[i]["username"].ToString();
                    dataGridView1.Rows[i].Cells["colPassword"].Value = dt.Rows[i]["Password"].ToString();
                    dataGridView1.Rows[i].Cells["colRoleId"].Value = dt.Rows[i]["RoleId"].ToString();
                    dataGridView1.Rows[i].Cells["colRole"].Value = dt.Rows[i]["Role"].ToString();
                    dataGridView1.Rows[i].Cells["colFullName"].Value = dt.Rows[i]["FullName"].ToString();
                    dataGridView1.Rows[i].Cells["colAddress"].Value = dt.Rows[i]["Address"].ToString();
                    dataGridView1.Rows[i].Cells["colPhoneNumber"].Value = dt.Rows[i]["PhoneNo"].ToString();

                }

            }
        }

        private void LoadCategory()
        {
            DataTable dt = blr.getAllRoles();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["Role"] = "Choose Role";
                dt.Rows.InsertAt(dr, 0);
                cmbUserType.DataSource = dt;
                cmbUserType.DisplayMember = "Role";
                cmbUserType.ValueMember = "RoleId";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = blu.AddUser(txtUsername.Text,txtPassword.Text,Convert.ToInt32(cmbUserType.SelectedValue.ToString()),txtFullName.Text,txtAddress.Text,txtPhoneNumber.Text);
            if (i > 0)
            {
                LoadUser();
                MessageBox.Show("User Added");
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Adding User Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
