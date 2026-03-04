using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05__Su_Dung_List_Box___Quan_ly_tinh_tien_phong_kham_rang
{
	public partial class Thaotacso : Form
	{
		public Thaotacso()
		{
			InitializeComponent();
		}

		private void txtSonguyen_TextChanged(object sender, EventArgs e)
		{
			Control ctrSonguyen = (Control)sender;

			if (ctrSonguyen.Text.Length > 0)
			{
				if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
					errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
				else
					errSonguyen.Clear();
			}

		}

		private void btCapnhat_Click(object sender, EventArgs e)
		{
			int n;

			// Kiểm tra có phải số nguyên hay không
			if (!int.TryParse(txtSonguyen.Text, out n))
			{
				MessageBox.Show(
					"Vui lòng chỉ nhập số nguyên!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				txtSonguyen.Focus();
				txtSonguyen.SelectAll();
				return;
			}

			// Nếu hợp lệ thì thêm vào ListBox
			lstKetqua.Items.Add(n.ToString());
			txtSonguyen.Text = "";
			txtSonguyen.Focus();

		}

		private void btTang2_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.Items.Count;

			for (int i = 0; i < n; i++)
			{
				int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
				lstKetqua.Items[i] = tam.ToString();
			}
		}

		private void btChonchandau_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.Items.Count;

			for (int i = 0; i < n; i++)
			{
				if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
				{
					lstKetqua.SelectedIndex = i;
					break;
				}
			}
		}

		private void btLecuoi_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.Items.Count;

			for (int i = n - 1; i >= 0; i--)
			{
				if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
				{
					lstKetqua.SelectedIndex = i;
					break;
				}
			}
		}

		private void btXoaphantudangchon_Click(object sender, EventArgs e)
		{
			for (int i = lstKetqua.SelectedIndices.Count - 1; i >= 0; i--)
			{
				lstKetqua.Items.RemoveAt(lstKetqua.SelectedIndices[i]);
			}
		}

		private void btXoaphantudau_Click(object sender, EventArgs e)
		{
			if (lstKetqua.Items.Count > 0)
				lstKetqua.Items.RemoveAt(0);
		}

		private void btXoaphantucuoi_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.Items.Count;
			if (n > 0)
				lstKetqua.Items.RemoveAt(n - 1);
		}

		private void Thaotacso_Load(object sender, EventArgs e)
		{

		}

		private void frmThaotacso_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn muốn thoát?", "Thông báo",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void btKetthuc_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
