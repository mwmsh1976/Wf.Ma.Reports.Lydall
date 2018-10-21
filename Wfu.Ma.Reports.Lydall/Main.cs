using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfu.Ma.Reports.Lydall
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				 this.BatchReportPath.Text = openFileDialog.FileName;
				if (BatchReportPath.Text.Trim() != "") { datePicker.Enabled = true; }
			}
		}
	}
}
