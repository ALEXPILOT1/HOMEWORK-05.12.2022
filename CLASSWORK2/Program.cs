// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию заданного массива 
//  с помощью поэлементного копирования.

string Fibon (int N)
{
   string C = "N = {N} -> 0 1 ";
   int sum = 0;
   int N1 = 0;
   int N2 = 1;
   int i = 2;
//    Console.Write($" N = {N} -> 0 1 ");
   while (i<N)
    {
       sum = N1+N2;
    C = C + sum+ " ";
    //    Console.Write($" {sum}");
       N1 = N2;
       N2 = sum;
       i++;
    }
    return C;

}

Console.Write(Fibon(5));


// void MetFib(int Num)
// {
// int[] listFib = new int[Num];
// Console.Write(listFib[0]);
// listFib[1] = 1; Console.Write(listFib[1]);
// for (int i = 2; i < Num; i++)
// {
//     listFib[i] = listFib[i-1]+listFib[i-2];
//     Console.Write(listFib[i]);
// }
// }
// int num = int.Parse(Console.ReadLine()!);
// MetFib(num);
