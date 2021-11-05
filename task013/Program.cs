int[] array = new int[12];
int sum = 0;
for (int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int j=0;j<array.Length;j++)
{
    sum += array[j];
}
Console.WriteLine("Сумма чисел массива: "+sum);