int [] CreateArray(int size)
{
 int [] array = new int[size];
 int i = 0;
while (i<size)
{
 array[i]=new Random().Next(-100,100);
 System.Console.Write($"{array[i]} ");
 i++;   
}
System.Console.WriteLine();
return array;

}



void DelWhZ(int index, int[] Arr)
{
if (index<=Arr.Length)
{
   int el = Arr[index];

if(el % 2 == 0)
{
    Console.WriteLine($"{el}");
}
}
}

DelWhZ(2, CreateArray(7));

//  10 15 16 6
//   0  1  2 3
