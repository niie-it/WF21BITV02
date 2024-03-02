using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP1
{
	public class HinhTron
	{
		private double _BanKinh;
		public double BanKinh
		{
			get { return _BanKinh; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Ban kinh am");
				}
				_BanKinh = value;
			}
		}

		public double DienTich { get; set; }
		public double ChuVi { get; set; }
		public HinhTron(double bk = 1)
		{
			BanKinh = bk;
		}
		public void TinhDienTichChuVi()
		{
			DienTich = BanKinh * BanKinh * Math.PI;
			ChuVi = 2 * BanKinh * Math.PI;
			Console.Write($"S={DienTich} P={ChuVi}");
		}
		public override string ToString()
		{
			return $"Tron co R = {BanKinh}, S={DienTich} P={ChuVi}";
		}
	}
}
