namespace lab08_QLSinhVien
{
	partial class FormMain
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
			toolStrip1 = new ToolStrip();
			toolSinhVien = new ToolStripLabel();
			toolMon = new ToolStripLabel();
			toolKhoa = new ToolStripLabel();
			toolNhapDiem = new ToolStripLabel();
			toolXemDiem = new ToolStripLabel();
			toolStripLabel1 = new ToolStripLabel();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.AutoSize = false;
			toolStrip1.BackColor = SystemColors.HotTrack;
			toolStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolSinhVien, toolMon, toolKhoa, toolNhapDiem, toolXemDiem, toolStripLabel1 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(20, 10, 20, 10);
			toolStrip1.Size = new Size(1057, 71);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolSinhVien
			// 
			toolSinhVien.ForeColor = Color.White;
			toolSinhVien.Name = "toolSinhVien";
			toolSinhVien.Size = new Size(149, 48);
			toolSinhVien.Text = "\U0001f9d1‍🎓Sinh Viên";
			toolSinhVien.Click += toolSinhVien_Click;
			// 
			// toolMon
			// 
			toolMon.ForeColor = Color.White;
			toolMon.Name = "toolMon";
			toolMon.Padding = new Padding(20, 10, 20, 10);
			toolMon.Size = new Size(137, 48);
			toolMon.Text = "📓Môn";
			toolMon.Click += toolMon_Click;
			// 
			// toolKhoa
			// 
			toolKhoa.ForeColor = Color.White;
			toolKhoa.Name = "toolKhoa";
			toolKhoa.Padding = new Padding(20, 10, 20, 10);
			toolKhoa.Size = new Size(142, 48);
			toolKhoa.Text = "\U0001fac2Khoa";
			toolKhoa.Click += toolKhoa_Click;
			// 
			// toolNhapDiem
			// 
			toolNhapDiem.ForeColor = Color.White;
			toolNhapDiem.Name = "toolNhapDiem";
			toolNhapDiem.Padding = new Padding(20, 10, 20, 10);
			toolNhapDiem.Size = new Size(208, 48);
			toolNhapDiem.Text = "📝Nhập Điểm";
			toolNhapDiem.Click += toolNhapDiem_Click;
			// 
			// toolXemDiem
			// 
			toolXemDiem.ForeColor = Color.White;
			toolXemDiem.Name = "toolXemDiem";
			toolXemDiem.Padding = new Padding(20, 10, 20, 10);
			toolXemDiem.Size = new Size(198, 48);
			toolXemDiem.Text = "👀Xem Điểm";
			toolXemDiem.Click += toolXemDiem_Click;
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
			toolStripLabel1.ForeColor = Color.White;
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Padding = new Padding(20, 10, 20, 10);
			toolStripLabel1.Size = new Size(149, 48);
			toolStripLabel1.Text = "👋Thoát";
			toolStripLabel1.Click += toolThoat_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1057, 506);
			Controls.Add(toolStrip1);
			IsMdiContainer = true;
			Name = "FormMain";
			Text = "Quản Lý Sinh Viên";
			WindowState = FormWindowState.Maximized;
			Load += FormMain_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripLabel toolSinhVien;
		private ToolStripLabel toolMon;
		private ToolStripLabel toolKhoa;
		private ToolStripLabel toolNhapDiem;
		private ToolStripLabel toolXemDiem;
		private ToolStripLabel toolStripLabel1;
	}
}