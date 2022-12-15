// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] CreateArray(int size )
{
    
    int[] array =new int[size];

    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(100, 1000);
       Console.Write($"{array[i]} ");
    }
    return array;
} 

void PrintArray(int[] arr)
{   
    System.Console.WriteLine();
    int count = 0;
    foreach (int item in arr)
    {
     if(item % 2 == 0 ) count++; 
    }
    System.Console.WriteLine($"количество чётных чисел в массиве {count}");
}
System.Console.WriteLine("Массив");
PrintArray(CreateArray(5));