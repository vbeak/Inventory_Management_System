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
    public partial class Printcs : Form
    {
        List<Receipt> _list;
        string _subtotal, _exciseDuty, _vat, _grandTotal, _invoiceNo, _Date,_customerName,_address,_username;
        public Printcs(List<Receipt> datasource,string subtotal,string exciseduty,string vat,string grandTotal,string invoiceNo,string date,string customerName,string address)
        {
            InitializeComponent();
            _list = datasource;
            _subtotal = subtotal;
            _exciseDuty = exciseduty;
            _vat = vat;
            _grandTotal = grandTotal;
            _invoiceNo = invoiceNo;
            _Date = date;
            _customerName = customerName;
            _address = address;
            _username = Program.username;
        }

        private void Printcs_Load(object sender, EventArgs e)
        {
            ReceiptBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSubTotal",_subtotal),
                new Microsoft.Reporting.WinForms.ReportParameter("PExciseDuty",_exciseDuty),
                new Microsoft.Reporting.WinForms.ReportParameter("pVat",_vat),
                new Microsoft.Reporting.WinForms.ReportParameter("pGrandTotal",_grandTotal),
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoice",_invoiceNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerName",_customerName),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_Date),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress",_address),
                new Microsoft.Reporting.WinForms.ReportParameter("pUsername",_username)
            };
            this.reportViewer.LocalReport.SetParameters(param);
            this.reportViewer.RefreshReport();
        }
    }
}
