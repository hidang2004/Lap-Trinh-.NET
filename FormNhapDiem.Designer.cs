namespace lab08_QLSinhVien
{
	partial class FormNhapDiem
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
			cbomaso = new ComboBox();
			cbohoten = new ComboBox();
			label2 = new Label();
			cbomamon = new ComboBox();
			label3 = new Label();
			cbotenmon = new ComboBox();
			label4 = new Label();
			label5 = new Label();
			txtdiem = new TextBox();
			btnnhap = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			label1.Location = new Point(74, 36);
			label1.Name = "label1";
			label1.Size = new Size(65, 25);
			label1.TabIndex = 0;
			label1.Text = "Mã Số";
			// 
			// cbomaso
			// 
			cbomaso.FormattingEnabled = true;
			cbomaso.Location = new Point(175, 33);
			cbomaso.Name = "cbomaso";
			cbomaso.Size = new Size(186, 28);
			cbomaso.TabIndex = 1;
			// 
			// cbohoten
			// 
			cbohoten.FormattingEnabled = true;
			cbohoten.Location = new Point(175, 83);
			cbohoten.Name = "cbohoten";
			cbohoten.Size = new Size(186, 28);
			cbohoten.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			label2.Location = new Point(74, 86);
			label2.Name = "label2";
			label2.Size = new Size(72, 25);
			label2.TabIndex = 2;
			label2.Text = "Họ Tên";
			// 
			// cbomamon
			// 
			cbomamon.FormattingEnabled = true;
			cbomamon.Location = new Point(175, 134);
			cbomamon.Name = "cbomamon";
			cbomamon.Size = new Size(186, 28);
			cbomamon.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			label3.Location = new Point(74, 137);
			label3.Name = "label3";
			label3.Size = new Size(83, 25);
			label3.TabIndex = 4;
			label3.Text = "Mã Môn";
			// 
			// cbotenmon
			// 
			cbotenmon.FormattingEnabled = true;
			cbotenmon.Location = new Point(175, 185);
			cbotenmon.Name = "cbotenmon";
			cbotenmon.Size = new Size(186, 28);
			cbotenmon.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			label4.Location = new Point(74, 188);
			label4.Name = "label4";
			label4.Size = new Size(86, 25);
			label4.TabIndex = 6;
			label4.Text = "Tên Môn";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			label5.Location = new Point(74, 237);
			label5.Name = "label5";
			label5.Size = new Size(56, 25);
			label5.TabIndex = 8;
			label5.Text = "Điểm";
			// 
			// txtdiem
			// 
			txtdiem.Location = new Point(175, 235);
			txtdiem.Name = "txtdiem";
			txtdiem.Size = new Size(150, 27);
			txtdiem.TabIndex = 9;
			// 
			// btnnhap
			// 
			btnnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnnhap.ForeColor = Color.FromArgb(64, 64, 0);
			btnnhap.Location = new Point(153, 319);
			btnnhap.Name = "btnnhap";
			btnnhap.Size = new Size(150, 61);
			btnnhap.TabIndex = 10;
			btnnhap.Text = "📝Nhập";
			btnnhap.UseVisualStyleBackColor = true;
			btnnhap.Click += btnNhap_Click;
			// 
			// FormNhapDiem
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(457, 450);
			Controls.Add(btnnhap);
			Controls.Add(txtdiem);
			Controls.Add(label5);
			Controls.Add(cbotenmon);
			Controls.Add(label4);
			Controls.Add(cbomamon);
			Controls.Add(label3);
			Controls.Add(cbohoten);
			Controls.Add(label2);
			Controls.Add(cbomaso);
			Controls.Add(label1);
			Name = "FormNhapDiem";
			Text = "Nhập Điểm";
			Load += FormNhapDiem_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cbomaso;
		private ComboBox cbohoten;
		private Label label2;
		private ComboBox cbomamon;
		private Label label3;
		private ComboBox cbotenmon;
		private Label label4;
		private Label label5;
		private TextBox txtdiem;
		private Button btnnhap;
	}
}