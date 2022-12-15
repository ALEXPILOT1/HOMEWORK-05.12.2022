// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
double[] CreateArray()
{
    int size = new Random().Next(5,10);
    double[] array =new double[size];

    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(100, 1000);
       Console.Write($"{array[i]} ");
    }
    return array;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine();
    double max = 0;
    double min = 1000;
    double result = 0;
    
    foreach (int el in arr)
    {
    if (el>max)
    {
    max = el;    
    }
    if (el<min)
    {
    min = el;    
    }
    
    }
    result = max - min;
    Console.WriteLine($"Результат вычитания {min} из {max}  дает {result}");
}
System.Console.WriteLine("Массив");
PrintArray(CreateArray());