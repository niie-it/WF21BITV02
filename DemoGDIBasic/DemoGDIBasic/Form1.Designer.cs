namespace DemoGDIBasic
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
			splitContainer1 = new SplitContainer();
			BtnVeChu = new Button();
			TxtNoiDung = new TextBox();
			TxtY = new TextBox();
			TxtX = new TextBox();
			label2 = new Label();
			label1 = new Label();
			BtnChonMau = new Button();
			PanelKhungVe = new Panel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(BtnVeChu);
			splitContainer1.Panel1.Controls.Add(TxtNoiDung);
			splitContainer1.Panel1.Controls.Add(TxtY);
			splitContainer1.Panel1.Controls.Add(TxtX);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(BtnChonMau);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.BackColor = Color.White;
			splitContainer1.Panel2.Controls.Add(PanelKhungVe);
			splitContainer1.Size = new Size(1010, 660);
			splitContainer1.SplitterDistance = 336;
			splitContainer1.TabIndex = 0;
			// 
			// BtnVeChu
			// 
			BtnVeChu.Location = new Point(64, 374);
			BtnVeChu.Name = "BtnVeChu";
			BtnVeChu.Size = new Size(188, 58);
			BtnVeChu.TabIndex = 5;
			BtnVeChu.Text = "Vẽ chữ";
			BtnVeChu.UseVisualStyleBackColor = true;
			BtnVeChu.Click += BtnVeChu_Click;
			// 
			// TxtNoiDung
			// 
			TxtNoiDung.Location = new Point(0, 298);
			TxtNoiDung.Name = "TxtNoiDung";
			TxtNoiDung.Size = new Size(333, 47);
			TxtNoiDung.TabIndex = 4;
			// 
			// TxtY
			// 
			TxtY.Location = new Point(68, 198);
			TxtY.Name = "TxtY";
			TxtY.Size = new Size(184, 47);
			TxtY.TabIndex = 3;
			// 
			// TxtX
			// 
			TxtX.Location = new Point(72, 129);
			TxtX.Name = "TxtX";
			TxtX.Size = new Size(184, 47);
			TxtX.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 198);
			label2.Name = "label2";
			label2.Size = new Size(35, 41);
			label2.TabIndex = 2;
			label2.Text = "Y";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 123);
			label1.Name = "label1";
			label1.Size = new Size(36, 41);
			label1.TabIndex = 1;
			label1.Text = "X";
			// 
			// BtnChonMau
			// 
			BtnChonMau.BackColor = Color.Black;
			BtnChonMau.Location = new Point(68, 29);
			BtnChonMau.Name = "BtnChonMau";
			BtnChonMau.Size = new Size(188, 58);
			BtnChonMau.TabIndex = 0;
			BtnChonMau.UseVisualStyleBackColor = false;
			BtnChonMau.Click += BtnChonMau_Click;
			// 
			// PanelKhungVe
			// 
			PanelKhungVe.Dock = DockStyle.Fill;
			PanelKhungVe.Location = new Point(0, 0);
			PanelKhungVe.Name = "PanelKhungVe";
			PanelKhungVe.Size = new Size(670, 660);
			PanelKhungVe.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1010, 660);
			Controls.Add(splitContainer1);
			Name = "Form1";
			Text = "Form1";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Button BtnChonMau;
		private Button BtnVeChu;
		private TextBox TxtNoiDung;
		private TextBox TxtY;
		private TextBox TxtX;
		private Label label2;
		private Label label1;
		private Panel PanelKhungVe;
	}
}
