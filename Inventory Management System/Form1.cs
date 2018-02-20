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
                DataTable dt = bllg.LoginUser();
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((txtUsername.Text == dt.Rows[i]["Username"].ToString() && txtPassword.Text == dt.Rows[i]["Password"].ToString() && cboUserType.Text == dt.Rows[i]["Role"].ToString()) == true)
                        {
                            Program.username = txtUsername.Text;
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

                else
                {
                    MessageBox.Show("Not Matched");
                    CleanLoginForm();
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
    }
}
