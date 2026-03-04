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
			this.Load += FormMonHoc_Load;
		}

		// ================= LOAD =================
		private void FormMonHoc_Load(object sender, EventArgs e)
		{
			try
			{
				dtMon.Clear();

				// 🔥 Sửa tên bảng thành Mon
				da = new SqlDataAdapter("SELECT * FROM Mon", conn);
				da.Fill(dtMon);

				if (dtMon.Rows.Count == 0)
				{
					MessageBox.Show("Bảng Môn đang rỗng!");
				}

				bds.DataSource = dtMon;
				dataGridViewMonHoc.DataSource = bds;

				// Clear binding cũ
				txtMaMonHoc.DataBindings.Clear();
				txtTenMonHoc.DataBindings.Clear();
				txtSoTiet.DataBindings.Clear();

				// 🔥 Sửa tên cột đúng theo bảng Mon
				txtMaMonHoc.DataBindings.Add("Text", bds, "MaMH", true);
				txtTenMonHoc.DataBindings.Add("Text", bds, "TenMH", true);
				txtSoTiet.DataBindings.Add("Text", bds, "SoTiet", true);
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

			if (bds.Current != null)
			{
				DataRowView row = (DataRowView)bds.Current;
				row["SoTiet"] = 45;
			}

			bds.ResetCurrentItem();
			txtMaMonHoc.Focus();
		}

		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bds.Count == 0 || bds.Current == null)
			{
				MessageBox.Show("Không có môn để xóa.");
				return;
			}

			DataRowView row = (DataRowView)bds.Current;
			string tenMon = row["TenMH"].ToString();

			DialogResult result = MessageBox.Show(
				$"Bạn có chắc muốn xóa môn {tenMon} không?",
				"Xác nhận",
				MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				try
				{
					bds.RemoveCurrent();

					SqlCommandBuilder builder = new SqlCommandBuilder(da);

					MessageBox.Show("Đã xóa thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi xóa: " + ex.Message);

					dtMon.Clear();
					da.Fill(dtMon);
				}
			}
		}

		// ================= LƯU =================
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bds.EndEdit();

				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				MessageBox.Show("Đã lưu dữ liệu thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi CSDL: " + ex.Message);

				dtMon.Clear();
				da.Fill(dtMon);
			}
		}
	}
}