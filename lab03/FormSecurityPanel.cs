using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab03
{
	public partial class FormSecurityPanel : Form
	{
		public FormSecurityPanel()
		{
			InitializeComponent();
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			textSecuritycode.Clear();
		}

		private void btnNumber_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn != null)
			{
				textSecuritycode.Text += btn.Text;
			}
		}

		private string GetGroup(string code)
		{
			switch (code)
			{
				case "1645":
				case "1689":
					return "Technicians";

				case "8345":
					return "Custodians";

				case "9998":
				case "1006":
				case "1008":
					return "Scientists";

				default:
					return null;
			}
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			string code = textSecuritycode.Text;
			string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
			string log;

			if (code.Length == 1)
			{
				log = $"{time} Restricted Access";
			}
			else
			{
				string group = GetGroup(code);
				if (group != null)
					log = $"{time} {group}";
				else
					log = $"{time} Access denied";
			}

			AccessLog.Items.Add(log);
			WriteLogToFile(log);
			textSecuritycode.Clear();
		}

		private void WriteLogToFile(string log)
		{
			string path = Path.Combine(Application.StartupPath, "security_log.txt");
			File.AppendAllText(path, log + Environment.NewLine);
		}

		private void FormSecurityPanel_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
			{
				textSecuritycode.Text += (e.KeyCode - Keys.D0).ToString();
			}
			else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
			{
				textSecuritycode.Text += (e.KeyCode - Keys.NumPad0).ToString();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				btnEnter_Click(null, null);
			}
			else if (e.KeyCode == Keys.Back)
			{
				textSecuritycode.Clear();
			}
		}
	}
}
