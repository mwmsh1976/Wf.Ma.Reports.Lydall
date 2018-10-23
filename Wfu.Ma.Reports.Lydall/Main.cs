
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Wfu.Ma.Reports.Lydall.Classes;

namespace Wfu.Ma.Reports.Lydall
{
	public partial class Main : Form
	{
        List<Batch> _batchFileResults = null;

        public Main()
		{
			InitializeComponent();
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				 this.BatchReportPath.Text = openFileDialog.FileName;
				if (BatchReportPath.Text.Trim() != "")
                {
                    _batchFileResults = ProcessSelectedFile(BatchReportPath.Text.Trim());
                    datePicker.MaxDate = _batchFileResults.Max(x => x.PayPeriodEnd);
                    datePicker.MinDate = _batchFileResults.Min(x => x.PayPeriodStart);
                    datePicker.Enabled = true;
                }
			}
		}

		private List<Batch> ProcessSelectedFile(string path)
		{
			if (File.Exists(path))
			{
				var batchReportContents = new BatchReportScanner(path);
                return batchReportContents.Scan();
			}
			MessageBox.Show("Whoops! We can't find a file located at '" + path + "'");
			return new List<Batch>();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!Directory.Exists(reportPath.Text))
                {
                    MessageBox.Show("Whoops! Report path '" + reportPath.Text + "' not found.");
                    return;
                }
                var summaryReport = new SummaryReport(datePicker.Value);
                summaryReport.Create(_batchFileResults, reportPath.Text, (checkOpenReport.CheckState == CheckState.Checked));
            }
            catch (Exception ex )
            {
                var message = MessageBox.Show("Whoops! Something went wrong." + Environment.NewLine + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

        private void BrowseReport_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    reportPath.Text = folderBrowser.SelectedPath;
                }
            }
        }
    }
}
