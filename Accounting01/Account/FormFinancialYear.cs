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
    public partial class FormFinancialYear : Form
    {
        public FormFinancialYear()
        {
            InitializeComponent();
        }

        private void FormFinancialYear_Load(object sender, EventArgs e)
        {
            {
                FillGrid("");
            }
        }

        //private void btnAddAccountHead_Click(object sender, EventArgs e)
        //{
        //    FormAccountHead formAccountHead = new FormAccountHead();
        //    formAccountHead.ShowDialog();
        //}

        //private void btnAddAccountControl_Click(object sender, EventArgs e)
        //{
        //    FormAccountControl formAccountControl = new FormAccountControl();
        //    formAccountControl.ShowDialog();
        //}

        //private void btnRefreshHead_Click(object sender, EventArgs e)
        //{
        //    ComboHelper.FillAccountHead(cmbAccountHead);
        //}

        //private void btnRefreshControl_Click(object sender, EventArgs e)
        //{
        //    ComboHelper.FillAccountControl(cmbAccountControl);
        //}






        private void EnableComponents()
        {
            btn_Update.Enabled = true;
            btn_Cancle.Enabled = true;
            btn_Save.Enabled = false;
            dgvFinancial.Enabled = false;
            searchValue.Enabled = false;
        }

        private void DisableBtn()
        {
            btn_Update.Enabled = false;
            btn_Cancle.Enabled = false;
            btn_Save.Enabled = true;
            dgvFinancial.Enabled = true;
            searchValue.Enabled = true;
            FillGrid("");
            txtFinancial.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtFinancial.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }



        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From FinancialYear";
            }
            else
            {
                query = "select * from FinancialYear where (FinancialYearID+' '+FinancialYear+' '+StartDate' '+IsActive)  like '%" + searchvalue + "%'";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvFinancial.DataSource = dt;
                    dgvFinancial.Columns[0].Width = 120;
                    dgvFinancial.Columns[1].Width = 120;
                    dgvFinancial.Columns[2].Width = 120;
                    dgvFinancial.Columns[3].Width = 120;
                }
                else
                {
                    dgvFinancial.DataSource = null;
                }
            }
            else
            {
                dgvFinancial.DataSource = null;
            }
            //cbGetAll.Checked = false;
            //cbIsDeleted.Checked = false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtFinancial.Text.Trim().Length == 0)
            {
                ep.SetError(txtFinancial, "Please Enter Account");
                txtFinancial.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from FinancialYear where FinancialYear = '" + txtFinancial.Text + "' and StartDate = '" + dateTimePicker1.Value+';' );
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtFinancial, "Already Exist");
                    txtFinancial.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into FinancialYear (FinancialYear, StartDate, EndDate, IsActive ) values('{0}','{1}', DateAdd(YY,1,'{2}'),'{3}');", txtFinancial.Text.Trim(), dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker1.Value.ToString("yyyy/MM/dd"), checkActive.Checked);
            //MessageBox.Show(cmbAccountControl.Items[2].ToString());
            //MessageBox.Show(cmbAccountControl.SelectedValue.ToString());
            bool result = DatabaseAccess.Insert(insertquery);
            if (result)
            {
                MessageBox.Show("FinancialYear Saved");
                txtFinancial.Clear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
                        ep.Clear();
            if (txtFinancial.Text.Trim().Length == 0)
            {
                ep.SetError(txtFinancial, "Please Enter Account");
                txtFinancial.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.Retrieve("select * from FinancialYear where FinancialYear = '" + txtFinancial.Text + "' and StartDate = '" + dateTimePicker1.Value + ';');
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtFinancial, "Already Exist");
                    txtFinancial.Focus();
                    return;
                }
            }

            string updatequery = string.Format("Update FinancialYear set FinancialYear = '{0}', StartDate = '{1}', EndDate = DateAdd(YY,1,'{2}'), IsActive = '{3}' where FinancialYearID = '{4}' ; ", txtFinancial.Text.Trim(), dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker1.Value.ToString("yyyy/MM/dd"), checkActive.Checked, dgvFinancial.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.Update(updatequery);
            if (result)
            {
                MessageBox.Show("Account Updated");
                DisableBtn();
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DisableBtn();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            FillGrid(searchValue.Text.Trim());
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            if (dgvFinancial != null)
            {
                if (dgvFinancial.Rows.Count > 0)
                {
                    if (dgvFinancial.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool result = DatabaseAccess.Delete("Delete from AccountHead where AccountHeadID = '" + dgvFinancial.CurrentRow.Cells[0].Value + "' ");
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

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            if (dgvFinancial != null)
            {
                if (dgvFinancial.Rows.Count > 0)
                {
                    if (dgvFinancial.SelectedRows.Count == 1)
                    {
                        txtFinancial.Text = Convert.ToString(dgvFinancial.CurrentRow.Cells[1].Value);
                        //dateTimePicker1.Value = dgvFinancial.CurrentRow.Cells[1].Value;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }

}
