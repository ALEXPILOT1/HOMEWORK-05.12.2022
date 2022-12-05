// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int a1 = 0;
while (num>1000) 
{
 a1 = num/10;
 num = a1;
}

 
if(num>100 && num<1000)
{
    int a2 = num%10;
    Console.Write(a2);
}
else
{
    Console.Write("Третьей цифры нет");
}
