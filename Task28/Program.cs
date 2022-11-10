// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2.выдаёт
// 3.произведение чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 1; // 0

    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
        // sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"произведение чисел чисел от 1 до {num} = {sumNumbers}");


