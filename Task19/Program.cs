// Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
// 1. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);


int CheckPolindrome(int number)
{
    if (number > 10000)
    {
    int Div1 = number / 100;
    int Num1 = number % 10;
       if (Div1 == Num1)
       number = number / 10;
         
          int Div2= (number / 10) % 10;
          int Num2 = number % 10;
          if(Div2==Num2)
         
         return CheckPolindrome(number);
        Console.WriteLine("Да"); 
    }
        else
         return CheckPolindrome(number);
        Console.WriteLine("Нет");
}

if(number < 10000)
Console.WriteLine("Введено некорректное число");   

int result = CheckPolindrome(number);

