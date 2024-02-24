/*
Nhập điểm các môn: toán, lý và hóa
Tính điểm trung bình (= (toan *2 + ly + hoa)/4) và hiển thị xếp loại học lực theo yêu cầu sau:
Điểm < 5: yếu
5 <= điểm  <6.5: trung bình
6.5 <= điểm <8: khá
8 <= điểm < 9: giỏi
Điểm >= 9:xuất sắc
*/
using System.Text;

double Toan, Ly, Hoa;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
	Console.Write("Điểm Toán: ");
	if (double.TryParse(Console.ReadLine(), out Toan) && Toan >= 0 && Toan <= 10)
	{
		Console.WriteLine($"Toán: {Toan}");
		break;
	}
	else
	{
		Console.WriteLine("Không hợp lệ. Nhập lại.");
	}
}

while (true)
{
	Console.Write("Điểm Lý: ");
	if (double.TryParse(Console.ReadLine(), out Ly) && Ly >= 0 && Ly <= 10)
	{
		Console.WriteLine($"Lý: {Ly}");
		break;
	}
	else
	{
		Console.WriteLine("Không hợp lệ. Nhập lại.");
	}
}

while (true)
{
	Console.Write("Điểm Hóa: ");
	if (double.TryParse(Console.ReadLine(), out Hoa) && Hoa >= 0 && Hoa <= 10)
	{
		Console.WriteLine($"Hóa: {Hoa}");
		break;
	}
	else
	{
		Console.WriteLine("Không hợp lệ. Nhập lại.");
	}
}

double DTB = Math.Round((Toan * 2 + Ly + Hoa) / 4, 1);
string XepLoai = string.Empty;
if (DTB >= 9) { XepLoai = "Xuất sắc"; }
else if (DTB >= 8) { XepLoai = "Giỏi"; }
else if (DTB >= 6.5) { XepLoai = "Khá"; }
else if (DTB >= 5) { XepLoai = "Trung Bình"; }
else { XepLoai = "Yếu"; }

Console.WriteLine($"Điểm TB: {DTB},  Loại: {XepLoai}");