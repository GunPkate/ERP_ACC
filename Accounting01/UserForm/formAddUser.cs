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
    public partial class formAddUser : Form
    {
        public formAddUser()
        {
            InitializeComponent();
        }

        private void formAddUser_Load(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbUserType);
        }



        private void btn_refresh(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbUserType);
        }

        private void btn_addUsertype(object sender, EventArgs e)
        {
            formUserTypes form_usertypes = new formUserTypes();
            form_usertypes.ShowDialog();
            btn_refresh(sender, e);
        }

        private void clearForm()
        {
            cmbUserType.SelectedIndex = 0;
            txtFullname.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        private void btn_register(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbUserType,"Please select UserType");
                cmbUserType.Focus();
                return;
            }
            if (txtFullname.Text.Trim().Length == 0)
            {
                ep.SetError(txtFullname,"Please Enter Name");
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
                ep.SetError(txtUsername,"Please Enter Username");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "Please Enter Password");
                txtPassword.Focus();
                return;
            }

            if (txtConfirmPass.Text.Trim().Length == 0)
            {
                ep.SetError(txtConfirmPass, "Please Confirm Password");
                txtConfirmPass.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
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
                    ep.SetError(txtUsername, "User Already Regiestered cannot add");
                    txtUsername.Focus();
                    return;
                }
            }

            DataTable dt_fullname = new DataTable();
            dt_fullname = DatabaseAccess.Retrieve("Select * from UsersTable Where Fullname = '" + txtFullname.Text.Trim() + "'"); // Beware of spacebar
            if (dt_fullname != null)
            {
                if (dt_fullname.Rows.Count > 0)
                {
                    ep.SetError(txtFullname, "This name already regiestered");
                    txtFullname.Focus();
                    return;
                }
            }



            string insertquery = string.Format("Insert into UsersTable (UsertypeID,FullName,Email,ContactNo,UserName,Password) values ({0},'{1}','{2}','{3}','{4}','{5}')",
                Convert.ToInt32(cmbUserType.SelectedValue),
                txtFullname.Text.Trim(),
                txtEmail.Text.Trim(),
                txtContact.Text.Trim(),
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim()
                );

            bool result = DatabaseAccess.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("Register Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Register Fail");
            }

            
            //clearForm();
        }

        private void btn_clear(object sender, EventArgs e)
        {
            clearForm();
        }


        private void btn_gen_email(object sender, EventArgs e)
        {
            if (txtFullname.Text.Trim().Length != 0)
            {
                string name = txtFullname.Text;
                string email = "";
                string user = "";
                int y = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    if (Convert.ToString(name[i]) == " ")
                    {
                        y = i;
                    }
                }

                email = String.Format("{0}{1}{2}",
                    name.Substring(0, y).ToLower(),
                    name.Substring(y + 1, 2).ToLower(),
                    "@gcomapny.com"
                    );
                user = String.Format("{0}{1}",
                    name.Substring(0, y).ToLower(),
                    name.Substring(y + 1, 2).ToLower()
                    );

                txtEmail.Text = email;
                txtUsername.Text = user;
            }
            else
            {
                MessageBox.Show("Enter Fullname");
            }
        }

        private void btn_gen_pass(object sender, EventArgs e)
        {
            string name = txtFullname.Text;
            int y = 0;
            int x = 0;
            string pass = "";
            if (txtFullname.Text.Trim().Length != 0)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (Convert.ToString(name[i]) == " ")
                    {
                        y = i;
                    }
                }
                if(name.Length%2 == 1)
                {
                    x = 1;
                }
 
                pass = String.Format("{0}{1}{2}{3}",
                    name.Substring(y+1,1).ToUpper(),
                    name[0].ToString().ToLower(),
                    name.Length,
                    x);
            }
            txtPassword.Text = pass;
        }


    }
}
