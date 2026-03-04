using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
	public partial class FormUocBoi : Form
	{
		public FormUocBoi()
		{
			InitializeComponent();
		}

		private int timUSCLN(int a, int b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			while (a != b)
			{
				if (a > b)
					a -= b;
				else
					b -= a;
			}
			return a;
		}

		private int timBSCNN(int a, int b)
		{
			return (a * b) / timUSCLN(a, b);
		}

		private void buttonTim_Click(object sender, EventArgs e)
		{
			int a = int.Parse(textBoxA.Text);
			int b = int.Parse(textBoxB.Text);
			if (radioButton_UocSoChungLonNhat.Checked)
			{
				textBoxKetQua.Text = timUSCLN(a, b).ToString();
			}
			else if (radioButton_BoiSoChungNhoNhat.Checked)
			{
				textBoxKetQua.Text = timBSCNN(a, b).ToString();
			}
		}

		private void buttonBoQua_Click(object sender, EventArgs e)
		{
			textBoxA.Text = "";
			textBoxB.Text = "";
			textBoxKetQua.Text = "";
			radioButton_UocSoChungLonNhat.Checked = false;
			radioButton_BoiSoChungNhoNhat.Checked = false;
		}

		private void buttonThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
