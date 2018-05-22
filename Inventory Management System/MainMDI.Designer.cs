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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.purchasedToolStripMenuItem,
            this.soldToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.userPanelToolStripMenuItem,
            this.adminPanelToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1126, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.addNewItemsToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Categories";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click_1);
            // 
            // addNewItemsToolStripMenuItem
            // 
            this.addNewItemsToolStripMenuItem.Name = "addNewItemsToolStripMenuItem";
            this.addNewItemsToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.addNewItemsToolStripMenuItem.Text = "Add New Product";
            this.addNewItemsToolStripMenuItem.Click += new System.EventHandler(this.addNewItemsToolStripMenuItem_Click);
            // 
            // purchasedToolStripMenuItem
            // 
            this.purchasedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemPurchaseToolStripMenuItem,
            this.showAllItemPurchasedToolStripMenuItem});
            this.purchasedToolStripMenuItem.Name = "purchasedToolStripMenuItem";
            this.purchasedToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.purchasedToolStripMenuItem.Text = "Purchased";
            // 
            // newItemPurchaseToolStripMenuItem
            // 
            this.newItemPurchaseToolStripMenuItem.Name = "newItemPurchaseToolStripMenuItem";
            this.newItemPurchaseToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.newItemPurchaseToolStripMenuItem.Text = "Add New Purchased Item";
            this.newItemPurchaseToolStripMenuItem.Click += new System.EventHandler(this.newItemPurchaseToolStripMenuItem_Click);
            // 
            // showAllItemPurchasedToolStripMenuItem
            // 
            this.showAllItemPurchasedToolStripMenuItem.Name = "showAllItemPurchasedToolStripMenuItem";
            this.showAllItemPurchasedToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.showAllItemPurchasedToolStripMenuItem.Text = "Show All Item Purchased";
            this.showAllItemPurchasedToolStripMenuItem.Click += new System.EventHandler(this.showAllItemPurchasedToolStripMenuItem_Click);
            // 
            // soldToolStripMenuItem
            // 
            this.soldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSoldItemToolStripMenuItem,
            this.showAllSoldItemToolStripMenuItem});
            this.soldToolStripMenuItem.Name = "soldToolStripMenuItem";
            this.soldToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.soldToolStripMenuItem.Text = "Sold";
            // 
            // addNewSoldItemToolStripMenuItem
            // 
            this.addNewSoldItemToolStripMenuItem.Name = "addNewSoldItemToolStripMenuItem";
            this.addNewSoldItemToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.addNewSoldItemToolStripMenuItem.Text = "Add New Sold Items";
            this.addNewSoldItemToolStripMenuItem.Click += new System.EventHandler(this.addNewSoldItemToolStripMenuItem_Click);
            // 
            // showAllSoldItemToolStripMenuItem
            // 
            this.showAllSoldItemToolStripMenuItem.Name = "showAllSoldItemToolStripMenuItem";
            this.showAllSoldItemToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.showAllSoldItemToolStripMenuItem.Text = "Show All Sold Items";
            this.showAllSoldItemToolStripMenuItem.Click += new System.EventHandler(this.showAllSoldItemToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllStockItemsToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // showAllStockItemsToolStripMenuItem
            // 
            this.showAllStockItemsToolStripMenuItem.Name = "showAllStockItemsToolStripMenuItem";
            this.showAllStockItemsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.showAllStockItemsToolStripMenuItem.Text = "Show All Stock items";
            this.showAllStockItemsToolStripMenuItem.Click += new System.EventHandler(this.showAllStockItemsToolStripMenuItem_Click);
            // 
            // userPanelToolStripMenuItem
            // 
            this.userPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDetailsToolStripMenuItem});
            this.userPanelToolStripMenuItem.Name = "userPanelToolStripMenuItem";
            this.userPanelToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.userPanelToolStripMenuItem.Text = "User Panel";
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.userListToolStripMenuItem});
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.editUserToolStripMenuItem.Text = "Edit User";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.userListToolStripMenuItem.Text = "User List";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.dateTime,
            this.lblUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 622);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMDI";
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
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
    }
}