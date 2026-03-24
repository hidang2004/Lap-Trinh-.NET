namespace lab08_QLSinhVien
{
	partial class FormKhoa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtTenKhoa = new TextBox();
			label2 = new Label();
			txtMaKhoa = new TextBox();
			label1 = new Label();
			dgvKhoa = new DataGridView();
			btnXoa = new Button();
			btnThem = new Button();
			btnlammoi = new Button();
			btnsua = new Button();
			txttimkiem = new TextBox();
			label8 = new Label();
			btntimkiem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
			SuspendLayout();
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Location = new Point(136, 96);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(212, 27);
			txtTenKhoa.TabIndex = 10;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label2.Location = new Point(27, 97);
			label2.Name = "label2";
			label2.Size = new Size(82, 23);
			label2.TabIndex = 9;
			label2.Text = "Tên Khoa";
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Location = new Point(136, 40);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(212, 27);
			txtMaKhoa.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label1.Location = new Point(27, 41);
			label1.Name = "label1";
			label1.Size = new Size(80, 23);
			label1.TabIndex = 7;
			label1.Text = "Mã Khoa";
			// 
			// dgvKhoa
			// 
			dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhoa.Location = new Point(0, 197);
			dgvKhoa.Name = "dgvKhoa";
			dgvKhoa.RowHeadersWidth = 51;
			dgvKhoa.Size = new Size(801, 252);
			dgvKhoa.TabIndex = 11;
			dgvKhoa.SelectionChanged += dgvKhoa_SelectionChanged;
			dgvKhoa.Click += dgvKhoa_SelectionChanged;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(192, 0, 192);
			btnXoa.Location = new Point(272, 144);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 51);
			btnXoa.TabIndex = 13;
			btnXoa.Text = "✖️Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(0, 192, 0);
			btnThem.Location = new Point(55, 146);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 49);
			btnThem.TabIndex = 12;
			btnThem.Text = "➕Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnlammoi
			// 
			btnlammoi.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnlammoi.ForeColor = Color.FromArgb(255, 128, 0);
			btnlammoi.Location = new Point(390, 145);
			btnlammoi.Name = "btnlammoi";
			btnlammoi.Size = new Size(113, 50);
			btnlammoi.TabIndex = 25;
			btnlammoi.Text = "🔃Làm Mới";
			btnlammoi.UseVisualStyleBackColor = true;
			btnlammoi.Click += btnLamMoi_Click;
			// 
			// btnsua
			// 
			btnsua.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnsua.ForeColor = Color.FromArgb(0, 0, 192);
			btnsua.Location = new Point(155, 146);
			btnsua.Name = "btnsua";
			btnsua.Size = new Size(100, 50);
			btnsua.TabIndex = 26;
			btnsua.Text = "🖊️Sửa";
			btnsua.UseVisualStyleBackColor = true;
			btnsua.Click += btnSua_Click;
			// 
			// txttimkiem
			// 
			txttimkiem.Location = new Point(535, 67);
			txttimkiem.Name = "txttimkiem";
			txttimkiem.Size = new Size(148, 27);
			txttimkiem.TabIndex = 35;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label8.Location = new Point(453, 71);
			label8.Name = "label8";
			label8.Size = new Size(76, 23);
			label8.TabIndex = 34;
			label8.Text = "Từ Khóa";
			// 
			// btntimkiem
			// 
			btntimkiem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btntimkiem.ForeColor = Color.Fuchsia;
			btntimkiem.Location = new Point(689, 58);
			btntimkiem.Name = "btntimkiem";
			btntimkiem.Size = new Size(58, 45);
			btntimkiem.TabIndex = 33;
			btntimkiem.Text = "🔍";
			btntimkiem.UseVisualStyleBackColor = true;
			btntimkiem.Click += btnTimKiem_Click;
			// 
			// FormKhoa
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txttimkiem);
			Controls.Add(label8);
			Controls.Add(btntimkiem);
			Controls.Add(btnsua);
			Controls.Add(btnlammoi);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(dgvKhoa);
			Controls.Add(txtTenKhoa);
			Controls.Add(label2);
			Controls.Add(txtMaKhoa);
			Controls.Add(label1);
			Name = "FormKhoa";
			Text = "Khoa";
			Load += FormKhoa_Load;
			((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtTenKhoa;
		private Label label2;
		private TextBox txtMaKhoa;
		private Label label1;
		private DataGridView dgvKhoa;
		private Button btnXoa;
		private Button btnThem;
		private Button btnlammoi;
		private Button btnsua;
		private TextBox txttimkiem;
		private Label label8;
		private Button btntimkiem;
	}
}