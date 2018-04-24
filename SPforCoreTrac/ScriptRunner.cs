using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using spforcoretrac.DataObjects;
using spforcoretrac.UserControls;
using System.Runtime.InteropServices;

namespace spforcoretrac
{
    public partial class ScriptRunner : Form
    {
        public ScriptRunner()
        {
            InitializeComponent();
            if (CommonUtilities.ConfigFileExists())
            {
                DOAppDatabaseInfo.GetDBInfoFromFile();
            }
        }

        //When form is loaded it always checks for Config file. If config file doesnt exists, then it asks user to give Sql details
        private void scriptRunner_FormShown(object sender, EventArgs e)
        {

            if (!CommonUtilities.ConfigFileExists())
            {
                DialogResult reply = MessageBox.Show("Database has not been configured. Please configure it now. Application wont run without configuration.", 
                    "Configure Database", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (reply == DialogResult.OK)
                {
                    SettingsUC settingsUCDisp = new SettingsUC();
                    UsercontrolDefaults(settingsUCDisp);
                    settingsUCDisp.Name = "settingsUCDisp";
                    usercontrolpanel.Controls.Add(settingsUCDisp);

                    settingsUCDisp.settingsAppUCDisp.BringToFront();
                }

                if (reply == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            

        }
        
        private void scriptRunner_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            Title.Text = "GENERATE SCRIPT";
            while (usercontrolpanel.Controls.Count > 0)
            {
                usercontrolpanel.Controls[0].Dispose();
            }
            GenerateScriptUC generateScriptDisp = new GenerateScriptUC();
            UsercontrolDefaults(generateScriptDisp);
            generateScriptDisp.Name = "generateScriptDisp";
            usercontrolpanel.Controls.Add(generateScriptDisp);
        }
        private void btnRunScript_Click(object sender, EventArgs e)
        {
            Title.Text = "RUN SCRIPT";
            while (usercontrolpanel.Controls.Count > 0)
            {
                usercontrolpanel.Controls[0].Dispose();
            }

            RunScriptUC runScriptDisp = new RunScriptUC();
            UsercontrolDefaults(runScriptDisp);
            runScriptDisp.Name = "runScriptDisp";
            usercontrolpanel.Controls.Add(runScriptDisp);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Title.Text = "SETTINGS";
            while (usercontrolpanel.Controls.Count > 0)
            {
                usercontrolpanel.Controls[0].Dispose();
            }

            SettingsUC settingsUCDisp = new SettingsUC();
            UsercontrolDefaults(settingsUCDisp);
            settingsUCDisp.Name = "settingsUCDisp";
            usercontrolpanel.Controls.Add(settingsUCDisp);
        }

        private void UsercontrolDefaults(UserControl name)
        {
            name.Dock = System.Windows.Forms.DockStyle.Fill;
            name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name.Location = new System.Drawing.Point(0, 0);
            name.Size = new System.Drawing.Size(784, 486);
            name.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
