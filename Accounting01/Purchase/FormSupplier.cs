using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.SupplierAndCustomer
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From Supplier";
            }
            else
            {
                query = "Select * From Supplier where (SupplierName+' '+ContactNo' '+address' '+Email' '+Description)  like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvSupplier.DataSource = dt;
                    dgvSupplier.Columns[0].Width = 100;
                    dgvSupplier.Columns[1].Width = 130;
                    dgvSupplier.Columns[2].Width = 120;
                    dgvSupplier.Columns[3].Width = 120;
                    dgvSupplier.Columns[4].Width = 120;
                    dgvSupplier.Columns[5].Width = 120;
                    //dgvSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvSupplier.DataSource = null;
                }
            }
            else
            {
                dgvSupplier.DataSource = null;
            }

        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSupplier.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplier, "Please Enter Supplier");
                txtSupplier.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Supplier where SupplierName ='" + txtSupplier.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSupplier, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtSupplier.Focus();
                    return;
                }
            }

            string query = string.Format("Insert into Supplier (SupplierName,ContactNo,Email,Address,Description) values('{0}','{1}','{2}','{3}','{4}';)", txtSupplier.Text.Trim(),txtContact.Text.Trim(), txtEmail.Text.Trim(), textBoxAddress.Text.Trim(), textBoxDescription.Text.Trim());
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

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            FillGrid(searchValue.Text.Trim());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtSupplier.Clear();
        }


        private void EnableComponents()
        {
            btn_Edit.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvSupplier.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Edit.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvSupplier.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtSupplier.Clear();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSupplier.Text.Trim().Length == 0)
            {
                ep.SetError(txtSupplier, "Please Enter Supplier");
                txtSupplier.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Supplier where SupplierName='" + txtSupplier.Text.Trim() + "'and SupplierID ='" + Convert.ToSingle(dgvSupplier.CurrentRow.Cells[0].Value) + "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSupplier, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtSupplier.Focus();
                    return;
                }
            }

            string query = string.Format("Update Supplier set SupplierName = '{0}' ,ContactNo = '{1}',,Email= '{2}',Address='{3}' Description = '{4}' where SupplierID = '{5}')", 
                txtSupplier.Text.Trim(), 
                txtContact.Text.Trim(),
                txtEmail.Text.Trim(), 
                textBoxAddress.Text.Trim(), 
                textBoxDescription.Text.Trim(),
                Convert.ToString(dgvSupplier.CurrentRow.Cells[0].Value).Trim()
            );

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

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvSupplier != null)
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    if (dgvSupplier.SelectedRows.Count == 1)
                    {
                        txtSupplier.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[1].Value);
                        txtContact.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[2].Value);
                        txtEmail.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[3].Value);
                        textBoxAddress.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[4].Value);
                        textBoxDescription.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[5].Value);
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSupplier != null)
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    if (dgvSupplier.SelectedRows.Count == 1)
                    {
                        txtSupplier.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[1].Value);
                        //dateTimePicker1.Value = dgvSupplier.CurrentRow.Cells[1].Value;
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
            if (dgvSupplier != null)
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    if (dgvSupplier.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool result = DatabaseAccess.Delete("Delete from AccountHead where AccountHeadID = '" + dgvSupplier.CurrentRow.Cells[0].Value + "' ");
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
