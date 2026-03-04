namespace lab05__Su_Dung_List_Box___Quan_ly_tinh_tien_phong_kham_rang
{
	partial class Thaotacso
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			txtSonguyen = new TextBox();
			lstKetqua = new ListBox();
			btCapnhat = new Button();
			groupBox1 = new GroupBox();
			btXoaphantucuoi = new Button();
			btXoaphantudau = new Button();
			btXoaphantudangchon = new Button();
			btLecuoi = new Button();
			btChonchandau = new Button();
			btTang2 = new Button();
			btKetthuc = new Button();
			errSonguyen = new ErrorProvider(components);
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errSonguyen).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(35, 26);
			label1.Name = "label1";
			label1.Size = new Size(127, 20);
			label1.TabIndex = 0;
			label1.Text = "Nhập Số Nguyên";
			// 
			// txtSonguyen
			// 
			txtSonguyen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			txtSonguyen.Location = new Point(208, 23);
			txtSonguyen.Name = "txtSonguyen";
			txtSonguyen.Size = new Size(383, 27);
			txtSonguyen.TabIndex = 1;
			txtSonguyen.TextChanged += txtSonguyen_TextChanged;
			// 
			// lstKetqua
			// 
			lstKetqua.BackColor = Color.FromArgb(255, 192, 192);
			lstKetqua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lstKetqua.FormattingEnabled = true;
			lstKetqua.Location = new Point(35, 76);
			lstKetqua.Name = "lstKetqua";
			lstKetqua.Size = new Size(263, 364);
			lstKetqua.TabIndex = 2;
			// 
			// btCapnhat
			// 
			btCapnhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btCapnhat.Location = new Point(640, 17);
			btCapnhat.Name = "btCapnhat";
			btCapnhat.Size = new Size(106, 38);
			btCapnhat.TabIndex = 3;
			btCapnhat.Text = "Cập Nhập";
			btCapnhat.UseVisualStyleBackColor = true;
			btCapnhat.Click += btCapnhat_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btXoaphantucuoi);
			groupBox1.Controls.Add(btXoaphantudau);
			groupBox1.Controls.Add(btXoaphantudangchon);
			groupBox1.Controls.Add(btLecuoi);
			groupBox1.Controls.Add(btChonchandau);
			groupBox1.Controls.Add(btTang2);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			groupBox1.Location = new Point(428, 76);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(329, 364);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Chức Năng";
			// 
			// btXoaphantucuoi
			// 
			btXoaphantucuoi.BackColor = Color.FromArgb(255, 192, 128);
			btXoaphantucuoi.ForeColor = Color.Black;
			btXoaphantucuoi.Location = new Point(55, 298);
			btXoaphantucuoi.Name = "btXoaphantucuoi";
			btXoaphantucuoi.Size = new Size(217, 50);
			btXoaphantucuoi.TabIndex = 5;
			btXoaphantucuoi.Text = "Xóa phần tử cuối";
			btXoaphantucuoi.UseVisualStyleBackColor = false;
			btXoaphantucuoi.Click += btXoaphantucuoi_Click;
			// 
			// btXoaphantudau
			// 
			btXoaphantudau.BackColor = Color.FromArgb(255, 192, 128);
			btXoaphantudau.ForeColor = Color.Black;
			btXoaphantudau.Location = new Point(55, 243);
			btXoaphantudau.Name = "btXoaphantudau";
			btXoaphantudau.Size = new Size(217, 49);
			btXoaphantudau.TabIndex = 4;
			btXoaphantudau.Text = "Xóa phần tử đầu";
			btXoaphantudau.UseVisualStyleBackColor = false;
			btXoaphantudau.Click += btXoaphantudau_Click;
			// 
			// btXoaphantudangchon
			// 
			btXoaphantudangchon.BackColor = Color.FromArgb(255, 192, 128);
			btXoaphantudangchon.ForeColor = Color.Black;
			btXoaphantudangchon.Location = new Point(55, 191);
			btXoaphantudangchon.Name = "btXoaphantudangchon";
			btXoaphantudangchon.Size = new Size(217, 46);
			btXoaphantudangchon.TabIndex = 3;
			btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
			btXoaphantudangchon.UseVisualStyleBackColor = false;
			btXoaphantudangchon.Click += btXoaphantudangchon_Click;
			// 
			// btLecuoi
			// 
			btLecuoi.BackColor = Color.FromArgb(255, 192, 128);
			btLecuoi.ForeColor = Color.Black;
			btLecuoi.Location = new Point(55, 137);
			btLecuoi.Name = "btLecuoi";
			btLecuoi.Size = new Size(217, 48);
			btLecuoi.TabIndex = 2;
			btLecuoi.Text = "Chọn số lẻ cuối";
			btLecuoi.UseVisualStyleBackColor = false;
			btLecuoi.Click += btLecuoi_Click;
			// 
			// btChonchandau
			// 
			btChonchandau.BackColor = Color.FromArgb(255, 192, 128);
			btChonchandau.ForeColor = Color.Black;
			btChonchandau.Location = new Point(57, 88);
			btChonchandau.Name = "btChonchandau";
			btChonchandau.Size = new Size(215, 43);
			btChonchandau.TabIndex = 1;
			btChonchandau.Text = "Chọn số chẵn đầu";
			btChonchandau.UseVisualStyleBackColor = false;
			btChonchandau.Click += btChonchandau_Click;
			// 
			// btTang2
			// 
			btTang2.BackColor = Color.FromArgb(255, 192, 128);
			btTang2.ForeColor = Color.Black;
			btTang2.Location = new Point(57, 36);
			btTang2.Name = "btTang2";
			btTang2.Size = new Size(215, 46);
			btTang2.TabIndex = 0;
			btTang2.Text = "Tăng mỗi phần tử lên 2";
			btTang2.UseVisualStyleBackColor = false;
			btTang2.Click += btTang2_Click;
			// 
			// btKetthuc
			// 
			btKetthuc.BackColor = Color.FromArgb(255, 192, 128);
			btKetthuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btKetthuc.Location = new Point(35, 468);
			btKetthuc.Name = "btKetthuc";
			btKetthuc.Size = new Size(722, 50);
			btKetthuc.TabIndex = 6;
			btKetthuc.Text = "Kết Thúc";
			btKetthuc.UseVisualStyleBackColor = false;
			btKetthuc.Click += btKetthuc_Click;
			// 
			// errSonguyen
			// 
			errSonguyen.ContainerControl = this;
			// 
			// Thaotacso
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(800, 530);
			Controls.Add(btKetthuc);
			Controls.Add(groupBox1);
			Controls.Add(btCapnhat);
			Controls.Add(lstKetqua);
			Controls.Add(txtSonguyen);
			Controls.Add(label1);
			DoubleBuffered = true;
			ForeColor = SystemColors.ControlText;
			Name = "Thaotacso";
			Text = "Thaotacso";
			Load += Thaotacso_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)errSonguyen).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSonguyen;
		private ListBox lstKetqua;
		private Button btCapnhat;
		private GroupBox groupBox1;
		private Button btXoaphantucuoi;
		private Button btXoaphantudau;
		private Button btXoaphantudangchon;
		private Button btLecuoi;
		private Button btChonchandau;
		private Button btTang2;
		private Button btKetthuc;
		private ErrorProvider errSonguyen;
	}
}