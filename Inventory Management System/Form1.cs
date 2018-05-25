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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLLRoles blr = new BLLRoles();
        BLLLogin bllg = new BLLLogin();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(txtUsername.Text==null || txtPassword.Text==null || cboUserType.SelectedIndex==0)
            {
                lblMessage.Text = "Please Provide Valid Users Credential";
                CleanLoginForm();

            }
            
         
            else
            {
                DataTable dt = bllg.LoginUser(txtUsername.Text,txtPassword.Text,Convert.ToInt32(cboUserType.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {

                    
                            Program.username = txtUsername.Text;
                            Program.userId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            if (cboUserType.Text == "Admin")
                            {
                                MainMDI mainForm = new MainMDI();
                                
                                mainForm.Show();
                                mainForm.userPanelToolStripMenuItem.Visible = false;

                                this.Hide();
                            }
                            else if (cboUserType.Text == "User")
                            {
                                MainMDI mainForm = new MainMDI();
                                mainForm.Show();
                                mainForm.adminPanelToolStripMenuItem.Visible = false;
                                this.Hide();
                            }


                    
                }




            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = blr.getAllRoles();
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.NewRow();
                dr["Role"] = "Choose Category";
                dt.Rows.InsertAt(dr, 0);
                cboUserType.DataSource = dt;
                cboUserType.DisplayMember = "Role";
                cboUserType.ValueMember = "RoleId";
            }
            CleanLoginForm();
        }

        private void CleanLoginForm()
        {
            txtUsername.Text = null;
            txtPassword.Text=null;
            cboUserType.SelectedIndex = 0;
             txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             
            this.Close();
            
            

        }
    }
}
