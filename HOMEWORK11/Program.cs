// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введи количесвто чисел в массиве");
int num = int.Parse(Console.ReadLine());

int[] arr = new int[num];
int [] NewArray( int[] arr)
{
         int i = 0;
         while (i<arr.Length)
        {   
         arr[i] = new Random().Next(0,10);
         Console.Write(arr[i]);
         i++;
        }
        return arr;
        
}
NewArray(arr);





