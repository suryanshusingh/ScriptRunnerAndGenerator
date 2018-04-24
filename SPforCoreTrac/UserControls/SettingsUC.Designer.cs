namespace spforcoretrac.UserControls
{
    partial class SettingsUC
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConfigureDatabase = new System.Windows.Forms.Button();
            this.btnConfigureApp = new System.Windows.Forms.Button();
            this.settingsAppUCDisp = new spforcoretrac.UserControls.SettingsAppUC();
            this.settingsDatabaseUCDisp = new spforcoretrac.UserControls.SettingsDatabaseUC();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnConfigureDatabase);
            this.panel6.Controls.Add(this.btnConfigureApp);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(784, 38);
            this.panel6.TabIndex = 16;
            // 
            // btnConfigureDatabase
            // 
            this.btnConfigureDatabase.Location = new System.Drawing.Point(0, 0);
            this.btnConfigureDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfigureDatabase.Name = "btnConfigureDatabase";
            this.btnConfigureDatabase.Size = new System.Drawing.Size(180, 38);
            this.btnConfigureDatabase.TabIndex = 1;
            this.btnConfigureDatabase.Text = "Configure Database";
            this.btnConfigureDatabase.UseVisualStyleBackColor = true;
            this.btnConfigureDatabase.Click += new System.EventHandler(this.btnConfigureDatabase_Click);
            // 
            // btnConfigureApp
            // 
            this.btnConfigureApp.Location = new System.Drawing.Point(178, 0);
            this.btnConfigureApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfigureApp.Name = "btnConfigureApp";
            this.btnConfigureApp.Size = new System.Drawing.Size(180, 38);
            this.btnConfigureApp.TabIndex = 0;
            this.btnConfigureApp.Text = "Configure App";
            this.btnConfigureApp.UseVisualStyleBackColor = true;
            this.btnConfigureApp.Click += new System.EventHandler(this.btnConfigureApp_Click);
            // 
            // settingsAppUCDisp
            // 
            this.settingsAppUCDisp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsAppUCDisp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsAppUCDisp.Location = new System.Drawing.Point(0, 38);
            this.settingsAppUCDisp.Name = "settingsAppUCDisp";
            this.settingsAppUCDisp.Size = new System.Drawing.Size(784, 448);
            this.settingsAppUCDisp.TabIndex = 17;
            // 
            // settingsDatabaseUCDisp
            // 
            this.settingsDatabaseUCDisp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsDatabaseUCDisp.Location = new System.Drawing.Point(0, 38);
            this.settingsDatabaseUCDisp.Name = "settingsDatabaseUCDisp";
            this.settingsDatabaseUCDisp.Size = new System.Drawing.Size(784, 448);
            this.settingsDatabaseUCDisp.TabIndex = 18;
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsDatabaseUCDisp);
            this.Controls.Add(this.settingsAppUCDisp);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(784, 486);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnConfigureApp;
        private System.Windows.Forms.Button btnConfigureDatabase;
        public SettingsAppUC settingsAppUCDisp;
        public SettingsDatabaseUC settingsDatabaseUCDisp;
    }
}
