
using DemoOOP1;

var x = new Diem();
//Console.WriteLine($"{x.HoanhDo}, {x.TungDo}");
x.Xuat();
var y = new Diem(7, 11);
Console.WriteLine($"{y.HoanhDo}, {y.TungDo}");
Console.WriteLine(y);

// Demo hình tròn
var ht1 = new HinhTron();
Console.WriteLine(ht1);
var ht2 = new HinhTron(3);
Console.WriteLine(ht2);
var ht3 = new HinhTron(-8);
Console.WriteLine(ht3);