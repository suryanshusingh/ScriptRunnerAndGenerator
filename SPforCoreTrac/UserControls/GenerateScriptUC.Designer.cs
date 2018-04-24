namespace spforcoretrac.UserControls
{
    partial class GenerateScriptUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxScriptType = new System.Windows.Forms.ComboBox();
            this.txtBoxVersionNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUCBugNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxScriptName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSPType = new System.Windows.Forms.ComboBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Script Type:";
            // 
            // comboBoxScriptType
            // 
            this.comboBoxScriptType.FormattingEnabled = true;
            this.comboBoxScriptType.Location = new System.Drawing.Point(292, 20);
            this.comboBoxScriptType.Name = "comboBoxScriptType";
            this.comboBoxScriptType.Size = new System.Drawing.Size(300, 28);
            this.comboBoxScriptType.TabIndex = 17;
            this.comboBoxScriptType.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptType_SelectedIndexChanged);
            // 
            // txtBoxVersionNumber
            // 
            this.txtBoxVersionNumber.Location = new System.Drawing.Point(292, 140);
            this.txtBoxVersionNumber.Name = "txtBoxVersionNumber";
            this.txtBoxVersionNumber.Size = new System.Drawing.Size(300, 26);
            this.txtBoxVersionNumber.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Version Number:";
            // 
            // txtBoxUCBugNumber
            // 
            this.txtBoxUCBugNumber.Location = new System.Drawing.Point(292, 200);
            this.txtBoxUCBugNumber.Name = "txtBoxUCBugNumber";
            this.txtBoxUCBugNumber.Size = new System.Drawing.Size(300, 26);
            this.txtBoxUCBugNumber.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "UC/Bug Number:";
            // 
            // txtBoxScriptName
            // 
            this.txtBoxScriptName.Location = new System.Drawing.Point(292, 260);
            this.txtBoxScriptName.Name = "txtBoxScriptName";
            this.txtBoxScriptName.Size = new System.Drawing.Size(300, 26);
            this.txtBoxScriptName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Script Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stored Proc Type:";
            // 
            // comboBoxSPType
            // 
            this.comboBoxSPType.FormattingEnabled = true;
            this.comboBoxSPType.Location = new System.Drawing.Point(292, 80);
            this.comboBoxSPType.Name = "comboBoxSPType";
            this.comboBoxSPType.Size = new System.Drawing.Size(300, 28);
            this.comboBoxSPType.TabIndex = 25;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(292, 320);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(300, 26);
            this.txtBoxLocation.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Location:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(622, 320);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(138, 30);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerateScript);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 38);
            this.panel2.TabIndex = 30;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnGenerateScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateScript.ForeColor = System.Drawing.Color.White;
            this.btnGenerateScript.Location = new System.Drawing.Point(627, 3);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(133, 32);
            this.btnGenerateScript.TabIndex = 0;
            this.btnGenerateScript.Text = "Generate Script";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // GenerateScriptUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSPType);
            this.Controls.Add(this.txtBoxScriptName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxUCBugNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxScriptType);
            this.Controls.Add(this.txtBoxVersionNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenerateScriptUC";
            this.Size = new System.Drawing.Size(784, 486);
            this.Load += new System.EventHandler(this.GenerateScriptUC_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxScriptType;
        private System.Windows.Forms.TextBox txtBoxVersionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUCBugNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxScriptName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSPType;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerateScript;
    }
}
