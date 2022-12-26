//             0 1 2 3 4 5
int[] array = {5,4,3,6,7,4};
int temp = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length-1-i; j++) // 
    {
        if (array[j] < array[j+1])
        {
            temp = array[j];
            array[j] = array[j+1];
             array[j+1] = temp;
        }
    }
} 

for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}

for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k]*b[k, j];
 