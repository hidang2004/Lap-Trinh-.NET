namespace lap08_StudentMS
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
			btnThem = new Button();
			txtMaKhoa = new TextBox();
			label1 = new Label();
			txtTenKhoa = new TextBox();
			label2 = new Label();
			btnXoa = new Button();
			btnLuu = new Button();
			dgvKhoa = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
			SuspendLayout();
			// 
			// btnThem
			// 
			btnThem.Location = new Point(469, 34);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 49);
			btnThem.TabIndex = 2;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Location = new Point(190, 36);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(212, 27);
			txtMaKhoa.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(81, 38);
			label1.Name = "label1";
			label1.Size = new Size(68, 20);
			label1.TabIndex = 3;
			label1.Text = "Mã Khoa";
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Location = new Point(190, 87);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(212, 27);
			txtTenKhoa.TabIndex = 6;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(81, 94);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 5;
			label2.Text = "Tên Khoa";
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(541, 103);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 51);
			btnXoa.TabIndex = 7;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(612, 34);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 49);
			btnLuu.TabIndex = 8;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// dgvKhoa
			// 
			dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhoa.Location = new Point(19, 186);
			dgvKhoa.Name = "dgvKhoa";
			dgvKhoa.RowHeadersWidth = 51;
			dgvKhoa.Size = new Size(761, 252);
			dgvKhoa.TabIndex = 9;
			// 
			// FormKhoa
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgvKhoa);
			Controls.Add(btnLuu);
			Controls.Add(btnXoa);
			Controls.Add(txtTenKhoa);
			Controls.Add(label2);
			Controls.Add(txtMaKhoa);
			Controls.Add(label1);
			Controls.Add(btnThem);
			Name = "FormKhoa";
			Text = "FormKhoa";
			Load += FormKhoa_Load;
			((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnThem;
		private TextBox txtMaKhoa;
		private Label label1;
		private TextBox txtTenKhoa;
		private Label label2;
		private Button btnXoa;
		private Button btnLuu;
		private DataGridView dgvKhoa;
	}
}