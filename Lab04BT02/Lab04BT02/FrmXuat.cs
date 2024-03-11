using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT02
{
	public partial class FrmXuat : Form
	{
		const int D = 10;
		const int W = 60;
		const int H = 60;

		public FrmXuat(int soDong = 1, int soCot = 1)
		{
			InitializeComponent();

			Button btn;
			for (int i = 0; i < soDong; i++)
			{
				for (int j = 0; j < soCot; j++)
				{
					btn = new Button();
					btn.Left = D + (W + D) * j;
					btn.Top = D + (H + D) * i;
					btn.Width = W;
					btn.Height = H;
					btn.Text = $"{i},{j}";
					btn.Click += XuLyClickButton;
					this.Controls.Add(btn);
				}
			}
		}

		private void XuLyClickButton(object sender, EventArgs e)
		{
			MessageBox.Show((sender as Button).Text);
		}

		private void FrmXuat_Load(object sender, EventArgs e)
		{

		}
	}
}
