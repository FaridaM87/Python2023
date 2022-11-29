// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = i + j;
//     return array;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write("{0,4} ", array[i, j]);

//         Console.WriteLine("]");
//     }
// }

// 

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
//             else Console.Write($"{matrix[i, 
// int[,] ReplaceEvenElem(int[,] matrix)


//  for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
//     return matrix;
// }


// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);  // вызов матрицы
// PrintMatrix(array2D);

// Console.WriteLine();
// int[,] replaceEvenElemMatrix = ReplaceEvenElem(array2D);
// PrintMatrix(replaceEvenElemMatrix);

// int ConvertToBin(int num10)
// {
//     int num2 = default;

//     while (num10 > 0)
//     {
//         num2 += num10 % 2;
//         num2 *= 10;
//         num10 /= 2;
//         ConvertToBin(num10);
//     }

//     return num2;
// }

//  задача 49
// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = 
// int[,] ReplaceEvenElem(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
//     return matrix;
// }


// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);  // вызов матрицы
// PrintMatrix(array2D);

// Console.WriteLine();
// int[,] replaceEvenElemMatrix = ReplaceEvenElem(array2D);
// PrintMatrix(replaceEvenElemMatrix);
