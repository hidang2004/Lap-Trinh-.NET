namespace lap07_QuanLyNhanVien_Sử_Dụng_list_view
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 1; i <= 10; i++)
			{
				ListViewItem item = new ListViewItem();
				item.Text = "Nguyễn Văn " + i.ToString();
				item.SubItems.Add("01/01/200" + i);
				item.SubItems.Add("Địa chỉ " + i.ToString());
				item.SubItems.Add("012345678" + i.ToString());
				lvdanhsachnhanvien.Items.Add(item);
			}
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (txthoten.Text.Trim().Length > 0)
			{
				ListViewItem item = new ListViewItem();
				item.Text = txthoten.Text;
				item.SubItems.Add(txtngaysinh.Value.ToString("dd/MM/yyyy"));
				item.SubItems.Add(txtdiachi.Text);
				item.SubItems.Add(txtdienthoai.Text);
				lvdanhsachnhanvien.Items.Add(item);
			}
			else
			{
				MessageBox.Show("Vui Lòng Nhập Họ Tên Trước Khi Thêm");
			}
		}

		private void chonMotDong(object sender, EventArgs e)
		{
			if (lvdanhsachnhanvien.SelectedItems.Count > 0)
			{
				try
				{
					txthoten.Text = lvdanhsachnhanvien.SelectedItems[0].SubItems[0].Text;
					string ngayStr = lvdanhsachnhanvien.SelectedItems[0].SubItems[1].Text;

					// Parse với Culture cố định
					System.Globalization.CultureInfo cultureInfo =
						new System.Globalization.CultureInfo("en-US");

					if (DateTime.TryParseExact(ngayStr, "dd/MM/yyyy", cultureInfo,
						System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))

						txtngaysinh.Value = ngaySinh;
					else
					{
						MessageBox.Show("Định dạng ngày không hợp lệ: " + ngayStr);
					}

					txtdiachi.Text = lvdanhsachnhanvien.SelectedItems[0].SubItems[2].Text;
					txtdienthoai.Text = lvdanhsachnhanvien.SelectedItems[0].SubItems[3].Text;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			if (lvdanhsachnhanvien.SelectedItems.Count > 0)
			{
				// Hiển thị dialog xác nhận
				DialogResult result = MessageBox.Show(
					"Bạn có chắc chắn muốn xóa nhân viên này?",
					"Xác nhận xóa",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				// Nếu người dùng nhấn "Yes" mới xóa
				if (result == DialogResult.Yes)
				{
					lvdanhsachnhanvien.Items.Remove(lvdanhsachnhanvien.SelectedItems[0]);
					// Xóa dữ liệu trên form
					txthoten.Text = "";
					txtngaysinh.Value = DateTime.Now;
					txtdiachi.Text = "";
					txtdienthoai.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (lvdanhsachnhanvien.SelectedItems.Count > 0)
			{
				lvdanhsachnhanvien.SelectedItems[0].SubItems[0].Text = txthoten.Text;
				lvdanhsachnhanvien.SelectedItems[0].SubItems[1].Text = txtngaysinh.Value.ToString("dd/MM/yyyy");
				lvdanhsachnhanvien.SelectedItems[0].SubItems[2].Text = txtdiachi.Text;
				lvdanhsachnhanvien.SelectedItems[0].SubItems[3].Text = txtdienthoai.Text;
			}
			else
			{
				MessageBox.Show("Vui Lòng Chọn Nhân Viên Cần Sửa");
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (result == DialogResult.Yes)
			{
				Close();
			}
		}
	}
}
