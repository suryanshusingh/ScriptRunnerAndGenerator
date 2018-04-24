using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using spforcoretrac.DataObjects;
using spforcoretrac.Utilities;

namespace spforcoretrac.UserControls
{
    public partial class SettingsDatabaseUC : UserControl
    {
        public SettingsDatabaseUC()
        {
            InitializeComponent();
        }

        #region Members

        private string ViewName
        {
            get
            {
                return txtBoxViewName.Text;
            }
        }
        private string ServerName
        {
            get
            {
                return txtBoxServerName.Text;
            }

        }
        private string UserID
        {
            get
            {
                return txtBoxUserID.Text;
            }
        }
        private string Password
        {
            get
            {
                return txtBoxPassword.Text;
            }
        }
        private string DBName
        {
            get
            {
                return txtBoxDatabaseName.Text;
            }
        }

        #endregion Members

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }

            string ErrorMessage = "";

            DOTestConnection tc = new DOTestConnection();
            if (tc.CheckConnection(ServerName, UserID, Password, DBName, out ErrorMessage))
            {
                MessageBox.Show("Test Connection Successful");
                this.btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Test Connection Failed.\n" + ErrorMessage);
            }
        }

        private bool InputValidation()
        {
            if (String.IsNullOrEmpty(txtBoxViewName.Text))
            {
                CommonUtilities.ErrorMessage("Please input the view name");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxServerName.Text))
            {
                CommonUtilities.ErrorMessage("Please input the server name");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxUserID.Text))
            {
                CommonUtilities.ErrorMessage("Please input the user id");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                CommonUtilities.ErrorMessage("Please input the password");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxDatabaseName.Text))
            {
                CommonUtilities.ErrorMessage("Please input the Database Name");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }

            if (!CheckforDuplicates())
            {
                return;
            }

            string ErrorMessage = null;

            DODatabaseFunctions df = new DODatabaseFunctions();
            df.InsertDatabaseInfo(ViewName, ServerName, UserID, Password, DBName, out ErrorMessage);

        }

        private bool CheckforDuplicates()
        {
            DODatabaseFunctions df = new DODatabaseFunctions();
            List<DatabaseInfoList> alldbinfo = df.GetDatabaseInfo();

            foreach (var dbinfo in alldbinfo)
            {
                if (dbinfo.UniqueName == ViewName)
                {
                    CommonUtilities.ErrorMessage("View Name already exists. Please input another view name.");
                    return false;
                }

                if (dbinfo.ServerName == ServerName && dbinfo.DatabaseName == DBName)
                {
                    CommonUtilities.ErrorMessage("Same server and database already exists.");
                    return false;
                }
            }
            return true;
            
        }

    }
}