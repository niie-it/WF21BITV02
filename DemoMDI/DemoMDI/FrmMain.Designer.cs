namespace DemoMDI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			menuStrip1 = new MenuStrip();
			systemToolStripMenuItem = new ToolStripMenuItem();
			loginToolStripMenuItem = new ToolStripMenuItem();
			settingToolStripMenuItem = new ToolStripMenuItem();
			windowsToolStripMenuItem = new ToolStripMenuItem();
			cascadeToolStripMenuItem = new ToolStripMenuItem();
			tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
			tileVerticalToolStripMenuItem = new ToolStripMenuItem();
			arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			toolStripButton3 = new ToolStripButton();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(40, 40);
			menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, windowsToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1270, 52);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// systemToolStripMenuItem
			// 
			systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, settingToolStripMenuItem });
			systemToolStripMenuItem.Name = "systemToolStripMenuItem";
			systemToolStripMenuItem.Size = new Size(137, 48);
			systemToolStripMenuItem.Text = "System";
			// 
			// loginToolStripMenuItem
			// 
			loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			loginToolStripMenuItem.Size = new Size(278, 54);
			loginToolStripMenuItem.Text = "Login";
			loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
			// 
			// settingToolStripMenuItem
			// 
			settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			settingToolStripMenuItem.Size = new Size(278, 54);
			settingToolStripMenuItem.Text = "Setting";
			settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
			// 
			// windowsToolStripMenuItem
			// 
			windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem, arrangeIconsToolStripMenuItem });
			windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			windowsToolStripMenuItem.Size = new Size(165, 48);
			windowsToolStripMenuItem.Text = "Windows";
			// 
			// cascadeToolStripMenuItem
			// 
			cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			cascadeToolStripMenuItem.Size = new Size(448, 54);
			cascadeToolStripMenuItem.Text = "Cascade";
			cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
			// 
			// tileHorizontalToolStripMenuItem
			// 
			tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
			tileHorizontalToolStripMenuItem.Size = new Size(448, 54);
			tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
			tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
			// 
			// tileVerticalToolStripMenuItem
			// 
			tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			tileVerticalToolStripMenuItem.Size = new Size(448, 54);
			tileVerticalToolStripMenuItem.Text = "Tile Vertical";
			tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
			// 
			// arrangeIconsToolStripMenuItem
			// 
			arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
			arrangeIconsToolStripMenuItem.Size = new Size(448, 54);
			arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
			arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(40, 40);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 941);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1270, 54);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(297, 41);
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(80, 80);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
			toolStrip1.Location = new Point(0, 52);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1270, 91);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(84, 84);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(84, 84);
			toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(84, 84);
			toolStripButton3.Text = "toolStripButton3";
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1270, 995);
			Controls.Add(toolStrip1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "FrmMain";
			Text = "MAIN FORM";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem systemToolStripMenuItem;
		private ToolStripMenuItem loginToolStripMenuItem;
		private ToolStripMenuItem settingToolStripMenuItem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		private ToolStripButton toolStripButton3;
		private ToolStripMenuItem windowsToolStripMenuItem;
		private ToolStripMenuItem cascadeToolStripMenuItem;
		private ToolStripMenuItem tileHorizontalToolStripMenuItem;
		private ToolStripMenuItem tileVerticalToolStripMenuItem;
		private ToolStripMenuItem arrangeIconsToolStripMenuItem;
	}
}
