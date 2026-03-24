namespace lab08_QLSinhVien
{
	partial class Quản_Lý_Sinh_Viên
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtdiachi = new TextBox();
			label7 = new Label();
			dtpngaysinh = new DateTimePicker();
			label4 = new Label();
			cbogioitinh = new ComboBox();
			cbokhoa = new ComboBox();
			btnthem = new Button();
			btnxoa = new Button();
			btnsua = new Button();
			btnlammoi = new Button();
			btntimkiem = new Button();
			dgvsinhvien = new DataGridView();
			txthoten = new TextBox();
			txtdienthoai = new TextBox();
			lblmaso = new Label();
			txttimkiem = new TextBox();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvsinhvien).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label1.Location = new Point(40, 76);
			label1.Name = "label1";
			label1.Size = new Size(65, 23);
			label1.TabIndex = 2;
			label1.Text = "Họ Tên";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label2.Location = new Point(40, 126);
			label2.Name = "label2";
			label2.Size = new Size(92, 23);
			label2.TabIndex = 4;
			label2.Text = "Ngày Sinh";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label3.Location = new Point(40, 178);
			label3.Name = "label3";
			label3.Size = new Size(83, 23);
			label3.TabIndex = 6;
			label3.Text = "Giới Tính";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label5.Location = new Point(497, 120);
			label5.Name = "label5";
			label5.Size = new Size(80, 23);
			label5.TabIndex = 12;
			label5.Text = "Mã Khoa";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label6.Location = new Point(497, 73);
			label6.Name = "label6";
			label6.Size = new Size(96, 23);
			label6.TabIndex = 10;
			label6.Text = "Điện Thoại";
			// 
			// txtdiachi
			// 
			txtdiachi.Location = new Point(608, 27);
			txtdiachi.Name = "txtdiachi";
			txtdiachi.Size = new Size(191, 27);
			txtdiachi.TabIndex = 9;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label7.Location = new Point(497, 28);
			label7.Name = "label7";
			label7.Size = new Size(68, 23);
			label7.TabIndex = 8;
			label7.Text = "Địa Chỉ";
			// 
			// dtpngaysinh
			// 
			dtpngaysinh.CustomFormat = "dd/MM/yyyy";
			dtpngaysinh.Format = DateTimePickerFormat.Custom;
			dtpngaysinh.Location = new Point(138, 123);
			dtpngaysinh.Name = "dtpngaysinh";
			dtpngaysinh.Size = new Size(191, 27);
			dtpngaysinh.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label4.Location = new Point(40, 31);
			label4.Name = "label4";
			label4.Size = new Size(60, 23);
			label4.TabIndex = 17;
			label4.Text = "Mã Số";
			// 
			// cbogioitinh
			// 
			cbogioitinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbogioitinh.FormattingEnabled = true;
			cbogioitinh.Location = new Point(128, 175);
			cbogioitinh.Name = "cbogioitinh";
			cbogioitinh.Size = new Size(201, 31);
			cbogioitinh.TabIndex = 18;
			// 
			// cbokhoa
			// 
			cbokhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbokhoa.FormattingEnabled = true;
			cbokhoa.Location = new Point(608, 120);
			cbokhoa.Name = "cbokhoa";
			cbokhoa.Size = new Size(191, 31);
			cbokhoa.TabIndex = 19;
			// 
			// btnthem
			// 
			btnthem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnthem.ForeColor = Color.Green;
			btnthem.Location = new Point(42, 231);
			btnthem.Name = "btnthem";
			btnthem.Size = new Size(100, 50);
			btnthem.TabIndex = 20;
			btnthem.Text = "➕Thêm";
			btnthem.UseVisualStyleBackColor = true;
			btnthem.Click += btnthem_Click;
			// 
			// btnxoa
			// 
			btnxoa.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnxoa.ForeColor = Color.FromArgb(192, 0, 0);
			btnxoa.Location = new Point(294, 231);
			btnxoa.Name = "btnxoa";
			btnxoa.Size = new Size(100, 50);
			btnxoa.TabIndex = 22;
			btnxoa.Text = "✖️Xóa";
			btnxoa.UseVisualStyleBackColor = true;
			btnxoa.Click += btnxoa_Click;
			// 
			// btnsua
			// 
			btnsua.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnsua.ForeColor = Color.FromArgb(0, 0, 192);
			btnsua.Location = new Point(168, 231);
			btnsua.Name = "btnsua";
			btnsua.Size = new Size(100, 50);
			btnsua.TabIndex = 23;
			btnsua.Text = "🖊️Sửa";
			btnsua.UseVisualStyleBackColor = true;
			btnsua.Click += btnsua_Click;
			// 
			// btnlammoi
			// 
			btnlammoi.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnlammoi.ForeColor = Color.FromArgb(255, 128, 0);
			btnlammoi.Location = new Point(420, 231);
			btnlammoi.Name = "btnlammoi";
			btnlammoi.Size = new Size(113, 50);
			btnlammoi.TabIndex = 24;
			btnlammoi.Text = "🔃Làm Mới";
			btnlammoi.UseVisualStyleBackColor = true;
			btnlammoi.Click += btnlammoi_Click;
			// 
			// btntimkiem
			// 
			btntimkiem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btntimkiem.ForeColor = Color.Fuchsia;
			btntimkiem.Location = new Point(776, 231);
			btntimkiem.Name = "btntimkiem";
			btntimkiem.Size = new Size(58, 45);
			btntimkiem.TabIndex = 25;
			btntimkiem.Text = "🔍";
			btntimkiem.UseVisualStyleBackColor = true;
			btntimkiem.Click += btntimkiem_Click;
			// 
			// dgvsinhvien
			// 
			dgvsinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvsinhvien.Location = new Point(1, 315);
			dgvsinhvien.Name = "dgvsinhvien";
			dgvsinhvien.RowHeadersWidth = 51;
			dgvsinhvien.Size = new Size(833, 281);
			dgvsinhvien.TabIndex = 26;
			dgvsinhvien.CellContentClick += dgvsinhvien_SelectionChanged;
			dgvsinhvien.SelectionChanged += dgvsinhvien_SelectionChanged;
			// 
			// txthoten
			// 
			txthoten.Location = new Point(128, 72);
			txthoten.Name = "txthoten";
			txthoten.Size = new Size(201, 27);
			txthoten.TabIndex = 28;
			// 
			// txtdienthoai
			// 
			txtdienthoai.Location = new Point(608, 72);
			txtdienthoai.Name = "txtdienthoai";
			txtdienthoai.Size = new Size(191, 27);
			txtdienthoai.TabIndex = 29;
			// 
			// lblmaso
			// 
			lblmaso.AutoSize = true;
			lblmaso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblmaso.ForeColor = Color.Red;
			lblmaso.Location = new Point(128, 33);
			lblmaso.Name = "lblmaso";
			lblmaso.Size = new Size(64, 20);
			lblmaso.TabIndex = 30;
			lblmaso.Text = "lblmaso";
			// 
			// txttimkiem
			// 
			txttimkiem.Location = new Point(658, 240);
			txttimkiem.Name = "txttimkiem";
			txttimkiem.Size = new Size(112, 27);
			txttimkiem.TabIndex = 32;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label8.Location = new Point(576, 244);
			label8.Name = "label8";
			label8.Size = new Size(76, 23);
			label8.TabIndex = 31;
			label8.Text = "Từ Khóa";
			// 
			// Quản_Lý_Sinh_Viên
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(835, 596);
			Controls.Add(txttimkiem);
			Controls.Add(label8);
			Controls.Add(lblmaso);
			Controls.Add(txtdienthoai);
			Controls.Add(txthoten);
			Controls.Add(dgvsinhvien);
			Controls.Add(btntimkiem);
			Controls.Add(btnlammoi);
			Controls.Add(btnsua);
			Controls.Add(btnxoa);
			Controls.Add(btnthem);
			Controls.Add(cbokhoa);
			Controls.Add(cbogioitinh);
			Controls.Add(label4);
			Controls.Add(dtpngaysinh);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(txtdiachi);
			Controls.Add(label7);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Quản_Lý_Sinh_Viên";
			Text = "SInh Viên";
			Load += Quản_Lý_Sinh_Viên_Load;
			((System.ComponentModel.ISupportInitialize)dgvsinhvien).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label txtmaso;
		private TextBox txttimkiem;
		private TextBox textBox2;
		private Label label1;
		private TextBox textBox3;
		private Label label2;
		private TextBox textBox4;
		private Label label3;
		private TextBox textBox5;
		private Label label5;
		private TextBox textBox7;
		private Label label6;
		private TextBox txtdiachi;
		private Label label7;
		private DateTimePicker dtpngaysinh;
		private Label label4;
		private ComboBox cbogioitinh;
		private ComboBox cbokhoa;
		private Button btnthem;
		private Button btnxoa;
		private Button btnsua;
		private Button btnlammoi;
		private Button btntimkiem;
		private DataGridView dgvsinhvien;
		private TextBox txthoten;
		private TextBox txtdienthoai;
		private Label lblmaso;
		private Label label8;
	}
}