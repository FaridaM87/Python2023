// Напишите цикл, который принимает на 
// 1. вход два числа (A и B) и
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// 

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int sum = a;
int res = b;
if (b >= 0)
{
    Console.WriteLine("Число не натуральное, введите натуральное число");
}
for (int i = 1; i < b; i++)
{
sum = sum * a;
}
Console.WriteLine("A в степени B = " + sum);

