string[,] matrix = {
    {" ", " ", " ", " "," "," "},
    {" ", " ", " ", " "," "," "},
    {" ", "@", " ", "*"," "," "},
    {" ", " ", " ", " "," "," "},
    {" ", " ", " ", " "," "," "},
    {" ", " ", " ", " "," "," "}};
int X = 1;
int Y = 2;

void WriteArrayMatrix(string[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            Console.Write(matrix[y,x] + " ");
        }
        Console.WriteLine();
    }
}

int Bonus(int X, int Y , string[,] matrix, int count )
{
    
    while (matrix[Y,X] == "*" )
    {
     matrix[Y,X] = " ";    // Y и Х это координаты персонажа
    int x = new Random().Next( 0, matrix.GetLength(0));
    int y = new Random().Next(0, matrix.GetLength(1));
    matrix[y,x] = "*";

    
    count +=1;
    } 
 return count;
}

void WriteCoordinates(int X, int Y, int count)
{
    Console.WriteLine($"X = {X} Y = {Y} Count = {count}");
}


void Game(string[,] matrix, int X, int Y)
{   
    int count = 0;
    while (true)
    {
       matrix[Y,X] =" ";
       ConsoleKeyInfo user_keyTab = Console.ReadKey();
       if(user_keyTab.Key == ConsoleKey.W) Y--;
       if(user_keyTab.Key == ConsoleKey.S) Y++;
       if(user_keyTab.Key == ConsoleKey.A) X--;
       if(user_keyTab.Key == ConsoleKey.D) X++;
       if (Y<0)Y=0;   
       if (X<0)X=0;
       if(X > matrix.GetLength(1)-1) X = matrix.GetLength(1)-1;
       if(Y > matrix.GetLength(0)-1) Y = matrix.GetLength(0)-1;
    
        count=Bonus(X,  Y, matrix, count); //

        matrix[Y,X] = "@";
        Console.Clear();
        WriteArrayMatrix(matrix); 

        WriteCoordinates(X,Y,count);
    
    }
}



WriteArrayMatrix(matrix); ,. // Показ поля перед началом игры

Game(matrix, X, Y);



