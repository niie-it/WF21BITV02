namespace DemoMDI
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		string lastLoginForm = "";
		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new FrmLogin();
			if (string.IsNullOrEmpty(lastLoginForm))
			{
				lastLoginForm = "Login 1";
			}
			else
			{
				lastLoginForm = "Login " + (Convert.ToInt32(lastLoginForm.Split(' ')[1]) + 1);
			}
			form.Text = lastLoginForm;
			form.MdiParent = this;
			form.Show();
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new FrmSetting();
			form.MdiParent = this;
			form.Show();
		}

		private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}
	}
}
