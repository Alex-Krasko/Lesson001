int i = 1;
int a;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кубы чисел от 1 до "+a);
while(i<=a)
{
    Console.Write(Math.Pow(i,3)+" ");
    i++;
}