// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int SumNumb(int num )
{
    int sum = 0; 
    while(num>0)
    {
      int a = num%10;
      sum += a;
      num /=10;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел равна: {SumNumb(num)}");