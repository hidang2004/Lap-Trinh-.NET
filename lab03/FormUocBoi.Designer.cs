namespace lab03
{
	partial class FormUocBoi
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
			groupBox1 = new GroupBox();
			textBoxB = new TextBox();
			textBoxA = new TextBox();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			radioButton_BoiSoChungNhoNhat = new RadioButton();
			radioButton_UocSoChungLonNhat = new RadioButton();
			groupBox3 = new GroupBox();
			buttonThoat = new Button();
			buttonBoQua = new Button();
			buttonTim = new Button();
			textBoxKetQua = new TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.FromArgb(128, 255, 128);
			groupBox1.Controls.Add(textBoxB);
			groupBox1.Controls.Add(textBoxA);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(32, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(588, 155);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nhập";
			// 
			// textBoxB
			// 
			textBoxB.BackColor = Color.FromArgb(255, 255, 192);
			textBoxB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxB.Location = new Point(56, 101);
			textBoxB.Name = "textBoxB";
			textBoxB.Size = new Size(498, 34);
			textBoxB.TabIndex = 3;
			// 
			// textBoxA
			// 
			textBoxA.BackColor = Color.FromArgb(255, 255, 192);
			textBoxA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxA.Location = new Point(56, 49);
			textBoxA.Name = "textBoxA";
			textBoxA.Size = new Size(498, 34);
			textBoxA.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(7, 107);
			label2.Name = "label2";
			label2.Size = new Size(29, 25);
			label2.TabIndex = 1;
			label2.Text = "B:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(6, 55);
			label1.Name = "label1";
			label1.Size = new Size(30, 25);
			label1.TabIndex = 0;
			label1.Text = "A:";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.FromArgb(128, 255, 255);
			groupBox2.Controls.Add(radioButton_BoiSoChungNhoNhat);
			groupBox2.Controls.Add(radioButton_UocSoChungLonNhat);
			groupBox2.Location = new Point(675, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(221, 155);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chọn Tìm";
			// 
			// radioButton_BoiSoChungNhoNhat
			// 
			radioButton_BoiSoChungNhoNhat.AutoSize = true;
			radioButton_BoiSoChungNhoNhat.Location = new Point(5, 92);
			radioButton_BoiSoChungNhoNhat.Name = "radioButton_BoiSoChungNhoNhat";
			radioButton_BoiSoChungNhoNhat.Size = new Size(187, 24);
			radioButton_BoiSoChungNhoNhat.TabIndex = 1;
			radioButton_BoiSoChungNhoNhat.TabStop = true;
			radioButton_BoiSoChungNhoNhat.Text = "Bội Số Chung Nhỏ Nhất";
			radioButton_BoiSoChungNhoNhat.UseVisualStyleBackColor = true;
			// 
			// radioButton_UocSoChungLonNhat
			// 
			radioButton_UocSoChungLonNhat.AutoSize = true;
			radioButton_UocSoChungLonNhat.Location = new Point(5, 39);
			radioButton_UocSoChungLonNhat.Name = "radioButton_UocSoChungLonNhat";
			radioButton_UocSoChungLonNhat.Size = new Size(188, 24);
			radioButton_UocSoChungLonNhat.TabIndex = 0;
			radioButton_UocSoChungLonNhat.TabStop = true;
			radioButton_UocSoChungLonNhat.Text = "Ước Số Chung Lớn Nhất";
			radioButton_UocSoChungLonNhat.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.FromArgb(128, 128, 255);
			groupBox3.Controls.Add(buttonThoat);
			groupBox3.Controls.Add(buttonBoQua);
			groupBox3.Controls.Add(buttonTim);
			groupBox3.Controls.Add(textBoxKetQua);
			groupBox3.Location = new Point(33, 206);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(863, 232);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Kết Quả";
			// 
			// buttonThoat
			// 
			buttonThoat.BackColor = Color.FromArgb(255, 128, 0);
			buttonThoat.Location = new Point(641, 127);
			buttonThoat.Name = "buttonThoat";
			buttonThoat.Size = new Size(194, 63);
			buttonThoat.TabIndex = 3;
			buttonThoat.Text = "Thoát";
			buttonThoat.UseVisualStyleBackColor = false;
			buttonThoat.Click += buttonThoat_Click;
			// 
			// buttonBoQua
			// 
			buttonBoQua.BackColor = Color.FromArgb(255, 128, 0);
			buttonBoQua.Location = new Point(336, 127);
			buttonBoQua.Name = "buttonBoQua";
			buttonBoQua.Size = new Size(195, 63);
			buttonBoQua.TabIndex = 2;
			buttonBoQua.Text = "Bỏ Qua";
			buttonBoQua.UseVisualStyleBackColor = false;
			buttonBoQua.Click += buttonBoQua_Click;
			// 
			// buttonTim
			// 
			buttonTim.BackColor = Color.FromArgb(255, 128, 0);
			buttonTim.Location = new Point(32, 127);
			buttonTim.Name = "buttonTim";
			buttonTim.Size = new Size(191, 63);
			buttonTim.TabIndex = 1;
			buttonTim.Text = "Tìm";
			buttonTim.UseVisualStyleBackColor = false;
			buttonTim.Click += buttonTim_Click;
			// 
			// textBoxKetQua
			// 
			textBoxKetQua.BackColor = Color.FromArgb(255, 255, 192);
			textBoxKetQua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxKetQua.Location = new Point(55, 36);
			textBoxKetQua.Name = "textBoxKetQua";
			textBoxKetQua.Size = new Size(747, 43);
			textBoxKetQua.TabIndex = 0;
			// 
			// FormUocBoi
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			ClientSize = new Size(932, 450);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FormUocBoi";
			Text = "FormUocBoi";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox textBoxB;
		private TextBox textBoxA;
		private Label label2;
		private Label label1;
		private GroupBox groupBox2;
		private RadioButton radioButton_BoiSoChungNhoNhat;
		private RadioButton radioButton_UocSoChungLonNhat;
		private GroupBox groupBox3;
		private Button buttonThoat;
		private Button buttonBoQua;
		private Button buttonTim;
		private TextBox textBoxKetQua;
	}
}