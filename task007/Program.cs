int a;
int b;
Console.Write("Введите число 1: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
b = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(b,2)==a)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
if (Math.Pow(a,2)==b)
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else {Console.WriteLine("Ошибка.");}