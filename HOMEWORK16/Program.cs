// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y2 = k2 * x + b2; значения b1,
// k1, b2 и k2 задаются пользователем.

Console.Clear();
System.Console.WriteLine("Введи значение b1");
double b1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введи значение k1");
double k1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введи значение b2");
double b2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введи значение k2");
double k2 = double.Parse(Console.ReadLine());

void Koordinate(double num1, double num2, double num3,double num4) 
{
   double y = 1;
   double x = 1;
    x = (b1-b2)/(k2-k1);
    y=k1*x + b1;
    System.Console.WriteLine(x);
    System.Console.WriteLine(y);
}

Koordinate(b1, k1, b2, k2);

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)