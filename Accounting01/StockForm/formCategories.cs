using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.StockForm
{
    public partial class formCategories : Form
    {
        public formCategories()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From Category Where IsDeleted = 0";
            }
            else
            {
                query = "Select * From Category Where CategoryID like '%" + searchvalue + "%' AND IsDeleted = 0";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvCategory.DataSource = dt;
                    dgvCategory.Columns[0].Width = 100;
                    dgvCategory.Columns[1].Width = 100;
                    dgvCategory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvCategory.DataSource = null;
                }
            }
            else
            {
                dgvCategory.DataSource = null;
            }
            cbGetAll.Checked = false;
            cbIsDeleted.Checked = false;
        }

        private void FillGridIsDeleted(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From Category Where IsDeleted = 1";
            }
            else
            {
                query = "Select * From Category Where CategoryID like '%" + searchvalue + "%' AND IsDeleted = 1";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvCategory.DataSource = dt;
                    dgvCategory.Columns[0].Width = 100;
                    dgvCategory.Columns[1].Width = 100;
                    dgvCategory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvCategory.DataSource = null;
                }
            }
            else
            {
                dgvCategory.DataSource = null;
            }
        }

        private void FillGridGetAll(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From Category";
            }
            else
            {
                query = "Select * From Category Where CategoryID like '%" + searchvalue + "%' AND IsDeleted = 1";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvCategory.DataSource = dt;
                    dgvCategory.Columns[0].Width = 100;
                    dgvCategory.Columns[1].Width = 100;
                    dgvCategory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvCategory.DataSource = null;
                }
            }
            else
            {
                dgvCategory.DataSource = null;
            }
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            if (cbIsDeleted.Checked == true)
            {
                FillGridIsDeleted(searchValue.Text.Trim());
            }
            else
            {
                FillGrid(searchValue.Text.Trim());
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtCategory.Text.Trim().Length == 0)
            {
                ep.SetError(txtCategory, "Please Enter Category");
                txtCategory.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Category where CategoryName ='" + txtCategory.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCategory, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtCategory.Focus();
                    return;
                }
            }

            string query = string.Format("Insert into Category(CategoryName) values('{0}')", txtCategory.Text.Trim());
            bool result = DatabaseAccess.Insert(query);
            if (result)
            {
                MessageBox.Show("Insert Successful");
                cbIsDeleted.Checked = false;
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
            FillGrid("");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtCategory.Text.Trim().Length == 0)
            {
                ep.SetError(txtCategory, "Please Enter Category");
                txtCategory.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Category where CategoryName ='" + txtCategory.Text.Trim() + "'and CategoryID ='" + Convert.ToSingle(dgvCategory.CurrentRow.Cells[0].Value) + "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCategory, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtCategory.Focus();
                    return;
                }
            }

            string query = string.Format("Update Category set CategoryName = '{0}' Where CategoryID = '{1}' ", txtCategory.Text.Trim(), Convert.ToSingle(dgvCategory.CurrentRow.Cells[0].Value));
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
            btn_Edit.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvCategory.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Edit.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvCategory.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtCategory.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCategory != null)
            {
                if (dgvCategory.Rows.Count > 0)
                {
                    if (dgvCategory.SelectedRows.Count == 1)
                    {
                        if (deleteToolStripMenuItem.Text == "Delete")
                        {
                            if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string deletequery = "Update Category set IsDeleted = 1 where CategoryID = '" + dgvCategory.CurrentRow.Cells[0].Value + "'";
                                bool result = DatabaseAccess.Update(deletequery);
                                //bool result = DatabaseAccess.Delete("Delete from Category where CategoryID = '" + dgvCategory.CurrentRow.Cells[0].Value + "' ");
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
                        else if(deleteToolStripMenuItem.Text == "Recover"){
                            if (MessageBox.Show("Do you want to recover this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string deletequery = "Update Category set IsDeleted = 0 where CategoryID = '" + dgvCategory.CurrentRow.Cells[0].Value + "'";
                                bool result = DatabaseAccess.Update(deletequery);
                                //bool result = DatabaseAccess.Delete("Delete from Category where CategoryID = '" + dgvCategory.CurrentRow.Cells[0].Value + "' ");
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

        private void cbIsDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsDeleted.Checked == true)
            {
                FillGridIsDeleted("");
            }
            else
            {
                FillGrid("");
            }
        }

        private void getAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGetAll.Checked == true)
            {
                FillGridGetAll("");
            }
            else
            {
                FillGrid("");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCategory != null)
            {
                if (dgvCategory.Rows.Count > 0)
                {
                    if (dgvCategory.SelectedRows.Count == 1)
                    {
                        txtCategory.Text = Convert.ToString(dgvCategory.CurrentRow.Cells[1].Value);
                        EnableBtn();
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

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dgvCategory != null)
            {
                if (dgvCategory.Rows.Count > 0)
                {
                    if (dgvCategory.SelectedRows.Count == 1)
                    {
                        if (Convert.ToBoolean(dgvCategory.CurrentRow.Cells[2].Value) == true)
                        {
                            deleteToolStripMenuItem.Text = "Recover";
                        }
                        else
                        {
                            deleteToolStripMenuItem.Text = "Delete";
                        }
                    }
                }
                else
                {
                    deleteToolStripMenuItem.Text = "Detete";
                }
            }
            else {
                deleteToolStripMenuItem.Text = "Detete";
            }
        }

    }
}
