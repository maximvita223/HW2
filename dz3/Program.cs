Console.WriteLine("введите число дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 5 && day < 8)
{
    Console.WriteLine("Выходной");
}
if (day <= 5)
{
    Console.WriteLine("Не выходной");
}
