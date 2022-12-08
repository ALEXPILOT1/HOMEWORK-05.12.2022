// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введи координату первой X1 ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введи координату первой Y1 ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введи координату первой Z1 ");
int Z1 = int.Parse(Console.ReadLine()!);


Console.Write("Введи координату первой X2 ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введи координату первой Y2 ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введи координату первой Z2 ");
int Z2 = int.Parse(Console.ReadLine()!);


double result = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));

Console.Write($"Расстояние между точками = ");
Console.Write( string.Format ("{0:F2}", result));