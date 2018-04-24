namespace spforcoretrac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radBtnStoredProc = new System.Windows.Forms.RadioButton();
            this.radBtnScript = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnGenerateOutput = new System.Windows.Forms.Button();
            this.txtbxBigOutput = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUCBugNumber = new System.Windows.Forms.TextBox();
            this.panelCreateorAlter = new System.Windows.Forms.Panel();
            this.radBtnCreate = new System.Windows.Forms.RadioButton();
            this.radBtnAlter = new System.Windows.Forms.RadioButton();
            this.panelSPorScript = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelCreateorAlter.SuspendLayout();
            this.panelSPorScript.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.Gray;
            this.panelControls.Controls.Add(this.btnGenerateFile);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.btnFolderBrowser);
            this.panelControls.Controls.Add(this.txtBoxLocation);
            this.panelControls.Controls.Add(this.groupBox1);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.txtBoxUCBugNumber);
            this.panelControls.Controls.Add(this.panelCreateorAlter);
            this.panelControls.Controls.Add(this.panelSPorScript);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.txtBoxNumber);
            this.panelControls.Controls.Add(this.btnGenerateOutput);
            this.panelControls.Controls.Add(this.txtBoxName);
            this.panelControls.Controls.Add(this.menuStrip1);
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Margin = new System.Windows.Forms.Padding(2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(287, 616);
            this.panelControls.TabStop = false;
            // 
            // panelSPorScript
            // 
            this.panelSPorScript.Controls.Add(this.radBtnStoredProc);
            this.panelSPorScript.Controls.Add(this.radBtnScript);
            this.panelSPorScript.Location = new System.Drawing.Point(0, 38);
            this.panelSPorScript.Name = "panelSPorScript";
            this.panelSPorScript.Size = new System.Drawing.Size(274, 44);
            // 
            // radBtnStoredProc
            // 
            this.radBtnStoredProc.AutoSize = true;
            this.radBtnStoredProc.Font = new System.Drawing.Font("Arial", 10F);
            this.radBtnStoredProc.ForeColor = System.Drawing.Color.Blue;
            this.radBtnStoredProc.Location = new System.Drawing.Point(6, 14);
            this.radBtnStoredProc.Name = "radBtnStoredProc";
            this.radBtnStoredProc.Size = new System.Drawing.Size(138, 20);
            this.radBtnStoredProc.TabStop = true;
            this.radBtnStoredProc.TabIndex = 0;
            this.radBtnStoredProc.Text = "Stored Procedure";
            this.radBtnStoredProc.UseVisualStyleBackColor = true;
            this.radBtnStoredProc.CheckedChanged += new System.EventHandler(this.radBtnStoredProc_CheckedChanged);
            // 
            // radBtnScript
            // 
            this.radBtnScript.AutoSize = true;
            this.radBtnScript.Font = new System.Drawing.Font("Arial", 10F);
            this.radBtnScript.ForeColor = System.Drawing.Color.Blue;
            this.radBtnScript.Location = new System.Drawing.Point(170, 14);
            this.radBtnScript.Name = "radBtnScript";
            this.radBtnScript.Size = new System.Drawing.Size(62, 20);
            this.radBtnScript.Text = "Script";
            this.radBtnScript.TabStop = true;
            this.radBtnScript.TabIndex = 1;
            this.radBtnScript.UseVisualStyleBackColor = true;
            this.radBtnScript.CheckedChanged += new System.EventHandler(this.radbtnScript_CheckedChanged);
            // 
            // label1
            //
            // Number:
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.Text = "Number:";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxNumber.Location = new System.Drawing.Point(6, 104);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(221, 20);
            this.txtBoxNumber.TabIndex = 2;
            // 
            // label3
            // 
            // UC/Bug Number:
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.Text = "UC/Bug Number:";
            // 
            // txtBoxUCBugNumber
            // 
            this.txtBoxUCBugNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxUCBugNumber.Location = new System.Drawing.Point(6, 165);
            this.txtBoxUCBugNumber.Name = "txtBoxUCBugNumber";
            this.txtBoxUCBugNumber.Size = new System.Drawing.Size(221, 20);
            this.txtBoxUCBugNumber.TabIndex = 3;
            this.txtBoxUCBugNumber.TabStop = true;
            // 
            // label4
            // 
            // SP Name:
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.Text = "SP Name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxName.Location = new System.Drawing.Point(6, 229);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(224, 20);
            this.txtBoxName.TabIndex = 4;
            // 
            // panelCreateorAlter
            // 
            this.panelCreateorAlter.Controls.Add(this.radBtnCreate);
            this.panelCreateorAlter.Controls.Add(this.radBtnAlter);
            this.panelCreateorAlter.Location = new System.Drawing.Point(6, 250);
            this.panelCreateorAlter.Name = "panelCreateorAlter";
            this.panelCreateorAlter.Size = new System.Drawing.Size(268, 56);
            this.panelCreateorAlter.Visible = false;
            // 
            // radBtnCreate
            // 
            this.radBtnCreate.AutoSize = true;
            this.radBtnCreate.Font = new System.Drawing.Font("Arial", 10F);
            this.radBtnCreate.ForeColor = System.Drawing.Color.Blue;
            this.radBtnCreate.Location = new System.Drawing.Point(3, 20);
            this.radBtnCreate.Name = "radBtnCreate";
            this.radBtnCreate.Size = new System.Drawing.Size(69, 20);
            this.radBtnCreate.TabStop = false;
            this.radBtnCreate.Text = "Create";
            this.radBtnCreate.UseVisualStyleBackColor = true;
            // 
            // radBtnAlter
            // 
            this.radBtnAlter.AutoSize = true;
            this.radBtnAlter.Font = new System.Drawing.Font("Arial", 10F);
            this.radBtnAlter.ForeColor = System.Drawing.Color.Blue;
            this.radBtnAlter.Location = new System.Drawing.Point(164, 20);
            this.radBtnAlter.Name = "radBtnAlter";
            this.radBtnAlter.Size = new System.Drawing.Size(55, 20);
            this.radBtnAlter.TabStop = false;
            this.radBtnAlter.Text = "Alter";
            this.radBtnAlter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.Text = "File Location:";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxLocation.Location = new System.Drawing.Point(6, 337);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(224, 20);
            this.txtBoxLocation.TabIndex = 5;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Image = global::spforcoretrac.Properties.Resources.folder_yellow;
            this.btnFolderBrowser.Location = new System.Drawing.Point(234, 337);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(30, 23);
            this.btnFolderBrowser.TabIndex = 6;
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // btnGenerateOutput
            // 
            this.btnGenerateOutput.ForeColor = System.Drawing.Color.Blue;
            this.btnGenerateOutput.Location = new System.Drawing.Point(6, 383);
            this.btnGenerateOutput.Name = "btnGenerateOutput";
            this.btnGenerateOutput.Size = new System.Drawing.Size(123, 23);
            this.btnGenerateOutput.TabIndex = 7;
            this.btnGenerateOutput.Text = "Check Output";
            this.btnGenerateOutput.UseVisualStyleBackColor = true;
            this.btnGenerateOutput.Click += new System.EventHandler(this.btnGenerateOutput_Click);
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateFile.ForeColor = System.Drawing.Color.Blue;
            this.btnGenerateFile.Location = new System.Drawing.Point(141, 383);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(123, 23);
            this.btnGenerateFile.TabIndex = 8;
            this.btnGenerateFile.Text = "Generate File";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(9, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 168);
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How to Use:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.Text = "help";
            // 
            // txtbxBigOutput
            // 
            this.txtbxBigOutput.Location = new System.Drawing.Point(292, 0);
            this.txtbxBigOutput.Multiline = true;
            this.txtbxBigOutput.Name = "txtbxBigOutput";
            this.txtbxBigOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxBigOutput.Size = new System.Drawing.Size(574, 616);
            this.txtbxBigOutput.TabIndex = 9;
            this.txtbxBigOutput.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // developerToolsToolStripMenuItem
            // 
            this.developerToolsToolStripMenuItem.Name = "developerToolsToolStripMenuItem";
            this.developerToolsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.developerToolsToolStripMenuItem.Text = "Developer Tools";
            this.developerToolsToolStripMenuItem.Click += new System.EventHandler(this.developerToolsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 611);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.txtbxBigOutput);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CoreTrac SP Generator";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCreateorAlter.ResumeLayout(false);
            this.panelCreateorAlter.PerformLayout();
            this.panelSPorScript.ResumeLayout(false);
            this.panelSPorScript.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnStoredProc;
        private System.Windows.Forms.RadioButton radBtnScript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnGenerateOutput;
        private System.Windows.Forms.TextBox txtbxBigOutput;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelSPorScript;
        private System.Windows.Forms.Panel panelCreateorAlter;
        private System.Windows.Forms.RadioButton radBtnCreate;
        private System.Windows.Forms.RadioButton radBtnAlter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUCBugNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

