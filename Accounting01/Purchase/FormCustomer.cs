using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.Purchase
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From Customer";
            }
            else
            {
                query = "Select * From Customer where (CustomerName+' '+ContactNo' '+address' '+Email' '+Description)  like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvCustomer.DataSource = dt;
                    dgvCustomer.Columns[0].Width = 100;
                    dgvCustomer.Columns[1].Width = 130;
                    dgvCustomer.Columns[2].Width = 120;
                    dgvCustomer.Columns[3].Width = 120;
                    dgvCustomer.Columns[4].Width = 120;
                    dgvCustomer.Columns[5].Width = 120;
                    //dgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvCustomer.DataSource = null;
                }
            }
            else
            {
                dgvCustomer.DataSource = null;
            }

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            checkError = "No";
            checkTextValue(txtContact);
            checkTextValue(txtCustomer);
            checkTextValue(txtEmail);
            if (checkError == "Yes")
            {
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Customer where CustomerName ='" + txtCustomer.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCustomer, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtCustomer.Focus();
                    return;
                }
            }

            string query = string.Format("Insert into Customer (CustomerName,ContactNo,Email,Address,Description) values('{0}','{1}','{2}','{3}','{4}');", txtCustomer.Text.Trim(), txtContact.Text.Trim(), txtEmail.Text.Trim(), textBoxAddress.Text.Trim(), textBoxDescription.Text.Trim());
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
            txtCustomer.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            textBoxAddress.Clear();
            textBoxDescription.Clear();
        }


        private void EnableComponents()
        {
            btn_Edit.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvCustomer.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Edit.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvCustomer.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtCustomer.Clear();
        }

        String checkError = "";
        private void checkTextValue(TextBox textValue) {
            if (textValue.Text.Trim().Length == 0)
            {
                ep.SetError(textValue, "Please Enter Customer");
                textValue.Focus();
                checkError = "Yes";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            checkError = "No";
            checkTextValue(txtContact);
            checkTextValue(txtCustomer);
            checkTextValue(txtEmail);
            if (checkError == "Yes") {
                return;
            }


            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From Customer where CustomerName='" + txtCustomer.Text.Trim() + "'and CustomerID ='" + Convert.ToSingle(dgvCustomer.CurrentRow.Cells[0].Value) + "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCustomer, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtCustomer.Focus();
                    return;
                }
            }

            string query = string.Format("Update Customer set CustomerName = '{0}' ,ContactNo = '{1}', Email= '{2}',Address='{3}', Description = '{4}' where CustomerID = '{5}';",
                txtCustomer.Text.Trim(),
                txtContact.Text.Trim(),
                txtEmail.Text.Trim(),
                textBoxAddress.Text.Trim(),
                textBoxDescription.Text.Trim(),
                Convert.ToString(dgvCustomer.CurrentRow.Cells[0].Value).Trim()
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
            txtCustomer.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            textBoxAddress.Clear();
            textBoxDescription.Clear();
            FillGrid("");
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomer != null)
            {
                if (dgvCustomer.Rows.Count > 0)
                {
                    if (dgvCustomer.SelectedRows.Count == 1)
                    {
                        txtCustomer.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[1].Value);
                        txtContact.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[2].Value);
                        txtEmail.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[3].Value);
                        textBoxAddress.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[4].Value);
                        textBoxDescription.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[5].Value);
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
            if (dgvCustomer != null)
            {
                if (dgvCustomer.Rows.Count > 0)
                {
                    if (dgvCustomer.SelectedRows.Count == 1)
                    {
                        txtCustomer.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[1].Value).Trim();
                        txtContact.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[2].Value).Trim();
                        textBoxAddress.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[3].Value).Trim();
                        txtEmail.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[4].Value).Trim();
                        textBoxDescription.Text = Convert.ToString(dgvCustomer.CurrentRow.Cells[5].Value).Trim();
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
            if (dgvCustomer != null)
            {
                if (dgvCustomer.Rows.Count > 0)
                {
                    if (dgvCustomer.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool result = DatabaseAccess.Delete("Delete from Customer where CustomerID = '" + dgvCustomer.CurrentRow.Cells[0].Value + "' ");
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
