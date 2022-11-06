// Задача 12. Напишите программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли второе число кратным первому.
// 3. Если число 1 не кратно числу 2, 
// 4. то программа выводит остаток от деления.


// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
    Console.WriteLine("Кратно");
else 
Console.WriteLine($"Не кратно, остаток {number1 % number2}");

