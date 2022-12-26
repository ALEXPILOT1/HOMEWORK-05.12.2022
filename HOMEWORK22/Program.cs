// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n )
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
         result[i, j] = new Random().Next(0,10);        
        }                                                                    
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
} 

int SumLineEl(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void PrintMinSum(int[,] inArr)
{
    int minSumLine = 0;
    int sumLine = SumLineEl(inArr,0);
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
      int tempSumLine = SumLineEl(inArr, i);
      if (sumLine > tempSumLine)
      {
        sumLine = tempSumLine;
        minSumLine = i;
      }
    }
    Console.WriteLine($"{minSumLine} - строкa с минимальной суммой ({sumLine}) элементов ");
}




Console.Write("Введите количство строки: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

 int[,] res = GetArray(m,n);

 PrintArray(res);
 System.Console.WriteLine();

 PrintMinSum(res);
System.Console.WriteLine();

