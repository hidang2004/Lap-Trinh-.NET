namespace lab08_QLSinhVien
{
	partial class FormXemDiem
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
			cbohoten = new ComboBox();
			label2 = new Label();
			cbomaso = new ComboBox();
			label1 = new Label();
			txtkhoa = new TextBox();
			label5 = new Label();
			dgvxemdiem = new DataGridView();
			btnxem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvxemdiem).BeginInit();
			SuspendLayout();
			// 
			// cbohoten
			// 
			cbohoten.FormattingEnabled = true;
			cbohoten.Location = new Point(180, 91);
			cbohoten.Name = "cbohoten";
			cbohoten.Size = new Size(242, 28);
			cbohoten.TabIndex = 11;
			cbohoten.SelectedIndexChanged += cbohoten_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.Location = new Point(80, 91);
			label2.Name = "label2";
			label2.Size = new Size(78, 28);
			label2.TabIndex = 10;
			label2.Text = "Họ Tên";
			// 
			// cbomaso
			// 
			cbomaso.FormattingEnabled = true;
			cbomaso.Location = new Point(180, 42);
			cbomaso.Name = "cbomaso";
			cbomaso.Size = new Size(151, 28);
			cbomaso.TabIndex = 9;
			cbomaso.SelectedIndexChanged += cbomaso_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.Location = new Point(80, 38);
			label1.Name = "label1";
			label1.Size = new Size(71, 28);
			label1.TabIndex = 8;
			label1.Text = "Mã Số";
			// 
			// txtkhoa
			// 
			txtkhoa.Location = new Point(180, 149);
			txtkhoa.Name = "txtkhoa";
			txtkhoa.Size = new Size(151, 27);
			txtkhoa.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.Location = new Point(80, 145);
			label5.Name = "label5";
			label5.Size = new Size(60, 28);
			label5.TabIndex = 14;
			label5.Text = "Khoa";
			// 
			// dgvxemdiem
			// 
			dgvxemdiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvxemdiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvxemdiem.Location = new Point(1, 222);
			dgvxemdiem.Name = "dgvxemdiem";
			dgvxemdiem.RowHeadersWidth = 51;
			dgvxemdiem.Size = new Size(799, 225);
			dgvxemdiem.TabIndex = 16;
			// 
			// btnxem
			// 
			btnxem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnxem.ForeColor = Color.FromArgb(192, 0, 192);
			btnxem.Location = new Point(520, 73);
			btnxem.Name = "btnxem";
			btnxem.Size = new Size(154, 53);
			btnxem.TabIndex = 17;
			btnxem.Text = "👀Xem";
			btnxem.UseVisualStyleBackColor = true;
			btnxem.Click += btnXem_Click;
			// 
			// FormXemDiem
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnxem);
			Controls.Add(dgvxemdiem);
			Controls.Add(txtkhoa);
			Controls.Add(label5);
			Controls.Add(cbohoten);
			Controls.Add(label2);
			Controls.Add(cbomaso);
			Controls.Add(label1);
			Name = "FormXemDiem";
			Text = "Xem Điểm";
			Load += FormXemDiem_Load;
			((System.ComponentModel.ISupportInitialize)dgvxemdiem).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox cbohoten;
		private Label label2;
		private ComboBox cbomaso;
		private Label label1;
		private TextBox txtkhoa;
		private Label label5;
		private DataGridView dgvxemdiem;
		private Button btnxem;
	}
}