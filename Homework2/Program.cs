// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.


 Console.WriteLine("Input a three-digit number:");
 int number= Convert.ToInt32(Console.ReadLine());

 int res = number / 10 % 10;
 Console.WriteLine($"The second number is {res} ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

 Console.WriteLine("Input a number:");
 int number = Convert.ToInt32(Console.ReadLine());
 int ThirdDigit(int num)
 {
   int res = 0;
   if (num <= 100)
   {
      while (num > 999)
      {
        num = num / 10;
      }
     res = num % 10;
   }
  else
  {
    res = -1;
    Console.WriteLine("No third digit"); 
  }
  return res;
 }
 int res = ThirdDigit(number);
 Console.WriteLine($"The third number is {res}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7)
{
    Console.WriteLine("Error!");
}

else if(number > 5)
{
    Console.WriteLine("Weekend!");
}
else
{
    Console.WriteLine("Weekday!");
}