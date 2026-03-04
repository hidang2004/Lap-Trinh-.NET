namespace lap07_QuanLyNhanVien_Sử_Dụng_list_view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			groupBox1 = new GroupBox();
			txtdiachi = new TextBox();
			label5 = new Label();
			txtdienthoai = new TextBox();
			label4 = new Label();
			txtngaysinh = new DateTimePicker();
			txthoten = new TextBox();
			label3 = new Label();
			label2 = new Label();
			btnthem = new Button();
			btnxoa = new Button();
			btnsua = new Button();
			btnthoat = new Button();
			groupBox2 = new GroupBox();
			lvdanhsachnhanvien = new ListView();
			columnHoten = new ColumnHeader();
			columnNgaysinh = new ColumnHeader();
			columnDiachi = new ColumnHeader();
			columnDienthoai = new ColumnHeader();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(255, 128, 128);
			label1.Location = new Point(198, 9);
			label1.Name = "label1";
			label1.Size = new Size(493, 62);
			label1.TabIndex = 0;
			label1.Text = "Danh Mục Nhân Viên";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtdiachi);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtdienthoai);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtngaysinh);
			groupBox1.Controls.Add(txthoten);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(16, 117);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(836, 138);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// txtdiachi
			// 
			txtdiachi.Location = new Point(548, 71);
			txtdiachi.Name = "txtdiachi";
			txtdiachi.Size = new Size(282, 27);
			txtdiachi.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(453, 74);
			label5.Name = "label5";
			label5.Size = new Size(57, 20);
			label5.TabIndex = 6;
			label5.Text = "Địa Chỉ";
			// 
			// txtdienthoai
			// 
			txtdienthoai.Location = new Point(548, 31);
			txtdienthoai.Name = "txtdienthoai";
			txtdienthoai.Size = new Size(282, 27);
			txtdienthoai.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(440, 34);
			label4.Name = "label4";
			label4.Size = new Size(102, 20);
			label4.TabIndex = 4;
			label4.Text = "Số Điện Thoại";
			// 
			// txtngaysinh
			// 
			txtngaysinh.CustomFormat = "dd/MM/yyyy";
			txtngaysinh.Format = DateTimePickerFormat.Custom;
			txtngaysinh.Location = new Point(127, 69);
			txtngaysinh.Name = "txtngaysinh";
			txtngaysinh.Size = new Size(247, 27);
			txtngaysinh.TabIndex = 3;
			// 
			// txthoten
			// 
			txthoten.Location = new Point(127, 31);
			txthoten.Name = "txthoten";
			txthoten.Size = new Size(247, 27);
			txthoten.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 74);
			label3.Name = "label3";
			label3.Size = new Size(76, 20);
			label3.TabIndex = 1;
			label3.Text = "Ngày Sinh";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(32, 34);
			label2.Name = "label2";
			label2.Size = new Size(56, 20);
			label2.TabIndex = 0;
			label2.Text = "Họ Tên";
			// 
			// btnthem
			// 
			btnthem.Location = new Point(48, 261);
			btnthem.Name = "btnthem";
			btnthem.Size = new Size(133, 51);
			btnthem.TabIndex = 2;
			btnthem.Text = "Thêm";
			btnthem.UseVisualStyleBackColor = true;
			btnthem.Click += btnthem_Click;
			// 
			// btnxoa
			// 
			btnxoa.Location = new Point(257, 261);
			btnxoa.Name = "btnxoa";
			btnxoa.Size = new Size(133, 51);
			btnxoa.TabIndex = 3;
			btnxoa.Text = "Xóa";
			btnxoa.UseVisualStyleBackColor = true;
			btnxoa.Click += btnxoa_Click;
			// 
			// btnsua
			// 
			btnsua.Location = new Point(469, 261);
			btnsua.Name = "btnsua";
			btnsua.Size = new Size(133, 51);
			btnsua.TabIndex = 4;
			btnsua.Text = "Sửa";
			btnsua.UseVisualStyleBackColor = true;
			btnsua.Click += btnsua_Click;
			// 
			// btnthoat
			// 
			btnthoat.Location = new Point(665, 261);
			btnthoat.Name = "btnthoat";
			btnthoat.Size = new Size(133, 51);
			btnthoat.TabIndex = 5;
			btnthoat.Text = "Thoát";
			btnthoat.UseVisualStyleBackColor = true;
			btnthoat.Click += btnthoat_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lvdanhsachnhanvien);
			groupBox2.Location = new Point(16, 341);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(836, 280);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin chung";
			// 
			// lvdanhsachnhanvien
			// 
			lvdanhsachnhanvien.Columns.AddRange(new ColumnHeader[] { columnHoten, columnNgaysinh, columnDiachi, columnDienthoai });
			lvdanhsachnhanvien.FullRowSelect = true;
			lvdanhsachnhanvien.GridLines = true;
			lvdanhsachnhanvien.Location = new Point(20, 30);
			lvdanhsachnhanvien.Name = "lvdanhsachnhanvien";
			lvdanhsachnhanvien.Size = new Size(801, 231);
			lvdanhsachnhanvien.TabIndex = 0;
			lvdanhsachnhanvien.UseCompatibleStateImageBehavior = false;
			lvdanhsachnhanvien.View = View.Details;
			lvdanhsachnhanvien.SelectedIndexChanged += chonMotDong;
			// 
			// columnHoten
			// 
			columnHoten.Text = "Họ Tên";
			columnHoten.Width = 200;
			// 
			// columnNgaysinh
			// 
			columnNgaysinh.Text = "Ngày Sinh";
			columnNgaysinh.Width = 150;
			// 
			// columnDiachi
			// 
			columnDiachi.Text = "Địa Chỉ";
			columnDiachi.Width = 150;
			// 
			// columnDienthoai
			// 
			columnDienthoai.Text = "Điện Thoại";
			columnDienthoai.Width = 150;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			ClientSize = new Size(867, 624);
			Controls.Add(groupBox2);
			Controls.Add(btnthoat);
			Controls.Add(btnsua);
			Controls.Add(btnxoa);
			Controls.Add(btnthem);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			ForeColor = SystemColors.ControlText;
			Name = "Form1";
			Text = "Quản Lý Nhân Viên";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private TextBox txthoten;
		private Label label3;
		private Label label2;
		private TextBox txtdiachi;
		private Label label5;
		private TextBox txtdienthoai;
		private Label label4;
		private DateTimePicker txtngaysinh;
		private Button btnthem;
		private Button btnxoa;
		private Button btnsua;
		private Button btnthoat;
		private GroupBox groupBox2;
		private ListView lvdanhsachnhanvien;
		private ColumnHeader columnHoten;
		private ColumnHeader columnNgaysinh;
		private ColumnHeader columnDiachi;
		private ColumnHeader columnDienthoai;
	}
}
