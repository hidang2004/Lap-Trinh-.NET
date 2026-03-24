using System;
using System.Windows.Forms;

namespace lab08_QLSinhVien
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

		// Sinh viên
		private void toolSinhVien_Click(object sender, EventArgs e)
		{
			Quản_Lý_Sinh_Viên f = new Quản_Lý_Sinh_Viên();
			f.MdiParent = this;
			f.Show();
		}

		// Khoa
		private void toolKhoa_Click(object sender, EventArgs e)
		{
			FormKhoa f = new FormKhoa();
			f.MdiParent = this;
			f.Show();
		}

		// Môn học
		private void toolMon_Click(object sender, EventArgs e)
		{
			FormMon f = new FormMon();
			f.MdiParent = this;
			f.Show();
		}

		// Nhập điểm
		private void toolNhapDiem_Click(object sender, EventArgs e)
		{
			FormNhapDiem f = new FormNhapDiem();
			f.MdiParent = this;
			f.Show();
		}

		// Xem điểm
		private void toolXemDiem_Click(object sender, EventArgs e)
		{
			FormXemDiem f = new FormXemDiem();
			f.MdiParent = this;
			f.Show();
		}

		// Thoát
		private void toolThoat_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			Application.Exit();
		}
	}
}