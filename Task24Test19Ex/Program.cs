


int num = 1234321;

if (num >= 10000 && num <= 99999)
{
    int num1 = num / 10000; // 1
    int num2 = num / 1000 % 10; // 2
    int num4 = num / 10 % 10; // 4
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Введено не пятизначное число");
