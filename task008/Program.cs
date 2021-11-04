int i = 1;
int a;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадраты чисел от 1 до "+a);
while(i<=a)
{
    Console.Write(Math.Pow(i,2)+" ");
    i++;
}