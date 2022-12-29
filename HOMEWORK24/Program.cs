// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30   5 10 

int SumNumbers(int M , int N, int sum = 1 )     
{
   
   if(N == M)  
   {
    return sum;
   } 
   sum +=N;
   return  SumNumbers(M,N-1,sum);
   
}

System.Console.WriteLine(SumNumbers(1,15));



