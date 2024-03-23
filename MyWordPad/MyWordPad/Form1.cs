using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWordPad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss K");
		}

		private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var fd = new FontDialog();

			fd.ShowColor = true;
			fd.ShowApply = true;
			fd.Apply += new EventHandler(XuLyNutApplyFont);

			if (fd.ShowDialog() == DialogResult.OK)
			{
				RtbDoc.SelectionFont = fd.Font;
				RtbDoc.SelectionColor = fd.Color;
			}
		}

		private void XuLyNutApplyFont(object sender, EventArgs e)
		{
			var fd = sender as FontDialog;
			RtbDoc.SelectionFont = fd.Font;
			RtbDoc.SelectionColor = fd.Color;
		}

		private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				//thay đổi nền của rich text box RtbDoc
				RtbDoc.BackColor = cd.Color;
			}
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RtbDoc.Undo();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RtbDoc.Copy();
		}
	}
}
