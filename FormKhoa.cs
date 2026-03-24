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
	public partial class FormKhoa : Form
	{
		QuanLySvContext db = new QuanLySvContext();

		public FormKhoa()
		{
			InitializeComponent();
		}
		private void FormKhoa_Load(object sender, EventArgs e)
		{
			LoadDanhSachKhoa();
		}
		// ===============================
		// Load danh sách khoa
		// ===============================
		private void LoadDanhSachKhoa()
		{
			var ds = db.Khoas
				.Select(k => new
				{
					k.MaKhoa,
					k.TenKhoa
				}).ToList();

			dgvKhoa.DataSource = ds;

			if (dgvKhoa.Columns.Count > 0)
			{
				dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
				dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";
			}

			dgvKhoa.ClearSelection();
		}

		// ===============================
		// Click DataGridView
		// ===============================
		private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvKhoa.CurrentRow == null) return;

			DataGridViewRow row = dgvKhoa.CurrentRow;

			txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString().Trim();
			txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString().Trim();
		}

		// ===============================
		// Thêm
		// ===============================
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
				return;
			}

			Khoa k = new Khoa
			{
				MaKhoa = txtMaKhoa.Text.Trim(),
				TenKhoa = txtTenKhoa.Text.Trim()
			};

			db.Khoas.Add(k);
			db.SaveChanges();

			LoadDanhSachKhoa();
			LamMoiForm();

			MessageBox.Show("Thêm khoa thành công!");
		}

		// ===============================
		// Sửa
		// ===============================
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dgvKhoa.CurrentRow == null)
			{
				MessageBox.Show("Chọn khoa cần sửa!");
				return;
			}

			string maCu = dgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
			string maMoi = txtMaKhoa.Text.Trim();
			string ten = txtTenKhoa.Text.Trim();

			if (maMoi == "" || ten == "")
			{
				MessageBox.Show("Nhập đầy đủ thông tin!");
				return;
			}

			var khoa = db.Khoas.FirstOrDefault(x => x.MaKhoa == maCu);

			if (khoa == null)
			{
				MessageBox.Show("Không tìm thấy khoa!");
				return;
			}

			// Nếu mã khoa không đổi → sửa tên
			if (maCu == maMoi)
			{
				khoa.TenKhoa = ten;
			}
			else
			{
				// Nếu mã khoa thay đổi
				db.Khoas.Remove(khoa);

				Khoa khoaMoi = new Khoa
				{
					MaKhoa = maMoi,
					TenKhoa = ten
				};

				db.Khoas.Add(khoaMoi);
			}

			db.SaveChanges();

			LoadDanhSachKhoa();

			MessageBox.Show("Sửa thành công!");
		}

		// ===============================
		// Xóa
		// ===============================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string ma = txtMaKhoa.Text.Trim();

			if (ma == "")
			{
				MessageBox.Show("Chọn khoa cần xóa!");
				return;
			}

			var cf = MessageBox.Show(
				"Bạn có chắc muốn xóa khoa này?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			Khoa k = db.Khoas.Find(ma);

			if (k != null)
			{
				db.Khoas.Remove(k);
				db.SaveChanges();
			}

			LoadDanhSachKhoa();
			LamMoiForm();

			MessageBox.Show("Xóa thành công!");
		}

		// ===============================
		// Làm mới
		// ===============================
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadDanhSachKhoa();
			LamMoiForm();
		}

		private void LamMoiForm()
		{
			// Xóa hết chữ trong các TextBox
			txtMaKhoa.Text = "";
			txtTenKhoa.Text = "";
			txttimkiem.Text = "";

			// Bỏ chọn dòng trong DataGridView
			dgvKhoa.ClearSelection();

			// Đưa con trỏ về ô Mã Khoa
			txtMaKhoa.Focus();
		}

		// ===============================
		// Tìm kiếm
		// ===============================
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string kw = txttimkiem.Text.Trim().ToLower();

			var ds = db.Khoas
				.Where(k => k.MaKhoa.ToLower().Contains(kw)
						 || k.TenKhoa.ToLower().Contains(kw))
				.Select(k => new
				{
					k.MaKhoa,
					k.TenKhoa
				})
				.ToList();

			dgvKhoa.DataSource = ds;
		}
	}
}