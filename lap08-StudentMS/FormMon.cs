using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lap08_StudentMS
{
	public partial class FormMon : Form
	{
		SqlConnection conn = new SqlConnection(
			"Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");

		SqlDataAdapter da;
		DataTable dtMon = new DataTable();
		BindingSource bds = new BindingSource();

		public FormMon()
		{
			InitializeComponent();
			this.Load += FormMon_Load;
		}

		// ================= LOAD =================
		private void FormMon_Load(object sender, EventArgs e)
		{
			try
			{
				da = new SqlDataAdapter("SELECT * FROM Mon", conn);
				da.Fill(dtMon);

				bds.DataSource = dtMon;
				dataGridViewMonHoc.DataSource = bds;

				// Binding textbox
				txtMaMonHoc.DataBindings.Clear();
				txtTenMonHoc.DataBindings.Clear();
				txtSoTiet.DataBindings.Clear();

				txtMaMonHoc.DataBindings.Add("Text", bds, "MaMH", true, DataSourceUpdateMode.OnPropertyChanged);
				txtTenMonHoc.DataBindings.Add("Text", bds, "TenMH", true, DataSourceUpdateMode.OnPropertyChanged);
				txtSoTiet.DataBindings.Add("Text", bds, "SoTiet", true, DataSourceUpdateMode.OnPropertyChanged);

				// bỏ chọn dòng
				dataGridViewMonHoc.ClearSelection();
				bds.Position = -1;

				// textbox trống
				txtMaMonHoc.Clear();
				txtTenMonHoc.Clear();
				txtSoTiet.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		// ================= THÊM =================
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaMonHoc.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập Mã môn học!");
				txtMaMonHoc.Focus();
				return;
			}

			if (txtTenMonHoc.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập Tên môn học!");
				txtTenMonHoc.Focus();
				return;
			}

			if (txtSoTiet.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập Số tiết!");
				txtSoTiet.Focus();
				return;
			}

			DataRow row = dtMon.NewRow();
			row["MaMH"] = txtMaMonHoc.Text;
			row["TenMH"] = txtTenMonHoc.Text;
			row["SoTiet"] = txtSoTiet.Text;

			dtMon.Rows.Add(row);

			MessageBox.Show("Thêm thành công!");

			txtMaMonHoc.Clear();
			txtTenMonHoc.Clear();
			txtSoTiet.Clear();

			txtMaMonHoc.Focus();
		}

		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bds.Current == null)
			{
				MessageBox.Show("Chưa chọn môn để xóa");
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