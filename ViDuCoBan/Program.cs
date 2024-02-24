/*
Nhập điểm các môn: toán, lý và hóa
Tính điểm trung bình (= (toan *2 + ly + hoa)/4) và hiển thị xếp loại học lực theo yêu cầu sau:
Điểm < 5: yếu
5 <= điểm  <6.5: trung bình
6.5 <= điểm <8: khá
8 <= điểm < 9: giỏi
Điểm >= 9:xuất sắc
*/
double Toan, Ly, Hoa;

Console.Write("Điểm Toán: ");
Toan = double.Parse(Console.ReadLine());
Console.WriteLine($"Toán: {Toan}");