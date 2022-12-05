// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine());
if(num == 1)
{
    Console.WriteLine("понедельник.Рабочий день");
}
if(num == 2)
{
    Console.WriteLine("Вторник.Рабочий день");
}
if(num == 3)
{
    Console.WriteLine("Среда.Рабочий день");
}
if(num == 4)
{
    Console.WriteLine("Четверг.Рабочий день");
}
if(num == 5)
{
    Console.WriteLine("Пятница.Рабочий день");
}
if(num == 6)
{
    Console.WriteLine("Суббота. Выходной день");
}
if(num == 7)
{
    Console.WriteLine("Воскресенье. Выходной день");
}
