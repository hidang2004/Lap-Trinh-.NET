namespace lap08_Quản_Lý_sinh_viên_Database_SQL_Server
{
	partial class FormMonHoc
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
			dgvMonHoc = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
			SuspendLayout();
			// 
			// dgvMonHoc
			// 
			dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMonHoc.Location = new Point(1, 109);
			dgvMonHoc.Name = "dgvMonHoc";
			dgvMonHoc.RowHeadersWidth = 51;
			dgvMonHoc.Size = new Size(797, 210);
			dgvMonHoc.TabIndex = 0;
			dgvMonHoc.CellContentClick += dgvMonHoc_CellContentClick;
			// 
			// FormMonHoc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgvMonHoc);
			Name = "FormMonHoc";
			Text = "FormMonHoc";
			Load += FormMonHoc_Load;
			((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvMonHoc;
	}
}