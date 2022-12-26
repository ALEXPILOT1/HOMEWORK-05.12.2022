// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int LineNumbers2(int n )
{     
                                                                       
    if(n == 0) return 0;                                      
    return n%10+LineNumbers2(n/10);
}                                                                         
System.Console.WriteLine( LineNumbers2(345));



