namespace DepMon.Test.SampleApp
{
    partial class FormMain
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
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.comboBoxProviders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepartures = new System.Windows.Forms.DataGridView();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateDepartures = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateQuery = new System.Windows.Forms.Button();
            this.listBoxLines = new System.Windows.Forms.ListBox();
            this.buttonSelectStation = new System.Windows.Forms.Button();
            this.listBoxStations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchStation = new System.Windows.Forms.Button();
            this.textBoxStationSearchTerm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProvider.Location = new System.Drawing.Point(165, 19);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(55, 23);
            this.buttonAddProvider.TabIndex = 5;
            this.buttonAddProvider.Text = "Load";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            this.buttonAddProvider.Click += new System.EventHandler(this.buttonAddProvider_Click);
            // 
            // comboBoxProviders
            // 
            this.comboBoxProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProviders.FormattingEnabled = true;
            this.comboBoxProviders.Location = new System.Drawing.Point(61, 21);
            this.comboBoxProviders.Name = "comboBoxProviders";
            this.comboBoxProviders.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProviders.TabIndex = 5;
            this.comboBoxProviders.SelectedValueChanged += new System.EventHandler(this.comboBoxProviders_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Provider:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDepartures);
            this.groupBox1.Controls.Add(this.buttonUpdateDepartures);
            this.groupBox1.Location = new System.Drawing.Point(244, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departures";
            // 
            // dataGridViewDepartures
            // 
            this.dataGridViewDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Provider,
            this.Station,
            this.Line,
            this.Departure});
            this.dataGridViewDepartures.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewDepartures.Name = "dataGridViewDepartures";
            this.dataGridViewDepartures.RowHeadersVisible = false;
            this.dataGridViewDepartures.Size = new System.Drawing.Size(403, 147);
            this.dataGridViewDepartures.TabIndex = 10;
            // 
            // Provider
            // 
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            this.Provider.ReadOnly = true;
            // 
            // Station
            // 
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // buttonUpdateDepartures
            // 
            this.buttonUpdateDepartures.Location = new System.Drawing.Point(6, 19);
            this.buttonUpdateDepartures.Name = "buttonUpdateDepartures";
            this.buttonUpdateDepartures.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDepartures.TabIndex = 9;
            this.buttonUpdateDepartures.Text = "Update";
            this.buttonUpdateDepartures.UseVisualStyleBackColor = true;
            this.buttonUpdateDepartures.Click += new System.EventHandler(this.buttonUpdateDepartures_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonCreateQuery);
            this.groupBox2.Controls.Add(this.listBoxLines);
            this.groupBox2.Controls.Add(this.buttonSelectStation);
            this.groupBox2.Controls.Add(this.listBoxStations);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonSearchStation);
            this.groupBox2.Controls.Add(this.textBoxStationSearchTerm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxProviders);
            this.groupBox2.Controls.Add(this.buttonAddProvider);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 201);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lines:";
            // 
            // buttonCreateQuery
            // 
            this.buttonCreateQuery.Location = new System.Drawing.Point(165, 172);
            this.buttonCreateQuery.Name = "buttonCreateQuery";
            this.buttonCreateQuery.Size = new System.Drawing.Size(55, 23);
            this.buttonCreateQuery.TabIndex = 11;
            this.buttonCreateQuery.Text = "Create";
            this.buttonCreateQuery.UseVisualStyleBackColor = true;
            this.buttonCreateQuery.Click += new System.EventHandler(this.buttonCreateQuery_Click);
            // 
            // listBoxLines
            // 
            this.listBoxLines.FormattingEnabled = true;
            this.listBoxLines.Location = new System.Drawing.Point(61, 139);
            this.listBoxLines.Name = "listBoxLines";
            this.listBoxLines.Size = new System.Drawing.Size(100, 56);
            this.listBoxLines.TabIndex = 11;
            // 
            // buttonSelectStation
            // 
            this.buttonSelectStation.Location = new System.Drawing.Point(165, 110);
            this.buttonSelectStation.Name = "buttonSelectStation";
            this.buttonSelectStation.Size = new System.Drawing.Size(55, 23);
            this.buttonSelectStation.TabIndex = 11;
            this.buttonSelectStation.Text = "Select";
            this.buttonSelectStation.UseVisualStyleBackColor = true;
            this.buttonSelectStation.Click += new System.EventHandler(this.buttonSelectStation_Click);
            // 
            // listBoxStations
            // 
            this.listBoxStations.FormattingEnabled = true;
            this.listBoxStations.Location = new System.Drawing.Point(61, 77);
            this.listBoxStations.Name = "listBoxStations";
            this.listBoxStations.Size = new System.Drawing.Size(100, 56);
            this.listBoxStations.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Station:";
            // 
            // buttonSearchStation
            // 
            this.buttonSearchStation.Location = new System.Drawing.Point(165, 48);
            this.buttonSearchStation.Name = "buttonSearchStation";
            this.buttonSearchStation.Size = new System.Drawing.Size(55, 23);
            this.buttonSearchStation.TabIndex = 11;
            this.buttonSearchStation.Text = "Search";
            this.buttonSearchStation.UseVisualStyleBackColor = true;
            this.buttonSearchStation.Click += new System.EventHandler(this.buttonSearchStation_Click);
            // 
            // textBoxStationSearchTerm
            // 
            this.textBoxStationSearchTerm.Location = new System.Drawing.Point(61, 50);
            this.textBoxStationSearchTerm.Name = "textBoxStationSearchTerm";
            this.textBoxStationSearchTerm.Size = new System.Drawing.Size(100, 20);
            this.textBoxStationSearchTerm.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "DepMon Sample Application";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProvider;
        private System.Windows.Forms.ComboBox comboBoxProviders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDepartures;
        private System.Windows.Forms.Button buttonUpdateDepartures;
        private System.Windows.Forms.Button buttonSearchStation;
        private System.Windows.Forms.TextBox textBoxStationSearchTerm;
        private System.Windows.Forms.Button buttonCreateQuery;
        private System.Windows.Forms.ListBox listBoxLines;
        private System.Windows.Forms.Button buttonSelectStation;
        private System.Windows.Forms.ListBox listBoxStations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;

    }
}

