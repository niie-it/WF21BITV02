namespace Lab04BT02
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtSoDong = new System.Windows.Forms.TextBox();
			this.TxtSoCot = new System.Windows.Forms.TextBox();
			this.BtnKhoiTao = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số dòng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số cột";
			// 
			// TxtSoDong
			// 
			this.TxtSoDong.Location = new System.Drawing.Point(199, 37);
			this.TxtSoDong.Name = "TxtSoDong";
			this.TxtSoDong.Size = new System.Drawing.Size(100, 38);
			this.TxtSoDong.TabIndex = 2;
			// 
			// TxtSoCot
			// 
			this.TxtSoCot.Location = new System.Drawing.Point(199, 108);
			this.TxtSoCot.Name = "TxtSoCot";
			this.TxtSoCot.Size = new System.Drawing.Size(100, 38);
			this.TxtSoCot.TabIndex = 3;
			// 
			// BtnKhoiTao
			// 
			this.BtnKhoiTao.Location = new System.Drawing.Point(342, 37);
			this.BtnKhoiTao.Name = "BtnKhoiTao";
			this.BtnKhoiTao.Size = new System.Drawing.Size(158, 109);
			this.BtnKhoiTao.TabIndex = 4;
			this.BtnKhoiTao.Text = "Khởi tạo";
			this.BtnKhoiTao.UseVisualStyleBackColor = true;
			this.BtnKhoiTao.Click += new System.EventHandler(this.BtnKhoiTao_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 185);
			this.Controls.Add(this.BtnKhoiTao);
			this.Controls.Add(this.TxtSoCot);
			this.Controls.Add(this.TxtSoDong);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSoDong;
		private System.Windows.Forms.TextBox TxtSoCot;
		private System.Windows.Forms.Button BtnKhoiTao;
	}
}

