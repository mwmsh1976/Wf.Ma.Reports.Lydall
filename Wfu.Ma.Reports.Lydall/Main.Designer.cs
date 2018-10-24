namespace Wfu.Ma.Reports.Lydall
{
	partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseEmployeeReport = new System.Windows.Forms.Button();
            this.EmployeeReportPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseReport = new System.Windows.Forms.Button();
            this.reportPath = new System.Windows.Forms.TextBox();
            this.checkOpenReport = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBatchReport = new System.Windows.Forms.Button();
            this.BatchReportPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BrowseEmployeeReport);
            this.groupBox1.Controls.Add(this.EmployeeReportPath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BrowseReport);
            this.groupBox1.Controls.Add(this.reportPath);
            this.groupBox1.Controls.Add(this.checkOpenReport);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BrowseBatchReport);
            this.groupBox1.Controls.Add(this.BatchReportPath);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose batch file criteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee Report Path";
            // 
            // BrowseEmployeeReport
            // 
            this.BrowseEmployeeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseEmployeeReport.Location = new System.Drawing.Point(396, 44);
            this.BrowseEmployeeReport.Name = "BrowseEmployeeReport";
            this.BrowseEmployeeReport.Size = new System.Drawing.Size(28, 23);
            this.BrowseEmployeeReport.TabIndex = 9;
            this.BrowseEmployeeReport.Text = "...";
            this.BrowseEmployeeReport.UseVisualStyleBackColor = true;
            this.BrowseEmployeeReport.Click += new System.EventHandler(this.BrowseEmployeeReport_Click);
            // 
            // EmployeeReportPath
            // 
            this.EmployeeReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeReportPath.Location = new System.Drawing.Point(138, 46);
            this.EmployeeReportPath.Name = "EmployeeReportPath";
            this.EmployeeReportPath.Size = new System.Drawing.Size(259, 20);
            this.EmployeeReportPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Report Path";
            // 
            // BrowseReport
            // 
            this.BrowseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseReport.Location = new System.Drawing.Point(396, 70);
            this.BrowseReport.Name = "BrowseReport";
            this.BrowseReport.Size = new System.Drawing.Size(28, 22);
            this.BrowseReport.TabIndex = 6;
            this.BrowseReport.Text = "...";
            this.BrowseReport.UseVisualStyleBackColor = true;
            this.BrowseReport.Click += new System.EventHandler(this.BrowseReport_Click);
            // 
            // reportPath
            // 
            this.reportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPath.Location = new System.Drawing.Point(138, 72);
            this.reportPath.Name = "reportPath";
            this.reportPath.Size = new System.Drawing.Size(259, 20);
            this.reportPath.TabIndex = 5;
            this.reportPath.Text = "C:\\Temp\\";
            // 
            // checkOpenReport
            // 
            this.checkOpenReport.AutoSize = true;
            this.checkOpenReport.Checked = true;
            this.checkOpenReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOpenReport.Location = new System.Drawing.Point(248, 102);
            this.checkOpenReport.Name = "checkOpenReport";
            this.checkOpenReport.Size = new System.Drawing.Size(87, 17);
            this.checkOpenReport.TabIndex = 2;
            this.checkOpenReport.Text = "Open Report";
            this.checkOpenReport.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(137, 99);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(105, 20);
            this.datePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Batch Report Path";
            // 
            // BrowseBatchReport
            // 
            this.BrowseBatchReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBatchReport.Location = new System.Drawing.Point(396, 17);
            this.BrowseBatchReport.Name = "BrowseBatchReport";
            this.BrowseBatchReport.Size = new System.Drawing.Size(28, 23);
            this.BrowseBatchReport.TabIndex = 1;
            this.BrowseBatchReport.Text = "...";
            this.BrowseBatchReport.UseVisualStyleBackColor = true;
            this.BrowseBatchReport.Click += new System.EventHandler(this.Browse_Click);
            // 
            // BatchReportPath
            // 
            this.BatchReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatchReportPath.Location = new System.Drawing.Point(138, 19);
            this.BatchReportPath.Name = "BatchReportPath";
            this.BatchReportPath.Size = new System.Drawing.Size(259, 20);
            this.BatchReportPath.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(359, 158);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(92, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Report";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 191);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Lydall - Daily Summary Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BrowseBatchReport;
		private System.Windows.Forms.TextBox BatchReportPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.CheckBox checkOpenReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseReport;
        private System.Windows.Forms.TextBox reportPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseEmployeeReport;
        private System.Windows.Forms.TextBox EmployeeReportPath;
    }
}

