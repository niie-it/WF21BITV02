using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForEach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] tenSvs = { "Tèo", "Tý", "Mận", "Đào", "Cam" };
			foreach(string ten in tenSvs)
			{
				Console.WriteLine(ten);
			}
		}
	}
}
