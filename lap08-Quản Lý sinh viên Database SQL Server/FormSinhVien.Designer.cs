namespace lap08_Quản_Lý_sinh_viên_Database_SQL_Server
{
	partial class FormSinhVien
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
			dgvSinhVien = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
			SuspendLayout();
			// 
			// dgvSinhVien
			// 
			dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSinhVien.Location = new Point(2, 109);
			dgvSinhVien.Name = "dgvSinhVien";
			dgvSinhVien.RowHeadersWidth = 51;
			dgvSinhVien.Size = new Size(797, 231);
			dgvSinhVien.TabIndex = 0;
			dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
			// 
			// FormSinhVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgvSinhVien);
			Name = "FormSinhVien";
			Text = "FormSinhVien";
			Load += FormSinhVien_Load;
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvSinhVien;
	}
}