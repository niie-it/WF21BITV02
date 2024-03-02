using KeThuaHinhHoc;

List<HinhHoc> dsHinh = new List<HinhHoc>();

//Nhập từ???
var rd = new Random();
var soLuongHinh = rd.Next(1, 100);
for (int i = 0; i < soLuongHinh; i++)
{
	var rdType = rd.Next() % 2 == 0;
	if (rdType)
	{
		dsHinh.Add(new Tron { BanKinh = rd.NextDouble() * 100 });
	}
	else
	{
		dsHinh.Add(new ChuNhat
		{
			Dai = rd.Next(1, 100),
			Rong = rd.Next(1, 100)
		});
	}
}

foreach(var hh in dsHinh)
{
	hh.TinhDTCV(); Console.WriteLine(hh);
}