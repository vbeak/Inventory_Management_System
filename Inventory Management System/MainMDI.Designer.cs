namespace Inventory_Management_System
{
    partial class MainMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemPurchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSoldItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllSoldItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStockItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.purchasedToolStripMenuItem,
            this.soldToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.userPanelToolStripMenuItem,
            this.adminPanelToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuStrip1.Size = new System.Drawing.Size(959, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.addNewItemsToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewCategoryToolStripMenuItem.Image")));
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Categories";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click_1);
            // 
            // addNewItemsToolStripMenuItem
            // 
            this.addNewItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemsToolStripMenuItem.Image")));
            this.addNewItemsToolStripMenuItem.Name = "addNewItemsToolStripMenuItem";
            this.addNewItemsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.addNewItemsToolStripMenuItem.Text = "Add New Product";
            this.addNewItemsToolStripMenuItem.Click += new System.EventHandler(this.addNewItemsToolStripMenuItem_Click);
            // 
            // purchasedToolStripMenuItem
            // 
            this.purchasedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemPurchaseToolStripMenuItem,
            this.showAllItemPurchasedToolStripMenuItem});
            this.purchasedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchasedToolStripMenuItem.Image")));
            this.purchasedToolStripMenuItem.Name = "purchasedToolStripMenuItem";
            this.purchasedToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.purchasedToolStripMenuItem.Text = "Purchased";
            // 
            // newItemPurchaseToolStripMenuItem
            // 
            this.newItemPurchaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newItemPurchaseToolStripMenuItem.Image")));
            this.newItemPurchaseToolStripMenuItem.Name = "newItemPurchaseToolStripMenuItem";
            this.newItemPurchaseToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.newItemPurchaseToolStripMenuItem.Text = "Add New Purchased Item";
            this.newItemPurchaseToolStripMenuItem.Click += new System.EventHandler(this.newItemPurchaseToolStripMenuItem_Click);
            // 
            // showAllItemPurchasedToolStripMenuItem
            // 
            this.showAllItemPurchasedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllItemPurchasedToolStripMenuItem.Image")));
            this.showAllItemPurchasedToolStripMenuItem.Name = "showAllItemPurchasedToolStripMenuItem";
            this.showAllItemPurchasedToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.showAllItemPurchasedToolStripMenuItem.Text = "Show All Item Purchased";
            this.showAllItemPurchasedToolStripMenuItem.Click += new System.EventHandler(this.showAllItemPurchasedToolStripMenuItem_Click);
            // 
            // soldToolStripMenuItem
            // 
            this.soldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSoldItemToolStripMenuItem,
            this.showAllSoldItemToolStripMenuItem});
            this.soldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("soldToolStripMenuItem.Image")));
            this.soldToolStripMenuItem.Name = "soldToolStripMenuItem";
            this.soldToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.soldToolStripMenuItem.Text = "Sold";
            // 
            // addNewSoldItemToolStripMenuItem
            // 
            this.addNewSoldItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewSoldItemToolStripMenuItem.Image")));
            this.addNewSoldItemToolStripMenuItem.Name = "addNewSoldItemToolStripMenuItem";
            this.addNewSoldItemToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.addNewSoldItemToolStripMenuItem.Text = "Add New Sold Items";
            this.addNewSoldItemToolStripMenuItem.Click += new System.EventHandler(this.addNewSoldItemToolStripMenuItem_Click);
            // 
            // showAllSoldItemToolStripMenuItem
            // 
            this.showAllSoldItemToolStripMenuItem.Image = global::Inventory_Management_System.Properties.Resources.Programming_Show_Property_icon;
            this.showAllSoldItemToolStripMenuItem.Name = "showAllSoldItemToolStripMenuItem";
            this.showAllSoldItemToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.showAllSoldItemToolStripMenuItem.Text = "Show All Sold Items";
            this.showAllSoldItemToolStripMenuItem.Click += new System.EventHandler(this.showAllSoldItemToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllStockItemsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // showAllStockItemsToolStripMenuItem
            // 
            this.showAllStockItemsToolStripMenuItem.Image = global::Inventory_Management_System.Properties.Resources.Programming_Show_Property_icon;
            this.showAllStockItemsToolStripMenuItem.Name = "showAllStockItemsToolStripMenuItem";
            this.showAllStockItemsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.showAllStockItemsToolStripMenuItem.Text = "Show All Stock items";
            this.showAllStockItemsToolStripMenuItem.Click += new System.EventHandler(this.showAllStockItemsToolStripMenuItem_Click);
            // 
            // userPanelToolStripMenuItem
            // 
            this.userPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDetailsToolStripMenuItem});
            this.userPanelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userPanelToolStripMenuItem.Image")));
            this.userPanelToolStripMenuItem.Name = "userPanelToolStripMenuItem";
            this.userPanelToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.userPanelToolStripMenuItem.Text = "User Panel";
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = global::Inventory_Management_System.Properties.Resources.Actions_edit_redo_icon;
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem});
            this.adminPanelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminPanelToolStripMenuItem.Image")));
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            this.adminPanelToolStripMenuItem.Click += new System.EventHandler(this.adminPanelToolStripMenuItem_Click);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Image = global::Inventory_Management_System.Properties.Resources.Programming_Show_Property_icon;
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.dateTime,
            this.lblUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.Text = "Today";
            // 
            // dateTime
            // 
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(57, 17);
            this.dateTime.Text = "Welcome";
            // 
            // lblUsername
            // 
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 17);
            this.lblUsername.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS - Inventory Management System";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMDI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMDI_FormClosed);
            this.Load += new System.EventHandler(this.MainMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem userPanelToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        protected internal System.Windows.Forms.ToolStripStatusLabel dateTime;
        public System.Windows.Forms.ToolStripStatusLabel lblUsername;
        private System.Windows.Forms.ToolStripMenuItem newItemPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllItemPurchasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSoldItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllSoldItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStockItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}