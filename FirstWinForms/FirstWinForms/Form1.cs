namespace FirstWinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnChao_Click(object sender, EventArgs e)
		{
			if (TxtHoTen.Text.Trim().Length == 0)
			{
				MessageBox.Show("Chưa nhập họ tên");
				return;
			}
			int gioHienTai = DateTime.Now.Hour;
			string loiChao = $"Chào {TxtHoTen.Text.Trim()}";
			LblChao.Text = loiChao;
		}

		private void BtnNhapLai_Click(object sender, EventArgs e)
		{
			TxtHoTen.Text = string.Empty;
			LblChao.Text = string.Empty;
			TxtHoTen.Focus();
		}

		private void BtnThoat_Click(object sender, EventArgs e)
		{
			var traLoi = MessageBox.Show("Thoát chương trình?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (traLoi == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
