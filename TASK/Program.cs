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

void Game(string[,] matrix, int X, int Y)
{
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

        
       


        matrix[Y,X] = "@";
        Console.Clear();
        WriteArrayMatrix(matrix);

    }
}

WriteArrayMatrix(matrix);
Game(matrix, X, Y);