using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUserControl
{
	public partial class UCCountDown : UserControl
	{
		public UCCountDown()
		{
			InitializeComponent();
		}

		TimeSpan coundDownTime = TimeSpan.Zero;
		private void BtnRun_Click(object sender, EventArgs e)
		{
			if (!timer1.Enabled)
			{
				var arr = MtbDongHo.Text.Split(':');
				timer1.Enabled = true;
				coundDownTime = new TimeSpan(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
			}
			else
			{
				timer1.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			coundDownTime = coundDownTime.Subtract(new TimeSpan(0, 0, 1));//Trừ 1 giây
			TxtDongHo.Text = coundDownTime.ToString();
			if (coundDownTime.Seconds == 0)
			{
				timer1.Enabled = false;
			}
		}
	}
}
