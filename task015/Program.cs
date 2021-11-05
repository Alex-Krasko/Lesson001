int[] array = new int[6];
for(int i=0;i<array.Length;i++){
    Console.Write("Введите число "+(i+1)+": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int a = 0;
for(int i=0;i<array.Length;i++){
    if(array[i]>0) {a++;}
}
Console.WriteLine("Введено "+a+" положительных чисел.");