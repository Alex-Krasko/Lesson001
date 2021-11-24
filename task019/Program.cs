int secret = GenNumber(1, 51);
int countOfAttempts = 5;
int b = 0;

int RequestNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GenNumber(int min, int max)
{
    int number = new Random().Next(min, max);
    return number;
}

int MakeMove(int SecretNumber, int CountOfAttempts)
{
    int recNum = RequestNumber();
    if (CountOfAttempts != 0)
    {
        if (recNum == SecretNumber)
        {
            return 1;
        }
        else
        {
            if (recNum > SecretNumber)
            {
                Console.WriteLine("Ваше число больше загаданного.");
            }
            else if (recNum < SecretNumber)
            {
                Console.WriteLine("Ваше число меньше загаданного.");
            }
            return 0;
        }
    }
    else return -1;

}

Console.WriteLine("Компьютер загадал число в диапазоне от 1 до 50. У Вас есть 5 попыток, чтобы угадать это число");
void Main()
{
    countOfAttempts--;
    int a = MakeMove(secret, countOfAttempts);
    switch (a)
    {
        case 1:
            Console.WriteLine("Вы угадали число! Игра окончена.");
            b = 1;
            break;
        case 0:
            Console.WriteLine($"Осталось {countOfAttempts} попыток.");
            break;
        case -1:
            Console.WriteLine("У Вас закончились попытки. Вы проиграли.");
            Console.WriteLine($"Было загадано число {secret}");
            b = 1;
            break;

    }

    if (b == 0) Main();
    else { };

}

Main();