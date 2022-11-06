// Задача11. Напишите программу, которая 
// 1. выводит случайное трехзначное число и
// 2. удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98



int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {number}:");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
 
// Console.WriteLine($"Полученное число {firstDigit}{thirdDigit}");

int DelSeconDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

int result = DelSeconDigit(number);
Console.WriteLine($"Полученное число {result}");