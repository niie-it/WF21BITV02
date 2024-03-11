namespace QuanLyHangTon
{
	public partial class Form1 : Form
	{
		static List<HangHoa> HangHoaList = new List<HangHoa>()
		{
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="Dell Vostro", SoLuong=11, DonGia=17999000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="ASUS Vivobook", SoLuong=8, DonGia=19919900},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="LG Gram", SoLuong=3, DonGia=23999000},
		};

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = HangHoaList;
			
			CboHangHoa.DisplayMember = "TenHh";
			CboHangHoa.ValueMember = "MaHh";
			CboHangHoa.DataSource = HangHoaList;
		}

		private void CboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var maHhDangChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());
				var hangHoaChon = HangHoaList.SingleOrDefault(hh => hh.MaHh == maHhDangChon);
				if (hangHoaChon != null)
				{
					LblDonGia.Text = hangHoaChon.DonGia.ToString("#,##0");
				}
			}
			catch (Exception ex) { }
		}

		private void BtnTang_Click(object sender, EventArgs e)
		{
			int giaTri = int.Parse(NudSoluong.Value.ToString());
			var maHhDangChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());
			var hangHoaChon = HangHoaList.SingleOrDefault(hh => hh.MaHh == maHhDangChon);
			if (hangHoaChon != null)
			{
				hangHoaChon.SoLuong += giaTri;
			}

			//Update DataGridView
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = HangHoaList;
		}
	}
}
