int a;
int b;
int c;
Console.WriteLine("Введите число 1: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
c = Convert.ToInt32(Console.ReadLine());
if (a+b>c&a+c>b&b+c>a)
{
    Console.WriteLine("Числа являются сторонами треугольника.");
}
else Console.WriteLine("Числа НЕ являются сторонами треугольника.");