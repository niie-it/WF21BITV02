namespace FirstWinForms
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
			label1 = new Label();
			TxtHoTen = new TextBox();
			BtnChao = new Button();
			LblChao = new Label();
			BtnNhapLai = new Button();
			BtnThoat = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(50, 57);
			label1.Name = "label1";
			label1.Size = new Size(108, 41);
			label1.TabIndex = 0;
			label1.Text = "Họ tên";
			// 
			// TxtHoTen
			// 
			TxtHoTen.Location = new Point(237, 53);
			TxtHoTen.Name = "TxtHoTen";
			TxtHoTen.Size = new Size(600, 47);
			TxtHoTen.TabIndex = 1;
			// 
			// BtnChao
			// 
			BtnChao.Location = new Point(237, 131);
			BtnChao.Name = "BtnChao";
			BtnChao.Size = new Size(188, 58);
			BtnChao.TabIndex = 2;
			BtnChao.Text = "Chào";
			BtnChao.UseVisualStyleBackColor = true;
			BtnChao.Click += BtnChao_Click;
			// 
			// LblChao
			// 
			LblChao.AutoSize = true;
			LblChao.Location = new Point(55, 236);
			LblChao.Name = "LblChao";
			LblChao.Size = new Size(97, 41);
			LblChao.TabIndex = 3;
			LblChao.Text = "label2";
			// 
			// BtnNhapLai
			// 
			BtnNhapLai.Location = new Point(445, 131);
			BtnNhapLai.Name = "BtnNhapLai";
			BtnNhapLai.Size = new Size(188, 58);
			BtnNhapLai.TabIndex = 4;
			BtnNhapLai.Text = "Nhập lại";
			BtnNhapLai.UseVisualStyleBackColor = true;
			BtnNhapLai.Click += BtnNhapLai_Click;
			// 
			// BtnThoat
			// 
			BtnThoat.Location = new Point(649, 131);
			BtnThoat.Name = "BtnThoat";
			BtnThoat.Size = new Size(188, 58);
			BtnThoat.TabIndex = 5;
			BtnThoat.Text = "Thoát";
			BtnThoat.UseVisualStyleBackColor = true;
			BtnThoat.Click += BtnThoat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(846, 330);
			Controls.Add(BtnThoat);
			Controls.Add(BtnNhapLai);
			Controls.Add(LblChao);
			Controls.Add(BtnChao);
			Controls.Add(TxtHoTen);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Say Hello";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TxtHoTen;
		private Button BtnChao;
		private Label LblChao;
		private Button BtnNhapLai;
		private Button BtnThoat;
	}
}
