// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
var length = number.Length;
if (number[0] == number[4] && number[1] == number[3])
{
        Console.WriteLine($" Число {number} является палиндром");
}
else
{
        Console.WriteLine($" Число {number}  не является  палиндром");
}

