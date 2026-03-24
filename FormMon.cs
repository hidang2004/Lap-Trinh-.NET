using lab08_QLSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08_QLSinhVien
{
	public partial class FormMon : Form
	{
		QuanLySvContext db = new QuanLySvContext();

		public FormMon()
		{
			InitializeComponent();
		}

		private void FormMon_Load(object sender, EventArgs e)
		{
			LoadDanhSachMon();
		}

		// ===============================
		// Load danh sách môn
		// ===============================
		private void LoadDanhSachMon()
		{
			var ds = db.Mons
				.Select(m => new
				{
					m.MaMh,
					m.TenMh,
					m.SoTiet
				}).ToList();

			dgvMon.DataSource = ds;

			if (dgvMon.Columns.Count > 0)
			{
				dgvMon.Columns["MaMh"].HeaderText = "Mã Môn";
				dgvMon.Columns["TenMh"].HeaderText = "Tên Môn";
				dgvMon.Columns["SoTiet"].HeaderText = "Số Tiết";
			}

			dgvMon.ClearSelection();
		}

		// ===============================
		// Click DataGridView
		// ===============================
		private void dgvMon_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvMon.CurrentRow == null || dgvMon.SelectedRows.Count == 0)
				return;

			DataGridViewRow row = dgvMon.CurrentRow;

			txtMaMon.Text = row.Cells["MaMh"].Value?.ToString().Trim();
			txtTenMon.Text = row.Cells["TenMh"].Value?.ToString().Trim();
			txtSoTiet.Text = row.Cells["SoTiet"].Value?.ToString().Trim();
		}

		// ===============================
		// Thêm
		// ===============================
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtSoTiet.Text == "")
			{
				MessageBox.Show("Nhập đầy đủ thông tin!");
				return;
			}

			Mon m = new Mon
			{
				MaMh = txtMaMon.Text.Trim(),
				TenMh = txtTenMon.Text.Trim(),
				SoTiet = int.Parse(txtSoTiet.Text)
			};

			db.Mons.Add(m);
			db.SaveChanges();

			LoadDanhSachMon();
			LamMoiForm();

			MessageBox.Show("Thêm môn thành công!");
		}

		// ===============================
		// Sửa
		// ===============================
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dgvMon.CurrentRow == null)
			{
				MessageBox.Show("Chọn môn cần sửa!");
				return;
			}

			string maCu = dgvMon.CurrentRow.Cells["MaMh"].Value.ToString();
			string maMoi = txtMaMon.Text.Trim();
			string ten = txtTenMon.Text.Trim();
			int sotiet = int.TryParse(txtSoTiet.Text, out int st) ? st : 0;

			var mon = db.Mons.FirstOrDefault(x => x.MaMh == maCu);

			if (mon == null)
			{
				MessageBox.Show("Không tìm thấy môn!");
				return;
			}

			// Nếu mã môn không đổi
			if (maCu == maMoi)
			{
				mon.TenMh = ten;
				mon.SoTiet = sotiet;
			}
			else
			{
				db.Mons.Remove(mon);

				Mon monMoi = new Mon
				{
					MaMh = maMoi,
					TenMh = ten,
					SoTiet = sotiet
				};

				db.Mons.Add(monMoi);
			}

			db.SaveChanges();

			LoadDanhSachMon();
			LamMoiForm();

			MessageBox.Show("Sửa thành công!");
		}

		// ===============================
		// Xóa
		// ===============================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string ma = txtMaMon.Text.Trim();

			if (ma == "")
			{
				MessageBox.Show("Chọn môn cần xóa!");
				return;
			}

			var cf = MessageBox.Show(
				"Bạn có chắc muốn xóa môn này?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			Mon m = db.Mons.Find(ma);

			if (m != null)
			{
				db.Mons.Remove(m);
				db.SaveChanges();
			}

			LoadDanhSachMon();
			LamMoiForm();

			MessageBox.Show("Xóa thành công!");
		}

		// ===============================
		// Làm mới
		// ===============================
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadDanhSachMon();
			LamMoiForm();
		}

		private void LamMoiForm()
		{
			txtMaMon.Text = "";
			txtTenMon.Text = "";
			txtSoTiet.Text = "";
			txttimkiem.Text = "";

			dgvMon.ClearSelection();

			txtMaMon.Focus();
		}

		// ===============================
		// Tìm kiếm
		// ===============================
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string kw = txttimkiem.Text.Trim().ToLower();

			var ds = db.Mons
				.Where(m => m.MaMh.ToLower().Contains(kw)
						 || m.TenMh.ToLower().Contains(kw))
				.Select(m => new
				{
					m.MaMh,
					m.TenMh,
					m.SoTiet
				})
				.ToList();

			dgvMon.DataSource = ds;
		}
	}
}