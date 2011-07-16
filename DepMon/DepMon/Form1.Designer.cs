namespace DepMon
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
            this.groupBoxProvider = new System.Windows.Forms.GroupBox();
            this.comboBoxProviders = new System.Windows.Forms.ComboBox();
            this.groupBoxStation = new System.Windows.Forms.GroupBox();
            this.listBoxStations = new System.Windows.Forms.ListBox();
            this.buttonFindStation = new System.Windows.Forms.Button();
            this.textBoxStation = new System.Windows.Forms.TextBox();
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.listBoxLines = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.groupBoxProvider.SuspendLayout();
            this.groupBoxStation.SuspendLayout();
            this.groupBoxLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProvider
            // 
            this.groupBoxProvider.Controls.Add(this.comboBoxProviders);
            this.groupBoxProvider.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProvider.Name = "groupBoxProvider";
            this.groupBoxProvider.Size = new System.Drawing.Size(200, 50);
            this.groupBoxProvider.TabIndex = 1;
            this.groupBoxProvider.TabStop = false;
            this.groupBoxProvider.Text = "1. Choose a provider";
            // 
            // comboBoxProviders
            // 
            this.comboBoxProviders.DisplayMember = "Name";
            this.comboBoxProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProviders.FormattingEnabled = true;
            this.comboBoxProviders.Location = new System.Drawing.Point(6, 19);
            this.comboBoxProviders.Name = "comboBoxProviders";
            this.comboBoxProviders.Size = new System.Drawing.Size(188, 21);
            this.comboBoxProviders.TabIndex = 3;
            this.comboBoxProviders.SelectedIndexChanged += new System.EventHandler(this.comboBoxProviders_SelectedIndexChanged);
            // 
            // groupBoxStation
            // 
            this.groupBoxStation.Controls.Add(this.listBoxStations);
            this.groupBoxStation.Controls.Add(this.buttonFindStation);
            this.groupBoxStation.Controls.Add(this.textBoxStation);
            this.groupBoxStation.Location = new System.Drawing.Point(12, 68);
            this.groupBoxStation.Name = "groupBoxStation";
            this.groupBoxStation.Size = new System.Drawing.Size(200, 107);
            this.groupBoxStation.TabIndex = 2;
            this.groupBoxStation.TabStop = false;
            this.groupBoxStation.Text = "2. Choose a station";
            // 
            // listBoxStations
            // 
            this.listBoxStations.FormattingEnabled = true;
            this.listBoxStations.Location = new System.Drawing.Point(6, 45);
            this.listBoxStations.Name = "listBoxStations";
            this.listBoxStations.Size = new System.Drawing.Size(188, 56);
            this.listBoxStations.TabIndex = 3;
            this.listBoxStations.SelectedIndexChanged += new System.EventHandler(this.listBoxStations_SelectedIndexChanged);
            // 
            // buttonFindStation
            // 
            this.buttonFindStation.Location = new System.Drawing.Point(151, 17);
            this.buttonFindStation.Name = "buttonFindStation";
            this.buttonFindStation.Size = new System.Drawing.Size(43, 23);
            this.buttonFindStation.TabIndex = 4;
            this.buttonFindStation.Text = "Find";
            this.buttonFindStation.UseVisualStyleBackColor = true;
            this.buttonFindStation.Click += new System.EventHandler(this.buttonFindStation_Click);
            // 
            // textBoxStation
            // 
            this.textBoxStation.Location = new System.Drawing.Point(6, 19);
            this.textBoxStation.Name = "textBoxStation";
            this.textBoxStation.Size = new System.Drawing.Size(139, 20);
            this.textBoxStation.TabIndex = 4;
            // 
            // groupBoxLine
            // 
            this.groupBoxLine.Controls.Add(this.listBoxLines);
            this.groupBoxLine.Location = new System.Drawing.Point(12, 181);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(200, 81);
            this.groupBoxLine.TabIndex = 3;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "3. Choose a line";
            // 
            // listBoxLines
            // 
            this.listBoxLines.FormattingEnabled = true;
            this.listBoxLines.Location = new System.Drawing.Point(6, 19);
            this.listBoxLines.Name = "listBoxLines";
            this.listBoxLines.Size = new System.Drawing.Size(188, 56);
            this.listBoxLines.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(140, 268);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 296);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.groupBoxLine);
            this.Controls.Add(this.groupBoxStation);
            this.Controls.Add(this.groupBoxProvider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxProvider.ResumeLayout(false);
            this.groupBoxStation.ResumeLayout(false);
            this.groupBoxStation.PerformLayout();
            this.groupBoxLine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProvider;
        private System.Windows.Forms.ComboBox comboBoxProviders;
        private System.Windows.Forms.GroupBox groupBoxStation;
        private System.Windows.Forms.ListBox listBoxStations;
        private System.Windows.Forms.Button buttonFindStation;
        private System.Windows.Forms.TextBox textBoxStation;
        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBoxLines;


    }
}

