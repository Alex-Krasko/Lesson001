int i = 1;
int a;
int b = 0;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел от 1 до "+a);
while(i<=a)
{
    b += i;
    i++;
}
Console.WriteLine("Сумма чисел равна "+b);