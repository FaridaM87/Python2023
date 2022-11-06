// Задача 14. Напишите программу, которая 
// 1. принимает на вход и 
// 2. проверяет, кратно ли оно одвременно 7 и 23

// 14 -> нет
// 46 -> нет
// 161 -> нет

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number %7 ==0 && number %23 ==0)
 Console.WriteLine("Кратно одновременно 7 и 23:");


else 
{
Console.WriteLine("Некратно одновременно 7 и 23:");
}
  


    
