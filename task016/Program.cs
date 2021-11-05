int a;
string b = string.Empty;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToString(a, 2);
Console.WriteLine("Число в двоичном виде: "+b);