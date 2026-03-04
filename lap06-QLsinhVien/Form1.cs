namespace lap06_QLsinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool kiemtraMaSV(string ma)
		{
			for (int i = 0; i < lvDSSV.Items.Count; i++)
			{
				if (lvDSSV.Items[i].Text == ma)
				{
					return false;
				}
			}

			for (int i = 0; i < lvDSDC.Items.Count; i++)
			{
				if (lvDSDC.Items[i].Text == ma)
				{
					return false;
				}
			}
			return true;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (txtMaSV.Text.Trim() == "" || txtHoVaTen.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông Báo");
			}
			else if (kiemtraMaSV(txtMaSV.Text.Trim()) == false)
			{
				MessageBox.Show("Mã sinh viên đã tồn tại, vui lòng nhập lại!", "Thông Báo");
				txtMaSV.SelectAll();
				txtMaSV.Focus();
			}
			else
			{
				int stt = lvDSSV.Items.Count + 1;

				ListViewItem li = new ListViewItem(stt.ToString());
				li.SubItems.Add(txtMaSV.Text.Trim());
				li.SubItems.Add(txtHoVaTen.Text.Trim());

				lvDSSV.Items.Add(li);
				txtMaSV.Text = "";
				txtHoVaTen.Text = "";
				txtMaSV.Focus();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDSSV.Items.Count)
			{
				if (lvDSSV.Items[i].Selected == true)
				{
					lvDSSV.Items.RemoveAt(i);
				}
				else
				{
					i++;
				}
				danhSoThuTu(lvDSSV);
			}
		}

		private void danhSoThuTu(ListView lv)
		{
			for (int i = 0; i < lv.Items.Count; i++)
			{
				lv.Items[i].SubItems[0].Text = (i + 1).ToString();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 1; i <= 5; i++)
			{
				ListViewItem li = new ListViewItem(i.ToString());
				li.SubItems.Add("SV" + i);
				li.SubItems.Add("Nguyễn Văn " + i);

				lvDSSV.Items.Add(li);
			}
			lvDSDC.HideSelection = false;
			lvDSSV.FullRowSelect = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
										 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void tim(ListView lv, string text)
		{
			text = text.ToUpper();

			for (int i = 0; i < lv.Items.Count; i++)
			{
				ListViewItem item = lv.Items[i];

				string maSV = item.SubItems[1].Text.ToUpper();
				string hoTen = item.SubItems[2].Text.ToUpper();

				if (maSV.Contains(text) || hoTen.Contains(text))
				{
					item.BackColor = Color.Yellow;   // 👉 tô vàng
					item.ForeColor = Color.Black;
					item.Selected = true;
					item.EnsureVisible();
				}
				else
				{
					item.BackColor = Color.White;    // reset màu
					item.ForeColor = Color.Black;
					item.Selected = false;
				}
			}
		}


		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			thuchientim();
		}

		private void thuchientim()
		{
			tim(lvDSSV, txtTimKiem.Text);
			txtTimKiem.SelectAll();
			txtTimKiem.Focus();
		}

		private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				thuchientim();
			}
		}

		private void btnChon1_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDSSV.Items.Count)
			{
				if (lvDSSV.Items[i].Selected == true)
				{
					ListViewItem li = lvDSSV.Items[i];

					lvDSSV.Items.RemoveAt(i);
					lvDSDC.Items.Add(li);
				}
				else
				{
					i++;
				}
				danhSoThuTu(lvDSSV);
			}
		}

		private void btnTrave1_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDSDC.Items.Count)
			{
				if (lvDSDC.Items[i].Selected == true)
				{
					ListViewItem li = lvDSDC.Items[i];

					lvDSDC.Items.RemoveAt(i);
					lvDSSV.Items.Add(li);
				}
				else
				{
					i++;
				}
				danhSoThuTu(lvDSDC);
			}
		}

		private void btnChonDS_Click(object sender, EventArgs e)
		{
			while (lvDSSV.Items.Count > 0)
			{
				ListViewItem li = lvDSSV.Items[0];

				lvDSSV.Items.RemoveAt(0);
				lvDSDC.Items.Add(li);
			}
		}

		private void btnTraveDS_Click(object sender, EventArgs e)
		{
			while (lvDSDC.Items.Count > 0)
			{
				ListViewItem li = lvDSDC.Items[0];

				lvDSDC.Items.RemoveAt(0);
				lvDSSV.Items.Add(li);
			}
		}
	}
}
