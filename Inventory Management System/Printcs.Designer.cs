namespace Inventory_Management_System
{
    partial class Printcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.receiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReceiptBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Inventory_Management_System.PrintReceipt.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(761, 350);
            this.reportViewer.TabIndex = 0;
            // 
            // receiptBindingSource1
            // 
            this.receiptBindingSource1.DataSource = typeof(BusinessLogicLayer.Receipt);
            // 
            // ReceiptBindingSource
            // 
            this.ReceiptBindingSource.DataSource = typeof(BusinessLogicLayer.Receipt);
            // 
            // Printcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 350);
            this.Controls.Add(this.reportViewer);
            this.Name = "Printcs";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Printcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        public System.Windows.Forms.BindingSource receiptBindingSource1;
        private System.Windows.Forms.BindingSource ReceiptBindingSource;
    }
}