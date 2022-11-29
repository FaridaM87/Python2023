// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] mtr = CreateMatrix(3, 5);
PrintMatrix(mtr);

int CalcSummDiagonal(int[,] matrix)
{
    int sum = default;
    int diag = default;

    if (matrix.GetLength(0) > matrix.GetLength(1))
        diag = matrix.GetLength(1);
    else
        diag = matrix.GetLength(0);

    for (int i = 0; i < diag; i++)
    {
        sum += matrix[i, i];
    }
    
    return sum;
}
int [,] mtr=CreatematrixRndInt(3,5,-10,10);
PtintMatrix(mtr);
int sum = CalcSummDiagonal(mtr);
PrintMatrix(mtr);

// int SumElementsMatrix(int[,] matrix)
// {
//     int sum = 0;
//     int minLength = matrix.GetLength(1);
//     if (matrix.GetLength(0) < matrix.GetLength(1)) minLength = matrix.GetLength(0);
//     for (int i = 0; i < minLength; i++) sum += matrix[i, i];
//     return sum;
// }
