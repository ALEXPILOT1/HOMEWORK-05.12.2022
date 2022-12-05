// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()); 
// 567
int a1 = num/100;
int a2 = num%10;
int a3 = num-(a1*100);
int a4 = a3/10;
Console.Write(a4);
