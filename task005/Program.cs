int a;
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
if(a%7==0|a%23==0)
{
    Console.WriteLine("Число кратно 7 и 23!");
    Console.WriteLine("Условие выполняется.");
}
else {Console.WriteLine("Условие не выполняется.");}