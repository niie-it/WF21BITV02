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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnKhoiTao_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TxtSoCot.Text, out int soCot) && soCot > 0 && int.TryParse(TxtSoDong.Text, out int soDong) && soDong > 0)
			{
				//gọi form truyền số dòng, số cột qua
				var form = new FrmXuat(soDong, soCot);
				form.ShowDialog();
			}
		}
	}
}
