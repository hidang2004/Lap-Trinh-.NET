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
		}

		// ================= LOAD =================
		private void FormKhoa_Load(object sender, EventArgs e)
		{
			try
			{
				da = new SqlDataAdapter("SELECT * FROM Khoa", conn);

				// tự sinh INSERT UPDATE DELETE
				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				da.Fill(dtKhoa);

				bds.DataSource = dtKhoa;
				dgvKhoa.DataSource = bds;

				// ===== Binding textbox =====
				txtMaKhoa.DataBindings.Clear();
				txtTenKhoa.DataBindings.Clear();

				txtMaKhoa.DataBindings.Add("Text", bds, "MaKhoa", true);
				txtTenKhoa.DataBindings.Add("Text", bds, "TenKhoa", true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		// ================= THÊM =================
		private void btnThem_Click(object sender, EventArgs e)
		{
			bds.AddNew();

			txtMaKhoa.Clear();
			txtTenKhoa.Clear();

			txtMaKhoa.Focus();
		}

		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bds.Count == 0 || bds.Current == null)
			{
				MessageBox.Show("Không có dữ liệu để xóa");
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
				bds.EndEdit();

				if (txtMaKhoa.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập Mã Khoa!");
					return;
				}

				if (txtTenKhoa.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập Tên Khoa!");
					return;
				}

				MessageBox.Show("Lưu thành công (chỉ trong chương trình)");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
     	}
	}
}
