Console.Clear();

Console.Write("Введи номер четверти ");

int num = int.Parse(Console.ReadLine()!);

switch (num)
{
    case 1:
          Console.WriteLine(" X>0 и Y>0");
          break;
    
    case 2:
          Console.WriteLine(" X<0 и Y>0");
          break;

    case 3:
          Console.WriteLine(" X<0 и Y<0");
          break;

    case 4:
          Console.WriteLine(" X>0 и Y<0");
          break;

    default: 
    Console.WriteLine("Такой четверти нет");
    break;
}

