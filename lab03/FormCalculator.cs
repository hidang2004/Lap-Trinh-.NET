namespace lab03
{
	public partial class FormCalculator : Form
	{
		public FormCalculator()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void buttonCong_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double tong = n + m;
			txtKetQua.Text = tong.ToString();
		}

		private void buttonTru_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double tong = n - m;
			txtKetQua.Text = tong.ToString();
		}

		private void buttonNhan_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double tong = n * m;
			txtKetQua.Text = tong.ToString();
		}

		private void buttonChia_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			if (m != 0)
			{
				double tong = n / m;
				txtKetQua.Text = tong.ToString();
			}
			else 
			{
				txtKetQua.Text = "Lỗi chia cho 0";
			}
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			txtSoN.Text = "";
			txtSoM.Text = "";
			txtKetQua.Text = "";
		}

		private void buttonThoat_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
