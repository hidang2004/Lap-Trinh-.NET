namespace lab04_Su_sung_cong_cu_Treeview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			toolStrip1 = new ToolStrip();
			tsbt1 = new ToolStripButton();
			tsbt2 = new ToolStripButton();
			treeView1 = new TreeView();
			imageIcons = new ImageList(components);
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbt1, tsbt2 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 27);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbt1
			// 
			tsbt1.Image = (Image)resources.GetObject("tsbt1.Image");
			tsbt1.ImageTransparentColor = Color.Magenta;
			tsbt1.Name = "tsbt1";
			tsbt1.Size = new Size(90, 24);
			tsbt1.Text = "Mở rộng";
			// 
			// tsbt2
			// 
			tsbt2.Image = (Image)resources.GetObject("tsbt2.Image");
			tsbt2.ImageTransparentColor = Color.Magenta;
			tsbt2.Name = "tsbt2";
			tsbt2.Size = new Size(87, 24);
			tsbt2.Text = "Thu gọn";
			// 
			// treeView1
			// 
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageIcons;
			treeView1.Location = new Point(9, 51);
			treeView1.Name = "treeView1";
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(260, 437);
			treeView1.TabIndex = 1;
			// 
			// imageIcons
			// 
			imageIcons.ColorDepth = ColorDepth.Depth32Bit;
			imageIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageIcons.ImageStream");
			imageIcons.TransparentColor = Color.Transparent;
			imageIcons.Images.SetKeyName(0, "red-folder-icon.png");
			imageIcons.Images.SetKeyName(1, "Button-Add-icon.png");
			imageIcons.Images.SetKeyName(2, "Alarm-Minus-icon.png");
			imageIcons.Images.SetKeyName(3, "Button-Download-icon.png");
			imageIcons.Images.SetKeyName(4, "Button-Upload-icon.png");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 500);
			Controls.Add(treeView1);
			Controls.Add(toolStrip1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton tsbt1;
		private ToolStripButton tsbt2;
		private TreeView treeView1;
		private ImageList imageIcons;
	}
}
