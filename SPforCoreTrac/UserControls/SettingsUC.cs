using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spforcoretrac.UserControls
{
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();
        }

        private void btnConfigureApp_Click(object sender, EventArgs e)
        {
            settingsAppUCDisp.Visible = true;
            settingsDatabaseUCDisp.Visible = false;
        }

        private void btnConfigureDatabase_Click(object sender, EventArgs e)
        {
            settingsDatabaseUCDisp.Visible = true;
            settingsAppUCDisp.Visible = false;

        }

    }
}
