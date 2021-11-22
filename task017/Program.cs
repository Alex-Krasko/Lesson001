void SetArray(int[,] a)
{
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=i*10+j;
    }
}

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

int[,] a;
a=new int[10,10];

SetArray(a);
Print(a);
