namespace lab08_QLSinhVien
{
	partial class FormMon
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
			btnXoa = new Button();
			btnThem = new Button();
			dgvMon = new DataGridView();
			txtSoTiet = new TextBox();
			label3 = new Label();
			txtTenMon = new TextBox();
			label2 = new Label();
			txtMaMon = new TextBox();
			label1 = new Label();
			btnsua = new Button();
			btnlammoi = new Button();
			txttimkiem = new TextBox();
			label8 = new Label();
			btntimkiem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
			SuspendLayout();
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(192, 0, 192);
			btnXoa.Location = new Point(490, 38);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 49);
			btnXoa.TabIndex = 19;
			btnXoa.Text = "✖️Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(0, 192, 0);
			btnThem.Location = new Point(390, 38);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 49);
			btnThem.TabIndex = 17;
			btnThem.Text = "➕Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// dgvMon
			// 
			dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMon.Location = new Point(1, 241);
			dgvMon.MultiSelect = false;
			dgvMon.Name = "dgvMon";
			dgvMon.RowHeadersWidth = 51;
			dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvMon.Size = new Size(818, 231);
			dgvMon.TabIndex = 16;
			dgvMon.SelectionChanged += dgvMon_SelectionChanged;
			dgvMon.Click += dgvMon_SelectionChanged;
			// 
			// txtSoTiet
			// 
			txtSoTiet.Location = new Point(150, 166);
			txtSoTiet.Name = "txtSoTiet";
			txtSoTiet.Size = new Size(223, 27);
			txtSoTiet.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label3.Location = new Point(36, 167);
			label3.Name = "label3";
			label3.Size = new Size(63, 23);
			label3.TabIndex = 14;
			label3.Text = "Số tiết";
			// 
			// txtTenMon
			// 
			txtTenMon.Location = new Point(150, 107);
			txtTenMon.Name = "txtTenMon";
			txtTenMon.Size = new Size(223, 27);
			txtTenMon.TabIndex = 13;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label2.Location = new Point(36, 108);
			label2.Name = "label2";
			label2.Size = new Size(78, 23);
			label2.TabIndex = 12;
			label2.Text = "Tên Môn";
			// 
			// txtMaMon
			// 
			txtMaMon.Location = new Point(150, 50);
			txtMaMon.Name = "txtMaMon";
			txtMaMon.Size = new Size(223, 27);
			txtMaMon.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label1.Location = new Point(36, 51);
			label1.Name = "label1";
			label1.Size = new Size(76, 23);
			label1.TabIndex = 10;
			label1.Text = "Mã Môn";
			// 
			// btnsua
			// 
			btnsua.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnsua.ForeColor = Color.FromArgb(0, 0, 192);
			btnsua.Location = new Point(590, 37);
			btnsua.Name = "btnsua";
			btnsua.Size = new Size(100, 50);
			btnsua.TabIndex = 27;
			btnsua.Text = "🖊️Sửa";
			btnsua.UseVisualStyleBackColor = true;
			btnsua.Click += btnSua_Click;
			// 
			// btnlammoi
			// 
			btnlammoi.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btnlammoi.ForeColor = Color.FromArgb(255, 128, 0);
			btnlammoi.Location = new Point(696, 37);
			btnlammoi.Name = "btnlammoi";
			btnlammoi.Size = new Size(113, 50);
			btnlammoi.TabIndex = 29;
			btnlammoi.Text = "🔃Làm Mới";
			btnlammoi.UseVisualStyleBackColor = true;
			btnlammoi.Click += btnLamMoi_Click;
			// 
			// txttimkiem
			// 
			txttimkiem.Location = new Point(554, 163);
			txttimkiem.Name = "txttimkiem";
			txttimkiem.Size = new Size(112, 27);
			txttimkiem.TabIndex = 38;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			label8.Location = new Point(472, 167);
			label8.Name = "label8";
			label8.Size = new Size(76, 23);
			label8.TabIndex = 37;
			label8.Text = "Từ Khóa";
			// 
			// btntimkiem
			// 
			btntimkiem.Font = new Font("Arial", 10.2F, FontStyle.Bold);
			btntimkiem.ForeColor = Color.Fuchsia;
			btntimkiem.Location = new Point(672, 154);
			btntimkiem.Name = "btntimkiem";
			btntimkiem.Size = new Size(58, 45);
			btntimkiem.TabIndex = 36;
			btntimkiem.Text = "🔍";
			btntimkiem.UseVisualStyleBackColor = true;
			btntimkiem.Click += btnTimKiem_Click;
			// 
			// FormMon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(821, 473);
			Controls.Add(txttimkiem);
			Controls.Add(label8);
			Controls.Add(btntimkiem);
			Controls.Add(btnlammoi);
			Controls.Add(btnsua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(dgvMon);
			Controls.Add(txtSoTiet);
			Controls.Add(label3);
			Controls.Add(txtTenMon);
			Controls.Add(label2);
			Controls.Add(txtMaMon);
			Controls.Add(label1);
			Name = "FormMon";
			Text = "Môn";
			Load += FormMon_Load;
			((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnXoa;
		private Button btnThem;
		private DataGridView dgvMon;
		private TextBox txtSoTiet;
		private Label label3;
		private TextBox txtTenMon;
		private Label label2;
		private TextBox txtMaMon;
		private Label label1;
		private Button btnsua;
		private Button btnlammoi;
		private TextBox txttimkiem;
		private Label label8;
		private Button btntimkiem;
	}
}