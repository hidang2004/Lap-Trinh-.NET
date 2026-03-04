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
	public partial class frmSinhvien : Form
	{
		public frmSinhvien()
		{
			InitializeComponent();
		}

		private void btCapnhat_Click(object sender, EventArgs e)
		{
			if (txtHoten.Text.Trim() != "")
			{
				lstBandau.Items.Add(txtHoten.Text);
				txtHoten.Text = "";
				txtHoten.Focus();
			}
		}

		private void btTraisangphai_Click(object sender, EventArgs e)
		{
			int n = lstBandau.SelectedItems.Count;

			for (int i = 0; i < n; i++)
			{
				lstKetqua.Items.Add(lstBandau.SelectedItems[i]);
			}

			for (int i = n - 1; i >= 0; i--)
			{
				lstBandau.Items.Remove(lstBandau.SelectedItems[i]);
			}
		}

		private void btTatcatraisangphai_Click(object sender, EventArgs e)
		{
			int n = lstBandau.Items.Count;

			for (int i = 0; i < n; i++)
			{
				lstKetqua.Items.Add(lstBandau.Items[i]);
			}

			lstBandau.Items.Clear();
		}

		private void btPhaisangtrai_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.SelectedItems.Count;

			for (int i = 0; i < n; i++)
			{
				lstBandau.Items.Add(lstKetqua.SelectedItems[i]);
			}

			for (int i = n - 1; i >= 0; i--)
			{
				lstKetqua.Items.Remove(lstKetqua.SelectedItems[i]);
			}
		}

		private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
		{
			int n = lstKetqua.Items.Count;

			for (int i = 0; i < n; i++)
			{
				lstBandau.Items.Add(lstKetqua.Items[i]);
			}

			lstKetqua.Items.Clear();
		}

		private void btXoa_Click(object sender, EventArgs e)
		{
			if (lstBandau.SelectedIndex != -1)
			{
				lstBandau.Items.Remove(lstBandau.SelectedItem);
			}
		}

		private void btKetthuc_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
