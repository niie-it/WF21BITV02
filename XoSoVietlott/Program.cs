using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoSoVietlott
{
	internal class Program
	{
		const int MEGA645 = 45;
		const int POWER655 = 55;
		static List<string> TaoNgauNhienVeSo(int type)
		{
			List<int> mangSo = new List<int>();
			Random rd = new Random();
			while (mangSo.Count < 6)
			{
				int soNgauNhien = rd.Next(1, type + 1);
				if (!mangSo.Contains(soNgauNhien))
				{
					mangSo.Add(soNgauNhien);
				}
			}
			mangSo.Sort();
			return mangSo.Select(x => x.ToString("00")).ToList();
		}

		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", TaoNgauNhienVeSo(POWER655)));
			Console.WriteLine(string.Join(", ", TaoNgauNhienVeSo(MEGA645)));
		}
	}
}
