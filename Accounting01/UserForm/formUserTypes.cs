using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01
{
    public partial class formUserTypes : Form
    {
        public formUserTypes()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue)&&string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From UserTypes";
            }
            else
            {
                query = "Select * From UserTypes Where Usertype like '%"+ searchvalue +"%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvUserType.DataSource = dt;
                    dgvUserType.Columns[0].Width = 100;
                    dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvUserType.DataSource = null;
                }
            }
            else
            {
                dgvUserType.DataSource = null;
            }

        }

        private void formUserTypes_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtUserTypes.Text.Trim().Length ==0)
            {
                ep.SetError(txtUserTypes,"Please Enter User Types");
                txtUserTypes.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From UserTypes where Usertype ='"+ txtUserTypes.Text.Trim() +"'");
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    ep.SetError(txtUserTypes, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtUserTypes.Focus();
                    return;
                }
            }

            string query = string.Format("Insert into UserTypes(Usertype) values('{0}')", txtUserTypes.Text.Trim());
            bool result = DatabaseAccess.Insert(query);
            if (result)
            {
                MessageBox.Show("Insert Successful");
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            FillGrid(searchValue.Text.Trim());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtUserTypes.Clear();
        }

        private void EnableBtn()
        {
            btn_Edit.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvUserType.Enabled = false;
            searchValue.Enabled = false;
        }
        
        private void DisableBtn()
        {
            btn_Edit.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvUserType.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtUserTypes.Clear();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtUserTypes.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserTypes, "Please Enter User Types");
                txtUserTypes.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * From UserTypes where Usertype ='" + txtUserTypes.Text.Trim() + "'and UserTypesID ='" + Convert.ToSingle(dgvUserType.CurrentRow.Cells[0].Value) +  "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtUserTypes, "Already Registered");
                    MessageBox.Show("Already Registered");
                    txtUserTypes.Focus();
                    return;
                }
            }

            string query = string.Format("Update UserTypes set Usertype = '{0}' Where UserTypesID = '{1}' ", txtUserTypes.Text.Trim(), Convert.ToSingle(dgvUserType.CurrentRow.Cells[0].Value));
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
            if (dgvUserType != null)
            {
                if (dgvUserType.Rows.Count > 0)
                {
                    if (dgvUserType.SelectedRows.Count == 1)
                    {
                        txtUserTypes.Text = Convert.ToString(dgvUserType.CurrentRow.Cells[1].Value);
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
    }
}
