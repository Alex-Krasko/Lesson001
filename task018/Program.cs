int n = 10;
int m = 10;
int [,] array = new int [n,m];
int sum = 0;
double multi = 1;

void Print(int[,] a)
{
for(int i=0;i<a.GetLength(0);i++) {

    for(int j=0;j<a.GetLength(1);j++)
    {
        Console.Write($"{a[i,j],4}");   
    }
    Console.WriteLine();
}
}

int[,] Fill(){
for(int i =0;i<array.GetLength(0);i++)
    for(int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(1,100);;
    }
return array;
}

int Sum()
{
for(int i =0;i<array.GetLength(0);i++){
    for(int j=0;j<array.GetLength(1);j++)
    {
        sum +=array[i,j];
    }
}
return sum;
}

double Proizv()
{
for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            {
                multi *= array[i,j];
            }
    }
return multi;
}

Fill();
Print(array);
Console.WriteLine("Сумма: "+Sum());
Console.WriteLine("Произведение: "+Proizv());