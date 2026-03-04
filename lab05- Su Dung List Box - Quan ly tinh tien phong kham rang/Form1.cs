using System;
using System.IO;
using System.Windows.Forms;

namespace lab05__Su_Dung_List_Box___Quan_ly_tinh_tien_phong_kham_rang
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void GetPay()
		{
			long total = 0;

			// Kiểm tra nhập tên khách hàng
			if (string.IsNullOrEmpty(txtFullName.Text))
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng");
				return;
			}

			if (chkClean.Checked) total += 100000;
			if (chkWhitening.Checked) total += 1000000;
			if (chkXRay.Checked) total += 10000000;

			total += (int)numericUpDownFilling.Value * 100000000;

			txtTotal.Text = total.ToString("N0") + "đ";
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			GetPay();
		}

		private void btnAddFile_Click(object sender, EventArgs e)
		{
			string info = txtFullName.Text + " - " + txtTotal.Text;
			listBoxCustomer.Items.Add(info);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
										 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (listBoxCustomer.SelectedIndex != -1)
			{
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng đã chọn!", "Xác nhận",
										 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					listBoxCustomer.Items.RemoveAt(listBoxCustomer.SelectedIndex);
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông Báo");
			}
		}

		private void btnSaveToFile_Click(object sender, EventArgs e)
		{
			try
			{
				// Khởi tạo hộp thoại lưu file
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Chỉ lọc file văn bản 
				saveFileDialog.Title = "Chọn nơi lưu danh sách khách hàng";
				saveFileDialog.DefaultExt = "txt";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string FileName = saveFileDialog.FileName;
					// Khởi tạo StreamWriter để ghi vào tệp "database.txt"
					// Tệp này sẽ nằm cùng thư mục với file chạy (.exe) của bạn
					using (StreamWriter writer = new StreamWriter(FileName))
					{
						foreach (var item in listBoxCustomer.Items)
						{
							writer.WriteLine(item.ToString());
						}
					}
					MessageBox.Show("Đã lưu danh sách vào tệp thành công!", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
			}
		}

		private void btnLoadFile_Click(object sender, EventArgs e)
		{
			// Khởi tạo hộp thoại mở file
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Bộ lọc định dạng file 
			openFileDialog.Title = "Chọn tệp dữ liệu khách hàng để tải";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					listBoxCustomer.Items.Clear(); // Xóa danh sách hiện tại trước khi tải mới [cite: 435]

					using (StreamReader reader = new StreamReader(openFileDialog.FileName))
					{
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							listBoxCustomer.Items.Add(line); // Nạp từng dòng vào ListBox [cite: 435]
						}
					}
					MessageBox.Show("Đã tải dữ liệu từ tệp lên danh sách!", "Thông báo");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message);
				}
			}
		}
	}
}
