// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] GetArray2(int a, int b )
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
         result[i, j] = new Random().Next(0,10);        
        }                                                                    
    }
    return result;
}

void PrintArray2(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            Console.Write($"{inArr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] СompositionArray(int[,] inArr1, int[,] inArr2)
{
   int[,] resMass = new int [inArr1.GetLength(0),inArr2.GetLength(1)];
   for (int i = 0; i < inArr1.GetLength(0); i++)
                for (int j = 0; j < inArr2.GetLength(0); j++)
                    for (int k = 0; k < inArr2.GetLength(1); k++)
                        resMass[i, j] += inArr1[i, k]*inArr2[k, j];
 
                                                                 
  return resMass;                                   
}                                                               
                                                                          
                                                                
Console.Write("Введите количство строк первого массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первого массива : ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите количство строк второго массива: ");
int а = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второго массива : ");
int b = int.Parse(Console.ReadLine()!);

 int[,] res = GetArray(а,b);
 int[,] res2 = GetArray2(m,n);

 PrintArray(res);
 System.Console.WriteLine();

 PrintArray2(res2);
 System.Console.WriteLine();


 PrintArray(СompositionArray( res, res2));












