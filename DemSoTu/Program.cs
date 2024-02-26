/*BT4: Nhập vào đoạn văn (có thể đọc từ file).
Hãy đếm số lượng xuất hiện từng từ (word) trong đoạn đó.
HINT:
- Phân tách đoạn văn thành mảng các từ <chuoi>.Split()
- Dùng Dictionary để lưu trữ từ==>số lượng (VD: { "an": 2, "ngu": 5}
- [Option] Đọc chuỗi từ file: File.ReadAllText(<duong_dan>)*/

using System.Text.RegularExpressions;

Console.Write("Nhập đoạn văn: ");
var doanVan = Console.ReadLine().Trim();

//remove dấu [,?:]
doanVan = Regex.Replace(doanVan, "[,?:!.]", "");

var mangTu = doanVan.Split();//phân cách theo khoảng trắng
Console.WriteLine(string.Join(";", mangTu));

var thongKe = new Dictionary<string, int>(); // tu: so luong
foreach (var tu in mangTu)
{
	if(thongKe.Keys.Contains(tu))
	{
		thongKe[tu] += 1;
	}
	else
	{
		thongKe[tu] = 1;
	}
}
foreach (var tu in thongKe.Keys)
{
	Console.WriteLine($"{tu} xuất hiện {thongKe[tu]}");
}