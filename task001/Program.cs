int a1;
int b1;
int c1;
int r;
Console.WriteLine("Поиск максимального из трех");
Console.Write("Введите число 1: ");
string? a = Console.ReadLine();
Console.Write("Введите число 2: ");
string? b = Console.ReadLine();
Console.Write("Введите число 3: ");
string? c = Console.ReadLine();
a1=Convert.ToInt32(a);
b1=Convert.ToInt32(b);
c1=Convert.ToInt32(c);

if (a1>b1) {r = a1;}
else {r = b1;}
if (r>c1) {}
else {r = c1;}
Console.WriteLine("Максимальное число: "+r);