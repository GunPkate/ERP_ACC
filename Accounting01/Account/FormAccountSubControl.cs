using Accounting01.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.Account
{
    public partial class FormAccountSubControl : Form
    {
        public FormAccountSubControl()
        {
            InitializeComponent();
        }
        private void FormAccountHead_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void FormAccountSubControl_Load(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountHead);
            ComboHelper.FillAccountControl(cmbAccountControl);
            FillGrid("");
        }


        private void btnAddAccountHead_Click(object sender, EventArgs e)
        {
            FormAccountHead formAccountHead = new FormAccountHead();
            formAccountHead.ShowDialog();
        }

        private void btnAddAccountControl_Click(object sender, EventArgs e)
        {
            FormAccountControl formAccountControl = new FormAccountControl();
            formAccountControl.ShowDialog();
        }

        private void btnRefreshHead_Click(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountHead);
        }

        private void btnRefreshControl_Click(object sender, EventArgs e)
        {
            ComboHelper.FillAccountControl(cmbAccountControl);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccountSubControl.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccountSubControl, "Please Enter Account");
                txtAccountSubControl.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from AccountSubControl where AccountSubControlName = '" + txtAccountSubControl.Text + "' and AccountControlID = '" + cmbAccountControl.SelectedIndex + "' and AccountHeadID = '" + cmbAccountHead.SelectedIndex + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccountSubControl, "Already Exist");
                    txtAccountSubControl.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into AccounttSubControl (UserID, AccountSubControlName, AccountControlID, AccountHeadID ) values('{0}','{1}','{2}','{3}');", CurrentUser.UserID, txtAccountSubControl.Text.Trim(), cmbAccountControl.SelectedValue.ToString(), cmbAccountHead.SelectedIndex);
            //MessageBox.Show(cmbAccountControl.Items[2].ToString());
            //MessageBox.Show(cmbAccountControl.SelectedValue.ToString());
            bool result = DatabaseAccess.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Account Saved");
                txtAccountSubControl.Clear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From v_AccountSubControlList";
            }
            else
            {
                query = "select * from v_AccountSubControlList where (ACC_name+' '+UserName+' '+CAST(Acc_ID AS varchar)) like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvAccountSubControl.DataSource = dt;
                    dgvAccountSubControl.Columns[0].Width = 140;
                    dgvAccountSubControl.Columns[1].Width = 140;
                    dgvAccountSubControl.Columns[2].Width = 140;
                    dgvAccountSubControl.Columns[3].Width = 140;
                }
                else
                {
                    dgvAccountSubControl.DataSource = null;
                }
            }
            else
            {
                dgvAccountSubControl.DataSource = null;
            }
            //cbGetAll.Checked = false;
            //cbIsDeleted.Checked = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccountSubControl != null)
            {
                if (dgvAccountSubControl.Rows.Count > 0)
                {
                    if (dgvAccountSubControl.SelectedRows.Count == 1)
                    {
                        txtAccountSubControl.Text = Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[1].Value).Trim();
                        cmbAccountControl.Text = Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[2].Value).Trim();
                        cmbAccountHead.Text = Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[3].Value).Trim();
                        EnableComponents();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Record");
                    }
                }
            }
            else
            {
                MessageBox.Show("List is empty");
            }
        }

        private void EnableComponents()
        {
            btn_Update.Enabled = true;
            btn_Cancle.Enabled = true;
            btnSave.Enabled = false;
            dgvAccountSubControl.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Update.Enabled = false;
            btn_Cancle.Enabled = false;
            btnSave.Enabled = true;
            dgvAccountSubControl.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtAccountSubControl.Clear();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtAccountSubControl.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccountSubControl.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccountSubControl, "Please Enter Account");
                txtAccountSubControl.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from AccountSubControl where AccountSubControlName = '" + txtAccountSubControl.Text + "'  where ACC_ID =" + dgvAccountSubControl.CurrentRow.Cells[0].Value);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccountSubControl, "Already Exist");
                    txtAccountSubControl.Focus();
                    return;
                }
            }

            string updatequery = string.Format("Update AccountSubControl set UserID = '{0}', AccountSubControlName = '{1}', " +
                "AccountControlID = (select AccountControlID from AccountControl where AccountControlName =  '{2}') ," +
                " AccountHeadID = (select AccountHeadID  from AccountHead where AccountHeadName = '{3}')  where AccountSubControlID = '{4}'", 
                CurrentUser.UserID, 
                txtAccountSubControl.Text.Trim(),
                Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[2].Value).Trim(),
                Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[3].Value).Trim(),
                Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[0].Value).Trim()
            );
            bool result = DatabaseAccess.Update(updatequery);
            if (result)
            {
                MessageBox.Show("Account Updated");
                DisableBtn();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            FillGrid(searchValue.Text.Trim());
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvAccountSubControl != null)
            {
                if (dgvAccountSubControl.Rows.Count > 0)
                {
                    if (dgvAccountSubControl.SelectedRows.Count == 1)
                    {
                        txtAccountSubControl.Text = Convert.ToString(dgvAccountSubControl.CurrentRow.Cells[1].Value);
                        EnableComponents();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("List is Empty ");
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccountSubControl != null)
            {
                if (dgvAccountSubControl.Rows.Count > 0)
                {
                    if (dgvAccountSubControl.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool result = DatabaseAccess.Delete("Delete from AccountHead where AccountHeadID = '" + dgvAccountSubControl.CurrentRow.Cells[0].Value + "' ");
                            if (result)
                            {
                                MessageBox.Show("Delete Successful");
                                FillGrid("");
                            }
                            else
                            {
                                MessageBox.Show("Some Record are depended");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("List is Empty ");
                }
            }
        }
    }
}
