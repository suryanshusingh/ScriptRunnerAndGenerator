using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using spforcoretrac.DataObjects;

namespace spforcoretrac.UserControls
{
    public partial class GenerateScriptUC : UserControl
    {
        public GenerateScriptUC()
        {
            InitializeComponent();
        }

        enum Script { Createproc, Alterproc, Updatescript };

        private void GenerateScriptUC_Load(object sender, EventArgs e)
        {
            AddItemsToComboBox();
            txtBoxLocation.Text = DOLocationInfo.GetFolderLocation("generatescript");
        }

        private void AddItemsToComboBox()
        {
            comboBoxScriptType.Items.Add("Stored Procedure");
            comboBoxScriptType.Items.Add("Sql Script");

            comboBoxSPType.Items.Add("Create");
            comboBoxSPType.Items.Add("Alter");
        }


        private void comboBoxScriptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScriptType.SelectedIndex == 0)
            {
                comboBoxSPType.Enabled = true;
            }
            else
            {
                comboBoxSPType.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)); //this is to make the C: as selected path
            fbd.Description = "Select the path where file has to be created";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBoxLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            else
            { 
                DOLocationInfo.UpdateFolderLocation(txtBoxLocation.Text, "generatescript");
                GenerateOutput();
            }
        }


        private void ErrorMessage(string errormessage)
        {
            CommonUtilities.ErrorMessage(errormessage);
        }

        private bool InputValidation()
        {
            if (comboBoxScriptType.SelectedIndex == -1) 
            {
                ErrorMessage("Please select what do you want to generate.");
                return false;
            }

            
            if (comboBoxScriptType.SelectedIndex == 0 && comboBoxSPType.SelectedIndex == -1)
            {
                ErrorMessage("Please select which operation you want to perform for Stored Procedure");
                return false;
            }
            
            if (string.IsNullOrEmpty(txtBoxVersionNumber.Text))
            {
                ErrorMessage("Please insert Version number");
                return false;
            }
            
            int n;
            if (int.TryParse(txtBoxVersionNumber.Text, out n) == false)
            {
                ErrorMessage("The Version number should be numeric");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxUCBugNumber.Text))
            {
                ErrorMessage("Please input Use Case or Bug Number");
                return false;
            }

            if (int.TryParse(txtBoxUCBugNumber.Text, out n) == false)
            {
                ErrorMessage("The Use Case or Bug Number should be numeric");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxScriptName.Text))
            {
                ErrorMessage("Please input Name");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxLocation.Text))
            {
                ErrorMessage("Please set the location");
                return false;
            }

            return true;
        }

        private void GenerateOutput()
        {
            int number = Convert.ToInt32(txtBoxVersionNumber.Text);
            int ucbugnumber = Convert.ToInt32(txtBoxUCBugNumber.Text);
            string name = txtBoxScriptName.Text;
            Script scripttype;
            string topoutputscript = null;
            string middleoutputscript = null;
            string loweroutputscript = null;

            if (comboBoxScriptType.SelectedIndex == 0) // if storedproc is selected
            {
                if (comboBoxSPType.SelectedIndex == 0) // if Create is selected
                {
                    scripttype = Script.Createproc;
                }
                else // if Alter is selected
                {
                    scripttype = Script.Alterproc;
                }
                topoutputscript = GenerateTopPartofScriptorSP(number, ucbugnumber, name, scripttype);
                middleoutputscript = GenerateMiddlePartofSP(name);
                loweroutputscript = GenerateLowerPartofScriptorSP(number);

            }
            else // if Script is selected
            {
                scripttype = Script.Updatescript;
                topoutputscript = GenerateTopPartofScriptorSP(number, ucbugnumber, name, scripttype);
                middleoutputscript = GenerateMiddlePartofScript();
                loweroutputscript = GenerateLowerPartofScriptorSP(number);
            }

            string GeneratedScript = topoutputscript + middleoutputscript + loweroutputscript;

            string filename = GetFileName(number, ucbugnumber, name, scripttype);
            string path = txtBoxLocation.Text + "\\" + filename;

            if (File.Exists(path))
            {
                //if file exists check if the user wants to override
                DialogResult reply = MessageBox.Show("File already exists at the location. Delete and create a new file?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (reply == DialogResult.OK)
                {
                    CreateFile(path, GeneratedScript);
                }
                else
                {

                }
            }
            else
            {
                CreateFile(path, GeneratedScript);
            }
         
        }

        private void CreateFile(string path, string generatedscript)
        {

            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(generatedscript);
                }
                MessageBox.Show("File created successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DirectoryNotFoundException)
            {
                ErrorMessage("Directory not found!");
            }
            catch (Exception)
            {
                ErrorMessage("Some Issue, kindly validate the input");
            }
        }

        private string GetFileName(int number, int ucbugnumber, string scriptname, Script typeofscript)
        {
            string filename = null;
            string part1 = number + " - " + "(" + ucbugnumber + ")";
            switch (typeofscript)
            {
                case (Script.Createproc):
                    filename = part1 + " CREATE PROCEDURE " + scriptname;
                    break;
                case (Script.Alterproc):
                    filename = part1 + " ALTER PROCEDURE " + scriptname;
                    break;
                case (Script.Updatescript):
                    filename = part1 + " " + "UPDATE " + scriptname;
                    break;
            }

            return filename + ".sql";
        }


        #region ScriptCreation Methods

        private string GenerateTopPartofScriptorSP(int number, int ucbugnumber, string scriptname, Script typeofscript)
        {
            string line1 = null;
            string line2 = null;
            switch (typeofscript)
            {
                case (Script.Createproc):
                    line1 = "(" + ucbugnumber + ")" + " CREATE PROCEDURE " + scriptname;
                    line2 = "CREATE PROCEDURE ";
                    break;
                case (Script.Alterproc):
                    line1 = "(" + ucbugnumber + ")" + " ALTER PROCEDURE " + scriptname;
                    line2 = "ALTER PROCEDURE ";
                    break;
                case (Script.Updatescript):
                    line1 = "(" + ucbugnumber + ")" + " UPDATE " + scriptname;
                    line2 = "UPDATE ";
                    break;

            }
            string newline = System.Environment.NewLine;
            StringBuilder storedproc = new StringBuilder();
            storedproc.AppendFormat(@"/**{0}**/ " + newline, line1);
            storedproc.Append(@"SET NOEXEC OFF" + newline);
            storedproc.Append(newline);
            storedproc.AppendFormat(@"IF OBJECT_ID('tempdb..#TEMPDBUPGRADE_{0}') IS NOT NULL" + newline, number);
            storedproc.AppendFormat(@"DROP TABLE #TEMPDBUPGRADE_{0}" + newline, number);
            storedproc.Append(newline);
            storedproc.AppendFormat(@"CREATE TABLE #TEMPDBUPGRADE_{0}" + newline, number);
            storedproc.Append(@"(" + newline);
            storedproc.Append("\t[Version] INT," + newline);
            storedproc.Append("\t[Time] DATETIME," + newline);
            storedproc.Append("\tComments nvarchar(2048)," + newline);
            storedproc.Append("\tSuccess BIT," + newline);
            storedproc.Append("\tError nvarchar(2048)" + newline);
            storedproc.Append(@")" + newline);
            storedproc.Append(newline);

            storedproc.AppendFormat(@"INSERT INTO #TEMPDBUPGRADE_{0} ([Version], [Time], Comments, Success, Error) VALUES " + newline, number);
            storedproc.AppendFormat(@"({0}" + newline, number);
            storedproc.Append(@", GETUTCDATE()" + newline);
            storedproc.AppendFormat(@", '({0}) {1}{2}'" + newline, ucbugnumber, line2, scriptname);
            storedproc.Append(@", 0" + newline);
            storedproc.Append(@", NULL" + newline);
            storedproc.Append(@")" + newline);
            storedproc.Append(@"GO" + newline);
            storedproc.Append(newline);

            storedproc.AppendFormat(@"IF (SELECT Version from #TEMPDBUPGRADE_{0}) <= (SELECT Version from DatabaseInfo)" + newline, number);
            storedproc.Append(@"BEGIN" + newline);
            storedproc.Append("\tPrint 'Script already run'" + newline);
            storedproc.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Error = 'Script already run' " + newline, number);
            storedproc.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT Version,Time,Comments,Success,Error from #TEMPDBUPGRADE_{0}" + newline, number);
            storedproc.Append("\tSET NOEXEC ON" + newline);
            storedproc.Append(@"END" + newline);
            storedproc.Append(newline);

            storedproc.Append(@"GO" + newline);
            storedproc.Append(newline);

            return storedproc.ToString();
        }

        private string GenerateMiddlePartofSP(string scriptname)
        {
            string newline = System.Environment.NewLine;
            StringBuilder storedproc = new StringBuilder();
            storedproc.AppendFormat(@"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'P', N'PC'))" + newline, scriptname);
            storedproc.AppendFormat(@"DROP PROCEDURE [dbo].[{0}]" + newline, scriptname);
            storedproc.Append(@"GO" + newline);
            storedproc.Append(newline);

            storedproc.AppendFormat(@"/****** Object: StoredProcedure [dbo].[{0}]  ******/" + newline, scriptname);
            storedproc.Append(newline);
            storedproc.Append(newline);
            storedproc.Append(@"--INSERT YOUR STORED PROCEDURE HERE--" + newline);
            storedproc.Append(@"--Remember to Change ""ALTER"" to ""CREATE""--" + newline);
            storedproc.Append(newline);
            storedproc.Append(newline);
            storedproc.Append(@"GO" + newline);
            storedproc.Append(newline);

            return storedproc.ToString();

        }

        private string GenerateMiddlePartofScript()
        {
            string newline = System.Environment.NewLine;
            StringBuilder middlepart = new StringBuilder();
            middlepart.Append("BEGIN TRANSACTION" + newline);
            middlepart.Append(newline);
            middlepart.Append(newline);
            middlepart.Append(@"--INSERT YOUR SCRIPT HERE--" + newline);
            middlepart.Append(newline);
            middlepart.Append(newline);
            middlepart.Append("COMMIT TRANSACTION" + newline);
            middlepart.Append(newline);
            middlepart.Append("GO" + newline);

            return middlepart.ToString();
        }

        private string GenerateLowerPartofScriptorSP(int number)
        {
            string newline = System.Environment.NewLine;
            StringBuilder lowerpart = new StringBuilder();

            lowerpart.Append(@"DECLARE @ErrorNumber INT" + newline);
            lowerpart.Append(@"SET @ErrorNumber = @@Error" + newline);
            lowerpart.Append(newline);

            lowerpart.Append(@"IF @ErrorNumber <> 0" + newline);
            lowerpart.Append(@"BEGIN" + newline);
            lowerpart.Append("\tPRINT 'Error Occurred while executing the script' " + newline);
            lowerpart.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Error = 'Error occured while running script' " + newline, number);
            lowerpart.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_{0}" + newline, number);
            lowerpart.Append(@"END" + newline);
            lowerpart.Append(@"ELSE" + newline);
            lowerpart.Append(@"BEGIN" + newline);
            lowerpart.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Success = 1" + newline, number);
            lowerpart.AppendFormat("\tUPDATE [DatabaseInfo] SET [Version] = (SELECT Version from #TEMPDBUPGRADE_{0});" + newline, number);
            lowerpart.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_{0}" + newline, number);
            lowerpart.Append(@"END" + newline);
            lowerpart.Append(@"" + newline);
            lowerpart.AppendFormat(@"DROP TABLE #TEMPDBUPGRADE_{0};" + newline, number);

            return lowerpart.ToString();
        }

        #endregion ScriptCreation Methods
    }
}
