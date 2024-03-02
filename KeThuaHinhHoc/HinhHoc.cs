using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaHinhHoc
{
	public class HinhHoc
	{
		public double DienTich { get; set; }
		public double ChuVi { get; set; }
		public virtual void TinhDTCV() { }
	}

	public class Tron: HinhHoc
	{
		public double BanKinh { get; set; }
		public override void TinhDTCV()
		{
			DienTich = BanKinh * BanKinh * Math.PI;
			ChuVi = 2 * BanKinh * Math.PI;
		}
		public override string ToString()
		{
			return $"Tron R={BanKinh}, S={DienTich}, P={ChuVi}";
		}
	}

	public class ChuNhat : HinhHoc
	{
		public double Dai { get; set; }
		public double Rong { get; set; }
		public override void TinhDTCV()
		{
			DienTich = Dai * Rong;
			ChuVi = (Dai + Rong) *2;
		}
		public override string ToString()
		{
			return $"Chu nhat D={Dai}, R={Rong}, S={DienTich}, P={ChuVi}";
		}
	}
}
