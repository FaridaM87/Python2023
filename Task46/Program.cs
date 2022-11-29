// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
       for (int i = 0; i < matrix.GetLength(0); i++) // 
       {
             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
       }
        
    }
    return matrix;
}


// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int j = 0; j < matrix.GetLength(1); j++) // 2
//     {
//        for (int i = 0; i < matrix.GetLength(0); i++) // 
//        {
//              matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
//        }
        
//     }
//     return matrix;
// }



// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int j = 0; j < matrix.GetLength(1); j++) // 2
//     {
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]},");
//             else Console.Write($"{matrix[i,j]}");
//         }
//         Console.WriteLine("]");
//     }
// }
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j], 5}");
        }
        Console.WriteLine(" |");
    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 100);
PrintMatrix(array2D);
