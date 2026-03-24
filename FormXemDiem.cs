using lab08_QLSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08_QLSinhVien
{
	public partial class FormXemDiem : Form
	{
		QuanLySvContext db = new QuanLySvContext();
		bool isLoading = false;

		public FormXemDiem()
		{
			InitializeComponent();
		}

		private void FormXemDiem_Load(object sender, EventArgs e)
		{
			LoadSinhVien();
		}

		void LoadSinhVien()
		{
			isLoading = true;

			var ds = db.SinhViens.ToList();

			// Combo mã số
			cbomaso.DataSource = ds;
			cbomaso.DisplayMember = "MaSo";
			cbomaso.ValueMember = "MaSo";

			// Combo họ tên
			cbohoten.DataSource = ds;
			cbohoten.DisplayMember = "HoTen";
			cbohoten.ValueMember = "MaSo";

			isLoading = false;
		}

		// Đồng bộ mã số -> họ tên
		private void cbomaso_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isLoading) return;

			cbohoten.SelectedIndex = cbomaso.SelectedIndex;

			int maso = Convert.ToInt32(cbomaso.SelectedValue);

			var sv = db.SinhViens.FirstOrDefault(x => x.MaSo == maso);

			if (sv != null)
			{
				txtkhoa.Text = sv.MaKhoa;
			}
		}

		// Đồng bộ họ tên -> mã số
		private void cbohoten_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isLoading) return;

			cbomaso.SelectedIndex = cbohoten.SelectedIndex;
		}

		// Nút xem điểm
		private void btnXem_Click(object sender, EventArgs e)
		{
			int maso = Convert.ToInt32(cbomaso.SelectedValue);

			var ds = from kq in db.KetQuas
					 join mh in db.Mons on kq.MaMh equals mh.MaMh
					 where kq.MaSo == maso
					 select new
					 {
						 MaMon = mh.MaMh,
						 TenMon = mh.TenMh,
						 Diem = kq.Diem
					 };

			dgvxemdiem.DataSource = ds.ToList();
		}
	}
}
