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

namespace SPforCoreTrac.UserControls
{
    public partial class SettingsConfigureDatabaseUC1 : UserControl
    {
        public SettingsConfigureDatabaseUC()
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
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SettingsConfigureDatabaseUC
            // 
            this.Name = "SettingsConfigureDatabaseUC";
            this.ResumeLayout(false);

        }
    }
}
