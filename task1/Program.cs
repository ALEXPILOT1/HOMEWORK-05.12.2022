Console.Clear();

Console.Write("Введи номер четверти ");

int num = int.Parse(Console.ReadLine()!);

if(num == 1) Console.WriteLine(" X>0 и Y>0");

if(num == 2) Console.WriteLine(" X<0 и Y>0");

if(num == 3) Console.WriteLine(" X<0 и Y<0");

if(num == 4) Console.WriteLine(" X>0 и Y<0");


