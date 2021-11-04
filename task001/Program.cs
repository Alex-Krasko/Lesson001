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
else { Console.WriteLine("Число 1 НЕ является квадратом числа 2");}
