Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99 && num >= 0)
Console.WriteLine("нет третьего числа");
    else
    {
        while (num > 1000) 
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num);
    }
