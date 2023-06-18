using Accounting01.Account;
using Accounting01.Product;
using Accounting01.StockForm;
using Accounting01.UserForm;
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
    public partial class mainForm : Form
    {
        formUserTypes UserTypesForm;
        formAddUser AddUserForm;
        formProductDetails Add_ProductForm;

        public mainForm()
        {
            InitializeComponent();
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            menuStripAll.Enabled = false;
        }

        private void userTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypesForm == null)
            {
                UserTypesForm = new formUserTypes();
            }
            UserTypesForm.ShowDialog();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddUserForm == null)
            {
                AddUserForm = new formAddUser();
            }
            AddUserForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin(this);
            formLogin.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            menuStripAll.Enabled = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdateUser updateUser = new formUpdateUser();
            updateUser.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategories formCategories = new formCategories();
            formCategories.ShowDialog(); 
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Add_ProductForm == null) {
                Add_ProductForm = new formProductDetails();
            }
            Add_ProductForm.TopLevel = false;
            panelParent.Controls.Add(Add_ProductForm);
            Add_ProductForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Add_ProductForm.Dock = DockStyle.Fill;
            Add_ProductForm.Show();
        }

        private void accountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountHead formAccountHead = new FormAccountHead();
            formAccountHead.Show();
        }

        private void accountControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountControl formAccountControl = new FormAccountControl();
            formAccountControl.ShowDialog();
        }

        private void accountSubControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountSubControl formAccountSubControl = new FormAccountSubControl();
            formAccountSubControl.ShowDialog();
        }

        private void financialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinancialYear formFinancialYear = new FormFinancialYear();
            formFinancialYear.ShowDialog();
        }
    }
}
