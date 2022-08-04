using Accounting01.SourceCode;
using Accounting01.StockForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.Product
{
    public partial class formProductDetails : Form
    {
        public formProductDetails()
        {
            InitializeComponent();
        }

        private void formProductDetails_Load(object sender, EventArgs e)
        {
            ComboHelper.FillCategoryTypes(cmbSelectCategory);
            FillGrid("");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            formCategories form = new formCategories();
            form.ShowDialog();
            ComboHelper.FillCategoryTypes(cmbSelectCategory);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ComboHelper.FillCategoryTypes(cmbSelectCategory);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbSelectCategory.SelectedIndex == 0) {
                ep.SetError(cmbSelectCategory, "Please Select Producttype");
                cmbSelectCategory.Focus();
                return;
            }

            if (txtProductName.Text.Trim().Length == 0) {
                ep.SetError(txtProductName, "Please Enter ProductName");
                txtProductName.Focus();
                return;
            }
            if (txtQuantity.Text.Trim().Length == 0 == null) {
                ep.SetError(txtQuantity, "Please Enter Quantity");
                txtQuantity.Focus();
                return;
            }
            if (txtSaleUnitPrice.Text.Trim().Length == 0 == null) {
                ep.SetError(txtSaleUnitPrice, "Please Enter Sale Unit tPrice");
                txtSaleUnitPrice.Focus();
                return;
            }
            if (txtPurchaseUnitPrice.Text.Trim().Length == 0 == null) {
                ep.SetError(txtPurchaseUnitPrice, "Please Enter Purchase Unit tPrice");
                txtPurchaseUnitPrice.Focus();
                return;
            }
            if (txtTresholdQTY.Text.Trim().Length == 0 == null) {
                ep.SetError(txtTresholdQTY, "Please Enter Treshold QuantitY");
                txtTresholdQTY.Focus();
                return;
            }

            string checkquery = String.Format("Select * from Stock where CategoryID = '{0}' and ProductName = '{1}'", cmbSelectCategory.SelectedValue,txtProductName.Text.Trim());
            DataTable dt = DatabaseAccess.Retrieve(checkquery);
            if (dt != null)
            {
                if (dt.Rows.Count > 0) {
                    ep.SetError(txtProductName,"Aready Exist");
                    txtProductName.Focus();
                    MessageBox.Show("Aready Exist");
                    return;
                }
            }

            string insertquery = String.Format("insert into Stock(CategoryID, UserID, ProductName, ExpiryDate, MfturDate, Description) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", cmbSelectCategory.SelectedValue, CurrentUser.UserID, txtProductName.Text.Trim(), dtpExpiryDate.Value.ToString("yyyy/MM/dd"), dtpManufactureDate.Value.ToString("yyyy/MM/dd"), txtDescription.Text.Trim());
            //string insertquery = String.Format("insert into Stock(CategoryID, ProductName, Quantity, SaleUnitPrice, CurrentPurchaseUnitPrice, ExpiryDate, MfturDate, StockTresholdQty, Description, IsDeleted) values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", cmbSelectCategory.SelectedIndex,txtProductName.Text.Trim(),txtQuantity.Text.Trim(),txtSaleUnitPrice.Text.Trim(),txtPurchaseUnitPrice.Text.Trim(),dtpExpiryDate.Value.ToString("yyyy/MM/dd"),dtpManufactureDate.Value.ToString("yyyy/MM/dd"), txtTresholdQTY.Text.Trim(),txtDescription.Text.Trim());
            bool result = DatabaseAccess.Insert(insertquery);
            if (result) {
                MessageBox.Show("Product Added");
                FormClear();
                FillGrid("");
            }
        }

        private void FillGrid(string searchvalue) // Empty String variable take parameter from searchValue_TextChanged
        {
            string query = string.Empty;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchvalue) && string.IsNullOrWhiteSpace(searchvalue))
            {
                query = "Select * From v_ProductList Where IsDeleted = 0";
            }
            else
            {
                query = "Select * From v_ProductList Where (CategoryName+' '+ProductName +' '+ UserName +' '+ Description+' '+ cast(CategoryID as varchar)) like '%" + searchvalue + "%' AND IsDeleted = 0";
            }

            dt = DatabaseAccess.Retrieve(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvProductList.DataSource = dt;
                    dgvProductList.Columns[0].Width = 100;
                    dgvProductList.Columns[1].Width = 100;
                    dgvProductList.Columns[2].Width = 100;
                }
                else
                {
                    dgvProductList.DataSource = null;
                }
            }
            else
            {
                dgvProductList.DataSource = null;
            }
            //cbGetAll.Checked = false;
            //cbIsDeleted.Checked = false;
        }

        private void FormClear()
        {
            cmbSelectCategory.SelectedIndex = 0;
            txtProductName.Clear();
            txtDescription.Clear();
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            FillGrid(searchValue.Text.Trim());
        }
    }
}
