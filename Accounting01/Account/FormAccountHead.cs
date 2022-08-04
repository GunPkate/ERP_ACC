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
    public partial class FormAccountHead : Form
    {
        public FormAccountHead()
        {
            InitializeComponent();
        }
        private void FormAccountHead_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccount.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccount, "Please Enter Account");
                txtAccount.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from AccountHead where AccountHeadName = '" + txtAccount.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccount, "Already Exist");
                    txtAccount.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into AccountHead(UserID, AccountHeadName) values('{0}','{1}')", CurrentUser.UserID, txtAccount.Text.Trim());
            bool result = DatabaseAccess.Insert(insertquery);
            if (result) {
                MessageBox.Show("Account Saved");
                txtAccount.Clear();
                FillGrid("");
            }
            else {
                MessageBox.Show("Invalid");
            }
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From v_AccountList";
            }
            else
            {
                query = "select * from v_accountList where (ACC_name+' '+UserName+' '+CAST(Acc_ID AS varchar)) like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvAccount.DataSource = dt;
                    dgvAccount.Columns[0].Width = 100;
                    dgvAccount.Columns[1].Width = 100;
                    dgvAccount.Columns[2].Width = 100;
                }
                else
                {
                    dgvAccount.DataSource = null;
                }
            }
            else
            {
                dgvAccount.DataSource = null;
            }
            //cbGetAll.Checked = false;
            //cbIsDeleted.Checked = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount != null)
            {
                if (dgvAccount.Rows.Count > 0)
                {
                    if (dgvAccount.SelectedRows.Count == 1)
                    {
                        txtAccount.Text = Convert.ToString(dgvAccount.CurrentRow.Cells[2].Value);
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
            btn_Save.Enabled = false;
            dgvAccount.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Update.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvAccount.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtAccount.Clear();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccount.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccount, "Please Enter Account");
                txtAccount.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from AccountHead where AccountHeadName = '" + txtAccount.Text + "'  where ACC_ID =" + dgvAccount.CurrentRow.Cells[0].Value);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccount, "Already Exist");
                    txtAccount.Focus();
                    return;
                }
            }

            string updatequery = string.Format("Update AccountHead set UserID = '{0}', AccountHeadName = '{1}' where AccountHeadID = '{2}'", CurrentUser.UserID, txtAccount.Text.Trim(), dgvAccount.CurrentRow.Cells[0].Value);
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
            if (dgvAccount != null)
            {
                if (dgvAccount.Rows.Count > 0)
                {
                    if (dgvAccount.SelectedRows.Count == 1)
                    {
                        txtAccount.Text = Convert.ToString(dgvAccount.CurrentRow.Cells[1].Value);
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
            if (dgvAccount!= null)
            {
                if (dgvAccount.Rows.Count > 0)
                {
                    if (dgvAccount.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool result = DatabaseAccess.Delete("Delete from AccountHead where AccountHeadID = '" + dgvAccount.CurrentRow.Cells[0].Value + "' ");
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
