Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
Console.Write("Третьей цифры нет");
}
else
{
while (num > 1000)
{
num = num / 10;
}
Console.Write($"Третьей цифра числа {num%10}");
}