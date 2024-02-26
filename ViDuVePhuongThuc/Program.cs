// Phân biệt tham số

void NhapSoNguyenDuong(out int So)
{
	while (true)
	{
		Console.Write("Nhập số dương: ");
		if (int.TryParse(Console.ReadLine(), out So) && So > 0)
		{
			break;
		}
		Console.WriteLine("Nhập sai...");
	}
}
void HoanDoi(ref int x, ref int y) { }

int a, b=7, c=9;
NhapSoNguyenDuong(out a);
HoanDoi(ref b, ref c);