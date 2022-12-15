// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


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

void PrintArray(int[] array)
{
    System.Console.WriteLine();
    int i = 1;
    int sum = 0;
    while (i < array.Length)
    {
      sum += array[i];
      i = i + 2;  
    }
    System.Console.WriteLine($"Сумма элементов равна {sum}");
}
System.Console.WriteLine("Массив");
PrintArray(CreateArray(7));