
namespace Accounting01.Purchase
{
    partial class FormCustomer
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
            label7=new System.Windows.Forms.Label();
            textBoxAddress=new System.Windows.Forms.TextBox();
            textBoxDescription=new System.Windows.Forms.TextBox();
            label5=new System.Windows.Forms.Label();
            txtCustomer=new System.Windows.Forms.TextBox();
            label4=new System.Windows.Forms.Label();
            txtEmail=new System.Windows.Forms.TextBox();
            label3=new System.Windows.Forms.Label();
            deleteToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            label6=new System.Windows.Forms.Label();
            contextMenuStrip=new System.Windows.Forms.ContextMenuStrip(components);
            dgvCustomer=new System.Windows.Forms.DataGridView();
            btn_Cancle=new System.Windows.Forms.Button();
            btn_Edit=new System.Windows.Forms.Button();
            btn_Clear=new System.Windows.Forms.Button();
            btn_Save=new System.Windows.Forms.Button();
            txtContact=new System.Windows.Forms.TextBox();
            label2=new System.Windows.Forms.Label();
            searchValue=new System.Windows.Forms.TextBox();
            label1=new System.Windows.Forms.Label();
            ep=new System.Windows.Forms.ErrorProvider(components);
            panel1=new System.Windows.Forms.Panel();
            btn_Print=new System.Windows.Forms.Button();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new System.Drawing.Point(491, 24);
            label7.Name="label7";
            label7.Size=new System.Drawing.Size(49, 15);
            label7.TabIndex=45;
            label7.Text="Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location=new System.Drawing.Point(491, 42);
            textBoxAddress.Multiline=true;
            textBoxAddress.Name="textBoxAddress";
            textBoxAddress.Size=new System.Drawing.Size(254, 51);
            textBoxAddress.TabIndex=43;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location=new System.Drawing.Point(491, 113);
            textBoxDescription.Multiline=true;
            textBoxDescription.Name="textBoxDescription";
            textBoxDescription.Size=new System.Drawing.Size(254, 51);
            textBoxDescription.TabIndex=42;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new System.Drawing.Point(56, 11);
            label5.Name="label5";
            label5.Size=new System.Drawing.Size(97, 15);
            label5.TabIndex=41;
            label5.Text="Customer Details";
            // 
            // txtCustomer
            // 
            txtCustomer.Location=new System.Drawing.Point(149, 42);
            txtCustomer.Name="txtCustomer";
            txtCustomer.Size=new System.Drawing.Size(318, 23);
            txtCustomer.TabIndex=40;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new System.Drawing.Point(56, 45);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(92, 15);
            label4.TabIndex=39;
            label4.Text="Customer name";
            // 
            // txtEmail
            // 
            txtEmail.Location=new System.Drawing.Point(149, 110);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new System.Drawing.Size(318, 23);
            txtEmail.TabIndex=32;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new System.Drawing.Point(56, 113);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(36, 15);
            label3.TabIndex=28;
            label3.Text="Email";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name="deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size=new System.Drawing.Size(107, 22);
            deleteToolStripMenuItem.Text="Delete";
            deleteToolStripMenuItem.Click+=deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name="editToolStripMenuItem";
            editToolStripMenuItem.Size=new System.Drawing.Size(107, 22);
            editToolStripMenuItem.Text="Edit";
            editToolStripMenuItem.Click+=editToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new System.Drawing.Point(491, 95);
            label6.Name="label6";
            label6.Size=new System.Drawing.Size(67, 15);
            label6.TabIndex=44;
            label6.Text="Description";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip.Name="contextMenuStrip1";
            contextMenuStrip.Size=new System.Drawing.Size(108, 48);
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows=false;
            dgvCustomer.BackgroundColor=System.Drawing.SystemColors.ButtonHighlight;
            dgvCustomer.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.GridColor=System.Drawing.SystemColors.ButtonShadow;
            dgvCustomer.Location=new System.Drawing.Point(56, 226);
            dgvCustomer.MultiSelect=false;
            dgvCustomer.Name="dgvCustomer";
            dgvCustomer.ReadOnly=true;
            dgvCustomer.RowTemplate.Height=25;
            dgvCustomer.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size=new System.Drawing.Size(666, 213);
            dgvCustomer.TabIndex=37;
            // 
            // btn_Cancle
            // 
            btn_Cancle.Enabled=false;
            btn_Cancle.Location=new System.Drawing.Point(670, 192);
            btn_Cancle.Name="btn_Cancle";
            btn_Cancle.Size=new System.Drawing.Size(75, 23);
            btn_Cancle.TabIndex=36;
            btn_Cancle.Text="Cancle";
            btn_Cancle.UseVisualStyleBackColor=true;
            btn_Cancle.Click+=btn_Cancle_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Enabled=false;
            btn_Edit.Location=new System.Drawing.Point(589, 192);
            btn_Edit.Name="btn_Edit";
            btn_Edit.Size=new System.Drawing.Size(75, 23);
            btn_Edit.TabIndex=35;
            btn_Edit.Text="Edit";
            btn_Edit.UseVisualStyleBackColor=true;
            btn_Edit.Click+=btn_Edit_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location=new System.Drawing.Point(508, 192);
            btn_Clear.Name="btn_Clear";
            btn_Clear.Size=new System.Drawing.Size(75, 23);
            btn_Clear.TabIndex=34;
            btn_Clear.Text="Clear";
            btn_Clear.UseVisualStyleBackColor=true;
            btn_Clear.Click+=btn_Clear_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location=new System.Drawing.Point(427, 192);
            btn_Save.Name="btn_Save";
            btn_Save.Size=new System.Drawing.Size(75, 23);
            btn_Save.TabIndex=33;
            btn_Save.Text="Save";
            btn_Save.UseVisualStyleBackColor=true;
            btn_Save.Click+=btn_Save_Click;
            // 
            // txtContact
            // 
            txtContact.Location=new System.Drawing.Point(149, 77);
            txtContact.Name="txtContact";
            txtContact.Size=new System.Drawing.Size(318, 23);
            txtContact.TabIndex=31;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new System.Drawing.Point(56, 196);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(42, 15);
            label2.TabIndex=30;
            label2.Text="Search";
            // 
            // searchValue
            // 
            searchValue.Location=new System.Drawing.Point(103, 193);
            searchValue.Name="searchValue";
            searchValue.Size=new System.Drawing.Size(318, 23);
            searchValue.TabIndex=29;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new System.Drawing.Point(56, 80);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(49, 15);
            label1.TabIndex=27;
            label1.Text="Contact";
            // 
            // ep
            // 
            ep.ContainerControl=this;
            // 
            // panel1
            // 
            panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            panel1.Location=new System.Drawing.Point(56, 160);
            panel1.Name="panel1";
            panel1.Size=new System.Drawing.Size(411, 21);
            panel1.TabIndex=38;
            // 
            // btn_Print
            // 
            btn_Print.Location=new System.Drawing.Point(670, 7);
            btn_Print.Name="btn_Print";
            btn_Print.Size=new System.Drawing.Size(75, 23);
            btn_Print.TabIndex=46;
            btn_Print.Text="Print";
            btn_Print.UseVisualStyleBackColor=true;
            btn_Print.Click+=btn_Print_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            ContextMenuStrip=contextMenuStrip;
            Controls.Add(btn_Print);
            Controls.Add(label7);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(txtCustomer);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(dgvCustomer);
            Controls.Add(btn_Cancle);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(txtContact);
            Controls.Add(label2);
            Controls.Add(searchValue);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name="FormCustomer";
            Text="FormCustomer";
            Load+=FormCustomer_Load;
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Print;
    }
}