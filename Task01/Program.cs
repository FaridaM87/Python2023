/*1. Напишите программу, которая  на вход принимает два 
числа и проверяет, является ли первое число квадратом 
второго

a = 25, b = 5 -> да
a = 2, b =18 -> нет
a = 9, b = -3 -> да
a =-3, b = 9 -> нет*/


Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.Readline());
int number2 = Convert.ToInt32(Console.Readline());
if (number1 == number2 * number2)
{
    Console.Writeline("Да");
}
else
{
    Console.Writeline("Нет");
}

