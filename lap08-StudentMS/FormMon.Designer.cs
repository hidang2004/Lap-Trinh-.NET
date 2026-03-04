namespace lap08_StudentMS
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
			label1 = new Label();
			txtMaMonHoc = new TextBox();
			txtTenMonHoc = new TextBox();
			label2 = new Label();
			txtSoTiet = new TextBox();
			label3 = new Label();
			dataGridViewMonHoc = new DataGridView();
			btnThem = new Button();
			btnLuu = new Button();
			btnXoa = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(92, 28);
			label1.Name = "label1";
			label1.Size = new Size(58, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã MH";
			// 
			// txtMaMonHoc
			// 
			txtMaMonHoc.Location = new Point(218, 28);
			txtMaMonHoc.Name = "txtMaMonHoc";
			txtMaMonHoc.Size = new Size(125, 27);
			txtMaMonHoc.TabIndex = 1;
			// 
			// txtTenMonHoc
			// 
			txtTenMonHoc.Location = new Point(218, 80);
			txtTenMonHoc.Name = "txtTenMonHoc";
			txtTenMonHoc.Size = new Size(125, 27);
			txtTenMonHoc.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(90, 80);
			label2.Name = "label2";
			label2.Size = new Size(60, 20);
			label2.TabIndex = 2;
			label2.Text = "Tên MH";
			// 
			// txtSoTiet
			// 
			txtSoTiet.Location = new Point(218, 139);
			txtSoTiet.Name = "txtSoTiet";
			txtSoTiet.Size = new Size(125, 27);
			txtSoTiet.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(92, 142);
			label3.Name = "label3";
			label3.Size = new Size(52, 20);
			label3.TabIndex = 4;
			label3.Text = "Số tiết";
			// 
			// dataGridViewMonHoc
			// 
			dataGridViewMonHoc.AllowUserToAddRows = false;
			dataGridViewMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewMonHoc.Location = new Point(3, 218);
			dataGridViewMonHoc.MultiSelect = false;
			dataGridViewMonHoc.Name = "dataGridViewMonHoc";
			dataGridViewMonHoc.RowHeadersVisible = false;
			dataGridViewMonHoc.RowHeadersWidth = 51;
			dataGridViewMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewMonHoc.Size = new Size(797, 231);
			dataGridViewMonHoc.TabIndex = 6;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(446, 27);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 50);
			btnThem.TabIndex = 7;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(660, 28);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 49);
			btnLuu.TabIndex = 8;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(557, 111);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 51);
			btnXoa.TabIndex = 9;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// FormMon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnXoa);
			Controls.Add(btnLuu);
			Controls.Add(btnThem);
			Controls.Add(dataGridViewMonHoc);
			Controls.Add(txtSoTiet);
			Controls.Add(label3);
			Controls.Add(txtTenMonHoc);
			Controls.Add(label2);
			Controls.Add(txtMaMonHoc);
			Controls.Add(label1);
			Name = "FormMon";
			Text = "FormMonHoc";
			Load += FormMonHoc_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtMaMonHoc;
		private TextBox txtTenMonHoc;
		private Label label2;
		private TextBox txtSoTiet;
		private Label label3;
		private DataGridView dataGridViewMonHoc;
		private Button btnThem;
		private Button btnLuu;
		private Button btnXoa;
	}
}