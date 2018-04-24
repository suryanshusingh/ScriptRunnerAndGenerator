namespace spforcoretrac.UserControls
{
    partial class RunScriptUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxServerDetails = new System.Windows.Forms.TextBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.checkedListBoxScripts = new System.Windows.Forms.CheckedListBox();
            this.comboBoxViewName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Details:";
            // 
            // txtBoxServerDetails
            // 
            this.txtBoxServerDetails.Location = new System.Drawing.Point(243, 80);
            this.txtBoxServerDetails.Name = "txtBoxServerDetails";
            this.txtBoxServerDetails.Size = new System.Drawing.Size(300, 26);
            this.txtBoxServerDetails.TabIndex = 2;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(243, 140);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(300, 26);
            this.txtBoxLocation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Location:";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(563, 78);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(138, 30);
            this.btnTestConnection.TabIndex = 10;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(563, 138);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(138, 30);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkedListBoxScripts
            // 
            this.checkedListBoxScripts.CheckOnClick = true;
            this.checkedListBoxScripts.FormattingEnabled = true;
            this.checkedListBoxScripts.Location = new System.Drawing.Point(78, 181);
            this.checkedListBoxScripts.Name = "checkedListBoxScripts";
            this.checkedListBoxScripts.Size = new System.Drawing.Size(619, 256);
            this.checkedListBoxScripts.TabIndex = 12;
            this.checkedListBoxScripts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxScripts_ItemCheck);
            this.checkedListBoxScripts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxScripts_SelectedIndexChanged);
            // 
            // comboBoxViewName
            // 
            this.comboBoxViewName.FormattingEnabled = true;
            this.comboBoxViewName.Location = new System.Drawing.Point(243, 20);
            this.comboBoxViewName.Name = "comboBoxViewName";
            this.comboBoxViewName.Size = new System.Drawing.Size(300, 28);
            this.comboBoxViewName.TabIndex = 13;
            this.comboBoxViewName.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "View Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRunScript);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 38);
            this.panel2.TabIndex = 15;
            // 
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(627, 3);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(133, 32);
            this.btnRunScript.TabIndex = 0;
            this.btnRunScript.Text = "Run Script";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            this.btnRunScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnRunScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunScript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunScript.ForeColor = System.Drawing.Color.White;
            this.btnRunScript.UseVisualStyleBackColor = false;
            // 
            // RunScriptUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxViewName);
            this.Controls.Add(this.checkedListBoxScripts);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxServerDetails);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RunScriptUC";
            this.Size = new System.Drawing.Size(784, 486);
            this.Load += new System.EventHandler(this.RunScriptUC_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxServerDetails;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckedListBox checkedListBoxScripts;
        private System.Windows.Forms.ComboBox comboBoxViewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRunScript;
    }
}
