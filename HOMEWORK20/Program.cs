// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

void SortArray(int[,] inArr)
{
   int temp = 0;
   for (int i = 0; i < inArr.GetLength(0); i++)
   {
        for (int y = 0; y < inArr.GetLength(1); y++)
        {
            for (int j = 0; j < inArr.GetLength(1)-1; j++)
           {
            if (inArr[i,j] < inArr[i,j+1])
            {
            temp = inArr[i,j];
            inArr[i,j] = inArr[i,j+1];
            inArr[i,j+1] = temp;   
            }
           }
         
        }
       
   } 


}

Console.Write("Введите количство строки: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

 int[,] res = GetArray(m,n);

 PrintArray(res);
 System.Console.WriteLine();

 SortArray((res));
 System.Console.WriteLine();

 PrintArray(res);