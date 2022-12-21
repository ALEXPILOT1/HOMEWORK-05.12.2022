// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void Average(int[,] inArr)
{
    
    int count = 0;
    double sum = 0;
    System.Console.Write("Среднее арифметическое столбцов ");
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)                
        {                                                           
          sum +=inArr[i,j];
        }
        System.Console.Write($"{sum/inArr.GetLength(1)} ");
        sum = 0;
    }
    
}
int[,] res = GetArray(5,5);
PrintArray(res);


Average(res);