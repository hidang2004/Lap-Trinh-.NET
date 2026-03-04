namespace lab05__Su_Dung_List_Box___Quan_ly_tinh_tien_phong_kham_rang
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
			groupBox1 = new GroupBox();
			btnAddFile = new Button();
			txtTotal = new TextBox();
			label7 = new Label();
			numericUpDownFilling = new NumericUpDown();
			btnExit = new Button();
			btnCalc = new Button();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			chkXRay = new CheckBox();
			chkWhitening = new CheckBox();
			chkClean = new CheckBox();
			txtFullName = new TextBox();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnDelete = new Button();
			btnLoadFile = new Button();
			btnSaveToFile = new Button();
			listBoxCustomer = new ListBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownFilling).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.FromArgb(255, 192, 192);
			groupBox1.Controls.Add(btnAddFile);
			groupBox1.Controls.Add(txtTotal);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(numericUpDownFilling);
			groupBox1.Controls.Add(btnExit);
			groupBox1.Controls.Add(btnCalc);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(chkXRay);
			groupBox1.Controls.Add(chkWhitening);
			groupBox1.Controls.Add(chkClean);
			groupBox1.Controls.Add(txtFullName);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 11);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(408, 570);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản Lý Thanh Toán";
			// 
			// btnAddFile
			// 
			btnAddFile.BackColor = Color.FromArgb(255, 192, 128);
			btnAddFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnAddFile.Location = new Point(214, 356);
			btnAddFile.Name = "btnAddFile";
			btnAddFile.Size = new Size(157, 75);
			btnAddFile.TabIndex = 16;
			btnAddFile.Text = "Thêm Vào Danh Sách";
			btnAddFile.UseVisualStyleBackColor = false;
			btnAddFile.Click += btnAddFile_Click;
			// 
			// txtTotal
			// 
			txtTotal.BackColor = SystemColors.Info;
			txtTotal.Location = new Point(116, 279);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(239, 27);
			txtTotal.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(13, 282);
			label7.Name = "label7";
			label7.Size = new Size(79, 20);
			label7.TabIndex = 14;
			label7.Text = "Tổng Tiền";
			// 
			// numericUpDownFilling
			// 
			numericUpDownFilling.BackColor = SystemColors.Info;
			numericUpDownFilling.Location = new Point(116, 217);
			numericUpDownFilling.Name = "numericUpDownFilling";
			numericUpDownFilling.Size = new Size(173, 27);
			numericUpDownFilling.TabIndex = 13;
			numericUpDownFilling.TextAlign = HorizontalAlignment.Center;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.FromArgb(255, 192, 128);
			btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnExit.Location = new Point(45, 472);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(310, 53);
			btnExit.TabIndex = 12;
			btnExit.Text = "Thoát";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			// 
			// btnCalc
			// 
			btnCalc.BackColor = Color.FromArgb(255, 192, 128);
			btnCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCalc.Location = new Point(26, 356);
			btnCalc.Name = "btnCalc";
			btnCalc.Size = new Size(156, 75);
			btnCalc.TabIndex = 11;
			btnCalc.Text = "Tính Tổng Tiền";
			btnCalc.UseVisualStyleBackColor = false;
			btnCalc.Click += btnCalc_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(295, 219);
			label6.Name = "label6";
			label6.Size = new Size(111, 20);
			label6.TabIndex = 10;
			label6.Text = "100.000.000 đ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label5.Location = new Point(295, 163);
			label5.Name = "label5";
			label5.Size = new Size(102, 20);
			label5.TabIndex = 9;
			label5.Text = "10.000.000 đ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(303, 136);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 8;
			label4.Text = "1.000.000 đ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(314, 109);
			label3.Name = "label3";
			label3.Size = new Size(80, 20);
			label3.TabIndex = 7;
			label3.Text = "100.000 đ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(6, 219);
			label2.Name = "label2";
			label2.Size = new Size(85, 20);
			label2.TabIndex = 5;
			label2.Text = "Trám Răng";
			// 
			// chkXRay
			// 
			chkXRay.AutoSize = true;
			chkXRay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			chkXRay.Location = new Point(4, 163);
			chkXRay.Name = "chkXRay";
			chkXRay.Size = new Size(144, 24);
			chkXRay.TabIndex = 4;
			chkXRay.Text = "Chụp Hình Răng";
			chkXRay.UseVisualStyleBackColor = true;
			// 
			// chkWhitening
			// 
			chkWhitening.AutoSize = true;
			chkWhitening.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			chkWhitening.Location = new Point(4, 136);
			chkWhitening.Name = "chkWhitening";
			chkWhitening.Size = new Size(140, 24);
			chkWhitening.TabIndex = 3;
			chkWhitening.Text = "Tẩy Trắng Răng";
			chkWhitening.UseVisualStyleBackColor = true;
			// 
			// chkClean
			// 
			chkClean.AutoSize = true;
			chkClean.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			chkClean.Location = new Point(4, 109);
			chkClean.Name = "chkClean";
			chkClean.Size = new Size(83, 24);
			chkClean.TabIndex = 2;
			chkClean.Text = "Cạo Vôi";
			chkClean.UseVisualStyleBackColor = true;
			// 
			// txtFullName
			// 
			txtFullName.BackColor = SystemColors.Info;
			txtFullName.Location = new Point(140, 40);
			txtFullName.Name = "txtFullName";
			txtFullName.Size = new Size(247, 27);
			txtFullName.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(6, 43);
			label1.Name = "label1";
			label1.Size = new Size(122, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên Khách Hàng";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.FromArgb(255, 192, 192);
			groupBox2.Controls.Add(btnDelete);
			groupBox2.Controls.Add(btnLoadFile);
			groupBox2.Controls.Add(btnSaveToFile);
			groupBox2.Controls.Add(listBoxCustomer);
			groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.Location = new Point(474, 11);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(383, 570);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh Sách";
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(255, 192, 128);
			btnDelete.Location = new Point(132, 466);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(139, 59);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Xóa Khách Hàng";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnLoadFile
			// 
			btnLoadFile.BackColor = Color.FromArgb(255, 192, 128);
			btnLoadFile.Location = new Point(220, 402);
			btnLoadFile.Name = "btnLoadFile";
			btnLoadFile.Size = new Size(151, 58);
			btnLoadFile.TabIndex = 2;
			btnLoadFile.Text = "Tải File";
			btnLoadFile.UseVisualStyleBackColor = false;
			btnLoadFile.Click += btnLoadFile_Click;
			// 
			// btnSaveToFile
			// 
			btnSaveToFile.BackColor = Color.FromArgb(255, 192, 128);
			btnSaveToFile.Location = new Point(20, 402);
			btnSaveToFile.Name = "btnSaveToFile";
			btnSaveToFile.Size = new Size(152, 58);
			btnSaveToFile.TabIndex = 1;
			btnSaveToFile.Text = "Lưu File";
			btnSaveToFile.UseVisualStyleBackColor = false;
			btnSaveToFile.Click += btnSaveToFile_Click;
			// 
			// listBoxCustomer
			// 
			listBoxCustomer.BackColor = Color.Gainsboro;
			listBoxCustomer.FormattingEnabled = true;
			listBoxCustomer.Location = new Point(20, 54);
			listBoxCustomer.Name = "listBoxCustomer";
			listBoxCustomer.Size = new Size(351, 284);
			listBoxCustomer.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.RosyBrown;
			ClientSize = new Size(869, 602);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownFilling).EndInit();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox txtFullName;
		private Label label1;
		private GroupBox groupBox2;
		private Label label2;
		private CheckBox chkXRay;
		private CheckBox chkWhitening;
		private CheckBox chkClean;
		private NumericUpDown numericUpDownFilling;
		private Button btnExit;
		private Button btnCalc;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private ListBox listBoxCustomer;
		private Button btnAddFile;
		private TextBox txtTotal;
		private Label label7;
		private Button btnLoadFile;
		private Button btnSaveToFile;
		private Button btnDelete;
	}
}
