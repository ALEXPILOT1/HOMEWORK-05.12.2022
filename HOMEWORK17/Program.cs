// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
       array[i, j] = Math.Round((new Random().NextDouble()*(10 - (-10)) + (-10)),1);

      }  
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        Console.Write($"{arr[i,j]} ");
      }  
      Console.WriteLine();  
    }

}
// int[,] result = CreateArray(3, 3);
// PrintArray(result);
PrintArray(CreateArray(5, 5));