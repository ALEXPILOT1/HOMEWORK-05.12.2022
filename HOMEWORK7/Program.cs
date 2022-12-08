// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введи число ");

int num = int.Parse(Console.ReadLine()!);
string X =String.Empty;


for (int i = 2; i <= num; i++)
{
 X=X+(Math.Pow(i, 3).ToString()+" ") ;
}
    Console.WriteLine(X);
