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
    public partial class formLogin : Form
    {
        private mainForm mainForm;

        public formLogin(mainForm mainForm)
        {
            InitializeComponent();
            labError.Visible = false;
            this.mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.TextLength == 0)
            {
                labError.Visible = true;
                ep.SetError(txtUsername, "Please Enter Your Username");
                txtUsername.Focus();
                return;
            }
            if(txtPassword.TextLength == 0)
            {
                labError.Visible = true;
                ep.SetError(txtPassword, "Please Enter Your Username");
                txtPassword.Focus();
                return;
            }

            string getquery = "select * from UsersTable where UserName ='" + txtUsername.Text.Trim() + "' and Password ='"+ txtPassword.Text.Trim() +"'";
            DataTable dt = DatabaseAccess.Retrieve(getquery);
            if (dt == null) 
            {
                labError.Visible = true;
                mainForm.btnLogin.Visible = true;
                mainForm.btnLogout.Visible = false;
                mainForm.menuStripAll.Enabled = false;
                return;
            }
            else if(dt.Rows.Count > 0)
            {
                mainForm.btnLogin.Visible = false;
                mainForm.btnLogout.Visible = true;
                mainForm.menuStripAll.Enabled = true;
                CurrentUser.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                CurrentUser.UsertypeID = Convert.ToInt32(dt.Rows[0]["UsertypeID"]);
                CurrentUser.FullName = Convert.ToString(dt.Rows[0]["FullName"]);
                CurrentUser.Email = Convert.ToString(dt.Rows[0]["Email"]);
                CurrentUser.ContactNo = Convert.ToString(dt.Rows[0]["ContactNo"]);
                CurrentUser.UserName= Convert.ToString(dt.Rows[0]["UserName"]);
                //if (CurrentUser.UserID != 1) 
                //{
                //    mainForm.menuStripAll.Items[4].Enabled = false;
                //}
                this.Close();
                return;
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
