// Задайте массив вещественных чисел. 
// 1. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int K = 0; K < numbers.Length; K++)
{
    if (numbers[K] > max)
    {
        max = numbers[K];
    }
    if (numbers[K] < min)
    {
        min = numbers[K];
    }
}

Console.WriteLine($"Чисел в массиве {numbers.Length} . Max = {max}, Min = {min}");
Console.WriteLine($"Разница между значениями = {max - min}");

 void FillArrayRandomNumbers(double[] numbers)
 {
     for (int i = 0; i < numbers.Length; i++)
     {
         numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
     }
 }
 void PrintArray(double[] numbers)
 {
     Console.Write("[ ");
     for (int i = 0; i < numbers.Length; i++)
    {
         Console.Write(numbers[i] + " ");
     }
     Console.Write("]");
     Console.WriteLine();
 }