using System;
using System.Windows.Forms;

namespace lap08_StudentMS
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.IsMdiContainer = true;
		}

		// ===== SINH VIÊN =====
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			FormSinhVien f = new FormSinhVien();
			f.MdiParent = this;
			f.Show();
		}

		// ===== MÔN HỌC =====
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			FormMon f = new FormMon();
			f.MdiParent = this;
			f.Show();
		}

		// ===== KHOA =====
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			FormKhoa f = new FormKhoa();
			f.MdiParent = this;
			f.Show();
		}
	}
}