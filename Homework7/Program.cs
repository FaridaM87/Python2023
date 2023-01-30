/*Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);

void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}


void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}  
*/ 

Console.WriteLine("Input the index of rows:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the index of columns:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
else Console.WriteLine($"{rows}{columns} -> error");


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

