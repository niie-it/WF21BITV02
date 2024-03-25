namespace DemoGDIBasic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Color MauDangChon = Color.Black;
		private void BtnChonMau_Click(object sender, EventArgs e)
		{
			var cd = new ColorDialog();
			cd.FullOpen = true;
			if (cd.ShowDialog() == DialogResult.OK)
			{
				BtnChonMau.BackColor = cd.Color;
				MauDangChon = cd.Color;
			}
		}

		private void BtnVeChu_Click(object sender, EventArgs e)
		{
			int X = int.Parse(TxtX.Text);
			int Y = int.Parse(TxtY.Text);

			//vẽ lên Panel
			var g = PanelKhungVe.CreateGraphics();
			g.DrawString(
				TxtNoiDung.Text,
				new Font("Arial", 20, FontStyle.Bold),
				new SolidBrush(MauDangChon),
				X, Y);
		}
	}
}
