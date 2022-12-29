
void Number(int num, int count)            // 345   1
{
 if (count != 1 && count != num )
 {
    if (num%count == 0)
    {
        System.Console.WriteLine("НЕ Простое число");
    }
    else
    {
        Number(num,count+1);
    }
   

 }else if(count == num)
{
    System.Console.WriteLine(" Простое число");
}
else
{
    Number(num,count+1);
}
}

Number(13, 1);
