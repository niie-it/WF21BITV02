namespace MyUserControl
{
	public partial class UCDongHo : UserControl
	{
		public UCDongHo()
		{
			InitializeComponent();
		}

		const string TEXT_START = "START";
		const string TEXT_STOP = "STOP";
		private DateTime startTime;

		private void BtnStartStop_Click(object sender, EventArgs e)
		{
			if (BtnStartStop.Text == TEXT_START)
			{
				BtnStartStop.Text = TEXT_STOP;
				timer1.Enabled = true;
				startTime = DateTime.Now;
			}
			else
			{
				BtnStartStop.Text = TEXT_START;
				timer1.Enabled = false;
				timeSpans = new List<TimeSpan>();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LblDongHo.Text = (DateTime.Now - startTime).ToString();
		}

		List<TimeSpan> timeSpans = new List<TimeSpan>();
		const int MAX_COUNT = 5;
		private void BtnLap_Click(object sender, EventArgs e)
		{

			//Tính thời gian và ghi nhận xuống file
			var thoiGian = DateTime.Now - startTime;
			timeSpans.Add(thoiGian);

			var content = timeSpans.Select(p => p.ToString()).ToList();
			File.WriteAllLines("data.txt", content);
			if (timeSpans.Count == MAX_COUNT)
			{
				BtnStartStop.Text = TEXT_START;
				timer1.Enabled = false;
				timeSpans.Clear();
			}
		}
	}
}
