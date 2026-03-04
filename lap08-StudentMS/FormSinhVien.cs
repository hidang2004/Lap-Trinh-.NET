using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lap08_StudentMS
{
	public partial class FormSinhVien : Form
	{
		SqlConnection conn = new SqlConnection("Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
		SqlDataAdapter da;
		DataTable dtSinhVien = new DataTable();
		DataTable dtKhoa = new DataTable();
		BindingSource bds = new BindingSource();

		public FormSinhVien()
		{
			InitializeComponent();
		}

		private void FormSinhVien_Load(object sender, EventArgs e)
		{
			try
			{
				// --- BƯỚC 1: Lấy dữ liệu Khoa đổ vào ComboBox ---
				SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa, TenKhoa FROM Khoa", conn);
				daKhoa.Fill(dtKhoa);

				comboBoxMaKhoa.DataSource = dtKhoa;
				comboBoxMaKhoa.DisplayMember = "TenKhoa";
				comboBoxMaKhoa.ValueMember = "MaKhoa";

				// --- BƯỚC 2: Lấy dữ liệu Sinh Viên ---
				da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);

				// QUAN TRỌNG: Dòng này tự động tạo lệnh INSERT, UPDATE, DELETE
				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				da.Fill(dtSinhVien);

				// --- BƯỚC 3: Thiết lập BindingSource ---
				bds.DataSource = dtSinhVien;
				dataGridViewSinhVien.DataSource = bds;

				// --- BƯỚC 4: Binding dữ liệu vào các ô TextBox/Date/Combo ---
				// Xóa binding cũ để tránh lỗi nếu hàm Load chạy lại (ít khi xảy ra nhưng an toàn)
				txtMaSoSV.DataBindings.Clear();
				txtHoTen.DataBindings.Clear();
				dtpNgaySinh.DataBindings.Clear();
				txtDiaChi.DataBindings.Clear();
				txtSoDienThoai.DataBindings.Clear();
				comboBoxMaKhoa.DataBindings.Clear();
				radioButtonNam.DataBindings.Clear();

				// Tham số: "Thuộc tính control", nguồn dữ liệu, "Tên cột trong SQL", format, update mode
				txtMaSoSV.DataBindings.Add("Text", bds, "MaSo", true);
				txtHoTen.DataBindings.Add("Text", bds, "HoTen", true);
				dtpNgaySinh.DataBindings.Add("Value", bds, "NgaySinh", true);
				txtDiaChi.DataBindings.Add("Text", bds, "DiaChi", true);
				txtSoDienThoai.DataBindings.Add("Text", bds, "DienThoai", true);

				// Binding ComboBox: Khi chọn grid, combo tự nhảy theo MaKhoa
				comboBoxMaKhoa.DataBindings.Add("SelectedValue", bds, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

				// Binding RadioButton:
				// Giả sử cột GioiTinh trong SQL là bit (True=Nam, False=Nữ)
				// Ta chỉ cần bind cho nút Nam, nút Nữ sẽ tự đảo ngược bằng code sự kiện bên dưới
				radioButtonNam.DataBindings.Add("Checked", bds, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);

				// Logic hiển thị: Khi nút Nam thay đổi, nút Nữ sẽ ngược lại
				radioButtonNam.CheckedChanged += (s, args) => { radioButtonNu.Checked = !radioButtonNam.Checked; };
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			// BindingSource hỗ trợ thêm mới cực nhanh
			bds.AddNew();

			// Thiết lập giá trị mặc định cho dòng mới (nếu cần)
			if (bds.Current != null)
			{
				DataRowView currentRow = (DataRowView)bds.Current;
				currentRow["GioiTinh"] = true; // Mặc định là Nam
				currentRow["NgaySinh"] = DateTime.Now;
				// Mặc định chọn khoa đầu tiên
				if (dtKhoa.Rows.Count > 0)
					currentRow["MaKhoa"] = dtKhoa.Rows[0]["MaKhoa"];
			}

			// Đưa con trỏ về ô nhập liệu đầu tiên
			bds.ResetCurrentItem();
			txtMaSoSV.Focus();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// 0. Kiểm tra có sinh viên hay không
			if (bds.Count == 0 || bds.Current == null)
			{
				MessageBox.Show("Không có sinh viên nào để xóa.");
				return;
			}

			// 1. Lấy thông tin sinh viên hiện tại đang chọn
			DataRowView currentRow = (DataRowView)bds.Current;
			string tenSV = currentRow["HoTen"].ToString();

			// 2. Hiển thị hộp thoại xác nhận (Confirm)
			DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {tenSV} không?",
												 "Xác nhận xóa",
												 MessageBoxButtons.YesNo,
												 MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					// 3. Xóa dòng khỏi BindingSource
					bds.RemoveCurrent();

					// 4. Cập nhật ngay lập tức xuống CSDL
					SqlCommandBuilder builder = new SqlCommandBuilder(da);

					MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
					// Nếu lỗi (vướng khóa ngoại), nạp lại dữ liệu để đồng bộ grid
					dtSinhVien.Clear();
					da.Fill(dtSinhVien);
				}
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				// Xác nhận dữ liệu từ các TextBox đã nạp vào dòng hiện tại của DataTable
				this.Validate();
				bds.EndEdit();

				// Tự động sinh lệnh INSERT/UPDATE
				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
			}
			catch (Exception ex)
			{

				MessageBox.Show("Lỗi CSDL: " + ex.Message);

				// Nạp lại dữ liệu để xóa các dòng lỗi trên giao diện
				dtSinhVien.Clear();
				da.Fill(dtSinhVien);
			}
		}
	}
}
