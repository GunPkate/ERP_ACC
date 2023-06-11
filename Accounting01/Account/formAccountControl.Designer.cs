
namespace Accounting01.Account
{
    partial class FormAccountControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAccountControl = new System.Windows.Forms.DataGridView();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtAccountControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountControl = new System.Windows.Forms.ComboBox();
            this.btnAddAccountHead = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(42, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 21);
            this.panel1.TabIndex = 29;
            // 
            // dgvAccountControl
            // 
            this.dgvAccountControl.AllowUserToAddRows = false;
            this.dgvAccountControl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccountControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountControl.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvAccountControl.Location = new System.Drawing.Point(42, 185);
            this.dgvAccountControl.MultiSelect = false;
            this.dgvAccountControl.Name = "dgvAccountControl";
            this.dgvAccountControl.ReadOnly = true;
            this.dgvAccountControl.RowTemplate.Height = 25;
            this.dgvAccountControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountControl.Size = new System.Drawing.Size(450, 250);
            this.dgvAccountControl.TabIndex = 28;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Enabled = false;
            this.btn_Cancle.Location = new System.Drawing.Point(417, 87);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 27;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(336, 87);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(255, 87);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 25;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(174, 87);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // txtAccountControl
            // 
            this.txtAccountControl.Location = new System.Drawing.Point(174, 58);
            this.txtAccountControl.Name = "txtAccountControl";
            this.txtAccountControl.Size = new System.Drawing.Size(318, 23);
            this.txtAccountControl.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search";
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(174, 143);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(318, 23);
            this.searchValue.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Account Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select Account Head";
            // 
            // cmbAccountControl
            // 
            this.cmbAccountControl.FormattingEnabled = true;
            this.cmbAccountControl.Location = new System.Drawing.Point(174, 21);
            this.cmbAccountControl.Name = "cmbAccountControl";
            this.cmbAccountControl.Size = new System.Drawing.Size(278, 23);
            this.cmbAccountControl.TabIndex = 31;
            // 
            // btnAddAccountHead
            // 
            this.btnAddAccountHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccountHead.BackgroundImage")));
            this.btnAddAccountHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccountHead.Location = new System.Drawing.Point(469, 21);
            this.btnAddAccountHead.Name = "btnAddAccountHead";
            this.btnAddAccountHead.Size = new System.Drawing.Size(23, 23);
            this.btnAddAccountHead.TabIndex = 49;
            this.btnAddAccountHead.UseVisualStyleBackColor = true;
            this.btnAddAccountHead.Click += new System.EventHandler(this.btnAddAccountHead_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(449, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
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
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FormAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAddAccountHead);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbAccountControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAccountControl);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtAccountControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.label1);
            this.Name = "FormAccountControl";
            this.Text = "FormAccountControl";
            this.Load += new System.EventHandler(this.formAccountControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAccountControl;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtAccountControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccountControl;
        private System.Windows.Forms.Button btnAddAccountHead;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}