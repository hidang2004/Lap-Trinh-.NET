namespace lap08_StudentMS
{
	partial class FormSinhVien
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
			dataGridViewSinhVien = new DataGridView();
			label1 = new Label();
			txtMaSoSV = new TextBox();
			txtHoTen = new TextBox();
			label2 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtDiaChi = new TextBox();
			label6 = new Label();
			label8 = new Label();
			dtpNgaySinh = new DateTimePicker();
			gbGioiTinh = new GroupBox();
			radioButtonNu = new RadioButton();
			radioButtonNam = new RadioButton();
			txtSoDienThoai = new TextBox();
			comboBoxMaKhoa = new ComboBox();
			btnThemMoi = new Button();
			btnXoa = new Button();
			btnLuu = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
			gbGioiTinh.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridViewSinhVien
			// 
			dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewSinhVien.Location = new Point(1, 291);
			dataGridViewSinhVien.Name = "dataGridViewSinhVien";
			dataGridViewSinhVien.RowHeadersVisible = false;
			dataGridViewSinhVien.RowHeadersWidth = 51;
			dataGridViewSinhVien.Size = new Size(797, 240);
			dataGridViewSinhVien.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 32);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 1;
			label1.Text = "Mã Số Sinh Viên";
			// 
			// txtMaSoSV
			// 
			txtMaSoSV.Location = new Point(152, 29);
			txtMaSoSV.Name = "txtMaSoSV";
			txtMaSoSV.Size = new Size(213, 27);
			txtMaSoSV.TabIndex = 2;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(152, 73);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(213, 27);
			txtHoTen.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(30, 76);
			label2.Name = "label2";
			label2.Size = new Size(56, 20);
			label2.TabIndex = 3;
			label2.Text = "Họ Tên";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(30, 119);
			label4.Name = "label4";
			label4.Size = new Size(76, 20);
			label4.TabIndex = 5;
			label4.Text = "Ngày Sinh";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(437, 76);
			label5.Name = "label5";
			label5.Size = new Size(102, 20);
			label5.TabIndex = 11;
			label5.Text = "Số Điện Thoại";
			// 
			// txtDiaChi
			// 
			txtDiaChi.Location = new Point(553, 26);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(212, 27);
			txtDiaChi.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(437, 29);
			label6.Name = "label6";
			label6.Size = new Size(57, 20);
			label6.TabIndex = 9;
			label6.Text = "Địa Chỉ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(437, 124);
			label8.Name = "label8";
			label8.Size = new Size(43, 20);
			label8.TabIndex = 13;
			label8.Text = "Khoa";
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			dtpNgaySinh.Format = DateTimePickerFormat.Short;
			dtpNgaySinh.Location = new Point(152, 119);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(213, 27);
			dtpNgaySinh.TabIndex = 15;
			// 
			// gbGioiTinh
			// 
			gbGioiTinh.Controls.Add(radioButtonNu);
			gbGioiTinh.Controls.Add(radioButtonNam);
			gbGioiTinh.Location = new Point(30, 161);
			gbGioiTinh.Name = "gbGioiTinh";
			gbGioiTinh.Size = new Size(338, 62);
			gbGioiTinh.TabIndex = 16;
			gbGioiTinh.TabStop = false;
			gbGioiTinh.Text = "Giới Tính";
			// 
			// radioButtonNu
			// 
			radioButtonNu.AutoSize = true;
			radioButtonNu.Location = new Point(232, 32);
			radioButtonNu.Name = "radioButtonNu";
			radioButtonNu.Size = new Size(50, 24);
			radioButtonNu.TabIndex = 1;
			radioButtonNu.TabStop = true;
			radioButtonNu.Text = "Nữ";
			radioButtonNu.UseVisualStyleBackColor = true;
			// 
			// radioButtonNam
			// 
			radioButtonNam.AutoSize = true;
			radioButtonNam.Location = new Point(104, 32);
			radioButtonNam.Name = "radioButtonNam";
			radioButtonNam.Size = new Size(62, 24);
			radioButtonNam.TabIndex = 0;
			radioButtonNam.TabStop = true;
			radioButtonNam.Text = "Nam";
			radioButtonNam.UseVisualStyleBackColor = true;
			// 
			// txtSoDienThoai
			// 
			txtSoDienThoai.Location = new Point(553, 73);
			txtSoDienThoai.Name = "txtSoDienThoai";
			txtSoDienThoai.Size = new Size(212, 27);
			txtSoDienThoai.TabIndex = 17;
			// 
			// comboBoxMaKhoa
			// 
			comboBoxMaKhoa.FormattingEnabled = true;
			comboBoxMaKhoa.Location = new Point(553, 121);
			comboBoxMaKhoa.Name = "comboBoxMaKhoa";
			comboBoxMaKhoa.Size = new Size(212, 28);
			comboBoxMaKhoa.TabIndex = 18;
			// 
			// btnThemMoi
			// 
			btnThemMoi.Location = new Point(399, 171);
			btnThemMoi.Name = "btnThemMoi";
			btnThemMoi.Size = new Size(125, 52);
			btnThemMoi.TabIndex = 19;
			btnThemMoi.Text = "Thêm Mới";
			btnThemMoi.UseVisualStyleBackColor = true;
			btnThemMoi.Click += btnThemMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(530, 171);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(125, 52);
			btnXoa.TabIndex = 20;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(661, 171);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(125, 52);
			btnLuu.TabIndex = 21;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// FormSinhVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 543);
			Controls.Add(btnLuu);
			Controls.Add(btnXoa);
			Controls.Add(btnThemMoi);
			Controls.Add(comboBoxMaKhoa);
			Controls.Add(txtSoDienThoai);
			Controls.Add(gbGioiTinh);
			Controls.Add(dtpNgaySinh);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(txtDiaChi);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(txtHoTen);
			Controls.Add(label2);
			Controls.Add(txtMaSoSV);
			Controls.Add(label1);
			Controls.Add(dataGridViewSinhVien);
			Name = "FormSinhVien";
			Text = "FormSinhVien";
			Load += FormSinhVien_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
			gbGioiTinh.ResumeLayout(false);
			gbGioiTinh.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewSinhVien;
		private Label label1;
		private TextBox txtMaSoSV;
		private TextBox txtHoTen;
		private Label label2;
		private TextBox textBox2;
		private Label label3;
		private Label label4;
		private TextBox textBox4;
		private Label label5;
		private TextBox txtDiaChi;
		private Label label6;
		private Label label8;
		private DateTimePicker dtpNgaySinh;
		private GroupBox gbGioiTinh;
		private RadioButton radioButtonNu;
		private RadioButton radioButtonNam;
		private TextBox txtSoDienThoai;
		private ComboBox comboBoxMaKhoa;
		private Button btnThemMoi;
		private Button btnXoa;
		private Button btnLuu;
	}
}