int[] array = new int[12];
int sum = 0;
int sum1 = 0;
for (int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int j=0;j<array.Length;j++)
{
    if (array[j] > 0)
    {
    sum += array[j];
    }
    else { sum1+= array[j];}
}
Console.WriteLine("Сумма положительных чисел массива: "+sum);
Console.WriteLine("Сумма отрицательных чисел массива: "+sum1);