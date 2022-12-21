// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
// int[] CreateArray(int size )
// {
    
//     int[] array =new int[size];

//     for (int i = 0; i < size; i++)
//     {
//        array[i] = new Random().Next(-100,100);
//        Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
//     return array;
// } 

// int[] Array = {30, -15, 20, 50, -10};
// for (int i = 0; i < Array.Length; i++)
// {
//  Console.Write($"{Array[i]} ");
// }

int[] CreateArray()
{
System.Console.WriteLine("Введи числа ");
string num = Console.ReadLine();

string[] Numbers = num.Split(' ');
int[] Array = new int[Numbers.Length];

for (int i = 0; i < Numbers.Length; i++)
{
 Array[i] = int.Parse(Numbers[i]);
}
return Array;
}


void CountNumb( int[] array)
{
 int count = 0;
 for (int i = 0; i < array.Length; i++)
 {
        if (array[i]>0)
        {
         count +=1;       
        }
    
}
System.Console.WriteLine($"Количество чисел больше 0 -> {count}");
}

CountNumb(CreateArray());


// int[] array = {10 , 15, -16, -151, 2, -6};