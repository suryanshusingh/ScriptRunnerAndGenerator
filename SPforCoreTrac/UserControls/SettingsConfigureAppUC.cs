using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPforCoreTrac.DataObjects;
using System.Xml;
using System.IO;

namespace SPforCoreTrac.UserControls
{
    public partial class SettingsConfigureAppUC : UserControl
    {
        public SettingsConfigureAppUC()
        {
            InitializeComponent();
        }

        #region Members
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

        #endregion Members


        private bool InputValidation()
        {
            return true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }

            string ErrorMessage = "";

            DOTestConnection tc = new DOTestConnection();
            if (tc.CheckAppServerConnection(ServerName, UserID, Password, out ErrorMessage))
            {
                MessageBox.Show("Test Connection Successful");
                this.btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Test Connection Failed.\n" + ErrorMessage);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this is not required but still as a precaution
            if (!InputValidation())
            {
                return;
            }

            if (!DOFileCreateAndUpdate.CreateAndUpdateFile(ServerName, UserID, Password))
            {
                DoRollBack();
                MessageBox.Show("");
                return;
            }

            if (!DOAppDatabaseInfo.GetDBInfoFromFile())
            {
                MessageBox.Show("Error: Issues in reading config file.");
                return;
            }

            string AppServerName = DOAppDatabaseInfo.ServerName;
            string AppUserID = DOAppDatabaseInfo.UserID;
            string AppPassword = DOAppDatabaseInfo.Password;
            string Message = null;

            DODatabaseCreation dc = new DODatabaseCreation();
            if (dc.CreateDB(AppServerName, AppUserID, AppPassword, out Message))
            {
                UIControls();
                MessageBox.Show(Message);
            }
            else
            {
                DoRollBack();
                MessageBox.Show("Error "+Message);
            }
        }

        private void DoRollBack()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CTTool\\CT_Tool.xml";
            if (CommonControls.ConfigFileExists())
            {
                File.Delete(path);
            }
        }
    
        private void txtBoxServerName_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
        }

        private void txtBoxUserID_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
        }

        private void SettingsConfigureDatabaseUC_Load(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            if (CommonControls.ConfigFileExists())
            {
                UIControls();
            }
        }

        private void UIControls()
        {
            this.btnSave.Enabled = false;
            this.btnTestConnection.Enabled = false;
            this.txtBoxServerName.Text = DOAppDatabaseInfo.ServerName;
            this.txtBoxServerName.Enabled = false;
            this.txtBoxUserID.Text = DOAppDatabaseInfo.UserID;
            this.txtBoxUserID.Enabled = false;
            this.txtBoxPassword.Visible = false;
            this.label3.Visible = false;
        }
    }
}
