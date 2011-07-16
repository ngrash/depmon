namespace DepMon
{
    partial class DepartureControl
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
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelMinsRemaining = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxType.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxType.TabIndex = 0;
            this.pictureBoxType.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.Location = new System.Drawing.Point(45, 3);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(39, 13);
            this.labelLine.TabIndex = 1;
            this.labelLine.Text = "[Line]";
            // 
            // labelMinsRemaining
            // 
            this.labelMinsRemaining.AutoSize = true;
            this.labelMinsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinsRemaining.Location = new System.Drawing.Point(144, -2);
            this.labelMinsRemaining.Name = "labelMinsRemaining";
            this.labelMinsRemaining.Size = new System.Drawing.Size(38, 25);
            this.labelMinsRemaining.TabIndex = 2;
            this.labelMinsRemaining.Text = "[X]";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(45, 22);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(66, 13);
            this.labelDestination.TabIndex = 3;
            this.labelDestination.Text = "[Destination]";
            // 
            // label1
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(175, 10);
            this.labelMin.Name = "label1";
            this.labelMin.Size = new System.Drawing.Size(23, 13);
            this.labelMin.TabIndex = 4;
            this.labelMin.Text = "min";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(146, 26);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "[Time]";
            // 
            // DepartureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelMinsRemaining);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.pictureBoxType);
            this.Name = "DepartureControl";
            this.Size = new System.Drawing.Size(201, 42);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxType;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelMinsRemaining;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelTime;
    }
}
