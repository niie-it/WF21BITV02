namespace Lab04BT01_Tong
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtN.Text, out int N) && N > 0)
			{
				int S = 0;
				for (int i = 0; i < N; i++)
				{
					S += i + 1;
				}
				txtTong.Text = S.ToString();
			}
			else
			{
				MessageBox.Show("Nhập sai rùi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtN.Focus();
			}
		}
	}
}
