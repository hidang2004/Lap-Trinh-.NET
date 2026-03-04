using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap08_Quản_Lý_sinh_viên_Database_SQL_Server
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			FormSinhVien f = new FormSinhVien();
			f.MdiParent = this;
			f.Show();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			FormMonHoc f = new FormMonHoc();
			f.MdiParent = this;
			f.Show();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}
