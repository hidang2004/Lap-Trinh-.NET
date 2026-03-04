namespace lap06_QLsinhVien
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
			label2 = new Label();
			txtMaSV = new TextBox();
			txtHoVaTen = new TextBox();
			btnLuu = new Button();
			btnXoa = new Button();
			btnThoat = new Button();
			label3 = new Label();
			btnTimKiem = new Button();
			txtTimKiem = new TextBox();
			label4 = new Label();
			lvDSSV = new ListView();
			STT = new ColumnHeader();
			MaSV = new ColumnHeader();
			Hoten = new ColumnHeader();
			lvDSDC = new ListView();
			STT2 = new ColumnHeader();
			MaSV2 = new ColumnHeader();
			Hoten2 = new ColumnHeader();
			btnChon1 = new Button();
			btnTrave1 = new Button();
			btnChonDS = new Button();
			btnTraveDS = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label1.Location = new Point(39, 21);
			label1.Name = "label1";
			label1.Size = new Size(61, 23);
			label1.TabIndex = 0;
			label1.Text = "Mã SV";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label2.Location = new Point(197, 21);
			label2.Name = "label2";
			label2.Size = new Size(88, 23);
			label2.TabIndex = 1;
			label2.Text = "Họ và Tên";
			// 
			// txtMaSV
			// 
			txtMaSV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			txtMaSV.Location = new Point(21, 60);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(100, 30);
			txtMaSV.TabIndex = 2;
			// 
			// txtHoVaTen
			// 
			txtHoVaTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			txtHoVaTen.Location = new Point(150, 60);
			txtHoVaTen.Name = "txtHoVaTen";
			txtHoVaTen.Size = new Size(183, 30);
			txtHoVaTen.TabIndex = 3;
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnLuu.Location = new Point(376, 52);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(113, 44);
			btnLuu.TabIndex = 4;
			btnLuu.Text = "Thêm";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnXoa.Location = new Point(527, 52);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(117, 44);
			btnXoa.TabIndex = 5;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThoat
			// 
			btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnThoat.Location = new Point(682, 52);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(119, 44);
			btnThoat.TabIndex = 6;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label3.Location = new Point(21, 131);
			label3.Name = "label3";
			label3.Size = new Size(172, 23);
			label3.TabIndex = 7;
			label3.Text = "Danh Sách Sinh viên";
			// 
			// btnTimKiem
			// 
			btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnTimKiem.Location = new Point(221, 119);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(112, 38);
			btnTimKiem.TabIndex = 8;
			btnTimKiem.Text = "Tìm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			txtTimKiem.Location = new Point(357, 124);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(205, 30);
			txtTimKiem.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label4.Location = new Point(587, 131);
			label4.Name = "label4";
			label4.Size = new Size(167, 23);
			label4.TabIndex = 10;
			label4.Text = "Danh Sách Đã Chọn";
			// 
			// lvDSSV
			// 
			lvDSSV.BackColor = Color.White;
			lvDSSV.Columns.AddRange(new ColumnHeader[] { STT, MaSV, Hoten });
			lvDSSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lvDSSV.Location = new Point(21, 177);
			lvDSSV.Name = "lvDSSV";
			lvDSSV.Size = new Size(312, 478);
			lvDSSV.TabIndex = 11;
			lvDSSV.UseCompatibleStateImageBehavior = false;
			lvDSSV.View = View.Details;
			// 
			// STT
			// 
			STT.Text = "STT";
			// 
			// MaSV
			// 
			MaSV.Text = "Mã SV";
			// 
			// Hoten
			// 
			Hoten.Text = "Họ Tên";
			Hoten.Width = 150;
			// 
			// lvDSDC
			// 
			lvDSDC.Columns.AddRange(new ColumnHeader[] { STT2, MaSV2, Hoten2 });
			lvDSDC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lvDSDC.Location = new Point(487, 177);
			lvDSDC.Name = "lvDSDC";
			lvDSDC.Size = new Size(314, 478);
			lvDSDC.TabIndex = 12;
			lvDSDC.UseCompatibleStateImageBehavior = false;
			lvDSDC.View = View.Details;
			// 
			// STT2
			// 
			STT2.Text = "STT";
			// 
			// MaSV2
			// 
			MaSV2.Text = "Mã SV";
			// 
			// Hoten2
			// 
			Hoten2.Text = "Họ Tên";
			Hoten2.Width = 150;
			// 
			// btnChon1
			// 
			btnChon1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnChon1.Location = new Point(357, 177);
			btnChon1.Name = "btnChon1";
			btnChon1.Size = new Size(106, 67);
			btnChon1.TabIndex = 13;
			btnChon1.Text = ">";
			btnChon1.UseVisualStyleBackColor = true;
			btnChon1.Click += btnChon1_Click;
			// 
			// btnTrave1
			// 
			btnTrave1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnTrave1.Location = new Point(357, 308);
			btnTrave1.Name = "btnTrave1";
			btnTrave1.Size = new Size(106, 67);
			btnTrave1.TabIndex = 14;
			btnTrave1.Text = "<";
			btnTrave1.UseVisualStyleBackColor = true;
			btnTrave1.Click += btnTrave1_Click;
			// 
			// btnChonDS
			// 
			btnChonDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnChonDS.Location = new Point(357, 442);
			btnChonDS.Name = "btnChonDS";
			btnChonDS.Size = new Size(106, 67);
			btnChonDS.TabIndex = 15;
			btnChonDS.Text = ">>";
			btnChonDS.UseVisualStyleBackColor = true;
			btnChonDS.Click += btnChonDS_Click;
			// 
			// btnTraveDS
			// 
			btnTraveDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnTraveDS.Location = new Point(357, 575);
			btnTraveDS.Name = "btnTraveDS";
			btnTraveDS.Size = new Size(106, 67);
			btnTraveDS.TabIndex = 16;
			btnTraveDS.Text = "<<";
			btnTraveDS.UseVisualStyleBackColor = true;
			btnTraveDS.Click += btnTraveDS_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 192);
			ClientSize = new Size(818, 667);
			Controls.Add(btnTraveDS);
			Controls.Add(btnChonDS);
			Controls.Add(btnTrave1);
			Controls.Add(btnChon1);
			Controls.Add(lvDSDC);
			Controls.Add(lvDSSV);
			Controls.Add(label4);
			Controls.Add(txtTimKiem);
			Controls.Add(btnTimKiem);
			Controls.Add(label3);
			Controls.Add(btnThoat);
			Controls.Add(btnXoa);
			Controls.Add(btnLuu);
			Controls.Add(txtHoVaTen);
			Controls.Add(txtMaSV);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "QL Sinh Viên";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtMaSV;
		private TextBox txtHoVaTen;
		private Button btnLuu;
		private Button btnXoa;
		private Button btnThoat;
		private Label label3;
		private Button btnTimKiem;
		private TextBox txtTimKiem;
		private Label label4;
		private ListView lvDSSV;
		private ListView lvDSDC;
		private Button btnChon1;
		private Button btnTrave1;
		private Button btnChonDS;
		private Button btnTraveDS;
		private ColumnHeader STT2;
		private ColumnHeader MaSV2;
		private ColumnHeader Hoten2;
		private ColumnHeader STT;
		private ColumnHeader MaSV;
		private ColumnHeader Hoten;
	}
}
