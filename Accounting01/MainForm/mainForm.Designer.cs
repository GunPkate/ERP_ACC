
namespace Accounting01
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStripAll = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSubControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripDropDownButton();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelParent = new System.Windows.Forms.Panel();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAll.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAll
            // 
            this.menuStripAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.reporttToolStripMenuItem});
            this.menuStripAll.Location = new System.Drawing.Point(0, 0);
            this.menuStripAll.Name = "menuStripAll";
            this.menuStripAll.Size = new System.Drawing.Size(800, 24);
            this.menuStripAll.TabIndex = 0;
            this.menuStripAll.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.productToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingToolStripMenuItem,
            this.acountSettingToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // userSettingToolStripMenuItem
            // 
            this.userSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userTypesToolStripMenuItem,
            this.addUsersToolStripMenuItem});
            this.userSettingToolStripMenuItem.Name = "userSettingToolStripMenuItem";
            this.userSettingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.userSettingToolStripMenuItem.Text = "User Setting";
            // 
            // userTypesToolStripMenuItem
            // 
            this.userTypesToolStripMenuItem.Name = "userTypesToolStripMenuItem";
            this.userTypesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.userTypesToolStripMenuItem.Text = "User Types";
            this.userTypesToolStripMenuItem.Click += new System.EventHandler(this.userTypesToolStripMenuItem_Click);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addUsersToolStripMenuItem.Text = "Add Users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // acountSettingToolStripMenuItem
            // 
            this.acountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountHeadToolStripMenuItem,
            this.accountControlToolStripMenuItem,
            this.accountSubControlToolStripMenuItem,
            this.financialYearToolStripMenuItem});
            this.acountSettingToolStripMenuItem.Name = "acountSettingToolStripMenuItem";
            this.acountSettingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.acountSettingToolStripMenuItem.Text = "Acount Setting";
            // 
            // accountHeadToolStripMenuItem
            // 
            this.accountHeadToolStripMenuItem.Name = "accountHeadToolStripMenuItem";
            this.accountHeadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountHeadToolStripMenuItem.Text = "Account Head";
            this.accountHeadToolStripMenuItem.Click += new System.EventHandler(this.accountHeadToolStripMenuItem_Click);
            // 
            // accountControlToolStripMenuItem
            // 
            this.accountControlToolStripMenuItem.Name = "accountControlToolStripMenuItem";
            this.accountControlToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountControlToolStripMenuItem.Text = "Account Control";
            this.accountControlToolStripMenuItem.Click += new System.EventHandler(this.accountControlToolStripMenuItem_Click);
            // 
            // accountSubControlToolStripMenuItem
            // 
            this.accountSubControlToolStripMenuItem.Name = "accountSubControlToolStripMenuItem";
            this.accountSubControlToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountSubControlToolStripMenuItem.Text = "Account Sub Control";
            this.accountSubControlToolStripMenuItem.Click += new System.EventHandler(this.accountSubControlToolStripMenuItem_Click);
            // 
            // financialYearToolStripMenuItem
            // 
            this.financialYearToolStripMenuItem.Name = "financialYearToolStripMenuItem";
            this.financialYearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.financialYearToolStripMenuItem.Text = "FinancialYear";
            this.financialYearToolStripMenuItem.Click += new System.EventHandler(this.financialYearToolStripMenuItem_Click);
            // 
            // reporttToolStripMenuItem
            // 
            this.reporttToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.reporttToolStripMenuItem.Name = "reporttToolStripMenuItem";
            this.reporttToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reporttToolStripMenuItem.Text = "Report";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogin,
            this.btnLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(41, 35);
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(58, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // panelParent
            // 
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 62);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(800, 366);
            this.panelParent.TabIndex = 3;
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelParent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripAll);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAll;
            this.Name = "mainForm";
            this.Text = "Account01 Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripAll.ResumeLayout(false);
            this.menuStripAll.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporttToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem userSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton btnLogin;
        public System.Windows.Forms.MenuStrip menuStripAll;
        public System.Windows.Forms.ToolStripDropDownButton btnLogout;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.ToolStripMenuItem acountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountHeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSubControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}