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
    public partial class FormAccountControl : Form
    {
        public FormAccountControl()
        {
            InitializeComponent();
        }

        private void btnAddAccountHead_Click(object sender, EventArgs e)
        {
            FormAccountHead formAccountHead = new FormAccountHead();
            formAccountHead.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountControl);
        }

        private void formAccountControl_Load(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountControl);
            btnRefresh_Click(sender, e);
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            //if (cbIsDeleted.Checked == true)
            //{
            //    FillGridIsDeleted(searchValue.Text.Trim());
            //}
            //else
            {
                FillGrid(searchValue.Text.Trim());
            }
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From AccountControl";
            }
            else
            {
                query = "Select * From AccountControl Where AccountControlID like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvAccountControl.DataSource = dt;
                    dgvAccountControl.Columns[0].Width = 100;
                    dgvAccountControl.Columns[1].Width = 100;
                    dgvAccountControl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvAccountControl.DataSource = null;
                }
            }
            else
            {
                dgvAccountControl.DataSource = null;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccountControl.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccountControl, "Please Enter Acccount");
                txtAccountControl.Focus();
                return;
            }

            if (cmbAccountControl.SelectedIndex == 0)
            {
                ep.SetError(cmbAccountControl, "Please enter AccountControl");
                cmbAccountControl.Focus();
            }
            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From AccountControl where AccountControlName ='" + txtAccountControl.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccountControl, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtAccountControl.Focus();
                    return;
                }
            }

            string query = string.Format("Insert into AccountControl(AccountControlName) values('{0}')", txtAccountControl.Text.Trim());
            bool result = DatabaseAccess.Insert(query);
            if (result)
            {
                MessageBox.Show("Insert Successful");
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
            FillGrid("");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtAccountControl.Clear();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccountControl.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccountControl, "Please Enter Account Control");
                txtAccountControl.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From AccountControl where AccountControlName ='" + txtAccountControl.Text.Trim() + "'and AccountControlID ='" + Convert.ToSingle(dgvAccountControl.CurrentRow.Cells[0].Value) + "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccountControl, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtAccountControl.Focus();
                    return;
                }
            }

            string query = string.Format("Update AccountControl set AccountControlName = '{0}' Where AccountControlID = '{1}' ", txtAccountControl.Text.Trim(), Convert.ToSingle(dgvAccountControl.CurrentRow.Cells[0].Value));
            bool result = DatabaseAccess.Update(query);
            if (result)
            {
                MessageBox.Show("Update Successful");
                DisableBtn();
            }
            else
            {
                MessageBox.Show("Update  Fail");
            }
        }

        private void EnableBtn()
        {
            //btn.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvAccountControl.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            //btn_Edit.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvAccountControl.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtAccountControl.Clear();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvAccountControl != null)
            {
                if (dgvAccountControl.Rows.Count > 0)
                {
                    if (dgvAccountControl.SelectedRows.Count == 1)
                    {
                        if (deleteToolStripMenuItem.Text == "Delete")
                        {
                            if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string deletequery = "Update AccountControl set IsDeleted = 1 where AccountControlID = '" + dgvAccountControl.CurrentRow.Cells[0].Value + "'";
                                bool result = DatabaseAccess.Update(deletequery);
                                //bool result = DatabaseAccess.Delete("Delete from AccountControl where AccountControlID = '" + dgvAccountControl.CurrentRow.Cells[0].Value + "' ");
                                if (result)
                                {
                                    MessageBox.Show("Delete is set Successfully");
                                    FillGrid("");
                                }
                                else
                                {
                                    MessageBox.Show("Some Record are depended");
                                }
                            }
                        }
                        else if (deleteToolStripMenuItem.Text == "Recover")
                        {
                            if (MessageBox.Show("Do you want to recover this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string deletequery = "Update AccountControl set IsDeleted = 0 where AccountControlID = '" + dgvAccountControl.CurrentRow.Cells[0].Value + "'";
                                bool result = DatabaseAccess.Update(deletequery);
                                //bool result = DatabaseAccess.Delete("Delete from AccountControl where AccountControlID = '" + dgvAccountControl.CurrentRow.Cells[0].Value + "' ");
                                if (result)
                                {
                                    MessageBox.Show("Relete is set Successfully");
                                    FillGrid("");
                                }
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

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }



        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtAccountControl.Text.Trim().Length == 0)
            {
                ep.SetError(txtAccountControl, "Please Enter Account");
                txtAccountControl.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from AccountControlwhere AccountControlName = '" + txtAccountControl.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtAccountControl, "Already Exist");
                    txtAccountControl.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into AccountControl(UserID, AccountControlName) values('{0}','{1}')", CurrentUser.UserID, txtAccountControl.Text.Trim());
            bool result = DatabaseAccess.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Account Saved");
                txtAccountControl.Clear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
