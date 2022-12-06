Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int a1 = num/10; // убираем 3 цифру
int a2 = a1%10; // у новой двузначной переменной находим последюю цифру, что и является искомой переменной
Console.Write(a2);