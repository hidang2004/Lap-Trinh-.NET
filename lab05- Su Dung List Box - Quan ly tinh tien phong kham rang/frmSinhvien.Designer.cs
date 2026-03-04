namespace lab05__Su_Dung_List_Box___Quan_ly_tinh_tien_phong_kham_rang
{
	partial class frmSinhvien
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
			txtHoten = new TextBox();
			lstBandau = new ListBox();
			lstKetqua = new ListBox();
			btCapnhat = new Button();
			btTraisangphai = new Button();
			btTatcatraisangphai = new Button();
			btPhaisangtrai = new Button();
			btTatcaphaisangtrai = new Button();
			btXoa = new Button();
			btKetthuc = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(218, 9);
			label1.Name = "label1";
			label1.Size = new Size(356, 41);
			label1.TabIndex = 0;
			label1.Text = "DANH SÁCH SINH VIÊN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(32, 99);
			label2.Name = "label2";
			label2.Size = new Size(78, 20);
			label2.TabIndex = 1;
			label2.Text = "Họ và Tên";
			// 
			// txtHoten
			// 
			txtHoten.Location = new Point(173, 96);
			txtHoten.Name = "txtHoten";
			txtHoten.Size = new Size(472, 27);
			txtHoten.TabIndex = 2;
			// 
			// lstBandau
			// 
			lstBandau.BackColor = Color.FromArgb(255, 192, 192);
			lstBandau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lstBandau.FormattingEnabled = true;
			lstBandau.Location = new Point(32, 157);
			lstBandau.Name = "lstBandau";
			lstBandau.Size = new Size(274, 424);
			lstBandau.TabIndex = 3;
			// 
			// lstKetqua
			// 
			lstKetqua.BackColor = Color.FromArgb(255, 192, 192);
			lstKetqua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lstKetqua.FormattingEnabled = true;
			lstKetqua.Location = new Point(497, 157);
			lstKetqua.Name = "lstKetqua";
			lstKetqua.Size = new Size(274, 424);
			lstKetqua.TabIndex = 4;
			// 
			// btCapnhat
			// 
			btCapnhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btCapnhat.Location = new Point(675, 85);
			btCapnhat.Name = "btCapnhat";
			btCapnhat.Size = new Size(96, 48);
			btCapnhat.TabIndex = 5;
			btCapnhat.Text = "Cập Nhật";
			btCapnhat.UseVisualStyleBackColor = true;
			btCapnhat.Click += btCapnhat_Click;
			// 
			// btTraisangphai
			// 
			btTraisangphai.BackColor = Color.FromArgb(255, 192, 128);
			btTraisangphai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btTraisangphai.Location = new Point(312, 267);
			btTraisangphai.Name = "btTraisangphai";
			btTraisangphai.Size = new Size(69, 36);
			btTraisangphai.TabIndex = 6;
			btTraisangphai.Text = ">";
			btTraisangphai.UseVisualStyleBackColor = false;
			btTraisangphai.Click += btTraisangphai_Click;
			// 
			// btTatcatraisangphai
			// 
			btTatcatraisangphai.BackColor = Color.FromArgb(255, 192, 128);
			btTatcatraisangphai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btTatcatraisangphai.Location = new Point(312, 309);
			btTatcatraisangphai.Name = "btTatcatraisangphai";
			btTatcatraisangphai.Size = new Size(69, 36);
			btTatcatraisangphai.TabIndex = 7;
			btTatcatraisangphai.Text = ">>";
			btTatcatraisangphai.UseVisualStyleBackColor = false;
			btTatcatraisangphai.Click += btTatcatraisangphai_Click;
			// 
			// btPhaisangtrai
			// 
			btPhaisangtrai.BackColor = Color.FromArgb(255, 192, 128);
			btPhaisangtrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btPhaisangtrai.Location = new Point(423, 267);
			btPhaisangtrai.Name = "btPhaisangtrai";
			btPhaisangtrai.Size = new Size(68, 36);
			btPhaisangtrai.TabIndex = 8;
			btPhaisangtrai.Text = "<";
			btPhaisangtrai.UseVisualStyleBackColor = false;
			btPhaisangtrai.Click += btPhaisangtrai_Click;
			// 
			// btTatcaphaisangtrai
			// 
			btTatcaphaisangtrai.BackColor = Color.FromArgb(255, 192, 128);
			btTatcaphaisangtrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btTatcaphaisangtrai.Location = new Point(423, 309);
			btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
			btTatcaphaisangtrai.Size = new Size(68, 36);
			btTatcaphaisangtrai.TabIndex = 9;
			btTatcaphaisangtrai.Text = "<<";
			btTatcaphaisangtrai.UseVisualStyleBackColor = false;
			btTatcaphaisangtrai.Click += btTatcaphaisangtrai_Click;
			// 
			// btXoa
			// 
			btXoa.BackColor = Color.FromArgb(255, 192, 128);
			btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btXoa.Location = new Point(72, 587);
			btXoa.Name = "btXoa";
			btXoa.Size = new Size(189, 29);
			btXoa.TabIndex = 10;
			btXoa.Text = "Xóa";
			btXoa.UseVisualStyleBackColor = false;
			btXoa.Click += btXoa_Click;
			// 
			// btKetthuc
			// 
			btKetthuc.BackColor = Color.FromArgb(255, 192, 128);
			btKetthuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btKetthuc.Location = new Point(544, 587);
			btKetthuc.Name = "btKetthuc";
			btKetthuc.Size = new Size(189, 29);
			btKetthuc.TabIndex = 11;
			btKetthuc.Text = "Kết Thúc";
			btKetthuc.UseVisualStyleBackColor = false;
			btKetthuc.Click += btKetthuc_Click;
			// 
			// frmSinhvien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			ClientSize = new Size(800, 619);
			Controls.Add(btKetthuc);
			Controls.Add(btXoa);
			Controls.Add(btTatcaphaisangtrai);
			Controls.Add(btPhaisangtrai);
			Controls.Add(btTatcatraisangphai);
			Controls.Add(btTraisangphai);
			Controls.Add(btCapnhat);
			Controls.Add(lstKetqua);
			Controls.Add(lstBandau);
			Controls.Add(txtHoten);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmSinhvien";
			Text = "frmSinhvien";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtHoten;
		private ListBox lstBandau;
		private ListBox lstKetqua;
		private Button btCapnhat;
		private Button btTraisangphai;
		private Button btTatcatraisangphai;
		private Button btPhaisangtrai;
		private Button btTatcaphaisangtrai;
		private Button btXoa;
		private Button btKetthuc;
	}
}