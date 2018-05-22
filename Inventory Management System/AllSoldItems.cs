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
    public partial class AllSoldItems : Form
    {
        public AllSoldItems()
        {
            InitializeComponent();
        }
        BLLsales bls = new BLLsales();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AllSoldItems_Load(object sender, EventArgs e)
        {
            LoadAllSales();
        }
        private void LoadAllSales()
        {
            DataTable dt = bls.ShowAllSales();
            if (dt.Rows.Count > 0)
                for(int i=0;i<dt.Rows.Count;i++)
            {
                dataGridView1.DataSource = dt;
                decimal total = 0m;
                total = Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString())+Convert.ToDecimal(txtTotal.Text);
                txtTotal.Text = total.ToString();
                decimal exciseduty = 0m;
                exciseduty = Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value.ToString())+Convert.ToDecimal(txtExciseDuty.Text);
                txtExciseDuty.Text = exciseduty.ToString();
                decimal vat = 0m;
                vat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value.ToString())+Convert.ToDecimal(txtVat.Text);
                txtVat.Text = vat.ToString();
                decimal grandTotal = 0m;
                grandTotal = Convert.ToDecimal(dataGridView1.Rows[i].Cells[10].Value.ToString())+Convert.ToDecimal(txtGrandTotal.Text);
                txtGrandTotal.Text = grandTotal.ToString();
                
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
