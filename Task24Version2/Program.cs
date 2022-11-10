Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default; // 0

    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");
