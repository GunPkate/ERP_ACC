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
    public partial class FormAccountSubControl : Form
    {
        public FormAccountSubControl()
        {
            InitializeComponent();
        }
        private void FormAccountSubControl_Load(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountHead);
            ComboHelper.FillAccountControl(cmbAccountControl);
        }


        private void btnAddAccountHead_Click(object sender, EventArgs e)
        {
            FormAccountHead formAccountHead = new FormAccountHead();
            formAccountHead.ShowDialog();
        }

        private void btnAddAccountControl_Click(object sender, EventArgs e)
        {
            FormAccountControl formAccountControl = new FormAccountControl();
            formAccountControl.ShowDialog();
        }

        private void btnRefreshHead_Click(object sender, EventArgs e)
        {
            ComboHelper.FillAccountHead(cmbAccountHead);
        }

        private void btnRefreshControl_Click(object sender, EventArgs e)
        {
            ComboHelper.FillAccountControl(cmbAccountControl);
        }
    }
}
