namespace lab03
{
	partial class FormSecurityPanel
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
			textSecuritycode = new TextBox();
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btn4 = new Button();
			btn5 = new Button();
			btn6 = new Button();
			btn7 = new Button();
			btn8 = new Button();
			btn9 = new Button();
			btnC = new Button();
			btnEnter = new Button();
			btn0 = new Button();
			AccessLog = new ListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 38);
			label1.Name = "label1";
			label1.Size = new Size(102, 20);
			label1.TabIndex = 0;
			label1.Text = "Security code";
			// 
			// textSecuritycode
			// 
			textSecuritycode.Location = new Point(172, 35);
			textSecuritycode.Name = "textSecuritycode";
			textSecuritycode.PasswordChar = '*';
			textSecuritycode.ReadOnly = true;
			textSecuritycode.Size = new Size(361, 27);
			textSecuritycode.TabIndex = 1;
			// 
			// btn1
			// 
			btn1.Location = new Point(39, 108);
			btn1.Name = "btn1";
			btn1.Size = new Size(83, 60);
			btn1.TabIndex = 2;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += btnNumber_Click;
			// 
			// btn2
			// 
			btn2.Location = new Point(193, 108);
			btn2.Name = "btn2";
			btn2.Size = new Size(78, 60);
			btn2.TabIndex = 3;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += btnNumber_Click;
			// 
			// btn3
			// 
			btn3.Location = new Point(339, 108);
			btn3.Name = "btn3";
			btn3.Size = new Size(77, 60);
			btn3.TabIndex = 4;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += btnNumber_Click;
			// 
			// btn4
			// 
			btn4.Location = new Point(39, 185);
			btn4.Name = "btn4";
			btn4.Size = new Size(83, 59);
			btn4.TabIndex = 5;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += btnNumber_Click;
			// 
			// btn5
			// 
			btn5.Location = new Point(193, 185);
			btn5.Name = "btn5";
			btn5.Size = new Size(78, 59);
			btn5.TabIndex = 6;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += btnNumber_Click;
			// 
			// btn6
			// 
			btn6.Location = new Point(339, 185);
			btn6.Name = "btn6";
			btn6.Size = new Size(77, 59);
			btn6.TabIndex = 7;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += btnNumber_Click;
			// 
			// btn7
			// 
			btn7.Location = new Point(39, 267);
			btn7.Name = "btn7";
			btn7.Size = new Size(83, 56);
			btn7.TabIndex = 8;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += btnNumber_Click;
			// 
			// btn8
			// 
			btn8.Location = new Point(193, 267);
			btn8.Name = "btn8";
			btn8.Size = new Size(78, 56);
			btn8.TabIndex = 9;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += btnNumber_Click;
			// 
			// btn9
			// 
			btn9.Location = new Point(339, 267);
			btn9.Name = "btn9";
			btn9.Size = new Size(77, 56);
			btn9.TabIndex = 10;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += btnNumber_Click;
			// 
			// btnC
			// 
			btnC.Location = new Point(485, 108);
			btnC.Name = "btnC";
			btnC.Size = new Size(75, 60);
			btnC.TabIndex = 11;
			btnC.Text = "C";
			btnC.UseVisualStyleBackColor = true;
			btnC.Click += btnC_Click;
			// 
			// btnEnter
			// 
			btnEnter.Location = new Point(485, 185);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(75, 59);
			btnEnter.TabIndex = 12;
			btnEnter.Text = "#";
			btnEnter.UseVisualStyleBackColor = true;
			btnEnter.Click += btnEnter_Click;
			// 
			// btn0
			// 
			btn0.Location = new Point(485, 267);
			btn0.Name = "btn0";
			btn0.Size = new Size(75, 56);
			btn0.TabIndex = 13;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += btnNumber_Click;
			// 
			// AccessLog
			// 
			AccessLog.FormattingEnabled = true;
			AccessLog.Location = new Point(39, 353);
			AccessLog.Name = "AccessLog";
			AccessLog.Size = new Size(521, 164);
			AccessLog.TabIndex = 14;
			// 
			// FormSecurityPanel
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(600, 549);
			Controls.Add(AccessLog);
			Controls.Add(btn0);
			Controls.Add(btnEnter);
			Controls.Add(btnC);
			Controls.Add(btn9);
			Controls.Add(btn8);
			Controls.Add(btn7);
			Controls.Add(btn6);
			Controls.Add(btn5);
			Controls.Add(btn4);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Controls.Add(textSecuritycode);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			KeyPreview = true;
			Name = "FormSecurityPanel";
			Text = "FormSecurityPanel";
			KeyDown += FormSecurityPanel_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textSecuritycode;
		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Button btn4;
		private Button btn5;
		private Button btn6;
		private Button btn7;
		private Button btn8;
		private Button btn9;
		private Button btnC;
		private Button btnEnter;
		private Button btn0;
		private ListBox AccessLog;
	}
}