using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spforcoretrac
{
    public partial class Form1 : Form
    {
        enum Script {Createproc, Alterproc, Updatescript};

        Size smallwindow = new Size(300, 650);
        Size bigwindow = new Size(900, 650);

        public Form1()
        {
            InitializeComponent();
            DefaultSettings();            
        }

        private void DefaultSettings()
        {
            this.Size = smallwindow;
            panelControls.Width = Convert.ToInt32(this.Width * 0.95);
            panelControls.Height = Convert.ToInt32(this.Height);
            txtbxBigOutput.Height = Convert.ToInt32(this.Height * 0.94);
            label2.Text = "1. Select the format which you want, Stored \n    procedure or Script.\n" + "2. Enter the" +
                " Number(must be numeric).\n" + "3. Enter the Use Case or Bug Number(must be\n    numeric).\n" + "4. If you are creating a SP, " +
                "select Create else \n   select Alter.\n" + @"Note: Remember to Replace ""Alter Procedure""" + "\n   with" + @"""Create Procedure"" in your Stored Proc.";
            radBtnStoredProc.Checked = true;
        }

        //this function is of no use -- kindly ignore
        private string generatestoredproc(int number, string inputproc)
        {
            string newline = System.Environment.NewLine;
            StringBuilder storedproc = new StringBuilder();
            //storedproc.Append(@"SET NOEXEC OFF"+ newline);
            //storedproc.Append(newline);
            //storedproc.AppendFormat(@"IF OBJECT_ID('tempdb..#TEMPDBUPGRADE_{0}') IS NOT NULL"+ newline, number);
            //storedproc.AppendFormat(@"DROP TABLE #TEMPDBUPGRADE_{0}" + newline,number);
            //storedproc.Append(newline);
            //storedproc.AppendFormat(@"CREATE TABLE #TEMPDBUPGRADE_{0}" + newline, number);
            //storedproc.Append(@"("+newline);
            //storedproc.Append("\t[Version] INT,"+newline);
            //storedproc.Append("\t[Time] DATETIME,"+newline);
            //storedproc.Append("\tComments nvarchar(2048),"+newline);
            //storedproc.Append("\tSuccess BIT,"+newline);
            //storedproc.Append("\tError nvarchar(2048)"+newline);
            //storedproc.Append(@")"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.AppendFormat(@"INSERT INTO #TEMPDBUPGRADE_{0} ([Version], [Time], Comments, Success, Error) VALUES "+newline,number);
            //storedproc.AppendFormat(@"({0}"+newline,number);
            //storedproc.Append(@", GETUTCDATE()"+newline);
            //storedproc.Append(@", '(287682) ALTER PROCEDURE spGet_User_Lost_Lead_v3'"+newline);//remove the hard coding
            //storedproc.Append(@", 0"+newline);
            //storedproc.Append(@", NULL"+newline);
            //storedproc.Append(@")"+newline);
            //storedproc.Append(@"GO"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.AppendFormat(@"IF (SELECT Version from #TEMPDBUPGRADE_{0}) <= (SELECT Version from DatabaseInfo)"+newline,number);
            //storedproc.Append(@"BEGIN"+newline);
            //storedproc.Append("\tPrint 'Script already run'"+newline);
            //storedproc.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Error = 'Script already run' "+newline,number);
            //storedproc.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT Version,Time,Comments,Success,Error from #TEMPDBUPGRADE_{0}"+newline,number);
            //storedproc.Append("\tSET NOEXEC ON"+newline);
            //storedproc.Append(@"END"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.Append(@"GO"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.Append(@"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spGet_User_Lost_Lead_v3]') AND type in (N'P', N'PC'))"+newline);
            //storedproc.Append(@"DROP PROCEDURE [dbo].[spGet_User_Lost_Lead_v3]"+newline);
            //storedproc.Append(@"GO"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.Append(@"GO"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.Append(@"DECLARE @ErrorNumber INT"+newline);
            //storedproc.Append(@"SET @ErrorNumber = @@Error"+newline);
            //storedproc.Append(newline);
            //
            //storedproc.Append(@"IF @ErrorNumber <> 0"+newline);
            //storedproc.Append(@"BEGIN"+newline);
            //storedproc.Append(@"PRINT 'Error Occurred while executing the script' "+newline);
            //storedproc.Append(@"UPDATE #TEMPDBUPGRADE_1333 SET Error = 'Error occured while running script' " + newline);
            //storedproc.Append(@"INSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_1333" + newline);
            //storedproc.Append(@"END" + newline);
            //storedproc.Append(@"ELSE" + newline);
            //storedproc.Append(@"BEGIN" + newline);
            //storedproc.Append(@"UPDATE #TEMPDBUPGRADE_1333 SET Success = 1" + newline);
            //storedproc.Append(@"UPDATE [DatabaseInfo] SET [Version] = (SELECT Version from #TEMPDBUPGRADE_1333);" + newline);
            //storedproc.Append(@"INSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_1333" + newline);
            //storedproc.Append(@"END" + newline);
            //storedproc.Append(@"" + newline);
            //storedproc.Append(@"DROP TABLE #TEMPDBUPGRADE_1333;" + newline);
            //
            //
            return storedproc.ToString();

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
            storedproc.AppendFormat(@"/**{0}**/ "+newline, line1);
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
            storedproc.AppendFormat(@"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'P', N'PC'))" + newline,scriptname);
            storedproc.AppendFormat(@"DROP PROCEDURE [dbo].[{0}]" + newline,scriptname);
            storedproc.Append(@"GO" + newline);
            storedproc.Append(newline);

            storedproc.AppendFormat(@"/****** Object: StoredProcedure [dbo].[{0}]  ******/"+newline,scriptname);
            storedproc.Append(newline);
            storedproc.Append(newline);
            storedproc.Append(@"--INSERT YOUR STORED PROCEDURE HERE--"+newline);
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
            middlepart.Append("BEGIN TRANSACTION"+newline);
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
            lowerpart.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Error = 'Error occured while running script' " + newline,number);
            lowerpart.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_{0}" + newline,number);
            lowerpart.Append(@"END" + newline);
            lowerpart.Append(@"ELSE" + newline);
            lowerpart.Append(@"BEGIN" + newline);
            lowerpart.AppendFormat("\tUPDATE #TEMPDBUPGRADE_{0} SET Success = 1" + newline,number);
            lowerpart.AppendFormat("\tUPDATE [DatabaseInfo] SET [Version] = (SELECT Version from #TEMPDBUPGRADE_{0});" + newline,number);
            lowerpart.AppendFormat("\tINSERT INTO [DatabaseUpgrades] SELECT [Version],[Time],Comments,Success,Error from #TEMPDBUPGRADE_{0}" + newline,number);
            lowerpart.Append(@"END" + newline);
            lowerpart.Append(@"" + newline);
            lowerpart.AppendFormat(@"DROP TABLE #TEMPDBUPGRADE_{0};" + newline,number);

            return lowerpart.ToString();
        }

        #endregion ScriptCreation Methods


        #region EventHandlers

        private void radbtnScript_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnStoredProc.Checked == false)
            {
                panelCreateorAlter.Visible = false;
            }
        }

        private void radBtnStoredProc_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnStoredProc.Checked == true)
            {
                panelCreateorAlter.Visible = true;
            }
        }

        private void btnGenerateOutput_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            else
            {
                string task = "OnlyGenerateOutput";
                GenerateOutput(task);
            }
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
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

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {

            if (!InputValidation())
            {
                return;
            }
            else if (string.IsNullOrEmpty(txtBoxLocation.Text))
            {
                ErrorMessage("Please set the location");
                return;
            }
            else
            {
                string task = "GenerateFile";
                GenerateOutput(task);
            }
        }


        #endregion EventHandlers

        #region Methods
        private bool InputValidation()
        {
            if (!radBtnStoredProc.Checked && !radBtnScript.Checked)
            {
                ErrorMessage("Please select what do you want to generate.");
                return false;
            }

            string message = null;
            if (radBtnStoredProc.Checked == true)
            {
                message = "Stored Procedure";

            }
            else
            {
                message = "Script";
            }

            if (string.IsNullOrEmpty(txtBoxNumber.Text))
            {
                ErrorMessage("Please insert " + message + " number");
                return false;
            }

            int n;
            if (int.TryParse(txtBoxNumber.Text, out n) == false)
            {
                ErrorMessage("The " + message + " number should be numeric");
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

            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                ErrorMessage("Please input " + message + " name");
                return false;
            }

            if (radBtnStoredProc.Checked)
            {
                if (!radBtnCreate.Checked && !radBtnAlter.Checked)
                {
                    ErrorMessage("Please select which operation you want to perform for Stored Procedure");
                    return false;
                }
            }


            return true;
        }
        private void GenerateOutput(string whattodo)
        {
            int number = Convert.ToInt32(txtBoxNumber.Text);
            int ucbugnumber = Convert.ToInt32(txtBoxUCBugNumber.Text);
            string name = txtBoxName.Text;
            Script scripttype;
            string topoutputscript = null;
            string middleoutputscript = null;
            string loweroutputscript = null;

            if (radBtnStoredProc.Checked) // if storedproc is selected
            {
                if (radBtnCreate.Checked) // if Create is selected
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

            txtbxBigOutput.Text = topoutputscript + middleoutputscript + loweroutputscript;

            if (whattodo == "OnlyGenerateOutput")
            {
                txtbxBigOutput.Visible = true;
                this.Size = bigwindow;
            }

            if (whattodo == "GenerateFile")
            {
                string filename = GetFileName(number, ucbugnumber, name, scripttype);
                string path = txtBoxLocation.Text + "\\" + filename;

                if (File.Exists(path))
                {
                    //if file exists check if the user wants to override
                    DialogResult reply = MessageBox.Show("File already exists at the location. Delete and create a new file?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (reply == DialogResult.OK)
                    {
                       CreateFile(path);   
                    }
                    else
                    {

                    }
                }
                else
                {
                    CreateFile(path);
                }
            }
        }

        private void CreateFile(string path)
        {
            
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(txtbxBigOutput.Text);
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

        private void ErrorMessage(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Methods

        private void developerToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScriptRunner sr = new ScriptRunner();
            sr.ShowDialog();
        }

    }
}
    