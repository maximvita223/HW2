Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
num = (num / 10);
num = (num % 10);
Console.WriteLine($"{num}");