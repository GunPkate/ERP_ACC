using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting01.SourceCode
{
    public class ComboHelper
    {
        public static void FillUserTypes(ComboBox cmb)
        {
            DataTable dtUserType = new DataTable();
            dtUserType.Columns.Add("UsertypeID");
            dtUserType.Columns.Add("Usertype");
            dtUserType.Rows.Add("0","---Select---");

            try
            {
                DataTable dt = DatabaseAccess.Retrieve("Select * From UserTypes");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow userType in dt.Rows)
                        {
                            dtUserType.Rows.Add(userType["UsertypeID"], userType["Usertype"]);
                        }
                    }
                }

                cmb.DataSource = dtUserType;
                cmb.ValueMember = "UsertypeID"; //Display as index value
                cmb.DisplayMember = "Usertype"; //display value

            }
            catch (Exception)
            {
                cmb.DataSource = dtUserType;
            }

        }
        public static void FillCategoryTypes(ComboBox cmb)
        {
            DataTable dtCategoryType = new DataTable();
            dtCategoryType.Columns.Add("CategoryID");
            dtCategoryType.Columns.Add("CategoryName");
            dtCategoryType.Rows.Add("0", "---Select---");

            try
            {
                DataTable dt = DatabaseAccess.Retrieve("Select * From Category where IsDeleted = 0");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow CategoryType in dt.Rows)
                        {
                            dtCategoryType.Rows.Add(CategoryType["CategoryID"], CategoryType["CategoryName"]);
                        }
                    }
                }

                cmb.DataSource = dtCategoryType;
                cmb.ValueMember = "CategoryID"; //Display as index value
                cmb.DisplayMember = "CategoryName"; //display value

            }
            catch (Exception)
            {
                cmb.DataSource = dtCategoryType;
            }

        }

        public static void FillAccountHead(ComboBox cmb)
        {
            DataTable dtAccountHeadID = new DataTable();
            dtAccountHeadID.Columns.Add("AccountHeadID");
            dtAccountHeadID.Columns.Add("AccountHeadName");
            dtAccountHeadID.Rows.Add("0", "---Select---");

            try
            {
                DataTable dt = DatabaseAccess.Retrieve("Select * From AccountHead");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow AccountHead in dt.Rows)
                        {
                            dtAccountHeadID.Rows.Add(AccountHead["AccountHeadID"], AccountHead["AccountHeadName"]);
                        }
                    }
                }

                cmb.DataSource = dtAccountHeadID;
                cmb.ValueMember = "AccountHeadID"; //Display as index value
                cmb.DisplayMember = "AccountHeadName"; //display value

            }
            catch (Exception)
            {
                cmb.DataSource = dtAccountHeadID;
            }

        }

        public static void FillAccountControl(ComboBox cmb)
        {
            DataTable dtAccountControlID = new DataTable();
            dtAccountControlID.Columns.Add("AccountControlID");
            dtAccountControlID.Columns.Add("AccountControlName");
            dtAccountControlID.Rows.Add("0", "---Select---");

            try
            {
                DataTable dt = DatabaseAccess.Retrieve("Select * From AccountControl");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow AccountControl in dt.Rows)
                        {
                            dtAccountControlID.Rows.Add(AccountControl["AccountControlID"], AccountControl["AccountControlName"]);
                        }
                    }
                }

                cmb.DataSource = dtAccountControlID;
                cmb.ValueMember = "AccountControlID"; //Display as index value
                cmb.DisplayMember = "AccountControlName"; //display value

            }
            catch (Exception)
            {
                cmb.DataSource = dtAccountControlID;
            }

        }

    }
}
