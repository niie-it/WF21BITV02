// Nhập tên các loại trái cây, dừng khi không nhập hoặc stop
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
List<string> mang = new List<string>();
while (true)
{
	Console.Write("Tên trái cây: ");
	string tenTrai = Console.ReadLine().Trim();
	if (tenTrai == "" || tenTrai.ToUpper() == "STOP")
	{
		break;
	}
	if (mang.Contains(tenTrai, StringComparer.OrdinalIgnoreCase))
	{
		Console.WriteLine("Đã có " + tenTrai); continue;
	}
	mang.Add(tenTrai);
	Console.WriteLine(string.Join(", ", mang));
	Console.WriteLine($"Count={mang.Count}, Cap={mang.Capacity}");
}

mang.Sort();
Console.WriteLine(string.Join(", ", mang));
mang.Reverse();
Console.WriteLine(string.Join(", ", mang));