// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)


int[,] GetArray()
{
    int[,] result = new int[5, 5];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
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

void FindELMs(int x, int y,int[,] arr )
{
    if (y>4 || x>4 || x<0 || y<0)
    {
       System.Console.WriteLine("Такого числа нет"); 
    }
    else
    {
    System.Console.WriteLine(arr[x,y]);
    }
    
}

Console.Write("Введите индекс строки: ");
int i = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс столбца: ");
int j = int.Parse(Console.ReadLine()!);

int[,] res = GetArray();
PrintArray(res);

FindELMs(i,j, res);


