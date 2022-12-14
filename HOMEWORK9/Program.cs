// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введи число ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введи степень ");
int num2 = int.Parse(Console.ReadLine());

int Method1(int num , int num2 )
{
int result = 1;
   for (int i = 0; i < num2; i++)
   {
    result = result * num;
   }
return result;
}


int result = Method1(num ,num2);
Console.WriteLine($"Возведение числа {num} в степень {num2} = {result} ");



    


