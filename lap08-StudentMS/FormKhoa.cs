using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lap08_StudentMS
{
	public partial class FormKhoa : Form
	{
		SqlConnection conn = new SqlConnection(
			"Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");

		SqlDataAdapter da;
		DataTable dtKhoa = new DataTable();
		BindingSource bds = new BindingSource();

		public FormKhoa()
		{
			InitializeComponent();
			this.Load += FormKhoa_Load;
			bool isAdding = false;
		}

		// ================= LOAD =================
		private void FormKhoa_Load(object sender, EventArgs e)
		{
			try
			{
				da = new SqlDataAdapter("SELECT * FROM Khoa", conn);
				da.Fill(dtKhoa);

				bds.DataSource = dtKhoa;
				dgvKhoa.DataSource = bds;

				// Binding textbox
				txtMaKhoa.DataBindings.Clear();
				txtTenKhoa.DataBindings.Clear();

				txtMaKhoa.DataBindings.Add("Text", bds, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
				txtTenKhoa.DataBindings.Add("Text", bds, "TenKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

				// 🔥 QUAN TRỌNG: bỏ chọn dòng
				dgvKhoa.ClearSelection();
				bds.Position = -1;

				// textbox trống
				txtMaKhoa.Clear();
				txtTenKhoa.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		// ================= THÊM =================
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaKhoa.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập Mã khoa!");
				txtMaKhoa.Focus();
				return;
			}

			if (txtTenKhoa.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập Tên khoa!");
				txtTenKhoa.Focus();
				return;
			}

			DataRow row = dtKhoa.NewRow();
			row["MaKhoa"] = txtMaKhoa.Text;
			row["TenKhoa"] = txtTenKhoa.Text;

			dtKhoa.Rows.Add(row);

			MessageBox.Show("Thêm thành công!");

			txtMaKhoa.Clear();
			txtTenKhoa.Clear();

			txtMaKhoa.Focus();
		}

		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bds.Current == null)
			{
				MessageBox.Show("Chưa chọn dòng để xóa");
				return;
			}

			if (MessageBox.Show("Bạn có chắc muốn xóa?",
				"Xác nhận",
				MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				bds.RemoveCurrent();

				MessageBox.Show("Xóa thành công (chỉ trong chương trình)");
			}
		}

		// ================= LƯU =================
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bds.EndEdit();   // kết thúc chỉnh sửa

				MessageBox.Show("Lưu thành công (chỉ trong chương trình)");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}
	}
}