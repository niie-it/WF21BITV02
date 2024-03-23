namespace MyUserControl
{
	partial class UCCountDown
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			TxtDongHo = new TextBox();
			BtnRun = new Button();
			MtbDongHo = new MaskedTextBox();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// TxtDongHo
			// 
			TxtDongHo.Font = new Font("Tahoma", 17F);
			TxtDongHo.Location = new Point(42, 20);
			TxtDongHo.Name = "TxtDongHo";
			TxtDongHo.Size = new Size(342, 76);
			TxtDongHo.TabIndex = 0;
			TxtDongHo.TextAlign = HorizontalAlignment.Center;
			// 
			// BtnRun
			// 
			BtnRun.Location = new Point(107, 124);
			BtnRun.Name = "BtnRun";
			BtnRun.Size = new Size(188, 58);
			BtnRun.TabIndex = 1;
			BtnRun.Text = "RUN";
			BtnRun.UseVisualStyleBackColor = true;
			BtnRun.Click += BtnRun_Click;
			// 
			// MtbDongHo
			// 
			MtbDongHo.Font = new Font("Tahoma", 17F);
			MtbDongHo.Location = new Point(42, 221);
			MtbDongHo.Mask = "00:00:00";
			MtbDongHo.Name = "MtbDongHo";
			MtbDongHo.Size = new Size(313, 76);
			MtbDongHo.TabIndex = 2;
			MtbDongHo.TextAlign = HorizontalAlignment.Center;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// UCCountDown
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(MtbDongHo);
			Controls.Add(BtnRun);
			Controls.Add(TxtDongHo);
			Name = "UCCountDown";
			Size = new Size(463, 327);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtDongHo;
		private Button BtnRun;
		private MaskedTextBox MtbDongHo;
		private System.Windows.Forms.Timer timer1;
	}
}
