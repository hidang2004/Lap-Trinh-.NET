using lab08_QLSinhVien.Models;
using Microsoft.EntityFrameworkCore;
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
	public partial class Quản_Lý_Sinh_Viên : Form
	{

		private QuanLySvContext db = new QuanLySvContext();

		public Quản_Lý_Sinh_Viên()
		{
			InitializeComponent();
		}

		private void Quản_Lý_Sinh_Viên_Load(object sender, EventArgs e)
		{
			LoadComboBoxGioiTinh();
			LoadComboBoxKhoa();
			LoadDanhSachSinhVien();
		}


		private void LoadDanhSachSinhVien()
		{
			// EF Core: dùng .Include() để load dữ liệu từ bảng liên quan (KHOA)
			var ds = db.SinhViens
				.Include(sv => sv.MaKhoaNavigation) // Load thông tin khoa
				.Select(sv => new
				{
					sv.MaSo,
					sv.HoTen,
					NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
					GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
					sv.DiaChi,
					sv.DienThoai,
					TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
				}).ToList();

			dgvsinhvien.DataSource = ds;
			if (dgvsinhvien.Columns.Count > 0)
			{
				dgvsinhvien.ClearSelection();
			}
			{
				dgvsinhvien.Columns["MaSo"].HeaderText = "Mã số";
				dgvsinhvien.Columns["HoTen"].HeaderText = "Họ và tên";
				dgvsinhvien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
				dgvsinhvien.Columns["GioiTinh"].HeaderText = "Giới tính";
				dgvsinhvien.Columns["DiaChi"].HeaderText = "Địa chỉ";
				dgvsinhvien.Columns["DienThoai"].HeaderText = "Điện thoại";
				dgvsinhvien.Columns["TenKhoa"].HeaderText = "Khoa";
			}
		}

		//----Load combo box Khoa----
		private void LoadComboBoxKhoa()
		{
			// EF Core: dùng .Include() để load navigation property nếu cần
			cbokhoa.DataSource = db.Khoas.ToList();
			cbokhoa.DisplayMember = "TenKhoa";
			cbokhoa.ValueMember = "MaKhoa";

		}

		//----Load combo box Giới Tính----
		private void LoadComboBoxGioiTinh()
		{
			cbogioitinh.Items.Clear();
			cbogioitinh.Items.Add("Nam");
			cbogioitinh.Items.Add("Nữ");
			cbogioitinh.SelectedIndex = 0;
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txthoten.Text))
			{
				MessageBox.Show("Vui lòng nhập họ tên sinh viên.", "Thông Báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txthoten.Focus();
				return;
			}

			SinhVien svMoi = new SinhVien
			{
				HoTen = txthoten.Text,
				NgaySinh = dtpngaysinh.Value,
				GioiTinh = cbogioitinh.SelectedItem.ToString() == "Nam",
				DiaChi = txtdiachi.Text,
				DienThoai = int.TryParse(txtdienthoai.Text, out int dt) ? dt : (int?)null,
				MaKhoa = cbokhoa.SelectedValue.ToString()
			};

			db.SinhViens.Add(svMoi);
			db.SaveChanges();

			LoadDanhSachSinhVien();

			MessageBox.Show("Thêm sinh viên thành công!", "Thông Báo",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(lblmaso.Text, out int maSo))
			{
				MessageBox.Show("Vui lòng chọn sinh viên cần sửa!"); return;
			}

			SinhVien? sv = db.SinhViens.Find(maSo);

			if (sv == null)
			{
				MessageBox.Show("Không tìm thấy!"); return;
			}

			sv.HoTen = txthoten.Text.Trim();
			sv.NgaySinh = dtpngaysinh.Value;
			sv.GioiTinh = cbogioitinh.SelectedItem.ToString() == "Nam";
			sv.DiaChi = txtdiachi.Text.Trim();
			sv.DienThoai = int.TryParse(txtdienthoai.Text, out int sdt) ? sdt : null;
			sv.MaKhoa = cbokhoa.SelectedValue?.ToString();

			db.SaveChanges();
			LoadDanhSachSinhVien();
			MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(lblmaso.Text, out int maSo))
			{
				MessageBox.Show("Vui lòng chọn sinh viên cần xóa!"); return;
			}

			var cf = MessageBox.Show(
			$"Xóa sinh viên: {txthoten.Text}?\nLưu ý: điểm của SV này cũng bị xóa!",
			"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


			if (cf != DialogResult.Yes) return;

			// Bắt buộc xóa KetQua trước (ràng buộc FK)
			var kqs = db.KetQuas.Where(kq => kq.MaSo == maSo).ToList();
			db.KetQuas.RemoveRange(kqs);

			SinhVien? sv = db.SinhViens.Find(maSo);
			if (sv != null) db.SinhViens.Remove(sv);

			db.SaveChanges();
			LoadDanhSachSinhVien();
			MessageBox.Show("Xóa thành công!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LamMoiForm()
		{
			lblmaso.Text = "";

			// Xóa hết chữ trong các TextBox
			txthoten.Text = "";
			txtdiachi.Text = "";
			txtdienthoai.Text = "";
			txttimkiem.Text = "";

			// Reset Date
			dtpngaysinh.Value = DateTime.Now;

			// Reset combobox
			cbogioitinh.SelectedIndex = -1;
			cbokhoa.SelectedIndex = -1;

			// Bỏ chọn dòng trong DataGridView
			dgvsinhvien.ClearSelection();

			// Con trỏ về ô Họ tên
			txthoten.Focus();            // đưa con trỏ về ô họ tên
		}

		private void btntimkiem_Click(object sender, EventArgs e)
		{
			string kw = txttimkiem.Text.Trim().ToLower();
			var kq = db.SinhViens
			.Include(sv => sv.MaKhoaNavigation)
			.Where(sv => sv.HoTen.ToLower().Contains(kw)
					   || (sv.DiaChi != null && sv.DiaChi.ToLower().Contains(kw)))
			.Select(sv => new
			{
				sv.MaSo,
				sv.HoTen,
				NgaySinh = sv.NgaySinh.HasValue
						   ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
				GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
				sv.DiaChi,
				sv.DienThoai,
				TenKhoa = sv.MaKhoaNavigation != null
						  ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
			}).ToList();

			dgvsinhvien.DataSource = kq;
		}

		private void btnlammoi_Click(object sender, EventArgs e)
		{
			LamMoiForm();
		}

		private void dgvsinhvien_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvsinhvien.CurrentRow == null) return;
			DataGridViewRow row = dgvsinhvien.CurrentRow;

			lblmaso.Text = row.Cells["MaSo"].Value.ToString();
			txthoten.Text = row.Cells["HoTen"].Value.ToString();
			txtdiachi.Text = row.Cells["DiaChi"].Value.ToString();
			txtdienthoai.Text = row.Cells["DienThoai"].Value.ToString();

			string? ns = row.Cells["NgaySinh"].Value?.ToString();
			if (DateTime.TryParseExact(ns, "dd/MM/yyyy",
				null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
				dtpngaysinh.Value = ngay;

			cbogioitinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() == "Nam" ? "Nam" : "Nữ";

			string? tenKhoa = row.Cells["TenKhoa"].Value?.ToString().Trim();
			foreach (Khoa k in cbokhoa.Items)
				if (k.TenKhoa.Trim() == tenKhoa) { cbokhoa.SelectedItem = k; break; }
		}
	}
}
