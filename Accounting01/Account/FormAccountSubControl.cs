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

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void FillGrid(string searchValue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchValue) && string.IsNullOrWhiteSpace(searchValue))
            {
                query = "Select * From AccountSubControl";
            }
            else
            {
                query = "Select * From AccountSubControl Where AccountSubControlID like '%" + searchValue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvAccountSubControl.DataSource = dt;
                    dgvAccountSubControl.Columns[0].Width = 100;
                    dgvAccountSubControl.Columns[1].Width = 100;
                    dgvAccountSubControl.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvAccountSubControl.DataSource = null;
                }
            }
            else
            {
                dgvAccountSubControl.DataSource = null;
            }
        }

    }
}
