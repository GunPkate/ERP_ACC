
namespace Accounting01.SupplierAndCustomer
{
    partial class FormSupplier
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
            components=new System.ComponentModel.Container();
            panel1=new System.Windows.Forms.Panel();
            dgvSupplier=new System.Windows.Forms.DataGridView();
            btn_Cancle=new System.Windows.Forms.Button();
            btn_Edit=new System.Windows.Forms.Button();
            btn_Clear=new System.Windows.Forms.Button();
            btn_Save=new System.Windows.Forms.Button();
            txtContact=new System.Windows.Forms.TextBox();
            label2=new System.Windows.Forms.Label();
            searchValue=new System.Windows.Forms.TextBox();
            label1=new System.Windows.Forms.Label();
            ep=new System.Windows.Forms.ErrorProvider(components);
            contextMenuStrip1=new System.Windows.Forms.ContextMenuStrip(components);
            editToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            label3=new System.Windows.Forms.Label();
            txtEmail=new System.Windows.Forms.TextBox();
            txtSupplier=new System.Windows.Forms.TextBox();
            label4=new System.Windows.Forms.Label();
            label5=new System.Windows.Forms.Label();
            textBoxDescription=new System.Windows.Forms.TextBox();
            textBoxAddress=new System.Windows.Forms.TextBox();
            label6=new System.Windows.Forms.Label();
            label7=new System.Windows.Forms.Label();
            btn_Print=new System.Windows.Forms.Button();
            backgroundWorker1=new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            panel1.Location=new System.Drawing.Point(67, 159);
            panel1.Name="panel1";
            panel1.Size=new System.Drawing.Size(411, 21);
            panel1.TabIndex=19;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToAddRows=false;
            dgvSupplier.BackgroundColor=System.Drawing.SystemColors.ButtonHighlight;
            dgvSupplier.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.GridColor=System.Drawing.SystemColors.ButtonShadow;
            dgvSupplier.Location=new System.Drawing.Point(67, 225);
            dgvSupplier.MultiSelect=false;
            dgvSupplier.Name="dgvSupplier";
            dgvSupplier.ReadOnly=true;
            dgvSupplier.RowTemplate.Height=25;
            dgvSupplier.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.Size=new System.Drawing.Size(666, 213);
            dgvSupplier.TabIndex=18;
            // 
            // btn_Cancle
            // 
            btn_Cancle.Enabled=false;
            btn_Cancle.Location=new System.Drawing.Point(681, 191);
            btn_Cancle.Name="btn_Cancle";
            btn_Cancle.Size=new System.Drawing.Size(75, 23);
            btn_Cancle.TabIndex=17;
            btn_Cancle.Text="Cancle";
            btn_Cancle.UseVisualStyleBackColor=true;
            btn_Cancle.Click+=btn_Cancle_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Enabled=false;
            btn_Edit.Location=new System.Drawing.Point(600, 191);
            btn_Edit.Name="btn_Edit";
            btn_Edit.Size=new System.Drawing.Size(75, 23);
            btn_Edit.TabIndex=16;
            btn_Edit.Text="Edit";
            btn_Edit.UseVisualStyleBackColor=true;
            btn_Edit.Click+=btn_Edit_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location=new System.Drawing.Point(519, 191);
            btn_Clear.Name="btn_Clear";
            btn_Clear.Size=new System.Drawing.Size(75, 23);
            btn_Clear.TabIndex=15;
            btn_Clear.Text="Clear";
            btn_Clear.UseVisualStyleBackColor=true;
            btn_Clear.Click+=btn_Clear_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location=new System.Drawing.Point(438, 191);
            btn_Save.Name="btn_Save";
            btn_Save.Size=new System.Drawing.Size(75, 23);
            btn_Save.TabIndex=14;
            btn_Save.Text="Save";
            btn_Save.UseVisualStyleBackColor=true;
            btn_Save.Click+=btn_Save_Click;
            // 
            // txtContact
            // 
            txtContact.Location=new System.Drawing.Point(160, 76);
            txtContact.Name="txtContact";
            txtContact.Size=new System.Drawing.Size(318, 23);
            txtContact.TabIndex=13;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new System.Drawing.Point(67, 195);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(42, 15);
            label2.TabIndex=12;
            label2.Text="Search";
            // 
            // searchValue
            // 
            searchValue.Location=new System.Drawing.Point(114, 192);
            searchValue.Name="searchValue";
            searchValue.Size=new System.Drawing.Size(318, 23);
            searchValue.TabIndex=11;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new System.Drawing.Point(67, 79);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(49, 15);
            label1.TabIndex=10;
            label1.Text="Contact";
            // 
            // ep
            // 
            ep.ContainerControl=this;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name="editToolStripMenuItem";
            editToolStripMenuItem.Size=new System.Drawing.Size(107, 22);
            editToolStripMenuItem.Text="Edit";
            editToolStripMenuItem.Click+=editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name="deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size=new System.Drawing.Size(107, 22);
            deleteToolStripMenuItem.Text="Delete";
            deleteToolStripMenuItem.Click+=deleteToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new System.Drawing.Point(67, 112);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(36, 15);
            label3.TabIndex=10;
            label3.Text="Email";
            // 
            // txtEmail
            // 
            txtEmail.Location=new System.Drawing.Point(160, 109);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new System.Drawing.Size(318, 23);
            txtEmail.TabIndex=13;
            // 
            // txtSupplier
            // 
            txtSupplier.Location=new System.Drawing.Point(160, 41);
            txtSupplier.Name="txtSupplier";
            txtSupplier.Size=new System.Drawing.Size(318, 23);
            txtSupplier.TabIndex=21;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new System.Drawing.Point(67, 44);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(83, 15);
            label4.TabIndex=20;
            label4.Text="Supplier name";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new System.Drawing.Point(67, 10);
            label5.Name="label5";
            label5.Size=new System.Drawing.Size(88, 15);
            label5.TabIndex=22;
            label5.Text="Supplier Details";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location=new System.Drawing.Point(502, 112);
            textBoxDescription.Multiline=true;
            textBoxDescription.Name="textBoxDescription";
            textBoxDescription.Size=new System.Drawing.Size(254, 51);
            textBoxDescription.TabIndex=23;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location=new System.Drawing.Point(502, 41);
            textBoxAddress.Multiline=true;
            textBoxAddress.Name="textBoxAddress";
            textBoxAddress.Size=new System.Drawing.Size(254, 51);
            textBoxAddress.TabIndex=24;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new System.Drawing.Point(502, 94);
            label6.Name="label6";
            label6.Size=new System.Drawing.Size(67, 15);
            label6.TabIndex=25;
            label6.Text="Description";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new System.Drawing.Point(502, 23);
            label7.Name="label7";
            label7.Size=new System.Drawing.Size(49, 15);
            label7.TabIndex=26;
            label7.Text="Address";
            // 
            // btn_Print
            // 
            btn_Print.Location=new System.Drawing.Point(681, 10);
            btn_Print.Name="btn_Print";
            btn_Print.Size=new System.Drawing.Size(75, 23);
            btn_Print.TabIndex=27;
            btn_Print.Text="Print";
            btn_Print.UseVisualStyleBackColor=true;
            btn_Print.Click+=btn_Print_Click;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            ContextMenuStrip=contextMenuStrip1;
            Controls.Add(btn_Print);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(txtSupplier);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dgvSupplier);
            Controls.Add(btn_Cancle);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(searchValue);
            Controls.Add(label1);
            Name="FormSupplier";
            Text="FormSupplier";
            Load+=FormSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btn_Print;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}