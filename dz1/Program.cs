Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num > 1000)
Console.WriteLine("ERROR");
else
num = (num / 10);
num = (num % 10);
Console.WriteLine($"{num}");