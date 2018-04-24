using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using spforcoretrac.DataObjects;
using System.IO;
using spforcoretrac.Utilities;

namespace spforcoretrac.UserControls
{
    public partial class RunScriptUC : UserControl
    {
        #region Members
        private List<DatabaseInfoList> dbinfoitems;
        #endregion Members

        #region Constructor
        public RunScriptUC()
        {
            InitializeComponent();  
        }
        #endregion Constructor

        #region OnLoad
        private void RunScriptUC_Load(object sender, EventArgs e)
        {
            AddItemsToComboBox();
            InitialiseDatas();
        }

        public void AddItemsToComboBox()
        {
            DODatabaseFunctions df = new DODatabaseFunctions();
            dbinfoitems = df.GetDatabaseInfo();
            foreach (DatabaseInfoList item in dbinfoitems)
            {
                comboBoxViewName.Items.Add(item.UniqueName);
            }
        }

        private void InitialiseDatas()
        {
            txtBoxLocation.Text = DOLocationInfo.GetFolderLocation("runscript");

            checkedListBoxScripts.Items.Clear();
            checkedListBoxScripts.Items.Add("Select All");
            string[] files = Directory.GetFiles(txtBoxLocation.Text);
            for (int i = files.Length - 1; i >= 0; i--)
            {
                string fileExt = Path.GetExtension(files[i]).ToUpper();
                if (fileExt == ".SQL")
                {
                    checkedListBoxScripts.Items.Add(Path.GetFileName(files[i]));
                }
            }
        }
        #endregion OnLoad


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
        }

        private bool InputValidation()
        {
            if (comboBoxViewName.SelectedIndex == -1)
            {
                CommonUtilities.ErrorMessage("Please select View Name.");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxLocation.Text))
            {
                CommonUtilities.ErrorMessage("Please select the folder location.");
                return false;
            }
            if (checkedListBoxScripts.SelectedItems.Count == 0)
            {
                CommonUtilities.ErrorMessage("Please select the scripts to run.");
                return false;
            }
            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)); //this is to make the C: as selected path
            fbd.Description = "Select the path at which scripts are located";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBoxLocation.Text = fbd.SelectedPath;

                checkedListBoxScripts.Items.Clear();
                checkedListBoxScripts.Items.Add("Select All");
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                for (int i = files.Length-1; i >= 0; i--)
                {
                    string fileExt = Path.GetExtension(files[i]).ToUpper();
                    if (fileExt == ".SQL")
                    {
                        checkedListBoxScripts.Items.Add(Path.GetFileName(files[i]));
                    }
                }

            }
        }

        private void checkedListBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxScripts.GetItemChecked(0))
            {
                for (int i = 1; i < checkedListBoxScripts.Items.Count; i++)
                {
                    checkedListBoxScripts.SetItemCheckState(i, CheckState.Indeterminate);
                }
            }
        }

        private void checkedListBoxScripts_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.Index == 0 && e.NewValue == CheckState.Unchecked && e.CurrentValue == CheckState.Checked)
            {
                for (int i = 1; i < checkedListBoxScripts.Items.Count; i++)
                {
                    checkedListBoxScripts.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }


        private void comboBoxViewName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxViewName.SelectedIndex;

            txtBoxServerDetails.Text = dbinfoitems[index].ServerName + "/" + dbinfoitems[index].UserName + "/" + dbinfoitems[index].DatabaseName;
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            //Validate the Inputs
            //Update the folder location in DB
            //Get the Files to Run
            //Get the Database Details where Scripts is to run.
            //Check which scripts have already run - do it by checking from database upgrades and compare it with scripts to run
            //Ask want to run the already run scripts, or select again
            //If says yes, then update database info table and then run all
            //If no, then update database info table, and then run only new ones
            //Cancel, user will select again

            if (!InputValidation())
            {
                return;
            }

            if (!UpdateLocationInDB())
            {
                CommonUtilities.ErrorMessage("Unable to Update Location in Database");
                return;
            }

            List<int> fileversionstorun = GetSelectedFileVersions();

            int index = comboBoxViewName.SelectedIndex;
            DatabaseInfoList dbinfo = dbinfoitems[index];

            List<int> alreadyrunscripts = CheckScriptsAlreadyRun(dbinfo);

            string CommonScriptMessage = null;

            foreach (int common in fileversionstorun.Intersect(alreadyrunscripts)) //gets a string which contains all the common scripts from which are selected and to run
            {
                CommonScriptMessage += common.ToString() + " ";
            }

            if (CommonScriptMessage != null)
            {
                DialogResult reply = MessageBox.Show("Application found few already run scripts.\n"+ CommonScriptMessage +"\nWant to rerun the scripts?" ,
                    "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (reply == DialogResult.Yes)
                {
                    DOScriptRun.UpdateDatabaseInfoTable(dbinfo);

                    RunScripts(fileversionstorun, dbinfo);
                }

                if (reply == DialogResult.No)
                {
                    DOScriptRun.UpdateDatabaseInfoTable(dbinfo);

                    List<int> uncommonscripts = fileversionstorun.Except(alreadyrunscripts).ToList();
                    RunScripts(uncommonscripts, dbinfo);
                }

                if (reply == DialogResult.Cancel)
                {
                    
                }
            }

            else
            {
                DOScriptRun.UpdateDatabaseInfoTable(dbinfo);
                RunScripts(fileversionstorun, dbinfo);
            }


        }

        private bool UpdateLocationInDB()
        {
            string location = txtBoxLocation.Text;
            return DOLocationInfo.UpdateFolderLocation(location, "runscript");
        }

        private List<int> GetSelectedFileVersions()
        {
            List<int> selectedfileversions = new List<int>();
  
            foreach (string item in checkedListBoxScripts.CheckedItems.Cast<string>().Skip(1)) // Cast has been written to remove "All Scripts" checked item
            {
                selectedfileversions.Add(Convert.ToInt32(item.Substring(0,4))); //this gets the version number from checked list. Version number should always be 4 digit only
            }
            selectedfileversions.Sort();
            return selectedfileversions;
        }

        private List<int> CheckScriptsAlreadyRun(DatabaseInfoList dbinformation)
        {
            DOScriptRun dr = new DOScriptRun();
            List<int> alreadyrunscripts = dr.CheckPreviouslyRunScripts(dbinformation);
            alreadyrunscripts.Sort();
            return alreadyrunscripts;
        }

        private void RunScripts(List<int> scriptstorun, DatabaseInfoList dbinforamtion)
        {
            DOScriptRun sr = new DOScriptRun();
            sr.RunScripts(scriptstorun, dbinforamtion);

        }
    }
}
