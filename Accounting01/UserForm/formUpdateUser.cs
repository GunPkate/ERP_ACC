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

namespace Accounting01.UserForm
{
    public partial class formUpdateUser : Form
    {
        public formUpdateUser()
        {
            InitializeComponent();
            if (CurrentUser.UserID > 0)
            {
                cmbUserType.SelectedItem = CurrentUser.UserID;
                txtFullname.Text = CurrentUser.FullName;
                txtContact.Text = CurrentUser.ContactNo;
                txtEmail.Text = CurrentUser.Email;
                txtUsername.Text = CurrentUser.UserName;

            }
        }

        private void ClearForm() {
            cmbUserType.SelectedItem = 0;
            txtFullname.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtNewPassword.Clear();
            txtOldPassword.Clear();
        }

        private void formUpdateUser_Load(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbUserType);
        }

        private void btnUserTypes_Click(object sender, EventArgs e)
        {
            formUserTypes form_usertypes = new formUserTypes();
            form_usertypes.ShowDialog();
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbUserType);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbUserType, "Please select UserType");
                cmbUserType.Focus();
                return;
            }
            if (txtFullname.Text.Trim().Length == 0)
            {
                ep.SetError(txtFullname, "Please Enter Name");
                txtFullname.Focus();
                return;
            }

            if (txtContact.Text.Trim().Length == 0)
            {
                ep.SetError(txtContact, "Please Enter Contact");
                txtContact.Focus();
                return;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                ep.SetError(txtEmail, "Please Enter Email");
                txtEmail.Focus();
                return;
            }

            if (txtUsername.Text.Trim().Length == 0)
            {
                ep.SetError(txtUsername, "Please Enter Username");
                txtUsername.Focus();
                return;
            }

            if (txtNewPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtNewPassword, "Please Enter Password");
                txtNewPassword.Focus();
                return;
            }

            if (txtConfirmPass.Text.Trim().Length == 0)
            {
                ep.SetError(txtConfirmPass, "Please Confirm Password");
                txtConfirmPass.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPass.Text)
            {
                ep.SetError(txtConfirmPass, "Password not match");
                txtConfirmPass.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrieve("Select * from UsersTable Where UserName = '" + txtUsername.Text.Trim() + "'"); // Beware of spacebar
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtUsername, "User Already Regiestered");
                    txtUsername.Focus();
                    return;
                }
            }

            string updatequery = String.Format("update UsersTable set UsertypeID = {0}, FullName = '{1}', Email = '{2}', ContactNo = '{3}', UserName = '{4}', Password = '{5}' where UserName = '" + CurrentUser.UserName + "'"
                , Convert.ToInt32(cmbUserType.SelectedValue)
                , txtFullname.Text.Trim()
                , txtEmail.Text.Trim()
                , txtContact.Text.Trim()
                , txtUsername.Text.Trim()
                , txtNewPassword.Text.Trim()
                ); 
            bool result = DatabaseAccess.Update(updatequery);
            if (result)
            {
                MessageBox.Show("Successfully Update");
                this.Close();
            }
            else {
                MessageBox.Show("Update Fail");
            }
        }


    }
}
