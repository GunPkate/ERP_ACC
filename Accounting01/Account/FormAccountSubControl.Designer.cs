
namespace Accounting01.Account
{
    partial class FormAccountSubControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountSubControl));
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddAccountHead = new System.Windows.Forms.Button();
            this.btnRefreshHead = new System.Windows.Forms.Button();
            this.cmbAccountHead = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAccountSubControl = new System.Windows.Forms.DataGridView();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtAccountControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAccountControl = new System.Windows.Forms.ComboBox();
            this.btnRefreshControl = new System.Windows.Forms.Button();
            this.btnAddAccountControl = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSubControl)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnAddAccountHead
            // 
            this.btnAddAccountHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccountHead.BackgroundImage")));
            this.btnAddAccountHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccountHead.Location = new System.Drawing.Point(464, 15);
            this.btnAddAccountHead.Name = "btnAddAccountHead";
            this.btnAddAccountHead.Size = new System.Drawing.Size(23, 23);
            this.btnAddAccountHead.TabIndex = 63;
            this.btnAddAccountHead.UseVisualStyleBackColor = true;
            this.btnAddAccountHead.Click += new System.EventHandler(this.btnAddAccountHead_Click);
            // 
            // btnRefreshHead
            // 
            this.btnRefreshHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshHead.BackgroundImage")));
            this.btnRefreshHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshHead.Location = new System.Drawing.Point(444, 15);
            this.btnRefreshHead.Name = "btnRefreshHead";
            this.btnRefreshHead.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshHead.TabIndex = 62;
            this.btnRefreshHead.UseVisualStyleBackColor = true;
            this.btnRefreshHead.Click += new System.EventHandler(this.btnRefreshHead_Click);
            // 
            // cmbAccountHead
            // 
            this.cmbAccountHead.FormattingEnabled = true;
            this.cmbAccountHead.Location = new System.Drawing.Point(169, 15);
            this.cmbAccountHead.Name = "cmbAccountHead";
            this.cmbAccountHead.Size = new System.Drawing.Size(278, 23);
            this.cmbAccountHead.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Select Account Head";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(37, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 21);
            this.panel1.TabIndex = 59;
            // 
            // dgvAccountSubControl
            // 
            this.dgvAccountSubControl.AllowUserToAddRows = false;
            this.dgvAccountSubControl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccountSubControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountSubControl.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvAccountSubControl.Location = new System.Drawing.Point(37, 227);
            this.dgvAccountSubControl.MultiSelect = false;
            this.dgvAccountSubControl.Name = "dgvAccountSubControl";
            this.dgvAccountSubControl.ReadOnly = true;
            this.dgvAccountSubControl.RowTemplate.Height = 25;
            this.dgvAccountSubControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountSubControl.Size = new System.Drawing.Size(450, 250);
            this.dgvAccountSubControl.TabIndex = 58;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Enabled = false;
            this.btn_Cancle.Location = new System.Drawing.Point(412, 129);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 57;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(331, 129);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 56;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(250, 129);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 55;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(0, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 64;
            // 
            // txtAccountControl
            // 
            this.txtAccountControl.Location = new System.Drawing.Point(169, 100);
            this.txtAccountControl.Name = "txtAccountControl";
            this.txtAccountControl.Size = new System.Drawing.Size(318, 23);
            this.txtAccountControl.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Search";
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(169, 185);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(318, 23);
            this.searchValue.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Enter Account Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Select Account Control";
            // 
            // cmbAccountControl
            // 
            this.cmbAccountControl.FormattingEnabled = true;
            this.cmbAccountControl.Location = new System.Drawing.Point(169, 56);
            this.cmbAccountControl.Name = "cmbAccountControl";
            this.cmbAccountControl.Size = new System.Drawing.Size(278, 23);
            this.cmbAccountControl.TabIndex = 61;
            // 
            // btnRefreshControl
            // 
            this.btnRefreshControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshControl.BackgroundImage")));
            this.btnRefreshControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshControl.Location = new System.Drawing.Point(444, 56);
            this.btnRefreshControl.Name = "btnRefreshControl";
            this.btnRefreshControl.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshControl.TabIndex = 62;
            this.btnRefreshControl.UseVisualStyleBackColor = true;
            this.btnRefreshControl.Click += new System.EventHandler(this.btnRefreshControl_Click);
            // 
            // btnAddAccountControl
            // 
            this.btnAddAccountControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccountControl.BackgroundImage")));
            this.btnAddAccountControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccountControl.Location = new System.Drawing.Point(464, 56);
            this.btnAddAccountControl.Name = "btnAddAccountControl";
            this.btnAddAccountControl.Size = new System.Drawing.Size(23, 23);
            this.btnAddAccountControl.TabIndex = 63;
            this.btnAddAccountControl.UseVisualStyleBackColor = true;
            this.btnAddAccountControl.Click += new System.EventHandler(this.btnAddAccountControl_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(169, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormAccountSubControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAccountControl);
            this.Controls.Add(this.btnAddAccountHead);
            this.Controls.Add(this.btnRefreshControl);
            this.Controls.Add(this.btnRefreshHead);
            this.Controls.Add(this.cmbAccountControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAccountHead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAccountSubControl);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtAccountControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.label1);
            this.Name = "FormAccountSubControl";
            this.Text = "FormAccountSubControl";
            this.Load += new System.EventHandler(this.FormAccountSubControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSubControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnAddAccountHead;
        private System.Windows.Forms.Button btnRefreshHead;
        private System.Windows.Forms.ComboBox cmbAccountHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAccountSubControl;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtAccountControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAccountControl;
        private System.Windows.Forms.Button btnRefreshControl;
        private System.Windows.Forms.ComboBox cmbAccountControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}