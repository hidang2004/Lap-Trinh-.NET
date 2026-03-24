using lab08_QLSinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab08_QLSinhVien
{
	public partial class FormNhapDiem : Form
	{
		QuanLySvContext db = new QuanLySvContext();

		public FormNhapDiem()
		{
			InitializeComponent();
		}

		private void FormNhapDiem_Load(object sender, EventArgs e)
		{
			LoadSinhVien();
			LoadMon();
		}

		// Load danh sách sinh viên
		void LoadSinhVien()
		{
			var ds = db.SinhViens.ToList();

			cbomaso.DataSource = ds;
			cbomaso.DisplayMember = "MaSo";
			cbomaso.ValueMember = "MaSo";

			cbohoten.DataSource = ds;
			cbohoten.DisplayMember = "HoTen";
			cbohoten.ValueMember = "MaSo";
		}

		// Load danh sách môn
		void LoadMon()
		{
			var ds = db.Mons.ToList();

			cbomamon.DataSource = ds;
			cbomamon.DisplayMember = "MaMh";
			cbomamon.ValueMember = "MaMh";

			cbotenmon.DataSource = ds;
			cbotenmon.DisplayMember = "TenMh";
			cbotenmon.ValueMember = "MaMh";
		}

		// Đồng bộ mã SV -> tên SV
		private void cbomaso_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbohoten.SelectedIndex = cbomaso.SelectedIndex;
		}

		// Đồng bộ tên SV -> mã SV
		private void cbohoten_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbomaso.SelectedIndex = cbohoten.SelectedIndex;
		}

		// Đồng bộ mã môn -> tên môn
		private void cbomamon_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbotenmon.SelectedIndex = cbomamon.SelectedIndex;
		}

		// Đồng bộ tên môn -> mã môn
		private void cbotenmon_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbomamon.SelectedIndex = cbotenmon.SelectedIndex;
		}

		// Nút nhập điểm
		private void btnNhap_Click(object sender, EventArgs e)
		{
			if (txtdiem.Text == "")
			{
				MessageBox.Show("Nhập điểm!");
				return;
			}

			KetQua kq = new KetQua
			{
				MaSo = Convert.ToInt32(cbomaso.SelectedValue),
				MaMh = cbomamon.SelectedValue.ToString(),
				Diem = Convert.ToInt32(txtdiem.Text)
			};

			db.KetQuas.Add(kq);
			db.SaveChanges();

			MessageBox.Show("Nhập điểm thành công!");

			txtdiem.Clear();
		}
	}
}