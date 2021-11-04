int a;
string a1 = "Понедельник!";
string a2 = "Вторник!";
string a3 = "Среда!";
string a4 = "Четверг!";
string a5 = "Пятница!";
string a6 = "Суббота!";
string a7 = "Воскресенье!";
Console.WriteLine("Введите номер дня недели: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Это же ");
    if(a==1)
    {
        Console.WriteLine(a1);
    }
    if(a==2)
    {
        Console.WriteLine(a2);
    }
    if(a==3)
    {
        Console.WriteLine(a3);
    }
    if(a==4)
    {
        Console.WriteLine(a4);
    }
    if(a==5)
    {
        Console.WriteLine(a5);
    }
    if(a==6)
    {
        Console.WriteLine(a6);
    }
    if(a==7)
    {
        Console.WriteLine(a7);
    }

