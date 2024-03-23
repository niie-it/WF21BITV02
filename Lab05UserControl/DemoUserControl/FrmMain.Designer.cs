namespace DemoUserControl
{
	partial class FrmMain
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
			ucDongHo1 = new MyUserControl.UCDongHo();
			ucDongHo2 = new MyUserControl.UCDongHo();
			ucCountDown1 = new MyUserControl.UCCountDown();
			SuspendLayout();
			// 
			// ucDongHo1
			// 
			ucDongHo1.Location = new Point(1, -4);
			ucDongHo1.Name = "ucDongHo1";
			ucDongHo1.Size = new Size(651, 280);
			ucDongHo1.TabIndex = 0;
			// 
			// ucDongHo2
			// 
			ucDongHo2.Location = new Point(-8, 282);
			ucDongHo2.Name = "ucDongHo2";
			ucDongHo2.Size = new Size(649, 274);
			ucDongHo2.TabIndex = 1;
			// 
			// ucCountDown1
			// 
			ucCountDown1.Location = new Point(28, 578);
			ucCountDown1.Name = "ucCountDown1";
			ucCountDown1.Size = new Size(424, 357);
			ucCountDown1.TabIndex = 2;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(846, 947);
			Controls.Add(ucCountDown1);
			Controls.Add(ucDongHo2);
			Controls.Add(ucDongHo1);
			Name = "FrmMain";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private MyUserControl.UCDongHo ucDongHo1;
		private MyUserControl.UCDongHo ucDongHo2;
		private MyUserControl.UCCountDown ucCountDown1;
	}
}
