// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

Console.Clear();

Console.Write("Введи числj ");

int num = int.Parse(Console.ReadLine()!);
string X =String.Empty;


for (int i = 1; i <= num; i++)
{
 X=X+(Math.Pow(i, 2).ToString()+" ") ;
}
    Console.WriteLine(X);